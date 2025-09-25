namespace GestionAgraria.Views
{
    partial class UCBuysAdd
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
            panel2 = new Panel();
            MepBuysAdd = new ReaLTaiizor.Controls.MaterialExpansionPanel();
            panel3 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            dgvProductList = new DataGridView();
            CodeProduct = new DataGridViewTextBoxColumn();
            NameProduct = new DataGridViewTextBoxColumn();
            Quatity = new DataGridViewTextBoxColumn();
            PriceProduct = new DataGridViewTextBoxColumn();
            PriceTotal = new DataGridViewTextBoxColumn();
            btnProductAddList = new ReaLTaiizor.Controls.MaterialButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel6 = new Panel();
            tbPrecio = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            panel7 = new Panel();
            tbQuatity = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            panel8 = new Panel();
            cbNameProduct = new ReaLTaiizor.Controls.MaterialComboBox();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            panel9 = new Panel();
            cbCodeProduc = new ReaLTaiizor.Controls.MaterialComboBox();
            materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel11 = new Panel();
            tbSellsObservations = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel5 = new ReaLTaiizor.Controls.MaterialLabel();
            panel10 = new Panel();
            tbTotal = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblCodigoProducto = new ReaLTaiizor.Controls.MaterialLabel();
            panel2.SuspendLayout();
            MepBuysAdd.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(MepBuysAdd);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1152, 667);
            panel2.TabIndex = 0;
            // 
            // MepBuysAdd
            // 
            MepBuysAdd.BackColor = Color.FromArgb(255, 255, 255);
            MepBuysAdd.CancelButtonText = "CANCELAR";
            MepBuysAdd.Controls.Add(panel3);
            MepBuysAdd.Depth = 0;
            MepBuysAdd.Description = "Registrar Nuevas Compras";
            MepBuysAdd.Dock = DockStyle.Top;
            MepBuysAdd.ExpandHeight = 667;
            MepBuysAdd.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            MepBuysAdd.ForeColor = Color.FromArgb(222, 0, 0, 0);
            MepBuysAdd.Location = new Point(0, 0);
            MepBuysAdd.Margin = new Padding(3, 12, 3, 12);
            MepBuysAdd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            MepBuysAdd.Name = "MepBuysAdd";
            MepBuysAdd.Padding = new Padding(21, 48, 21, 12);
            MepBuysAdd.Size = new Size(1152, 667);
            MepBuysAdd.TabIndex = 3;
            MepBuysAdd.Title = "Compras";
            MepBuysAdd.ValidationButtonText = "GUARDAR";
            MepBuysAdd.CancelClick += MepBuysAdd_CancelClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel2);
            panel3.Controls.Add(tableLayoutPanel3);
            panel3.Controls.Add(tableLayoutPanel5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(21, 48);
            panel3.Name = "panel3";
            panel3.Size = new Size(1110, 607);
            panel3.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(dgvProductList, 0, 1);
            tableLayoutPanel2.Controls.Add(btnProductAddList, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 164);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(20, 3, 20, 3);
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1110, 295);
            tableLayoutPanel2.TabIndex = 46;
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
            dgvProductList.Size = new Size(1064, 239);
            dgvProductList.TabIndex = 38;
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
            btnProductAddList.TabIndex = 37;
            btnProductAddList.Text = "AGREGAR";
            btnProductAddList.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnProductAddList.UseAccentColor = false;
            btnProductAddList.UseVisualStyleBackColor = true;
            btnProductAddList.Click += btnProductAddList_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(panel6, 1, 1);
            tableLayoutPanel3.Controls.Add(panel7, 0, 1);
            tableLayoutPanel3.Controls.Add(panel8, 1, 0);
            tableLayoutPanel3.Controls.Add(panel9, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(3);
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(1110, 164);
            tableLayoutPanel3.TabIndex = 45;
            // 
            // panel6
            // 
            panel6.Controls.Add(tbPrecio);
            panel6.Controls.Add(materialLabel1);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(555, 79);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20, 0, 20, 0);
            panel6.Size = new Size(552, 82);
            panel6.TabIndex = 26;
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
            tbPrecio.Size = new Size(512, 48);
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
            materialLabel1.Size = new Size(94, 19);
            materialLabel1.TabIndex = 4;
            materialLabel1.Text = "Precio Costo ";
            // 
            // panel7
            // 
            panel7.Controls.Add(tbQuatity);
            panel7.Controls.Add(materialLabel2);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 79);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(20, 0, 20, 0);
            panel7.Size = new Size(552, 82);
            panel7.TabIndex = 24;
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
            tbQuatity.Size = new Size(512, 48);
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
            // panel8
            // 
            panel8.Controls.Add(cbNameProduct);
            panel8.Controls.Add(materialLabel3);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(555, 3);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(20, 0, 20, 0);
            panel8.Size = new Size(552, 76);
            panel8.TabIndex = 22;
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
            cbNameProduct.Size = new Size(512, 49);
            cbNameProduct.StartIndex = 0;
            cbNameProduct.TabIndex = 11;
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
            materialLabel3.Size = new Size(57, 19);
            materialLabel3.TabIndex = 4;
            materialLabel3.Text = "Nombre";
            // 
            // panel9
            // 
            panel9.Controls.Add(cbCodeProduc);
            panel9.Controls.Add(materialLabel4);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(3, 3);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(20, 0, 20, 0);
            panel9.Size = new Size(552, 76);
            panel9.TabIndex = 21;
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
            cbCodeProduc.Size = new Size(512, 49);
            cbCodeProduc.StartIndex = 0;
            cbCodeProduc.TabIndex = 11;
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
            materialLabel4.Size = new Size(55, 19);
            materialLabel4.TabIndex = 4;
            materialLabel4.Text = "Codigo ";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.77778F));
            tableLayoutPanel5.Controls.Add(panel11, 1, 0);
            tableLayoutPanel5.Controls.Add(panel10, 0, 0);
            tableLayoutPanel5.Location = new Point(0, 459);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.Padding = new Padding(3);
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.Size = new Size(1110, 85);
            tableLayoutPanel5.TabIndex = 43;
            // 
            // panel11
            // 
            panel11.Controls.Add(tbSellsObservations);
            panel11.Controls.Add(materialLabel5);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(248, 3);
            panel11.Margin = new Padding(0);
            panel11.Name = "panel11";
            panel11.Padding = new Padding(20, 0, 20, 0);
            panel11.Size = new Size(859, 79);
            panel11.TabIndex = 24;
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
            tbSellsObservations.Size = new Size(819, 48);
            tbSellsObservations.TabIndex = 0;
            tbSellsObservations.TabStop = false;
            tbSellsObservations.TextAlign = HorizontalAlignment.Left;
            tbSellsObservations.TrailingIcon = null;
            tbSellsObservations.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Dock = DockStyle.Top;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(20, 0);
            materialLabel5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(84, 19);
            materialLabel5.TabIndex = 4;
            materialLabel5.Text = "Descripcion";
            // 
            // panel10
            // 
            panel10.Controls.Add(tbTotal);
            panel10.Controls.Add(lblCodigoProducto);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(3, 3);
            panel10.Margin = new Padding(0);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(20, 0, 20, 0);
            panel10.Size = new Size(245, 79);
            panel10.TabIndex = 23;
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
            tbTotal.Size = new Size(205, 48);
            tbTotal.TabIndex = 0;
            tbTotal.TabStop = false;
            tbTotal.TextAlign = HorizontalAlignment.Left;
            tbTotal.TrailingIcon = null;
            tbTotal.UseSystemPasswordChar = false;
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
            lblCodigoProducto.Size = new Size(38, 19);
            lblCodigoProducto.TabIndex = 4;
            lblCodigoProducto.Text = "Total";
            // 
            // UCBuysAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCBuysAdd";
            Size = new Size(1152, 667);
            panel2.ResumeLayout(false);
            MepBuysAdd.ResumeLayout(false);
            MepBuysAdd.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox4;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDescuento;
        private ReaLTaiizor.Controls.MaterialLabel lblDescuento;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSubTotal;
        private Panel panel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNombreProducto;
        private ReaLTaiizor.Controls.MaterialLabel lblNombreProducto;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit txtObservaciones;
        private Panel panel5;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPrecioCosto;
        private ReaLTaiizor.Controls.MaterialLabel lblDescripcion;
        private Panel panel4;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCantidad;
        private ReaLTaiizor.Controls.MaterialLabel lblCantidad;
        private Panel panel2;
        private ReaLTaiizor.Controls.MaterialExpansionPanel MepBuysAdd;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.MaterialButton btnProductAddList;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel6;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbPrecio;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private Panel panel7;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbQuatity;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private Panel panel8;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private Panel panel9;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel10;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbTotal;
        private ReaLTaiizor.Controls.MaterialLabel lblCodigoProducto;
        private Panel panel11;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbSellsObservations;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel5;
        private ReaLTaiizor.Controls.MaterialComboBox cbNameProduct;
        private ReaLTaiizor.Controls.MaterialComboBox cbCodeProduc;
        private DataGridView dgvProductList;
        private DataGridViewTextBoxColumn CodeProduct;
        private DataGridViewTextBoxColumn NameProduct;
        private DataGridViewTextBoxColumn Quatity;
        private DataGridViewTextBoxColumn PriceProduct;
        private DataGridViewTextBoxColumn PriceTotal;
    }
}
