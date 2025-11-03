using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

// Aliases claros para evitar choques
using WFButton = System.Windows.Forms.Button;
using WFFlatStyle = System.Windows.Forms.FlatStyle;
using WinTimer = System.Windows.Forms.Timer;
using System.ComponentModel; // ya lo tienes, por las dudas

namespace ReaLTaiizor.Controls
{
    [DefaultEvent("SelectedIndexChanged")]
    public class MaterialEditableComboBoxFixed : UserControl
    {
        // --- Subcontroles ---
        private readonly TextBox textBox;
        private readonly WFButton dropButton;
        private readonly ListBox listBox;
        private readonly Panel bottomLine;
        private readonly Panel dropHost;

        // --- Estado / flags ---
        private bool _itemsReady = false;
        private bool _isAnimating = false;
        private bool _isOpeningInternally = false; // para no rebotar entre focus/mousedown/click
        private bool _filterHooked = false;
        private bool _suppressNextFocus = false;
        private bool _focusByMouse = false;
        private GlobalClickFilter? _clickFilter;
        private bool _isClosing = false;           // cierre animado en progreso
        private WinTimer? _focusLossTimer = null;  // debounce único de pérdida de foco
        private const int FocusDebounceMs = 80;    // 60–120ms anda bien
                                                   // junto a tus campos/flags
        private bool InDesignMode => LicenseManager.UsageMode == LicenseUsageMode.Designtime || DesignMode;
        public bool UseAnimation { get; set; } = false;  // false = abrir/cerrar instantáneo

        private bool _applyingFocus = false;
        public bool OpenOnClick { get; set; } = true;   // abrir con clic en el textbox
        public bool OpenOnFocus { get; set; } = false;  // NO abrir solo por foco

       

        private WinTimer? _openTimer;
        private WinTimer? _closeTimer;

        public bool AnimateOpen { get; set; } = true;   // apertura animada (ON)
        public bool AnimateClose { get; set; } = false;  // cierre instantáneo (OFF por defecto)
        // --- Estilos ---
        private readonly Color Accent = Color.FromArgb(76, 175, 80);
        private readonly Color LineGray = Color.FromArgb(189, 189, 189);

        // --- API pública ---
        private string _hint = "Seleccione o escriba...";

        [Category("Material")]
        public string Hint
        {
            get => _hint;
            set { _hint = value; Invalidate(); }
        }

        [Browsable(false)]
        public List<string> Items { get; private set; } = new();

