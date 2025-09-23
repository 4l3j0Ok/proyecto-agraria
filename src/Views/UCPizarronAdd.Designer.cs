namespace GestionAgraria.Views
{
    partial class UCPizarronAdd
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
            groupBox1 = new GroupBox();
            panel8 = new Panel();
            dataGridView1 = new DataGridView();
            txtObservaciones = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            materialLabel8 = new ReaLTaiizor.Controls.MaterialLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            cbEntorno = new ReaLTaiizor.Controls.MaterialComboBox();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            panel1 = new Panel();
            txtTitulo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            materialExpansionPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // materialExpansionPanel1
            // 
            materialExpansionPanel1.BackColor = Color.FromArgb(255, 255, 255);
            materialExpansionPanel1.CancelButtonText = "CANCELAR";
            materialExpansionPanel1.Controls.Add(groupBox1);
            materialExpansionPanel1.Depth = 0;
            materialExpansionPanel1.Description = "Agregar Procedimientos";
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
            materialExpansionPanel1.TabIndex = 0;
            materialExpansionPanel1.Title = "Procedimeintos ";
            materialExpansionPanel1.ValidationButtonText = "GUARDAR";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel8);
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(24, 50);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1105, 491);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(dataGridView1);
            panel8.Controls.Add(txtObservaciones);
            panel8.Controls.Add(materialLabel8);
            panel8.Location = new Point(5, 91);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(20, 0, 20, 0);
            panel8.Size = new Size(1095, 398);
            panel8.TabIndex = 27;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 72);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1064, 316);
            dataGridView1.TabIndex = 7;
            // 
            // txtObservaciones
            // 
            txtObservaciones.AnimateReadOnly = false;
            txtObservaciones.BackgroundImageLayout = ImageLayout.None;
            txtObservaciones.CharacterCasing = CharacterCasing.Normal;
            txtObservaciones.Depth = 0;
            txtObservaciones.HideSelection = true;
            txtObservaciones.Location = new Point(13, 23);
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
            txtObservaciones.Size = new Size(1064, 43);
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
            tableLayoutPanel1.Location = new Point(5, 17);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1095, 71);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbEntorno);
            panel2.Controls.Add(materialLabel2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(550, 2);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(542, 67);
            panel2.TabIndex = 1;
            // 
            // cbEntorno
            // 
            cbEntorno.AutoResize = false;
            cbEntorno.BackColor = Color.FromArgb(255, 255, 255);
            cbEntorno.Depth = 0;
            cbEntorno.DrawMode = DrawMode.OwnerDrawVariable;
            cbEntorno.DropDownHeight = 174;
            cbEntorno.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEntorno.DropDownWidth = 121;
            cbEntorno.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbEntorno.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbEntorno.FormattingEnabled = true;
            cbEntorno.IntegralHeight = false;
            cbEntorno.ItemHeight = 43;
            cbEntorno.Location = new Point(18, 16);
            cbEntorno.Margin = new Padding(3, 2, 3, 2);
            cbEntorno.MaxDropDownItems = 4;
            cbEntorno.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbEntorno.Name = "cbEntorno";
            cbEntorno.Size = new Size(510, 49);
            cbEntorno.StartIndex = 0;
            cbEntorno.TabIndex = 1;
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
            panel1.Controls.Add(txtTitulo);
            panel1.Controls.Add(materialLabel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(541, 67);
            panel1.TabIndex = 0;
            // 
            // txtTitulo
            // 
            txtTitulo.AnimateReadOnly = false;
            txtTitulo.AutoCompleteMode = AutoCompleteMode.None;
            txtTitulo.AutoCompleteSource = AutoCompleteSource.None;
            txtTitulo.BackgroundImageLayout = ImageLayout.None;
            txtTitulo.CharacterCasing = CharacterCasing.Normal;
            txtTitulo.Depth = 0;
            txtTitulo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTitulo.HideSelection = true;
            txtTitulo.LeadingIcon = null;
            txtTitulo.Location = new Point(10, 16);
            txtTitulo.Margin = new Padding(3, 2, 3, 2);
            txtTitulo.MaxLength = 32767;
            txtTitulo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PasswordChar = '\0';
            txtTitulo.PrefixSuffixText = null;
            txtTitulo.ReadOnly = false;
            txtTitulo.RightToLeft = RightToLeft.No;
            txtTitulo.SelectedText = "";
            txtTitulo.SelectionLength = 0;
            txtTitulo.SelectionStart = 0;
            txtTitulo.ShortcutsEnabled = true;
            txtTitulo.Size = new Size(518, 48);
            txtTitulo.TabIndex = 1;
            txtTitulo.TabStop = false;
            txtTitulo.TextAlign = HorizontalAlignment.Left;
            txtTitulo.TrailingIcon = null;
            txtTitulo.UseSystemPasswordChar = false;
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
            // UCPizarronAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialExpansionPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCPizarronAdd";
            Size = new Size(1152, 604);
            materialExpansionPanel1.ResumeLayout(false);
            materialExpansionPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialExpansionPanel materialExpansionPanel1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel8;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel8;
        private Panel panel1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit txtObservaciones;
        private Panel panel2;
        private ReaLTaiizor.Controls.MaterialComboBox cbEntorno;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTitulo;
        private DataGridView dataGridView1;
    }
}
