namespace GestionAgraria.Views
{
    partial class UCCargaProductosAdd
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
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel6 = new Panel();
            materialTextBoxEdit1 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel5 = new Panel();
            cbbCantidad = new ReaLTaiizor.Controls.MaterialComboBox();
            lblCantidad = new ReaLTaiizor.Controls.MaterialLabel();
            panel4 = new Panel();
            txtTipo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblTipo = new ReaLTaiizor.Controls.MaterialLabel();
            panel1 = new Panel();
            cbbEntorno = new ReaLTaiizor.Controls.MaterialComboBox();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            materialExpansionPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // materialExpansionPanel1
            // 
            materialExpansionPanel1.BackColor = Color.FromArgb(255, 255, 255);
            materialExpansionPanel1.CancelButtonText = "CANCELAR";
            materialExpansionPanel1.Controls.Add(panel2);
            materialExpansionPanel1.Depth = 0;
            materialExpansionPanel1.Description = "Registrar un Nuevo Producto";
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
            materialExpansionPanel1.Title = "Cargar Nuevo Producto ";
            materialExpansionPanel1.ValidationButtonText = "GUARDAR";
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(tableLayoutPanel5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(21, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(1110, 544);
            panel2.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel6, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 84);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1110, 81);
            tableLayoutPanel1.TabIndex = 34;
            // 
            // panel6
            // 
            panel6.Controls.Add(materialTextBoxEdit1);
            panel6.Controls.Add(materialLabel1);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20, 0, 20, 0);
            panel6.Size = new Size(1110, 81);
            panel6.TabIndex = 25;
            // 
            // materialTextBoxEdit1
            // 
            materialTextBoxEdit1.AnimateReadOnly = false;
            materialTextBoxEdit1.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit1.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit1.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit1.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit1.Depth = 0;
            materialTextBoxEdit1.Dock = DockStyle.Fill;
            materialTextBoxEdit1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxEdit1.HideSelection = true;
            materialTextBoxEdit1.LeadingIcon = null;
            materialTextBoxEdit1.Location = new Point(20, 19);
            materialTextBoxEdit1.Margin = new Padding(3, 3, 26, 3);
            materialTextBoxEdit1.MaxLength = 32767;
            materialTextBoxEdit1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEdit1.Name = "materialTextBoxEdit1";
            materialTextBoxEdit1.Padding = new Padding(9, 8, 9, 8);
            materialTextBoxEdit1.PasswordChar = '\0';
            materialTextBoxEdit1.PrefixSuffixText = null;
            materialTextBoxEdit1.ReadOnly = false;
            materialTextBoxEdit1.RightToLeft = RightToLeft.No;
            materialTextBoxEdit1.SelectedText = "";
            materialTextBoxEdit1.SelectionLength = 0;
            materialTextBoxEdit1.SelectionStart = 0;
            materialTextBoxEdit1.ShortcutsEnabled = true;
            materialTextBoxEdit1.Size = new Size(1070, 48);
            materialTextBoxEdit1.TabIndex = 0;
            materialTextBoxEdit1.TabStop = false;
            materialTextBoxEdit1.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit1.TrailingIcon = null;
            materialTextBoxEdit1.UseSystemPasswordChar = false;
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
            materialLabel1.Size = new Size(84, 19);
            materialLabel1.TabIndex = 4;
            materialLabel1.Text = "Descripción";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.Controls.Add(panel5, 1, 0);
            tableLayoutPanel5.Controls.Add(panel4, 0, 0);
            tableLayoutPanel5.Controls.Add(panel1, 2, 0);
            tableLayoutPanel5.Dock = DockStyle.Top;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.Size = new Size(1110, 84);
            tableLayoutPanel5.TabIndex = 33;
            // 
            // panel5
            // 
            panel5.Controls.Add(cbbCantidad);
            panel5.Controls.Add(lblCantidad);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(370, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(20, 0, 20, 0);
            panel5.Size = new Size(370, 84);
            panel5.TabIndex = 40;
            // 
            // cbbCantidad
            // 
            cbbCantidad.AutoResize = false;
            cbbCantidad.BackColor = Color.FromArgb(255, 255, 255);
            cbbCantidad.Depth = 0;
            cbbCantidad.Dock = DockStyle.Top;
            cbbCantidad.DrawMode = DrawMode.OwnerDrawVariable;
            cbbCantidad.DropDownHeight = 174;
            cbbCantidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCantidad.DropDownWidth = 121;
            cbbCantidad.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbbCantidad.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbbCantidad.FormattingEnabled = true;
            cbbCantidad.IntegralHeight = false;
            cbbCantidad.ItemHeight = 43;
            cbbCantidad.Location = new Point(20, 19);
            cbbCantidad.MaxDropDownItems = 4;
            cbbCantidad.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbbCantidad.Name = "cbbCantidad";
            cbbCantidad.Size = new Size(330, 49);
            cbbCantidad.StartIndex = 0;
            cbbCantidad.TabIndex = 11;
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
            // panel4
            // 
            panel4.Controls.Add(txtTipo);
            panel4.Controls.Add(lblTipo);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20, 0, 20, 0);
            panel4.Size = new Size(370, 84);
            panel4.TabIndex = 39;
            // 
            // txtTipo
            // 
            txtTipo.AnimateReadOnly = false;
            txtTipo.AutoCompleteMode = AutoCompleteMode.None;
            txtTipo.AutoCompleteSource = AutoCompleteSource.None;
            txtTipo.BackgroundImageLayout = ImageLayout.None;
            txtTipo.CharacterCasing = CharacterCasing.Normal;
            txtTipo.Depth = 0;
            txtTipo.Dock = DockStyle.Fill;
            txtTipo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTipo.HideSelection = true;
            txtTipo.LeadingIcon = null;
            txtTipo.Location = new Point(20, 19);
            txtTipo.Margin = new Padding(3, 3, 26, 3);
            txtTipo.MaxLength = 32767;
            txtTipo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTipo.Name = "txtTipo";
            txtTipo.Padding = new Padding(9, 8, 9, 8);
            txtTipo.PasswordChar = '\0';
            txtTipo.PrefixSuffixText = null;
            txtTipo.ReadOnly = false;
            txtTipo.RightToLeft = RightToLeft.No;
            txtTipo.SelectedText = "";
            txtTipo.SelectionLength = 0;
            txtTipo.SelectionStart = 0;
            txtTipo.ShortcutsEnabled = true;
            txtTipo.Size = new Size(330, 48);
            txtTipo.TabIndex = 0;
            txtTipo.TabStop = false;
            txtTipo.TextAlign = HorizontalAlignment.Left;
            txtTipo.TrailingIcon = null;
            txtTipo.UseSystemPasswordChar = false;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Depth = 0;
            lblTipo.Dock = DockStyle.Top;
            lblTipo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTipo.Location = new Point(20, 0);
            lblTipo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(33, 19);
            lblTipo.TabIndex = 4;
            lblTipo.Text = "Tipo";
            // 
            // panel1
            // 
            panel1.Controls.Add(cbbEntorno);
            panel1.Controls.Add(materialLabel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(740, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 0, 20, 0);
            panel1.Size = new Size(370, 84);
            panel1.TabIndex = 32;
            // 
            // cbbEntorno
            // 
            cbbEntorno.AutoResize = false;
            cbbEntorno.BackColor = Color.FromArgb(255, 255, 255);
            cbbEntorno.Depth = 0;
            cbbEntorno.Dock = DockStyle.Top;
            cbbEntorno.DrawMode = DrawMode.OwnerDrawVariable;
            cbbEntorno.DropDownHeight = 174;
            cbbEntorno.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbEntorno.DropDownWidth = 121;
            cbbEntorno.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbbEntorno.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbbEntorno.FormattingEnabled = true;
            cbbEntorno.IntegralHeight = false;
            cbbEntorno.ItemHeight = 43;
            cbbEntorno.Location = new Point(20, 19);
            cbbEntorno.MaxDropDownItems = 4;
            cbbEntorno.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbbEntorno.Name = "cbbEntorno";
            cbbEntorno.Size = new Size(330, 49);
            cbbEntorno.StartIndex = 0;
            cbbEntorno.TabIndex = 10;
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
            materialLabel2.Size = new Size(89, 19);
            materialLabel2.TabIndex = 4;
            materialLabel2.Text = "Relacionado";
            // 
            // UCCargaProductosAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialExpansionPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCCargaProductosAdd";
            Size = new Size(1152, 604);
            materialExpansionPanel1.ResumeLayout(false);
            materialExpansionPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialExpansionPanel materialExpansionPanel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel6;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel1;
        private ReaLTaiizor.Controls.MaterialComboBox cbbEntorno;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private Panel panel5;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit3;
        private ReaLTaiizor.Controls.MaterialLabel lblCantidad;
        private Panel panel4;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTipo;
        private ReaLTaiizor.Controls.MaterialLabel lblTipo;
        private ReaLTaiizor.Controls.MaterialComboBox cbbCantidad;
    }
}
