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
            groupBox1 = new GroupBox();
            tlpMain = new TableLayoutPanel();
            panel3 = new Panel();
            tbProductStock = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            panel6 = new Panel();
            tbDescription = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            panel1 = new Panel();
            tbProductUnitPrice = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            panel5 = new Panel();
            tbProductName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            panel4 = new Panel();
            tbProductCode = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblTipo = new ReaLTaiizor.Controls.MaterialLabel();
            mepProductAdd.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            tlpMain.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
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
            mepProductAdd.ExpandHeight = 604;
            mepProductAdd.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            mepProductAdd.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mepProductAdd.Location = new Point(0, 0);
            mepProductAdd.Margin = new Padding(3, 12, 3, 12);
            mepProductAdd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mepProductAdd.Name = "mepProductAdd";
            mepProductAdd.Padding = new Padding(21, 48, 21, 20);
            mepProductAdd.ShowCollapseExpand = false;
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
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(21, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(1110, 486);
            panel2.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tlpMain);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1110, 192);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del producto";
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 4;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpMain.Controls.Add(panel3, 3, 0);
            tlpMain.Controls.Add(panel6, 0, 1);
            tlpMain.Controls.Add(panel1, 2, 0);
            tlpMain.Controls.Add(panel5, 1, 0);
            tlpMain.Controls.Add(panel4, 0, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(3, 19);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 2;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMain.Size = new Size(1104, 170);
            tlpMain.TabIndex = 37;
            // 
            // panel3
            // 
            panel3.Controls.Add(tbProductStock);
            panel3.Controls.Add(materialLabel3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(828, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 0, 20, 0);
            panel3.Size = new Size(276, 85);
            panel3.TabIndex = 49;
            // 
            // tbProductStock
            // 
            tbProductStock.AnimateReadOnly = false;
            tbProductStock.AutoCompleteMode = AutoCompleteMode.None;
            tbProductStock.AutoCompleteSource = AutoCompleteSource.None;
            tbProductStock.BackgroundImageLayout = ImageLayout.None;
            tbProductStock.CharacterCasing = CharacterCasing.Normal;
            tbProductStock.Depth = 0;
            tbProductStock.Dock = DockStyle.Fill;
            tbProductStock.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbProductStock.HideSelection = true;
            tbProductStock.LeadingIcon = null;
            tbProductStock.Location = new Point(20, 19);
            tbProductStock.Margin = new Padding(3, 3, 26, 3);
            tbProductStock.MaxLength = 32767;
            tbProductStock.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbProductStock.Name = "tbProductStock";
            tbProductStock.Padding = new Padding(9, 8, 9, 8);
            tbProductStock.PasswordChar = '\0';
            tbProductStock.PrefixSuffixText = null;
            tbProductStock.ReadOnly = false;
            tbProductStock.RightToLeft = RightToLeft.No;
            tbProductStock.SelectedText = "";
            tbProductStock.SelectionLength = 0;
            tbProductStock.SelectionStart = 0;
            tbProductStock.ShortcutsEnabled = true;
            tbProductStock.Size = new Size(236, 48);
            tbProductStock.TabIndex = 0;
            tbProductStock.TabStop = false;
            tbProductStock.TextAlign = HorizontalAlignment.Left;
            tbProductStock.TrailingIcon = null;
            tbProductStock.UseSystemPasswordChar = false;
            tbProductStock.KeyPress += tbProductStock_KeyPress;
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
            materialLabel3.Size = new Size(41, 19);
            materialLabel3.TabIndex = 4;
            materialLabel3.Text = "Stock";
            // 
            // panel6
            // 
            tlpMain.SetColumnSpan(panel6, 4);
            panel6.Controls.Add(tbDescription);
            panel6.Controls.Add(materialLabel1);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 85);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20, 0, 20, 0);
            panel6.Size = new Size(1104, 85);
            panel6.TabIndex = 48;
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
            tbDescription.Size = new Size(1064, 48);
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
            // panel1
            // 
            panel1.Controls.Add(tbProductUnitPrice);
            panel1.Controls.Add(materialLabel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(552, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 0, 20, 0);
            panel1.Size = new Size(276, 85);
            panel1.TabIndex = 47;
            // 
            // tbProductUnitPrice
            // 
            tbProductUnitPrice.AnimateReadOnly = false;
            tbProductUnitPrice.AutoCompleteMode = AutoCompleteMode.None;
            tbProductUnitPrice.AutoCompleteSource = AutoCompleteSource.None;
            tbProductUnitPrice.BackgroundImageLayout = ImageLayout.None;
            tbProductUnitPrice.CharacterCasing = CharacterCasing.Normal;
            tbProductUnitPrice.Depth = 0;
            tbProductUnitPrice.Dock = DockStyle.Fill;
            tbProductUnitPrice.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbProductUnitPrice.HideSelection = true;
            tbProductUnitPrice.LeadingIcon = null;
            tbProductUnitPrice.Location = new Point(20, 19);
            tbProductUnitPrice.Margin = new Padding(3, 3, 26, 3);
            tbProductUnitPrice.MaxLength = 32767;
            tbProductUnitPrice.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbProductUnitPrice.Name = "tbProductUnitPrice";
            tbProductUnitPrice.Padding = new Padding(9, 8, 9, 8);
            tbProductUnitPrice.PasswordChar = '\0';
            tbProductUnitPrice.PrefixSuffix = ReaLTaiizor.Controls.MaterialTextBoxEdit.PrefixSuffixTypes.Prefix;
            tbProductUnitPrice.PrefixSuffixText = "$";
            tbProductUnitPrice.ReadOnly = false;
            tbProductUnitPrice.RightToLeft = RightToLeft.No;
            tbProductUnitPrice.SelectedText = "";
            tbProductUnitPrice.SelectionLength = 0;
            tbProductUnitPrice.SelectionStart = 0;
            tbProductUnitPrice.ShortcutsEnabled = true;
            tbProductUnitPrice.Size = new Size(236, 48);
            tbProductUnitPrice.TabIndex = 0;
            tbProductUnitPrice.TabStop = false;
            tbProductUnitPrice.TextAlign = HorizontalAlignment.Left;
            tbProductUnitPrice.TrailingIcon = null;
            tbProductUnitPrice.UseSystemPasswordChar = false;
            tbProductUnitPrice.KeyPress += tbProductUnitPrice_KeyPress;
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
            materialLabel2.Size = new Size(104, 19);
            materialLabel2.TabIndex = 4;
            materialLabel2.Text = "Precio Unitario";
            // 
            // panel5
            // 
            panel5.Controls.Add(tbProductName);
            panel5.Controls.Add(materialLabel4);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(276, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(20, 0, 20, 0);
            panel5.Size = new Size(276, 85);
            panel5.TabIndex = 41;
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
            tbProductName.Size = new Size(236, 48);
            tbProductName.TabIndex = 0;
            tbProductName.TabStop = false;
            tbProductName.TextAlign = HorizontalAlignment.Left;
            tbProductName.TrailingIcon = null;
            tbProductName.UseSystemPasswordChar = false;
            tbProductName.KeyPress += tbProductCode_KeyPress;
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
            panel4.Size = new Size(276, 85);
            panel4.TabIndex = 40;
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
            tbProductCode.Size = new Size(236, 48);
            tbProductCode.TabIndex = 0;
            tbProductCode.TabStop = false;
            tbProductCode.TextAlign = HorizontalAlignment.Left;
            tbProductCode.TrailingIcon = null;
            tbProductCode.UseSystemPasswordChar = false;
            tbProductCode.KeyPress += tbProductCode_KeyPress;
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
            groupBox1.ResumeLayout(false);
            tlpMain.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private NonCollapsibleMaterialExpansionPanel mepProductAdd;
        private Panel panel2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit3;
        private GroupBox groupBox1;
        private TableLayoutPanel tlpMain;
        private Panel panel6;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbDescription;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private Panel panel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private Panel panel5;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbProductName;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private Panel panel4;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbProductCode;
        private ReaLTaiizor.Controls.MaterialLabel lblTipo;
        private Panel panel3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbProductStock;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbProductUnitPrice;
    }
}
