using GestionAgraria.Controls;


namespace GestionAgraria.Views
{
    partial class UCSellAdd
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
            mepSellsAdd = new NonCollapsibleMaterialExpansionPanel();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel10 = new Panel();
            tbSellsObservations = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            panel7 = new Panel();
            tbTotal = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblSubTotal = new ReaLTaiizor.Controls.MaterialLabel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnProductAddList = new ReaLTaiizor.Controls.MaterialButton();
            dgvProductList = new DataGridView();
            CodeProduct = new DataGridViewTextBoxColumn();
            NameProduct = new DataGridViewTextBoxColumn();
            Quatity = new DataGridViewTextBoxColumn();
            PriceProduct = new DataGridViewTextBoxColumn();
            PriceTotal = new DataGridViewTextBoxColumn();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel5 = new Panel();
            tbPrecio = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            panel4 = new Panel();
            tbQuatity = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            panel3 = new Panel();
            cbNameProduct = new ReaLTaiizor.Controls.MaterialComboBox();
            lblNombreProducto = new ReaLTaiizor.Controls.MaterialLabel();
            panel8 = new Panel();
            cbCodeProduc = new ReaLTaiizor.Controls.MaterialComboBox();
            lblCodigoProducto = new ReaLTaiizor.Controls.MaterialLabel();
            mepSellsAdd.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel10.SuspendLayout();
            panel7.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // mepSellsAdd
            // 
            mepSellsAdd.BackColor = Color.FromArgb(255, 255, 255);
            mepSellsAdd.CancelButtonText = "CANCELAR";
            mepSellsAdd.Controls.Add(panel2);
            mepSellsAdd.Depth = 0;
            mepSellsAdd.Description = "Registrar un Nueva Venta";
            mepSellsAdd.Dock = DockStyle.Fill;
            mepSellsAdd.ExpandHeight = 616;
            mepSellsAdd.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            mepSellsAdd.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mepSellsAdd.Location = new Point(0, 0);
            mepSellsAdd.Margin = new Padding(3, 12, 3, 12);
            mepSellsAdd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mepSellsAdd.Name = "mepSellsAdd";
            mepSellsAdd.Padding = new Padding(21, 48, 21, 20);
            mepSellsAdd.ShowCollapseExpand = false;
            mepSellsAdd.Size = new Size(1152, 616);
            mepSellsAdd.TabIndex = 3;
            mepSellsAdd.Title = "Ventas";
            mepSellsAdd.ValidationButtonEnable = true;
            mepSellsAdd.ValidationButtonText = "GUARDAR";
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Controls.Add(tableLayoutPanel5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(21, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(1110, 548);
            panel2.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.77778F));
            tableLayoutPanel1.Controls.Add(panel10, 1, 0);
            tableLayoutPanel1.Controls.Add(panel7, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 415);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1110, 83);
            tableLayoutPanel1.TabIndex = 37;
            // 
            // panel10
            // 
            panel10.Controls.Add(tbSellsObservations);
            panel10.Controls.Add(materialLabel3);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(246, 0);
            panel10.Margin = new Padding(0);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(20, 0, 20, 0);
            panel10.Size = new Size(864, 83);
            panel10.TabIndex = 22;
            // 
            // tbSellsObservations
            // 
            tbSellsObservations.AnimateReadOnly = false;
            tbSellsObservations.AutoCompleteMode = AutoCompleteMode.None;
            tbSellsObservations.AutoCompleteSource = AutoCompleteSource.None;
            tbSellsObservations.BackgroundImageLayout = ImageLayout.None;
            tbSellsObservations.CharacterCasing = CharacterCasing.Normal;
            tbSellsObservations.Depth = 0;
            tbSellsObservations.Dock = DockStyle.Fill;
            tbSellsObservations.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbSellsObservations.HideSelection = true;
            tbSellsObservations.LeadingIcon = null;
            tbSellsObservations.Location = new Point(20, 19);
            tbSellsObservations.Margin = new Padding(3, 3, 26, 3);
            tbSellsObservations.MaxLength = 32767;
            tbSellsObservations.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbSellsObservations.Name = "tbSellsObservations";
            tbSellsObservations.Padding = new Padding(9, 8, 9, 8);
            tbSellsObservations.PasswordChar = '\0';
            tbSellsObservations.PrefixSuffixText = null;
            tbSellsObservations.ReadOnly = false;
            tbSellsObservations.RightToLeft = RightToLeft.No;
            tbSellsObservations.SelectedText = "";
            tbSellsObservations.SelectionLength = 0;
            tbSellsObservations.SelectionStart = 0;
            tbSellsObservations.ShortcutsEnabled = true;
            tbSellsObservations.Size = new Size(824, 48);
            tbSellsObservations.TabIndex = 0;
            tbSellsObservations.TabStop = false;
            tbSellsObservations.TextAlign = HorizontalAlignment.Left;
            tbSellsObservations.TrailingIcon = null;
            tbSellsObservations.UseSystemPasswordChar = false;
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
            materialLabel3.Size = new Size(84, 19);
            materialLabel3.TabIndex = 4;
            materialLabel3.Text = "Descripcion";
            // 
            // panel7
            // 
            panel7.Controls.Add(tbTotal);
            panel7.Controls.Add(lblSubTotal);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(20, 0, 20, 0);
            panel7.Size = new Size(246, 83);
            panel7.TabIndex = 21;
            // 
            // tbTotal
            // 
            tbTotal.AnimateReadOnly = false;
            tbTotal.AutoCompleteMode = AutoCompleteMode.None;
            tbTotal.AutoCompleteSource = AutoCompleteSource.None;
            tbTotal.BackgroundImageLayout = ImageLayout.None;
            tbTotal.CharacterCasing = CharacterCasing.Normal;
            tbTotal.Depth = 0;
            tbTotal.Dock = DockStyle.Fill;
            tbTotal.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbTotal.HideSelection = true;
            tbTotal.LeadingIcon = null;
            tbTotal.Location = new Point(20, 19);
            tbTotal.Margin = new Padding(3, 3, 26, 3);
            tbTotal.MaxLength = 32767;
            tbTotal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbTotal.Name = "tbTotal";
            tbTotal.Padding = new Padding(9, 8, 9, 8);
            tbTotal.PasswordChar = '\0';
            tbTotal.PrefixSuffixText = null;
            tbTotal.ReadOnly = false;
            tbTotal.RightToLeft = RightToLeft.No;
            tbTotal.SelectedText = "";
            tbTotal.SelectionLength = 0;
            tbTotal.SelectionStart = 0;
            tbTotal.ShortcutsEnabled = true;
            tbTotal.Size = new Size(206, 48);
            tbTotal.TabIndex = 0;
            tbTotal.TabStop = false;
            tbTotal.TextAlign = HorizontalAlignment.Left;
            tbTotal.TrailingIcon = null;
            tbTotal.UseSystemPasswordChar = false;
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Depth = 0;
            lblSubTotal.Dock = DockStyle.Top;
            lblSubTotal.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSubTotal.Location = new Point(20, 0);
            lblSubTotal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(38, 19);
            lblSubTotal.TabIndex = 4;
            lblSubTotal.Text = "Total";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(btnProductAddList, 0, 0);
            tableLayoutPanel2.Controls.Add(dgvProductList, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 156);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(20, 3, 20, 3);
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1110, 259);
            tableLayoutPanel2.TabIndex = 36;
            // 
            // btnProductAddList
            // 
            btnProductAddList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnProductAddList.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnProductAddList.Depth = 0;
            btnProductAddList.Dock = DockStyle.Top;
            btnProductAddList.HighEmphasis = true;
            btnProductAddList.Icon = null;
            btnProductAddList.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnProductAddList.Location = new Point(24, 7);
            btnProductAddList.Margin = new Padding(4);
            btnProductAddList.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnProductAddList.Name = "btnProductAddList";
            btnProductAddList.NoAccentTextColor = Color.Empty;
            btnProductAddList.Size = new Size(1062, 36);
            btnProductAddList.TabIndex = 36;
            btnProductAddList.Text = "AGREGAR";
            btnProductAddList.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnProductAddList.UseAccentColor = false;
            btnProductAddList.UseVisualStyleBackColor = true;
            // 
            // dgvProductList
            // 
            dgvProductList.AllowUserToAddRows = false;
            dgvProductList.AllowUserToDeleteRows = false;
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Columns.AddRange(new DataGridViewColumn[] { CodeProduct, NameProduct, Quatity, PriceProduct, PriceTotal });
            dgvProductList.Dock = DockStyle.Fill;
            dgvProductList.Location = new Point(23, 50);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.ReadOnly = true;
            dgvProductList.Size = new Size(1064, 183);
            dgvProductList.TabIndex = 37;
            // 
            // CodeProduct
            // 
            CodeProduct.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CodeProduct.HeaderText = "Cod. Producto";
            CodeProduct.Name = "CodeProduct";
            CodeProduct.ReadOnly = true;
            // 
            // NameProduct
            // 
            NameProduct.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NameProduct.HeaderText = "Nombre del producto";
            NameProduct.Name = "NameProduct";
            NameProduct.ReadOnly = true;
            // 
            // Quatity
            // 
            Quatity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Quatity.HeaderText = "Cantidad";
            Quatity.Name = "Quatity";
            Quatity.ReadOnly = true;
            // 
            // PriceProduct
            // 
            PriceProduct.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PriceProduct.HeaderText = "SubTotal";
            PriceProduct.Name = "PriceProduct";
            PriceProduct.ReadOnly = true;
            // 
            // PriceTotal
            // 
            PriceTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PriceTotal.HeaderText = "Total";
            PriceTotal.Name = "PriceTotal";
            PriceTotal.ReadOnly = true;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(panel5, 1, 1);
            tableLayoutPanel5.Controls.Add(panel4, 0, 1);
            tableLayoutPanel5.Controls.Add(panel3, 1, 0);
            tableLayoutPanel5.Controls.Add(panel8, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Top;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(1110, 156);
            tableLayoutPanel5.TabIndex = 39;
            // 
            // panel5
            // 
            panel5.Controls.Add(tbPrecio);
            panel5.Controls.Add(materialLabel1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(555, 78);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(20, 0, 20, 0);
            panel5.Size = new Size(555, 78);
            panel5.TabIndex = 26;
            // 
            // tbPrecio
            // 
            tbPrecio.AnimateReadOnly = false;
            tbPrecio.AutoCompleteMode = AutoCompleteMode.None;
            tbPrecio.AutoCompleteSource = AutoCompleteSource.None;
            tbPrecio.BackgroundImageLayout = ImageLayout.None;
            tbPrecio.CharacterCasing = CharacterCasing.Normal;
            tbPrecio.Depth = 0;
            tbPrecio.Dock = DockStyle.Fill;
            tbPrecio.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbPrecio.HideSelection = true;
            tbPrecio.LeadingIcon = null;
            tbPrecio.Location = new Point(20, 19);
            tbPrecio.Margin = new Padding(3, 3, 26, 3);
            tbPrecio.MaxLength = 32767;
            tbPrecio.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbPrecio.Name = "tbPrecio";
            tbPrecio.Padding = new Padding(9, 8, 9, 8);
            tbPrecio.PasswordChar = '\0';
            tbPrecio.PrefixSuffixText = null;
            tbPrecio.ReadOnly = false;
            tbPrecio.RightToLeft = RightToLeft.No;
            tbPrecio.SelectedText = "";
            tbPrecio.SelectionLength = 0;
            tbPrecio.SelectionStart = 0;
            tbPrecio.ShortcutsEnabled = true;
            tbPrecio.Size = new Size(515, 48);
            tbPrecio.TabIndex = 0;
            tbPrecio.TabStop = false;
            tbPrecio.TextAlign = HorizontalAlignment.Left;
            tbPrecio.TrailingIcon = null;
            tbPrecio.UseSystemPasswordChar = false;
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
            materialLabel1.Size = new Size(45, 19);
            materialLabel1.TabIndex = 4;
            materialLabel1.Text = "Precio";
            // 
            // panel4
            // 
            panel4.Controls.Add(tbQuatity);
            panel4.Controls.Add(materialLabel2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 78);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20, 0, 20, 0);
            panel4.Size = new Size(555, 78);
            panel4.TabIndex = 25;
            // 
            // tbQuatity
            // 
            tbQuatity.AnimateReadOnly = false;
            tbQuatity.AutoCompleteMode = AutoCompleteMode.None;
            tbQuatity.AutoCompleteSource = AutoCompleteSource.None;
            tbQuatity.BackgroundImageLayout = ImageLayout.None;
            tbQuatity.CharacterCasing = CharacterCasing.Normal;
            tbQuatity.Depth = 0;
            tbQuatity.Dock = DockStyle.Fill;
            tbQuatity.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbQuatity.HideSelection = true;
            tbQuatity.LeadingIcon = null;
            tbQuatity.Location = new Point(20, 19);
            tbQuatity.Margin = new Padding(3, 3, 26, 3);
            tbQuatity.MaxLength = 32767;
            tbQuatity.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbQuatity.Name = "tbQuatity";
            tbQuatity.Padding = new Padding(9, 8, 9, 8);
            tbQuatity.PasswordChar = '\0';
            tbQuatity.PrefixSuffixText = null;
            tbQuatity.ReadOnly = false;
            tbQuatity.RightToLeft = RightToLeft.No;
            tbQuatity.SelectedText = "";
            tbQuatity.SelectionLength = 0;
            tbQuatity.SelectionStart = 0;
            tbQuatity.ShortcutsEnabled = true;
            tbQuatity.Size = new Size(515, 48);
            tbQuatity.TabIndex = 0;
            tbQuatity.TabStop = false;
            tbQuatity.TextAlign = HorizontalAlignment.Left;
            tbQuatity.TrailingIcon = null;
            tbQuatity.UseSystemPasswordChar = false;
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
            materialLabel2.Size = new Size(65, 19);
            materialLabel2.TabIndex = 4;
            materialLabel2.Text = "Cantidad";
            // 
            // panel3
            // 
            panel3.Controls.Add(cbNameProduct);
            panel3.Controls.Add(lblNombreProducto);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(555, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 0, 20, 0);
            panel3.Size = new Size(555, 78);
            panel3.TabIndex = 22;
            // 
            // cbNameProduct
            // 
            cbNameProduct.AutoResize = false;
            cbNameProduct.BackColor = Color.FromArgb(255, 255, 255);
            cbNameProduct.Depth = 0;
            cbNameProduct.Dock = DockStyle.Top;
            cbNameProduct.DrawMode = DrawMode.OwnerDrawVariable;
            cbNameProduct.DropDownHeight = 174;
            cbNameProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNameProduct.DropDownWidth = 121;
            cbNameProduct.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbNameProduct.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbNameProduct.FormattingEnabled = true;
            cbNameProduct.IntegralHeight = false;
            cbNameProduct.ItemHeight = 43;
            cbNameProduct.Location = new Point(20, 19);
            cbNameProduct.MaxDropDownItems = 4;
            cbNameProduct.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbNameProduct.Name = "cbNameProduct";
            cbNameProduct.Size = new Size(515, 49);
            cbNameProduct.StartIndex = 0;
            cbNameProduct.TabIndex = 10;
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
            // panel8
            // 
            panel8.Controls.Add(cbCodeProduc);
            panel8.Controls.Add(lblCodigoProducto);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(20, 0, 20, 0);
            panel8.Size = new Size(555, 78);
            panel8.TabIndex = 21;
            // 
            // cbCodeProduc
            // 
            cbCodeProduc.AutoResize = false;
            cbCodeProduc.BackColor = Color.FromArgb(255, 255, 255);
            cbCodeProduc.Depth = 0;
            cbCodeProduc.Dock = DockStyle.Top;
            cbCodeProduc.DrawMode = DrawMode.OwnerDrawVariable;
            cbCodeProduc.DropDownHeight = 174;
            cbCodeProduc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCodeProduc.DropDownWidth = 121;
            cbCodeProduc.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbCodeProduc.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbCodeProduc.FormattingEnabled = true;
            cbCodeProduc.IntegralHeight = false;
            cbCodeProduc.ItemHeight = 43;
            cbCodeProduc.Location = new Point(20, 19);
            cbCodeProduc.MaxDropDownItems = 4;
            cbCodeProduc.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbCodeProduc.Name = "cbCodeProduc";
            cbCodeProduc.Size = new Size(515, 49);
            cbCodeProduc.StartIndex = 0;
            cbCodeProduc.TabIndex = 10;
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
            // UCSellAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mepSellsAdd);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCSellAdd";
            Size = new Size(1152, 616);
            Load += UCSellsAdd_Load;
            mepSellsAdd.ResumeLayout(false);
            mepSellsAdd.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private NonCollapsibleMaterialExpansionPanel mepSellsAdd;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel10;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbSellsObservations;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private Panel panel7;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbTotal;
        private ReaLTaiizor.Controls.MaterialLabel lblSubTotal;
        private TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.MaterialButton btnProductAddList;
        private DataGridView dgvProductList;
        private DataGridViewTextBoxColumn CodeProduct;
        private DataGridViewTextBoxColumn NameProduct;
        private DataGridViewTextBoxColumn Quatity;
        private DataGridViewTextBoxColumn PriceProduct;
        private DataGridViewTextBoxColumn PriceTotal;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel5;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbPrecio;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private Panel panel4;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbQuatity;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private Panel panel3;
        private ReaLTaiizor.Controls.MaterialComboBox cbNameProduct;
        private ReaLTaiizor.Controls.MaterialLabel lblNombreProducto;
        private Panel panel8;
        private ReaLTaiizor.Controls.MaterialComboBox cbCodeProduc;
        private ReaLTaiizor.Controls.MaterialLabel lblCodigoProducto;
    }
}
