namespace GestionAgraria.Views
{
    partial class UCComprasAdd
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            materialExpansionPanel1 = new ReaLTaiizor.Controls.MaterialExpansionPanel();
            groupBox4 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel7 = new Panel();
            txtObservaciones = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            groupBox1 = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel1 = new Panel();
            panel5 = new Panel();
            txtPrecioCosto = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblDescripcion = new ReaLTaiizor.Controls.MaterialLabel();
            txtNombreProducto = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblNombreProducto = new ReaLTaiizor.Controls.MaterialLabel();
            panel3 = new Panel();
            panel4 = new Panel();
            txtCantidad = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblCantidad = new ReaLTaiizor.Controls.MaterialLabel();
            tbCodigoProducto = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblCodigoProducto = new ReaLTaiizor.Controls.MaterialLabel();
            materialExpansionPanel1.SuspendLayout();
            groupBox4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // materialExpansionPanel1
            // 
            materialExpansionPanel1.BackColor = Color.FromArgb(255, 255, 255);
            materialExpansionPanel1.CancelButtonText = "CANCELAR";
            materialExpansionPanel1.Controls.Add(groupBox4);
            materialExpansionPanel1.Controls.Add(panel2);
            materialExpansionPanel1.Depth = 0;
            materialExpansionPanel1.Description = "Registrar Nuevas Compras";
            materialExpansionPanel1.Dock = DockStyle.Fill;
            materialExpansionPanel1.ExpandHeight = 604;
            materialExpansionPanel1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialExpansionPanel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialExpansionPanel1.Location = new Point(0, 0);
            materialExpansionPanel1.Margin = new Padding(3, 12, 3, 12);
            materialExpansionPanel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialExpansionPanel1.Name = "materialExpansionPanel1";
            materialExpansionPanel1.Padding = new Padding(21, 48, 21, 12);
            materialExpansionPanel1.Size = new Size(1152, 604);
            materialExpansionPanel1.TabIndex = 2;
            materialExpansionPanel1.Title = "Compras";
            materialExpansionPanel1.ValidationButtonText = "GUARDAR";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tableLayoutPanel1);
            groupBox4.Location = new Point(18, 432);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1110, 120);
            groupBox4.TabIndex = 35;
            groupBox4.TabStop = false;
            groupBox4.Text = "Observaciones del Producto";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel7, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 102F));
            tableLayoutPanel1.Size = new Size(1104, 98);
            tableLayoutPanel1.TabIndex = 29;
            // 
            // panel7
            // 
            panel7.Controls.Add(txtObservaciones);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(20, 0, 20, 0);
            panel7.Size = new Size(1104, 102);
            panel7.TabIndex = 21;
            // 
            // txtObservaciones
            // 
            txtObservaciones.AnimateReadOnly = false;
            txtObservaciones.BackgroundImageLayout = ImageLayout.None;
            txtObservaciones.CharacterCasing = CharacterCasing.Normal;
            txtObservaciones.Depth = 0;
            txtObservaciones.HideSelection = true;
            txtObservaciones.Location = new Point(20, 16);
            txtObservaciones.Margin = new Padding(3, 2, 3, 2);
            txtObservaciones.MaxLength = 32767;
            txtObservaciones.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.PasswordChar = '\0';
            txtObservaciones.ReadOnly = false;
            txtObservaciones.ScrollBars = ScrollBars.None;
            txtObservaciones.SelectedText = "";
            txtObservaciones.SelectionLength = 0;
            txtObservaciones.SelectionStart = 0;
            txtObservaciones.ShortcutsEnabled = true;
            txtObservaciones.Size = new Size(1068, 70);
            txtObservaciones.TabIndex = 5;
            txtObservaciones.TabStop = false;
            txtObservaciones.TextAlign = HorizontalAlignment.Left;
            txtObservaciones.UseSystemPasswordChar = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(materialButton1);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(21, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(1110, 544);
            panel2.TabIndex = 12;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(3, 209);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(1105, 172);
            groupBox2.TabIndex = 34;
            groupBox2.TabStop = false;
            groupBox2.Text = "Compras Agregadas";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 22);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1095, 141);
            dataGridView1.TabIndex = 0;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.Dock = DockStyle.Top;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton1.Location = new Point(0, 162);
            materialButton1.Margin = new Padding(4);
            materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(1110, 36);
            materialButton1.TabIndex = 33;
            materialButton1.Text = "AGREGAR";
            materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel5);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1110, 162);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Producto";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(panel1, 1, 0);
            tableLayoutPanel5.Controls.Add(panel3, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 19);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 144F));
            tableLayoutPanel5.Size = new Size(1104, 140);
            tableLayoutPanel5.TabIndex = 29;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(txtNombreProducto);
            panel1.Controls.Add(lblNombreProducto);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(552, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 0, 20, 0);
            panel1.Size = new Size(552, 144);
            panel1.TabIndex = 22;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtPrecioCosto);
            panel5.Controls.Add(lblDescripcion);
            panel5.Location = new Point(0, 66);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(20, 0, 20, 0);
            panel5.Size = new Size(553, 78);
            panel5.TabIndex = 24;
            // 
            // txtPrecioCosto
            // 
            txtPrecioCosto.AnimateReadOnly = false;
            txtPrecioCosto.AutoCompleteMode = AutoCompleteMode.None;
            txtPrecioCosto.AutoCompleteSource = AutoCompleteSource.None;
            txtPrecioCosto.BackgroundImageLayout = ImageLayout.None;
            txtPrecioCosto.CharacterCasing = CharacterCasing.Normal;
            txtPrecioCosto.Depth = 0;
            txtPrecioCosto.Dock = DockStyle.Fill;
            txtPrecioCosto.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrecioCosto.HideSelection = true;
            txtPrecioCosto.LeadingIcon = null;
            txtPrecioCosto.Location = new Point(20, 19);
            txtPrecioCosto.Margin = new Padding(3, 3, 26, 3);
            txtPrecioCosto.MaxLength = 32767;
            txtPrecioCosto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPrecioCosto.Name = "txtPrecioCosto";
            txtPrecioCosto.Padding = new Padding(9, 8, 9, 8);
            txtPrecioCosto.PasswordChar = '\0';
            txtPrecioCosto.PrefixSuffixText = null;
            txtPrecioCosto.ReadOnly = false;
            txtPrecioCosto.RightToLeft = RightToLeft.No;
            txtPrecioCosto.SelectedText = "";
            txtPrecioCosto.SelectionLength = 0;
            txtPrecioCosto.SelectionStart = 0;
            txtPrecioCosto.ShortcutsEnabled = true;
            txtPrecioCosto.Size = new Size(513, 48);
            txtPrecioCosto.TabIndex = 0;
            txtPrecioCosto.TabStop = false;
            txtPrecioCosto.TextAlign = HorizontalAlignment.Left;
            txtPrecioCosto.TrailingIcon = null;
            txtPrecioCosto.UseSystemPasswordChar = false;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Depth = 0;
            lblDescripcion.Dock = DockStyle.Top;
            lblDescripcion.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblDescripcion.Location = new Point(20, 0);
            lblDescripcion.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(94, 19);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Precio Costo ";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.AnimateReadOnly = false;
            txtNombreProducto.AutoCompleteMode = AutoCompleteMode.None;
            txtNombreProducto.AutoCompleteSource = AutoCompleteSource.None;
            txtNombreProducto.BackgroundImageLayout = ImageLayout.None;
            txtNombreProducto.CharacterCasing = CharacterCasing.Normal;
            txtNombreProducto.Depth = 0;
            txtNombreProducto.Dock = DockStyle.Fill;
            txtNombreProducto.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombreProducto.HideSelection = true;
            txtNombreProducto.LeadingIcon = null;
            txtNombreProducto.Location = new Point(20, 19);
            txtNombreProducto.Margin = new Padding(3, 3, 26, 3);
            txtNombreProducto.MaxLength = 32767;
            txtNombreProducto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Padding = new Padding(9, 8, 9, 8);
            txtNombreProducto.PasswordChar = '\0';
            txtNombreProducto.PrefixSuffixText = null;
            txtNombreProducto.ReadOnly = false;
            txtNombreProducto.RightToLeft = RightToLeft.No;
            txtNombreProducto.SelectedText = "";
            txtNombreProducto.SelectionLength = 0;
            txtNombreProducto.SelectionStart = 0;
            txtNombreProducto.ShortcutsEnabled = true;
            txtNombreProducto.Size = new Size(512, 48);
            txtNombreProducto.TabIndex = 0;
            txtNombreProducto.TabStop = false;
            txtNombreProducto.TextAlign = HorizontalAlignment.Left;
            txtNombreProducto.TrailingIcon = null;
            txtNombreProducto.UseSystemPasswordChar = false;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Depth = 0;
            lblNombreProducto.Dock = DockStyle.Top;
            lblNombreProducto.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblNombreProducto.Location = new Point(20, 0);
            lblNombreProducto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(57, 19);
            lblNombreProducto.TabIndex = 4;
            lblNombreProducto.Text = "Nombre";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(tbCodigoProducto);
            panel3.Controls.Add(lblCodigoProducto);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 0, 20, 0);
            panel3.Size = new Size(552, 144);
            panel3.TabIndex = 21;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtCantidad);
            panel4.Controls.Add(lblCantidad);
            panel4.Location = new Point(0, 66);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20, 0, 20, 0);
            panel4.Size = new Size(552, 78);
            panel4.TabIndex = 23;
            // 
            // txtCantidad
            // 
            txtCantidad.AnimateReadOnly = false;
            txtCantidad.AutoCompleteMode = AutoCompleteMode.None;
            txtCantidad.AutoCompleteSource = AutoCompleteSource.None;
            txtCantidad.BackgroundImageLayout = ImageLayout.None;
            txtCantidad.CharacterCasing = CharacterCasing.Normal;
            txtCantidad.Depth = 0;
            txtCantidad.Dock = DockStyle.Fill;
            txtCantidad.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCantidad.HideSelection = true;
            txtCantidad.LeadingIcon = null;
            txtCantidad.Location = new Point(20, 19);
            txtCantidad.Margin = new Padding(3, 3, 26, 3);
            txtCantidad.MaxLength = 32767;
            txtCantidad.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Padding = new Padding(9, 8, 9, 8);
            txtCantidad.PasswordChar = '\0';
            txtCantidad.PrefixSuffixText = null;
            txtCantidad.ReadOnly = false;
            txtCantidad.RightToLeft = RightToLeft.No;
            txtCantidad.SelectedText = "";
            txtCantidad.SelectionLength = 0;
            txtCantidad.SelectionStart = 0;
            txtCantidad.ShortcutsEnabled = true;
            txtCantidad.Size = new Size(512, 48);
            txtCantidad.TabIndex = 0;
            txtCantidad.TabStop = false;
            txtCantidad.TextAlign = HorizontalAlignment.Left;
            txtCantidad.TrailingIcon = null;
            txtCantidad.UseSystemPasswordChar = false;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Depth = 0;
            lblCantidad.Dock = DockStyle.Top;
            lblCantidad.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblCantidad.Location = new Point(20, 0);
            lblCantidad.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(65, 19);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "Cantidad";
            // 
            // tbCodigoProducto
            // 
            tbCodigoProducto.AnimateReadOnly = false;
            tbCodigoProducto.AutoCompleteMode = AutoCompleteMode.None;
            tbCodigoProducto.AutoCompleteSource = AutoCompleteSource.None;
            tbCodigoProducto.BackgroundImageLayout = ImageLayout.None;
            tbCodigoProducto.CharacterCasing = CharacterCasing.Normal;
            tbCodigoProducto.Depth = 0;
            tbCodigoProducto.Dock = DockStyle.Fill;
            tbCodigoProducto.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbCodigoProducto.HideSelection = true;
            tbCodigoProducto.LeadingIcon = null;
            tbCodigoProducto.Location = new Point(20, 19);
            tbCodigoProducto.Margin = new Padding(3, 3, 26, 3);
            tbCodigoProducto.MaxLength = 32767;
            tbCodigoProducto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbCodigoProducto.Name = "tbCodigoProducto";
            tbCodigoProducto.Padding = new Padding(9, 8, 9, 8);
            tbCodigoProducto.PasswordChar = '\0';
            tbCodigoProducto.PrefixSuffixText = null;
            tbCodigoProducto.ReadOnly = false;
            tbCodigoProducto.RightToLeft = RightToLeft.No;
            tbCodigoProducto.SelectedText = "";
            tbCodigoProducto.SelectionLength = 0;
            tbCodigoProducto.SelectionStart = 0;
            tbCodigoProducto.ShortcutsEnabled = true;
            tbCodigoProducto.Size = new Size(512, 48);
            tbCodigoProducto.TabIndex = 0;
            tbCodigoProducto.TabStop = false;
            tbCodigoProducto.TextAlign = HorizontalAlignment.Left;
            tbCodigoProducto.TrailingIcon = null;
            tbCodigoProducto.UseSystemPasswordChar = false;
            // 
            // lblCodigoProducto
            // 
            lblCodigoProducto.AutoSize = true;
            lblCodigoProducto.Depth = 0;
            lblCodigoProducto.Dock = DockStyle.Top;
            lblCodigoProducto.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblCodigoProducto.Location = new Point(20, 0);
            lblCodigoProducto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblCodigoProducto.Name = "lblCodigoProducto";
            lblCodigoProducto.Size = new Size(55, 19);
            lblCodigoProducto.TabIndex = 4;
            lblCodigoProducto.Text = "Codigo ";
            // 
            // UCComprasAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialExpansionPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCComprasAdd";
            Size = new Size(1152, 604);
            materialExpansionPanel1.ResumeLayout(false);
            materialExpansionPanel1.PerformLayout();
            groupBox4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialExpansionPanel materialExpansionPanel1;
        private GroupBox groupBox4;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel6;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDescuento;
        private ReaLTaiizor.Controls.MaterialLabel lblDescuento;
        private Panel panel7;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSubTotal;
        private Panel panel2;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNombreProducto;
        private ReaLTaiizor.Controls.MaterialLabel lblNombreProducto;
        private Panel panel3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbCodigoProducto;
        private ReaLTaiizor.Controls.MaterialLabel lblCodigoProducto;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit txtObservaciones;
        private Panel panel5;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPrecioCosto;
        private ReaLTaiizor.Controls.MaterialLabel lblDescripcion;
        private Panel panel4;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCantidad;
        private ReaLTaiizor.Controls.MaterialLabel lblCantidad;
    }
}
