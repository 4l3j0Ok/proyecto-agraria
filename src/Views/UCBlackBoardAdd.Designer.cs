namespace GestionAgraria.Views
{
    partial class UCBlackBoardAdd
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
            mepBlackBoard = new ReaLTaiizor.Controls.MaterialExpansionPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            dgvData = new DataGridView();
            panel8 = new Panel();
            txtObservaciones = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            materialLabel8 = new ReaLTaiizor.Controls.MaterialLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            cbFormativeEnvironment = new ReaLTaiizor.Controls.MaterialComboBox();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            panel1 = new Panel();
            tbTitle = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            mepBlackBoard.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            panel8.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // mepBlackBoard
            // 
            mepBlackBoard.AutoScroll = true;
            mepBlackBoard.AutoSize = true;
            mepBlackBoard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mepBlackBoard.BackColor = Color.FromArgb(255, 255, 255);
            mepBlackBoard.CancelButtonText = "CANCELAR";
            mepBlackBoard.Controls.Add(tableLayoutPanel2);
            mepBlackBoard.Depth = 0;
            mepBlackBoard.Description = "Crea notas personalizadas con tablas incluídas";
            mepBlackBoard.Dock = DockStyle.Top;
            mepBlackBoard.ExpandHeight = 572;
            mepBlackBoard.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            mepBlackBoard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mepBlackBoard.Location = new Point(0, 0);
            mepBlackBoard.Margin = new Padding(3, 12, 3, 12);
            mepBlackBoard.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mepBlackBoard.Name = "mepBlackBoard";
            mepBlackBoard.Padding = new Padding(21, 48, 21, 12);
            mepBlackBoard.Size = new Size(889, 572);
            mepBlackBoard.TabIndex = 0;
            mepBlackBoard.Title = "Pizarrón";
            mepBlackBoard.ValidationButtonEnable = true;
            mepBlackBoard.ValidationButtonText = "GUARDAR";
            mepBlackBoard.SaveClick += mepBlackBoard_SaveClick;
            mepBlackBoard.CancelClick += mepBlackBoard_CancelClick;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(dgvData, 0, 2);
            tableLayoutPanel2.Controls.Add(panel8, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(21, 48);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(847, 512);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // dgvData
            // 
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.ColumnHeadersVisible = false;
            dgvData.Dock = DockStyle.Top;
            dgvData.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvData.Location = new Point(3, 140);
            dgvData.Name = "dgvData";
            dgvData.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvData.Size = new Size(841, 281);
            dgvData.TabIndex = 30;
            // 
            // panel8
            // 
            panel8.AutoSize = true;
            panel8.Controls.Add(txtObservaciones);
            panel8.Controls.Add(materialLabel8);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 75);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(20, 0, 20, 0);
            panel8.Size = new Size(847, 62);
            panel8.TabIndex = 29;
            // 
            // txtObservaciones
            // 
            txtObservaciones.AnimateReadOnly = false;
            txtObservaciones.BackgroundImageLayout = ImageLayout.None;
            txtObservaciones.CharacterCasing = CharacterCasing.Normal;
            txtObservaciones.Depth = 0;
            txtObservaciones.Dock = DockStyle.Top;
            txtObservaciones.HideSelection = true;
            txtObservaciones.Location = new Point(20, 19);
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
            txtObservaciones.Size = new Size(807, 43);
            txtObservaciones.TabIndex = 6;
            txtObservaciones.TabStop = false;
            txtObservaciones.TextAlign = HorizontalAlignment.Left;
            txtObservaciones.UseSystemPasswordChar = false;
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
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 2);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(841, 71);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbFormativeEnvironment);
            panel2.Controls.Add(materialLabel2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(423, 2);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(415, 67);
            panel2.TabIndex = 1;
            // 
            // cbFormativeEnvironment
            // 
            cbFormativeEnvironment.AutoResize = false;
            cbFormativeEnvironment.BackColor = Color.FromArgb(255, 255, 255);
            cbFormativeEnvironment.Depth = 0;
            cbFormativeEnvironment.DrawMode = DrawMode.OwnerDrawVariable;
            cbFormativeEnvironment.DropDownHeight = 174;
            cbFormativeEnvironment.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFormativeEnvironment.DropDownWidth = 121;
            cbFormativeEnvironment.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbFormativeEnvironment.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbFormativeEnvironment.FormattingEnabled = true;
            cbFormativeEnvironment.IntegralHeight = false;
            cbFormativeEnvironment.ItemHeight = 43;
            cbFormativeEnvironment.Location = new Point(3, 18);
            cbFormativeEnvironment.Margin = new Padding(3, 2, 3, 2);
            cbFormativeEnvironment.MaxDropDownItems = 4;
            cbFormativeEnvironment.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbFormativeEnvironment.Name = "cbFormativeEnvironment";
            cbFormativeEnvironment.Size = new Size(420, 49);
            cbFormativeEnvironment.StartIndex = 0;
            cbFormativeEnvironment.TabIndex = 1;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(18, 0);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(56, 19);
            materialLabel2.TabIndex = 0;
            materialLabel2.Text = "Entorno";
            // 
            // panel1
            // 
            panel1.Controls.Add(tbTitle);
            panel1.Controls.Add(materialLabel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 67);
            panel1.TabIndex = 0;
            // 
            // tbTitle
            // 
            tbTitle.AnimateReadOnly = false;
            tbTitle.AutoCompleteMode = AutoCompleteMode.None;
            tbTitle.AutoCompleteSource = AutoCompleteSource.None;
            tbTitle.BackgroundImageLayout = ImageLayout.None;
            tbTitle.CharacterCasing = CharacterCasing.Normal;
            tbTitle.Depth = 0;
            tbTitle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbTitle.HideSelection = true;
            tbTitle.LeadingIcon = null;
            tbTitle.Location = new Point(10, 16);
            tbTitle.Margin = new Padding(3, 2, 3, 2);
            tbTitle.MaxLength = 32767;
            tbTitle.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbTitle.Name = "tbTitle";
            tbTitle.PasswordChar = '\0';
            tbTitle.PrefixSuffixText = null;
            tbTitle.ReadOnly = false;
            tbTitle.RightToLeft = RightToLeft.No;
            tbTitle.SelectedText = "";
            tbTitle.SelectionLength = 0;
            tbTitle.SelectionStart = 0;
            tbTitle.ShortcutsEnabled = true;
            tbTitle.Size = new Size(410, 48);
            tbTitle.TabIndex = 1;
            tbTitle.TabStop = false;
            tbTitle.TextAlign = HorizontalAlignment.Left;
            tbTitle.TrailingIcon = null;
            tbTitle.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(18, 0);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(42, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Titulo";
            // 
            // UCBlackBoardAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(mepBlackBoard);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCBlackBoardAdd";
            Size = new Size(889, 548);
            Load += UCBlackBoardAdd_Load;
            mepBlackBoard.ResumeLayout(false);
            mepBlackBoard.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialExpansionPanel mepBlackBoard;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dgvData;
        private Panel panel8;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit txtObservaciones;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel8;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private ReaLTaiizor.Controls.MaterialComboBox cbFormativeEnvironment;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private Panel panel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbTitle;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
    }
}
