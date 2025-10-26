namespace GestionAgraria.Views
{
    partial class UCActivityRecordAdd
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
            mepActivityRecord = new GestionAgraria.Controls.NonCollapsibleMaterialExpansionPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel8 = new Panel();
            tbObservaciones = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            materialLabel8 = new ReaLTaiizor.Controls.MaterialLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel4 = new Panel();
            cbEstado = new ReaLTaiizor.Controls.MaterialComboBox();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            panel9 = new Panel();
            cbStateRecord = new ReaLTaiizor.Controls.MaterialComboBox();
            materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            panel1 = new Panel();
            cbFormativeEnvironment = new ReaLTaiizor.Controls.MaterialComboBox();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            panel3 = new Panel();
            tbTitleActivity = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblUsuario = new ReaLTaiizor.Controls.MaterialLabel();
            mepActivityRecord.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel8.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel4.SuspendLayout();
            panel9.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // mepActivityRecord
            // 
            mepActivityRecord.BackColor = Color.FromArgb(255, 255, 255);
            mepActivityRecord.CancelButtonText = "CANCELAR";
            mepActivityRecord.Controls.Add(tableLayoutPanel2);
            mepActivityRecord.Depth = 0;
            mepActivityRecord.Description = "Crea tareas personalizadas";
            mepActivityRecord.Dock = DockStyle.Fill;
            mepActivityRecord.ExpandHeight = 496;
            mepActivityRecord.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            mepActivityRecord.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mepActivityRecord.Location = new Point(0, 0);
            mepActivityRecord.Margin = new Padding(3, 12, 3, 12);
            mepActivityRecord.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mepActivityRecord.Name = "mepActivityRecord";
            mepActivityRecord.Padding = new Padding(21, 48, 21, 20);
            mepActivityRecord.ShowCollapseExpand = false;
            mepActivityRecord.Size = new Size(1000, 496);
            mepActivityRecord.TabIndex = 1;
            mepActivityRecord.Title = "Registro de actividad";
            mepActivityRecord.ValidationButtonEnable = true;
            mepActivityRecord.ValidationButtonText = "GUARDAR";
            mepActivityRecord.SaveClick += mepActivityAdd_SaveClick;
            mepActivityRecord.CancelClick += mepActivityAdd_CancelClick;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel8, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(21, 48);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 42.990654F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 44.8598137F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.3831778F));
            tableLayoutPanel2.Size = new Size(958, 428);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // panel8
            // 
            panel8.AutoSize = true;
            panel8.Controls.Add(tbObservaciones);
            panel8.Controls.Add(materialLabel8);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 183);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(20, 0, 20, 0);
            panel8.Size = new Size(958, 191);
            panel8.TabIndex = 29;
            // 
            // tbObservaciones
            // 
            tbObservaciones.AnimateReadOnly = false;
            tbObservaciones.BackgroundImageLayout = ImageLayout.None;
            tbObservaciones.CharacterCasing = CharacterCasing.Normal;
            tbObservaciones.Depth = 0;
            tbObservaciones.Dock = DockStyle.Fill;
            tbObservaciones.HideSelection = true;
            tbObservaciones.Location = new Point(20, 19);
            tbObservaciones.Margin = new Padding(3, 2, 3, 2);
            tbObservaciones.MaxLength = 32767;
            tbObservaciones.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbObservaciones.Name = "tbObservaciones";
            tbObservaciones.PasswordChar = '\0';
            tbObservaciones.ReadOnly = false;
            tbObservaciones.ScrollBars = ScrollBars.None;
            tbObservaciones.SelectedText = "";
            tbObservaciones.SelectionLength = 0;
            tbObservaciones.SelectionStart = 0;
            tbObservaciones.ShortcutsEnabled = true;
            tbObservaciones.Size = new Size(918, 172);
            tbObservaciones.TabIndex = 6;
            tbObservaciones.TabStop = false;
            tbObservaciones.TextAlign = HorizontalAlignment.Left;
            tbObservaciones.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Dock = DockStyle.Top;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(20, 0);
            materialLabel8.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(105, 19);
            materialLabel8.TabIndex = 4;
            materialLabel8.Text = "Observaciones";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.1596642F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 2);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.31847F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 102F));
            tableLayoutPanel1.Size = new Size(952, 178);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.Controls.Add(panel4, 2, 0);
            tableLayoutPanel3.Controls.Add(panel9, 1, 0);
            tableLayoutPanel3.Controls.Add(panel1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(3, 78);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(946, 80);
            tableLayoutPanel3.TabIndex = 24;
            // 
            // panel4
            // 
            panel4.Controls.Add(cbEstado);
            panel4.Controls.Add(materialLabel2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(630, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20, 0, 20, 0);
            panel4.Size = new Size(316, 80);
            panel4.TabIndex = 41;
            // 
            // cbEstado
            // 
            cbEstado.AutoResize = false;
            cbEstado.BackColor = Color.FromArgb(255, 255, 255);
            cbEstado.Depth = 0;
            cbEstado.Dock = DockStyle.Top;
            cbEstado.DrawMode = DrawMode.OwnerDrawVariable;
            cbEstado.DropDownHeight = 174;
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.DropDownWidth = 121;
            cbEstado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbEstado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbEstado.FormattingEnabled = true;
            cbEstado.IntegralHeight = false;
            cbEstado.ItemHeight = 43;
            cbEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cbEstado.Location = new Point(20, 19);
            cbEstado.MaxDropDownItems = 4;
            cbEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(276, 49);
            cbEstado.StartIndex = 0;
            cbEstado.TabIndex = 10;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Dock = DockStyle.Top;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(20, 0);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(50, 19);
            materialLabel2.TabIndex = 4;
            materialLabel2.Text = "Estado";
            // 
            // panel9
            // 
            panel9.Controls.Add(cbStateRecord);
            panel9.Controls.Add(materialLabel4);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(315, 0);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(20, 0, 20, 0);
            panel9.Size = new Size(315, 80);
            panel9.TabIndex = 40;
            // 
            // cbStateRecord
            // 
            cbStateRecord.AutoResize = false;
            cbStateRecord.BackColor = Color.FromArgb(255, 255, 255);
            cbStateRecord.Depth = 0;
            cbStateRecord.Dock = DockStyle.Top;
            cbStateRecord.DrawMode = DrawMode.OwnerDrawVariable;
            cbStateRecord.DropDownHeight = 174;
            cbStateRecord.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStateRecord.DropDownWidth = 121;
            cbStateRecord.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbStateRecord.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbStateRecord.FormattingEnabled = true;
            cbStateRecord.IntegralHeight = false;
            cbStateRecord.ItemHeight = 43;
            cbStateRecord.Location = new Point(20, 19);
            cbStateRecord.MaxDropDownItems = 4;
            cbStateRecord.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbStateRecord.Name = "cbStateRecord";
            cbStateRecord.Size = new Size(275, 49);
            cbStateRecord.StartIndex = 0;
            cbStateRecord.TabIndex = 10;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Dock = DockStyle.Top;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(20, 0);
            materialLabel4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(140, 19);
            materialLabel4.TabIndex = 4;
            materialLabel4.Text = "Estado de actividad";
            // 
            // panel1
            // 
            panel1.Controls.Add(cbFormativeEnvironment);
            panel1.Controls.Add(materialLabel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 0, 20, 0);
            panel1.Size = new Size(315, 80);
            panel1.TabIndex = 39;
            // 
            // cbFormativeEnvironment
            // 
            cbFormativeEnvironment.AutoResize = false;
            cbFormativeEnvironment.BackColor = Color.FromArgb(255, 255, 255);
            cbFormativeEnvironment.Depth = 0;
            cbFormativeEnvironment.Dock = DockStyle.Top;
            cbFormativeEnvironment.DrawMode = DrawMode.OwnerDrawVariable;
            cbFormativeEnvironment.DropDownHeight = 174;
            cbFormativeEnvironment.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFormativeEnvironment.DropDownWidth = 121;
            cbFormativeEnvironment.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbFormativeEnvironment.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbFormativeEnvironment.FormattingEnabled = true;
            cbFormativeEnvironment.IntegralHeight = false;
            cbFormativeEnvironment.ItemHeight = 43;
            cbFormativeEnvironment.Location = new Point(20, 19);
            cbFormativeEnvironment.MaxDropDownItems = 4;
            cbFormativeEnvironment.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbFormativeEnvironment.Name = "cbFormativeEnvironment";
            cbFormativeEnvironment.Size = new Size(275, 49);
            cbFormativeEnvironment.StartIndex = 0;
            cbFormativeEnvironment.TabIndex = 10;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Dock = DockStyle.Top;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(20, 0);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(154, 19);
            materialLabel1.TabIndex = 4;
            materialLabel1.Text = "Entorno perteneciente";
            // 
            // panel3
            // 
            panel3.Controls.Add(tbTitleActivity);
            panel3.Controls.Add(lblUsuario);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 0, 20, 0);
            panel3.Size = new Size(952, 76);
            panel3.TabIndex = 23;
            // 
            // tbTitleActivity
            // 
            tbTitleActivity.AnimateReadOnly = false;
            tbTitleActivity.AutoCompleteMode = AutoCompleteMode.None;
            tbTitleActivity.AutoCompleteSource = AutoCompleteSource.None;
            tbTitleActivity.BackgroundImageLayout = ImageLayout.None;
            tbTitleActivity.CharacterCasing = CharacterCasing.Normal;
            tbTitleActivity.Depth = 0;
            tbTitleActivity.Dock = DockStyle.Fill;
            tbTitleActivity.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbTitleActivity.HideSelection = true;
            tbTitleActivity.LeadingIcon = null;
            tbTitleActivity.Location = new Point(20, 19);
            tbTitleActivity.Margin = new Padding(3, 3, 26, 3);
            tbTitleActivity.MaxLength = 32767;
            tbTitleActivity.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbTitleActivity.Name = "tbTitleActivity";
            tbTitleActivity.Padding = new Padding(9, 8, 9, 8);
            tbTitleActivity.PasswordChar = '\0';
            tbTitleActivity.PrefixSuffixText = null;
            tbTitleActivity.ReadOnly = false;
            tbTitleActivity.RightToLeft = RightToLeft.No;
            tbTitleActivity.SelectedText = "";
            tbTitleActivity.SelectionLength = 0;
            tbTitleActivity.SelectionStart = 0;
            tbTitleActivity.ShortcutsEnabled = true;
            tbTitleActivity.Size = new Size(912, 48);
            tbTitleActivity.TabIndex = 0;
            tbTitleActivity.TabStop = false;
            tbTitleActivity.TextAlign = HorizontalAlignment.Left;
            tbTitleActivity.TrailingIcon = null;
            tbTitleActivity.UseSystemPasswordChar = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Depth = 0;
            lblUsuario.Dock = DockStyle.Top;
            lblUsuario.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblUsuario.Location = new Point(20, 0);
            lblUsuario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(42, 19);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Titulo";
            // 
            // UCActivityRecordAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mepActivityRecord);
            Name = "UCActivityRecordAdd";
            Size = new Size(1000, 496);
            Load += UCActivityRecordAdd_Load;
            mepActivityRecord.ResumeLayout(false);
            mepActivityRecord.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Controls.NonCollapsibleMaterialExpansionPanel mepActivityRecord;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel8;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit tbObservaciones;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel8;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbTitleActivity;
        private ReaLTaiizor.Controls.MaterialLabel lblUsuario;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel9;
        private ReaLTaiizor.Controls.MaterialComboBox cbStateRecord;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private Panel panel1;
        private ReaLTaiizor.Controls.MaterialComboBox cbFormativeEnvironment;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private Panel panel4;
        private ReaLTaiizor.Controls.MaterialComboBox cbEstado;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
    }
}