        [Browsable(false)]
        public string SelectedItem
        {
            get => textBox.Text;
            set
            {
                textBox.Text = value ?? string.Empty;
                textBox.SelectionStart = textBox.TextLength;
                textBox.SelectionLength = 0;
                SelectedIndexChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler? SelectedIndexChanged;

        private Form? _hostForm;

        // Exponer el texto real del textbox como Text del control
        [Browsable(true)]
        [Bindable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public override string Text
        {
            get => textBox?.Text ?? base.Text;
            set
            {
                if (textBox != null)
                {
                    textBox.Text = value ?? string.Empty;
                    textBox.SelectionStart = textBox.TextLength;
                    textBox.SelectionLength = 0;
                }
                else
                {
                    base.Text = value;
                }
            }
        }

        // (opcional) una propiedad clara para validaciones
        [Browsable(false)]
        public string Value => textBox?.Text ?? string.Empty;

        // (opcional) expone si hay texto no vacío
        [Browsable(false)]
        public bool HasText => !string.IsNullOrWhiteSpace(textBox?.Text);


        // ================== CTOR ==================
        public MaterialEditableComboBoxFixed()
        {
            Height = 42;
            BackColor = Color.FromArgb(245, 245, 245);

            // TEXTBOX
            textBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                Font = new Font("Segoe UI", 12f),
                ForeColor = Color.FromArgb(33, 33, 33),
                BackColor = BackColor,
                Location = new Point(8, 10),
                Width = Width - 36,
                TextAlign = HorizontalAlignment.Center
            };

            // MouseDown en TextBox: abrir solo si está cerrado
            textBox.MouseDown += (s, e) =>
            {
                if (_isAnimating) return;

                _focusByMouse = true;

                // 👉 abrir solo si está permitido y está cerrado
                if (OpenOnClick && !dropHost.Visible)
                {
                    ApplyFocus(true);
                    ShowDropdown();
                }

                var t = new WinTimer { Interval = 120 };
                t.Tick += (_, __) =>
                {
                    t.Stop(); t.Dispose();
                    _focusByMouse = false;
                };
                t.Start();
            };


            // Gana foco → puede abrir si está configurado
            textBox.GotFocus += (_, __) =>
            {
                ApplyFocus(true);

                // 👉 si NO querés apertura por foco, respetar el flag
                if (!OpenOnFocus) return;

                if (_isClosing) return;

                if (!_focusByMouse && !_isAnimating && !_isOpeningInternally && !dropHost.Visible)
                {
                    ShowDropdown();
                }
            };


            // Pierde foco → verificar cierre
            textBox.LostFocus += (_, __) =>
            {
                // Debounce de cierre igual (por si abrís/cerrás muy rápido)
                DelayCheckFocusLoss();

                // 👉 si la lista NO está visible y ningún subcontrol tiene foco, apagar verde YA
                if (!dropHost.Visible && !HasTrueFocus())
                    ApplyFocus(false);
            };


            // Navegación con teclado
            textBox.KeyDown += TextBox_KeyDown;

            Controls.Add(textBox);

            // Botón de drop
            dropButton = new WFButton
            {
                Dock = DockStyle.Right,
                Width = 25,
                FlatStyle = WFFlatStyle.Flat,
                BackColor = BackColor,
                TabStop = false
            };
            dropButton.FlatAppearance.BorderSize = 0;
            dropButton.Paint += DrawArrow;

            dropButton.MouseDown += (_, __) =>
            {
                _isOpeningInternally = true;   // para que el filtro global no cierre
                ApplyFocus(true);
            };

            dropButton.MouseUp += (_, __) =>
            {
                BeginInvoke(new System.Action(() =>
                {
                    _isOpeningInternally = false;
                    if (dropHost.Visible) CloseDropdownAnimated();
                    else ShowDropdown();
                    textBox.Focus();
                }));
            };


            dropButton.LostFocus += (_, __) =>
            {
                DelayCheckFocusLoss();
                if (!dropHost.Visible && !HasTrueFocus())
                    ApplyFocus(false);
            };

            Controls.Add(dropButton);

            // Línea inferior
            bottomLine = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 2,
                BackColor = LineGray
            };
            Controls.Add(bottomLine);

            // Lista
            listBox = new ListBox
            {
                BorderStyle = BorderStyle.None,
                Font = new Font("Segoe UI", 14f),
                IntegralHeight = false,
                ItemHeight = 36,
                BackColor = Color.White,
                DrawMode = DrawMode.OwnerDrawFixed
            };
            listBox.DrawItem += ListBox_DrawItem;
            listBox.Click += (_, __) => AcceptSelection();
            listBox.LostFocus += (_, __) => DelayCheckFocusLoss();

            // Host flotante
            dropHost = new Panel
            {
                Visible = false,
                BackColor = Color.Transparent
            };
            dropHost.Paint += DropHost_Paint;

            // Redimensionar
            Resize += (_, __) =>
            {
                textBox.Width = Width - 30;
                if (dropHost.Visible) RepositionDropHost(dropHost.Height);
            };

            // Limpiezas
            Disposed += (_, __) => HideDropdown();
            VisibleChanged += (_, __) => { if (!Visible) HideDropdown(); };


        }

        // ================== API ==================
        public void BindItems(IEnumerable<string> items)
        {
            Items = items?.ToList() ?? new List<string>();
            _itemsReady = Items.Count > 0;

            if (!_filterHooked)
            {
                _filterHooked = true;
                textBox.TextChanged += (_, __) =>
                {
                    if (!_itemsReady || !IsHandleCreated) return;

                    string txt = textBox.Text?.Trim() ?? "";
                    if (string.IsNullOrEmpty(txt))
                    {
                        HideDropdown();
                        return;
                    }
                    ShowDropdown(); // recalcula alto y filtro en vivo
                };
            }

            if (dropHost.Visible)
                RefillList();
        }

        public void ClearItems()
        {
            Items.Clear();
            _itemsReady = false;
            listBox.Items.Clear();
            HideDropdown();
        }

        // ================== DIBUJO ==================
        private void DrawArrow(object? sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Color arrow = (HasTrueFocus() || dropHost.Visible) ? Accent : Color.FromArgb(100, 100, 100);
            using var pen = new Pen(arrow, 2);
            int midX = dropButton.Width / 2;
            int midY = dropButton.Height / 2;
            e.Graphics.DrawLines(pen, new[]
            {
                new Point(midX - 5, midY - 2),
                new Point(midX,     midY + 3),
                new Point(midX + 5, midY - 2)
            });
        }

        private void ListBox_DrawItem(object? sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            bool selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            Color bgColor = selected ? Color.FromArgb(232, 245, 233) : Color.White;

            using (var bg = new SolidBrush(bgColor))
                g.FillRectangle(bg, e.Bounds);

            string text = listBox.Items[e.Index]?.ToString() ?? "";
            using var textBrush = new SolidBrush(Color.FromArgb(33, 33, 33));

            float textY = e.Bounds.Top + (e.Bounds.Height - e.Font.Height) / 2f;
            g.DrawString(text, e.Font, textBrush, e.Bounds.Left + 10, textY);
        }

        private void DropHost_Paint(object? sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (var clip = new Region(new Rectangle(0, 0, dropHost.Width, dropHost.Height)))
                g.Clip = clip;

            g.Clear(Color.Transparent);
            var rect = new Rectangle(0, 0, dropHost.Width - 1, dropHost.Height - 1);

            using var bg = new SolidBrush(Color.White);
            g.FillRectangle(bg, rect);

            using var border = new Pen(Color.FromArgb(210, 210, 210), 1);
            g.DrawRectangle(border, rect);

            using var top = new Pen(Accent, 2);
            g.DrawLine(top, rect.Left, rect.Top, rect.Right, rect.Top);

            for (int i = 1; i <= 6; i++)
            {
                int alpha = 22 - i * 3;
                using var sh = new SolidBrush(Color.FromArgb(Math.Max(alpha, 0), 0, 0, 0));
                g.FillRectangle(sh, rect.Left - 2, rect.Bottom + i, rect.Width + 4, 1);
            }
        }

        // ================== FOCUS ==================
        private bool HasTrueFocus()
        {
            return textBox.ContainsFocus || dropButton.ContainsFocus || listBox.ContainsFocus || dropHost.ContainsFocus;
        }

        private void ApplyFocus(bool focused)
        {
            if (_applyingFocus) return;
            if (bottomLine == null || dropButton == null || textBox == null) return;
            if (IsDisposed || !IsHandleCreated) return;              // el UserControl no tiene handle listo
            if (textBox.IsDisposed) return;                          // safety

            _applyingFocus = true;
            try
            {
                // Estado real: foco en subcontroles o lista visible (y no cerrando)
                bool hasFocus = HasTrueFocus() || (dropHost.Visible && !_isClosing);

                // Cambiar línea y flecha solo si cambia
                var newColor = hasFocus ? Accent : LineGray;
                if (bottomLine.BackColor != newColor)
                    bottomLine.BackColor = newColor;

                dropButton.Invalidate(); // ok hacer invalidate

                // Alinear el texto sin forzar handle si aún no existe
                HorizontalAlignment desired =
                    hasFocus ? HorizontalAlignment.Left :
                    (string.IsNullOrEmpty(textBox.Text) ? HorizontalAlignment.Center : textBox.TextAlign);

                if (textBox.TextAlign != desired)
                {
                    if (textBox.IsHandleCreated && !textBox.IsDisposed)
                    {
                        textBox.TextAlign = desired;
                    }
                    else
                    {
                        // Si el handle no está listo, postergar una vez
                        BeginInvoke(new System.Action(() =>
                        {
                            if (!IsDisposed && IsHandleCreated && textBox.IsHandleCreated && !textBox.IsDisposed)
                            {
                                if (textBox.TextAlign != desired)
                                    textBox.TextAlign = desired;
                            }
                        }));
                    }
                }
            }
            finally
            {
                _applyingFocus = false;
            }
        }



        // ================== DROPDOWN ==================
        private void RefillList()
        {
            string term = textBox.Text?.Trim().ToLower() ?? "";
            var filtered = string.IsNullOrEmpty(term)
                ? Items
                : Items.Where(i => i.ToLower().Contains(term)).ToList();

            listBox.BeginUpdate();
            listBox.Items.Clear();
            listBox.Items.AddRange(filtered.Cast<object>().ToArray());
            listBox.EndUpdate();

            if (filtered.Count == 0)
            {
                HideDropdown();
                return;
            }

            if (Math.Abs(listBox.Font.Size - 14f) > 0.1f)
            {
                listBox.Font = new Font(listBox.Font.FontFamily, 14f, FontStyle.Regular, GraphicsUnit.Point);
                listBox.ItemHeight = TextRenderer.MeasureText("Ag", listBox.Font).Height + 12;
            }

            int visibleCount = Math.Min(filtered.Count, 4);
            int listHeight = visibleCount * listBox.ItemHeight;
            int hostHeight = listHeight + 2;

            listBox.Margin = Padding.Empty;
            listBox.Padding = Padding.Empty;
            listBox.BorderStyle = BorderStyle.None;

            listBox.Dock = DockStyle.None;
            listBox.Left = 1;
            listBox.Top = 1;
            listBox.Width = dropHost.Width - 2;
            listBox.Height = listHeight;

            listBox.ScrollAlwaysVisible = filtered.Count > 4;
            listBox.IntegralHeight = false;

            dropHost.Height = hostHeight;
            RepositionDropHost(hostHeight);

            dropHost.Invalidate();
        }

        private void RepositionDropHost(int targetHeight)
        {
            var parentForm = FindForm();
            if (parentForm == null) return;

            Point screen = PointToScreen(Point.Empty);
            Point rel = parentForm.PointToClient(screen);

            int y = rel.Y + Height;
            if (y + targetHeight > parentForm.ClientSize.Height)
                y = rel.Y - targetHeight - 2;

            dropHost.Location = new Point(rel.X, y);
            dropHost.Width = Width;
        }

        private void ShowDropdown()
        {
            if (InDesignMode) return; // 👈 no desplegar en diseñador

            if (_isAnimating || _isOpeningInternally) return;
            _isClosing = false;                 // venimos a abrir → no estamos cerrando
            _isOpeningInternally = true;        // evita cierres por filtro global/otros handlers

            try
            {
                if (!_itemsReady || Items.Count == 0) return;

                var parentForm = FindForm();
                if (parentForm == null || !parentForm.IsHandleCreated) return;

                // --- Filtro ---
                string filter = textBox.Text?.Trim().ToLower() ?? "";
                var filteredItems = string.IsNullOrEmpty(filter)
                    ? Items
                    : Items.Where(i => i.ToLower().Contains(filter)).ToList();

                if (filteredItems.Count == 0)
                {
                    HideDropdown();
                    return;
                }

                // --- Config ListBox ---
                listBox.BeginUpdate();
                listBox.Items.Clear();
                listBox.Items.AddRange(filteredItems.ToArray());
                listBox.EndUpdate();

                listBox.Dock = DockStyle.None;
                listBox.Margin = Padding.Empty;
                listBox.Padding = Padding.Empty;
                listBox.BorderStyle = BorderStyle.None;
                listBox.IntegralHeight = false;
                listBox.ScrollAlwaysVisible = filteredItems.Count > 4;

                if (Math.Abs(listBox.Font.Size - 14f) > 0.1f)
                {
                    listBox.Font = new Font(listBox.Font.FontFamily, 14f, FontStyle.Regular);
                    listBox.ItemHeight = TextRenderer.MeasureText("Ag", listBox.Font).Height + 10;
                }

                // --- Insertar dentro del host ---
                if (listBox.Parent != dropHost)
                {
                    dropHost.Controls.Clear();
                    dropHost.Controls.Add(listBox);
                }
                if (dropHost.Parent != parentForm)
                {
                    parentForm.Controls.Add(dropHost);
                    dropHost.BringToFront();
                }

                // --- Calcular alturas ---
                int visibleItems = Math.Min(filteredItems.Count, 4);
                int listHeight = visibleItems * listBox.ItemHeight;
                int totalHeight = listHeight + 2;

                // --- Posicionar host ---
                Point screen = PointToScreen(Point.Empty);
                Point rel = parentForm.PointToClient(screen);

                int y = rel.Y + Height;
                if (y + totalHeight > parentForm.ClientSize.Height)
                    y = rel.Y - totalHeight - 2;

                dropHost.Location = new Point(rel.X, y);
                dropHost.Size = new Size(Width, 0); // setear ANTES de usar dropHost.Width

                // --- Sizing listBox (con host dimensionado) ---
                listBox.Top = 1;
                listBox.Left = 1;
                listBox.Width = dropHost.Width - 2;
                listBox.Height = 0; // arrancamos en 0 para animar

                dropHost.Visible = true;
                ApplyFocus(false); // mantener verde mientras esté abierto

                // Selección inicial (UX)
                if (listBox.Items.Count > 0 && listBox.SelectedIndex < 0)
                    listBox.SelectedIndex = 0;

                // --- Cancelar cualquier cierre en curso y apertura previa ---
                _openTimer?.Stop(); _openTimer?.Dispose(); _openTimer = null;
                _closeTimer?.Stop(); _closeTimer?.Dispose(); _closeTimer = null;

                // --- Apertura con/sin animación ---
                if (!AnimateOpen)
                {
                    dropHost.Height = totalHeight;
                    listBox.Height = listHeight;
                    _isOpeningInternally = false; // listo
                }
                else
                {
                    int step() => Math.Max(4, totalHeight / 10);

                    _openTimer = new WinTimer { Interval = 10 };
                    _openTimer.Tick += (s, e) =>
                    {
                        // si alguien pidió cerrar mientras abría, abortamos
                        if (!dropHost.Visible)
                        {
                            _openTimer!.Stop(); _openTimer.Dispose(); _openTimer = null;
                            _isOpeningInternally = false;
                            return;
                        }

                        if (dropHost.Height < totalHeight)
                        {
                            dropHost.Height += step();
                            listBox.Height = Math.Max(0, dropHost.Height - 2);
                        }
                        else
                        {
                            dropHost.Height = totalHeight;
                            listBox.Height = listHeight;
                            _openTimer!.Stop(); _openTimer.Dispose(); _openTimer = null;
                            _isOpeningInternally = false;
                        }
                    };
                    _openTimer.Start();
                }
            }
            finally
            {
                // Si salimos por return temprano (no se abrió), liberá el flag.
                if (!dropHost.Visible || listBox.Height == 0)
                    _isOpeningInternally = false;
            }
        }




        private void HideDropdown()
        {
            if (dropHost.Visible)
            {
                dropHost.Visible = false;
                dropHost.Height = 0;
            }

            listBox.ClearSelected();

            var form = FindForm();
            if (form != null && dropHost.Parent == form && form.Controls.Contains(dropHost))
                form.Controls.Remove(dropHost);

            // No re-forzar foco al TextBox (evita rebotes y verde pegado)
            ApplyFocus(false);
        }

        private void CloseDropdownAnimated()
        {
            if (InDesignMode) { dropHost.Visible = false; return; }

            if (!dropHost.Visible) return;

            // cancelar apertura en curso
            _openTimer?.Stop();
            _openTimer?.Dispose();
            _openTimer = null;

            if (!AnimateClose)
            {
                _isAnimating = false;
                _isClosing = false;

                dropHost.Visible = false;
                dropHost.Height = 0;
                listBox.Height = 0;

                ApplyFocus(false);
                return;
            }

            // --- cierre animado (solo si querés AnimateClose=true) ---
            if (_isAnimating) return;

            _isClosing = true;
            _isAnimating = true;

            _closeTimer?.Stop();
            _closeTimer?.Dispose();
            _closeTimer = new WinTimer { Interval = 10 };

            _closeTimer.Tick += (s, e) =>
            {
                if (dropHost.Height > 0)
                {
                    dropHost.Height -= Math.Max(2, dropHost.Height / 10);
                    listBox.Height = Math.Max(0, dropHost.Height - 2);
                    dropHost.Invalidate();
                }
                else
                {
                    dropHost.Visible = false;
                    dropHost.Height = 0;

                    _isAnimating = false;
                    _isClosing = false;

                    _closeTimer!.Stop(); _closeTimer.Dispose(); _closeTimer = null;

                    ApplyFocus(false);
                }
            };
            _closeTimer.Start();
        }


        // ================== SELECCIÓN / TECLADO ==================
        private void AcceptSelection()
        {
            if (listBox.SelectedItem == null) return;
            textBox.Text = listBox.SelectedItem.ToString() ?? string.Empty;
            textBox.SelectionStart = textBox.TextLength;
            textBox.SelectionLength = 0;
            CloseDropdownAnimated();
            SelectedIndexChanged?.Invoke(this, EventArgs.Empty);
            textBox.Focus();
        }

        private void TextBox_KeyDown(object? sender, KeyEventArgs e)
        {
            if (!dropHost.Visible) return;

            if (e.KeyCode == Keys.Down && listBox.SelectedIndex < listBox.Items.Count - 1)
            {
                listBox.SelectedIndex = Math.Max(0, listBox.SelectedIndex + 1);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up && listBox.SelectedIndex > 0)
            {
                listBox.SelectedIndex -= 1;
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                AcceptSelection();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                CloseDropdownAnimated();
                e.Handled = true;
            }
        }

        // ================== CLICK GLOBAL (cierra fuera) ==================
        private sealed class GlobalClickFilter : IMessageFilter
        {
            private readonly MaterialEditableComboBoxFixed _owner;

            public GlobalClickFilter(MaterialEditableComboBoxFixed owner)
            {
                _owner = owner;
            }

            public bool PreFilterMessage(ref Message m)
            {
                const int WM_LBUTTONDOWN = 0x0201;
                if (m.Msg != WM_LBUTTONDOWN)
                    return false;

                if (_owner == null || _owner.dropHost == null)
                    return false;

                // No cerrar mientras se está abriendo internamente
                if (_owner._isOpeningInternally || _owner._isAnimating || _owner._isClosing)
                    return false; // no interrumpir transiciones

                if (!_owner.dropHost.Visible)
                    return false;

                Control? clicked = Control.FromChildHandle(m.HWnd);
                if (clicked == null)
                    return false;

                // Si el clic fue dentro del combo o su dropdown → no cerrar
                if (_owner.Contains(clicked) || _owner.dropHost.Contains(clicked))
                    return false;

                // Clic fuera → cerrar
                _owner.CloseDropdownAnimated();
                _owner.ApplyFocus(false);
                return false;
            }

        }

        // 👇 Delay para consolidar pérdida de foco
        private void DelayCheckFocusLoss()
        {
            if (InDesignMode) return; // 👈 nada de timers en diseñador

            // cancelar timer previo si existía
            if (_focusLossTimer != null)
            {
                _focusLossTimer.Stop();
                _focusLossTimer.Dispose();
                _focusLossTimer = null;
            }

            _focusLossTimer = new WinTimer { Interval = FocusDebounceMs };
            _focusLossTimer.Tick += (_, __) =>
            {
                _focusLossTimer!.Stop();
                _focusLossTimer.Dispose();
                _focusLossTimer = null;

                // si estamos abriendo/cerrando, no decidas todavía
                if (_isAnimating || _isOpeningInternally) return;

                // ¿algún subcontrol aún tiene foco?
                if (HasTrueFocus()) return;

                var form = FindForm();
                if (form == null) return;

                // ¿activo sigue siendo parte del combo o dropdown?
                Control? active = form.ActiveControl;
                if (active != null && (Contains(active) || dropHost.Contains(active))) return;

                // ¿el mouse quedó sobre el dropdown? (clicks rápidos)
                var mouse = form.PointToClient(Cursor.Position);
                if (dropHost.Visible && dropHost.Bounds.Contains(mouse)) return;

                if (dropHost.Visible) CloseDropdownAnimated();

                if (!HasTrueFocus())
                    ApplyFocus(false);
            };
            _focusLossTimer.Start();
        }

        // --- Hook del Form y filtros globales ---
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (InDesignMode) return; // 👈 clave

            if (_clickFilter == null)
            {
                _clickFilter = new GlobalClickFilter(this);
                Application.AddMessageFilter(_clickFilter);
            }

            BeginInvoke(new System.Action(HookHostForm));
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            if (!InDesignMode && _clickFilter != null)
            {
                Application.RemoveMessageFilter(_clickFilter);
                _clickFilter = null;
            }

            if (!InDesignMode && _hostForm != null)
            {
                _hostForm.Move -= HostForm_MoveResize;
                _hostForm.Resize -= HostForm_MoveResize;
                _hostForm.Deactivate -= HostForm_Deactivate;
                _hostForm.FormClosed -= HostForm_FormClosed;
                _hostForm = null;
            }

            base.OnHandleDestroyed(e);
        }


        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (!Visible && dropHost.Visible)
            {
                dropHost.Visible = false;
                dropHost.Height = 0;
            }
        }

