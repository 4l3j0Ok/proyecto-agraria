using GestionAgraria.Controls;


namespace GestionAgraria.Views
{
    partial class UCProductAdd
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
            mepProductAdd = new NonCollapsibleMaterialExpansionPanel();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel6 = new Panel();
            tbDescription = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            panel3 = new Panel();
            cbProductStock = new ReaLTaiizor.Controls.MaterialComboBox();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel5 = new Panel();
            tbProductName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            panel4 = new Panel();
            tbProductCode = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblTipo = new ReaLTaiizor.Controls.MaterialLabel();
            panel1 = new Panel();
            cbProductFormativeEnvironment = new ReaLTaiizor.Controls.MaterialComboBox();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            mepProductAdd.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // mepProductAdd
            // 
            mepProductAdd.BackColor = Color.FromArgb(255, 255, 255);
            mepProductAdd.CancelButtonText = "CANCELAR";
            mepProductAdd.Controls.Add(panel2);
            mepProductAdd.Depth = 0;
            mepProductAdd.Description = "Registrar un Nuevo Producto";
            mepProductAdd.Dock = DockStyle.Fill;
            mepProductAdd.ExpandHeight = 0;
            mepProductAdd.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            mepProductAdd.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mepProductAdd.Location = new Point(0, 0);
            mepProductAdd.Margin = new Padding(3, 12, 3, 12);
            mepProductAdd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mepProductAdd.Name = "mepProductAdd";
            mepProductAdd.Padding = new Padding(21, 48, 21, 20);
            mepProductAdd.Size = new Size(1152, 604);
            mepProductAdd.TabIndex = 0;
            mepProductAdd.Title = "Cargar Nuevo Producto ";
            mepProductAdd.ValidationButtonEnable = true;
            mepProductAdd.ValidationButtonText = "GUARDAR";
            mepProductAdd.SaveClick += mepProductAdd_SaveClick;
            mepProductAdd.CancelClick += mepProductAdd_cancelClick;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(tableLayoutPanel5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(21, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(1110, 536);
            panel2.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Controls.Add(panel6, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
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
            panel6.Controls.Add(tbDescription);
            panel6.Controls.Add(materialLabel1);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(277, 0);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20, 0, 20, 0);
            panel6.Size = new Size(833, 81);
            panel6.TabIndex = 25;
            // 
            // tbDescription
            // 
            tbDescription.AnimateReadOnly = false;
            tbDescription.AutoCompleteMode = AutoCompleteMode.None;
            tbDescription.AutoCompleteSource = AutoCompleteSource.None;
            tbDescription.BackgroundImageLayout = ImageLayout.None;
            tbDescription.CharacterCasing = CharacterCasing.Normal;
            tbDescription.Depth = 0;
            tbDescription.Dock = DockStyle.Fill;
            tbDescription.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbDescription.HideSelection = true;
            tbDescription.LeadingIcon = null;
            tbDescription.Location = new Point(20, 19);
            tbDescription.Margin = new Padding(3, 3, 26, 3);
            tbDescription.MaxLength = 32767;
            tbDescription.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbDescription.Name = "tbDescription";
            tbDescription.Padding = new Padding(9, 8, 9, 8);
            tbDescription.PasswordChar = '\0';
            tbDescription.PrefixSuffixText = null;
            tbDescription.ReadOnly = false;
            tbDescription.RightToLeft = RightToLeft.No;
            tbDescription.SelectedText = "";
            tbDescription.SelectionLength = 0;
            tbDescription.SelectionStart = 0;
            tbDescription.ShortcutsEnabled = true;
            tbDescription.Size = new Size(793, 48);
            tbDescription.TabIndex = 0;
            tbDescription.TabStop = false;
            tbDescription.TextAlign = HorizontalAlignment.Left;
            tbDescription.TrailingIcon = null;
            tbDescription.UseSystemPasswordChar = false;
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
            // panel3
            // 
            panel3.Controls.Add(cbProductStock);
            panel3.Controls.Add(materialLabel3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 0, 20, 0);
            panel3.Size = new Size(277, 81);
            panel3.TabIndex = 42;
            // 
            // cbProductStock
            // 
            cbProductStock.AutoResize = false;
            cbProductStock.BackColor = Color.FromArgb(255, 255, 255);
            cbProductStock.Depth = 0;
            cbProductStock.Dock = DockStyle.Top;
            cbProductStock.DrawMode = DrawMode.OwnerDrawVariable;
            cbProductStock.DropDownHeight = 174;
            cbProductStock.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProductStock.DropDownWidth = 121;
            cbProductStock.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbProductStock.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbProductStock.FormattingEnabled = true;
            cbProductStock.IntegralHeight = false;
            cbProductStock.ItemHeight = 43;
            cbProductStock.Items.AddRange(new object[] { "1", "2", "3" });
            cbProductStock.Location = new Point(20, 19);
            cbProductStock.MaxDropDownItems = 4;
            cbProductStock.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbProductStock.Name = "cbProductStock";
            cbProductStock.Size = new Size(237, 49);
            cbProductStock.StartIndex = 0;
            cbProductStock.TabIndex = 11;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Dock = DockStyle.Top;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(20, 0);
            materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(65, 19);
            materialLabel3.TabIndex = 4;
            materialLabel3.Text = "Cantidad";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.Controls.Add(panel5, 0, 0);
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
            panel5.Controls.Add(tbProductName);
            panel5.Controls.Add(materialLabel4);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(370, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(20, 0, 20, 0);
            panel5.Size = new Size(370, 84);
            panel5.TabIndex = 40;
            // 
            // tbProductName
            // 
            tbProductName.AnimateReadOnly = false;
            tbProductName.AutoCompleteMode = AutoCompleteMode.None;
            tbProductName.AutoCompleteSource = AutoCompleteSource.None;
            tbProductName.BackgroundImageLayout = ImageLayout.None;
            tbProductName.CharacterCasing = CharacterCasing.Normal;
            tbProductName.Depth = 0;
            tbProductName.Dock = DockStyle.Fill;
            tbProductName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbProductName.HideSelection = true;
            tbProductName.LeadingIcon = null;
            tbProductName.Location = new Point(20, 19);
            tbProductName.Margin = new Padding(3, 3, 26, 3);
            tbProductName.MaxLength = 32767;
            tbProductName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbProductName.Name = "tbProductName";
            tbProductName.Padding = new Padding(9, 8, 9, 8);
            tbProductName.PasswordChar = '\0';
            tbProductName.PrefixSuffixText = null;
            tbProductName.ReadOnly = false;
            tbProductName.RightToLeft = RightToLeft.No;
            tbProductName.SelectedText = "";
            tbProductName.SelectionLength = 0;
            tbProductName.SelectionStart = 0;
            tbProductName.ShortcutsEnabled = true;
            tbProductName.Size = new Size(330, 48);
            tbProductName.TabIndex = 0;
            tbProductName.TabStop = false;
            tbProductName.TextAlign = HorizontalAlignment.Left;
            tbProductName.TrailingIcon = null;
            tbProductName.UseSystemPasswordChar = false;
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
            materialLabel4.Size = new Size(57, 19);
            materialLabel4.TabIndex = 4;
            materialLabel4.Text = "Nombre";
            // 
            // panel4
            // 
            panel4.Controls.Add(tbProductCode);
            panel4.Controls.Add(lblTipo);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20, 0, 20, 0);
            panel4.Size = new Size(370, 84);
            panel4.TabIndex = 39;
            // 
            // tbProductCode
            // 
            tbProductCode.AnimateReadOnly = false;
            tbProductCode.AutoCompleteMode = AutoCompleteMode.None;
            tbProductCode.AutoCompleteSource = AutoCompleteSource.None;
            tbProductCode.BackgroundImageLayout = ImageLayout.None;
            tbProductCode.CharacterCasing = CharacterCasing.Normal;
            tbProductCode.Depth = 0;
            tbProductCode.Dock = DockStyle.Fill;
            tbProductCode.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbProductCode.HideSelection = true;
            tbProductCode.LeadingIcon = null;
            tbProductCode.Location = new Point(20, 19);
            tbProductCode.Margin = new Padding(3, 3, 26, 3);
            tbProductCode.MaxLength = 32767;
            tbProductCode.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbProductCode.Name = "tbProductCode";
            tbProductCode.Padding = new Padding(9, 8, 9, 8);
            tbProductCode.PasswordChar = '\0';
            tbProductCode.PrefixSuffixText = null;
            tbProductCode.ReadOnly = false;
            tbProductCode.RightToLeft = RightToLeft.No;
            tbProductCode.SelectedText = "";
            tbProductCode.SelectionLength = 0;
            tbProductCode.SelectionStart = 0;
            tbProductCode.ShortcutsEnabled = true;
            tbProductCode.Size = new Size(330, 48);
            tbProductCode.TabIndex = 0;
            tbProductCode.TabStop = false;
            tbProductCode.TextAlign = HorizontalAlignment.Left;
            tbProductCode.TrailingIcon = null;
            tbProductCode.UseSystemPasswordChar = false;
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
            lblTipo.Size = new Size(101, 19);
            lblTipo.TabIndex = 4;
            lblTipo.Text = "Cod. Producto";
            // 
            // panel1
            // 
            panel1.Controls.Add(cbProductFormativeEnvironment);
            panel1.Controls.Add(materialLabel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(740, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 0, 20, 0);
            panel1.Size = new Size(370, 84);
            panel1.TabIndex = 32;
            // 
            // cbProductFormativeEnvironment
            // 
            cbProductFormativeEnvironment.AutoResize = false;
            cbProductFormativeEnvironment.BackColor = Color.FromArgb(255, 255, 255);
            cbProductFormativeEnvironment.Depth = 0;
            cbProductFormativeEnvironment.Dock = DockStyle.Top;
            cbProductFormativeEnvironment.DrawMode = DrawMode.OwnerDrawVariable;
            cbProductFormativeEnvironment.DropDownHeight = 174;
            cbProductFormativeEnvironment.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProductFormativeEnvironment.DropDownWidth = 121;
            cbProductFormativeEnvironment.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbProductFormativeEnvironment.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbProductFormativeEnvironment.FormattingEnabled = true;
            cbProductFormativeEnvironment.IntegralHeight = false;
            cbProductFormativeEnvironment.ItemHeight = 43;
            cbProductFormativeEnvironment.Location = new Point(20, 19);
            cbProductFormativeEnvironment.MaxDropDownItems = 4;
            cbProductFormativeEnvironment.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbProductFormativeEnvironment.Name = "cbProductFormativeEnvironment";
            cbProductFormativeEnvironment.Size = new Size(330, 49);
            cbProductFormativeEnvironment.StartIndex = 0;
            cbProductFormativeEnvironment.TabIndex = 10;
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
            materialLabel2.Size = new Size(154, 19);
            materialLabel2.TabIndex = 4;
            materialLabel2.Text = "Entorno perteneciente";
            // 
            // UCProductAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mepProductAdd);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCProductAdd";
            Size = new Size(1152, 604);
            mepProductAdd.ResumeLayout(false);
            mepProductAdd.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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

        private NonCollapsibleMaterialExpansionPanel mepProductAdd;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel6;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbDescription;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel1;
        private ReaLTaiizor.Controls.MaterialComboBox cbProductFormativeEnvironment;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit3;
        private Panel panel3;
        private ReaLTaiizor.Controls.MaterialComboBox cbProductStock;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private Panel panel5;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbProductName;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private Panel panel4;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbProductCode;
        private ReaLTaiizor.Controls.MaterialLabel lblTipo;
    }
}