        private void HookHostForm()
        {
            if (InDesignMode) return; // 👈 no engancharse al Form en diseñador

            var form = this.FindForm();
            if (form == null)
            {
                BeginInvoke(new System.Action(HookHostForm));
                return;
            }

            if (_hostForm == form) return;

            if (_hostForm != null)
            {
                _hostForm.Move -= HostForm_MoveResize;
                _hostForm.Resize -= HostForm_MoveResize;
                _hostForm.Deactivate -= HostForm_Deactivate;
                _hostForm.FormClosed -= HostForm_FormClosed;
            }

            _hostForm = form;

            _hostForm.Move += HostForm_MoveResize;
            _hostForm.Resize += HostForm_MoveResize;
            _hostForm.Deactivate += HostForm_Deactivate;
            _hostForm.FormClosed += HostForm_FormClosed;
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                dropHost?.Dispose();
            }
            base.Dispose(disposing);
        }
        
        private void HostForm_MoveResize(object? sender, EventArgs e)
        {
            if (dropHost != null && !dropHost.IsDisposed && dropHost.Visible)
                RepositionDropHost(dropHost.Height);
        }

        private void HostForm_Deactivate(object? sender, EventArgs e) => HideDropdown();
        private void HostForm_FormClosed(object? sender, FormClosedEventArgs e) => HideDropdown();

        // --- Dentro del click o mouse down del combo:
        private void OnComboMouseDown(object? sender, MouseEventArgs e)
        {
            _focusByMouse = true;

            if (dropHost.Visible)
                CloseDropdownAnimated();
            else
            {
                _suppressNextFocus = true;
                ShowDropdown();

                var timer = new WinTimer { Interval = 80 };
                timer.Tick += (s, _) =>
                {
                    _suppressNextFocus = false;
                    timer.Stop();
                    timer.Dispose();
                };
                timer.Start();
            }
        }
    }
}
