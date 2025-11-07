namespace GestionAgraria.Views
{
    partial class UCNewSellsAdd
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
            mepSellsAdd = new GestionAgraria.Controls.NonCollapsibleMaterialExpansionPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel7 = new Panel();
            tbTotal = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblSubTotal = new ReaLTaiizor.Controls.MaterialLabel();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            dgvProductList = new DataGridView();
            CodeProduct = new DataGridViewTextBoxColumn();
            NameProduct = new DataGridViewTextBoxColumn();
            Quatity = new DataGridViewTextBoxColumn();
            PriceProduct = new DataGridViewTextBoxColumn();
            PriceTotal = new DataGridViewTextBoxColumn();
            btnProductAddList = new ReaLTaiizor.Controls.MaterialButton();
            panel4 = new Panel();
            tbSellProductQuantity = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            panel8 = new Panel();
            cbSellProductName = new ReaLTaiizor.Controls.MaterialComboBox();
            lblNombreProducto = new ReaLTaiizor.Controls.MaterialLabel();
            panel3 = new Panel();
            tbSellPrice = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            groupBox2 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel10 = new Panel();
            tbSellObservations = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            panel5 = new Panel();
            tbSellClientName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            mepSellsAdd.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel7.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel10.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // mepSellsAdd
            // 
            mepSellsAdd.BackColor = Color.FromArgb(255, 255, 255);
            mepSellsAdd.CancelButtonText = "CANCELAR";
            mepSellsAdd.Controls.Add(tableLayoutPanel1);
            mepSellsAdd.Depth = 0;
            mepSellsAdd.Description = "Registrar un Nueva Venta";
            mepSellsAdd.Dock = DockStyle.Top;
            mepSellsAdd.ExpandHeight = 559;
            mepSellsAdd.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            mepSellsAdd.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mepSellsAdd.Location = new Point(0, 0);
            mepSellsAdd.Margin = new Padding(3, 12, 3, 12);
            mepSellsAdd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mepSellsAdd.Name = "mepSellsAdd";
            mepSellsAdd.Padding = new Padding(21, 48, 21, 20);
            mepSellsAdd.ShowCollapseExpand = false;
            mepSellsAdd.Size = new Size(825, 559);
            mepSellsAdd.TabIndex = 0;
            mepSellsAdd.Title = "Ventas";
            mepSellsAdd.ValidationButtonEnable = true;
            mepSellsAdd.ValidationButtonText = "GUARDAr";
            mepSellsAdd.SaveClick += mepSellsAdd_SaveClick;
            mepSellsAdd.CancelClick += mepSellsAdd_CancelClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel7, 0, 2);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(21, 48);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.1995926F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60.2851334F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.3396683F));
            tableLayoutPanel1.Size = new Size(783, 491);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.Controls.Add(tbTotal);
            panel7.Controls.Add(lblSubTotal);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 405);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(20, 0, 20, 0);
            panel7.Size = new Size(783, 86);
            panel7.TabIndex = 42;
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
            tbTotal.Enabled = false;
            tbTotal.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbTotal.HideSelection = true;
            tbTotal.LeadingIcon = null;
            tbTotal.Location = new Point(20, 19);
            tbTotal.Margin = new Padding(3, 3, 26, 3);
            tbTotal.MaximumSize = new Size(240, 0);
            tbTotal.MaxLength = 32767;
            tbTotal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbTotal.Name = "tbTotal";
            tbTotal.Padding = new Padding(9, 8, 9, 8);
            tbTotal.PasswordChar = '\0';
            tbTotal.PrefixSuffix = ReaLTaiizor.Controls.MaterialTextBoxEdit.PrefixSuffixTypes.Prefix;
            tbTotal.PrefixSuffixText = "$";
            tbTotal.ReadOnly = false;
            tbTotal.RightToLeft = RightToLeft.No;
            tbTotal.SelectedText = "";
            tbTotal.SelectionLength = 0;
            tbTotal.SelectionStart = 0;
            tbTotal.ShortcutsEnabled = true;
            tbTotal.Size = new Size(240, 48);
            tbTotal.TabIndex = 7;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(777, 290);
            groupBox1.TabIndex = 41;
            groupBox1.TabStop = false;
            groupBox1.Text = "Productos de la venta";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel2.Controls.Add(dgvProductList, 0, 2);
            tableLayoutPanel2.Controls.Add(btnProductAddList, 0, 1);
            tableLayoutPanel2.Controls.Add(panel4, 1, 0);
            tableLayoutPanel2.Controls.Add(panel8, 0, 0);
            tableLayoutPanel2.Controls.Add(panel3, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 19);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(771, 268);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // dgvProductList
            // 
            dgvProductList.AllowUserToAddRows = false;
            dgvProductList.AllowUserToDeleteRows = false;
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Columns.AddRange(new DataGridViewColumn[] { CodeProduct, NameProduct, Quatity, PriceProduct, PriceTotal });
            tableLayoutPanel2.SetColumnSpan(dgvProductList, 3);
            dgvProductList.Dock = DockStyle.Fill;
            dgvProductList.Location = new Point(3, 129);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.ReadOnly = true;
            dgvProductList.Size = new Size(765, 136);
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
            tableLayoutPanel2.SetColumnSpan(btnProductAddList, 3);
            btnProductAddList.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnProductAddList.Depth = 0;
            btnProductAddList.Dock = DockStyle.Fill;
            btnProductAddList.HighEmphasis = true;
            btnProductAddList.Icon = null;
            btnProductAddList.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnProductAddList.Location = new Point(4, 84);
            btnProductAddList.Margin = new Padding(4, 6, 4, 6);
            btnProductAddList.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnProductAddList.Name = "btnProductAddList";
            btnProductAddList.NoAccentTextColor = Color.Empty;
            btnProductAddList.Size = new Size(763, 36);
            btnProductAddList.TabIndex = 6;
            btnProductAddList.Text = "Agregar producto";
            btnProductAddList.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnProductAddList.UseAccentColor = false;
            btnProductAddList.UseVisualStyleBackColor = true;
            btnProductAddList.Click += btnProductAddList_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(tbSellProductQuantity);
            panel4.Controls.Add(materialLabel2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(256, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20, 0, 20, 0);
            panel4.Size = new Size(257, 78);
            panel4.TabIndex = 25;
            // 
            // tbSellProductQuantity
            // 
            tbSellProductQuantity.AnimateReadOnly = false;
            tbSellProductQuantity.AutoCompleteMode = AutoCompleteMode.None;
            tbSellProductQuantity.AutoCompleteSource = AutoCompleteSource.None;
            tbSellProductQuantity.BackgroundImageLayout = ImageLayout.None;
            tbSellProductQuantity.CharacterCasing = CharacterCasing.Normal;
            tbSellProductQuantity.Depth = 0;
            tbSellProductQuantity.Dock = DockStyle.Fill;
            tbSellProductQuantity.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbSellProductQuantity.HideSelection = true;
            tbSellProductQuantity.LeadingIcon = null;
            tbSellProductQuantity.Location = new Point(20, 19);
            tbSellProductQuantity.Margin = new Padding(3, 3, 26, 3);
            tbSellProductQuantity.MaxLength = 32767;
            tbSellProductQuantity.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbSellProductQuantity.Name = "tbSellProductQuantity";
            tbSellProductQuantity.Padding = new Padding(9, 8, 9, 8);
            tbSellProductQuantity.PasswordChar = '\0';
            tbSellProductQuantity.PrefixSuffixText = null;
            tbSellProductQuantity.ReadOnly = false;
            tbSellProductQuantity.RightToLeft = RightToLeft.No;
            tbSellProductQuantity.SelectedText = "";
            tbSellProductQuantity.SelectionLength = 0;
            tbSellProductQuantity.SelectionStart = 0;
            tbSellProductQuantity.ShortcutsEnabled = true;
            tbSellProductQuantity.Size = new Size(217, 48);
            tbSellProductQuantity.TabIndex = 4;
            tbSellProductQuantity.TabStop = false;
            tbSellProductQuantity.TextAlign = HorizontalAlignment.Left;
            tbSellProductQuantity.TrailingIcon = null;
            tbSellProductQuantity.UseSystemPasswordChar = false;
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
            panel8.Controls.Add(cbSellProductName);
            panel8.Controls.Add(lblNombreProducto);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(20, 0, 20, 0);
            panel8.Size = new Size(256, 78);
            panel8.TabIndex = 21;
            // 
            // cbSellProductName
            // 
            cbSellProductName.AutoResize = false;
            cbSellProductName.BackColor = Color.FromArgb(255, 255, 255);
            cbSellProductName.Depth = 0;
            cbSellProductName.Dock = DockStyle.Top;
            cbSellProductName.DrawMode = DrawMode.OwnerDrawVariable;
            cbSellProductName.DropDownHeight = 174;
            cbSellProductName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSellProductName.DropDownWidth = 121;
            cbSellProductName.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbSellProductName.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbSellProductName.FormattingEnabled = true;
            cbSellProductName.IntegralHeight = false;
            cbSellProductName.ItemHeight = 43;
            cbSellProductName.Location = new Point(20, 19);
            cbSellProductName.MaxDropDownItems = 4;
            cbSellProductName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbSellProductName.Name = "cbSellProductName";
            cbSellProductName.Size = new Size(216, 49);
            cbSellProductName.StartIndex = 0;
            cbSellProductName.TabIndex = 3;
            cbSellProductName.SelectedIndexChanged += cbSellProductName_SelectedIndexChanged;
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
            lblNombreProducto.TabIndex = 11;
            lblNombreProducto.Text = "Nombre";
            // 
            // panel3
            // 
            panel3.Controls.Add(tbSellPrice);
            panel3.Controls.Add(materialLabel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(513, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 0, 20, 0);
            panel3.Size = new Size(258, 78);
            panel3.TabIndex = 22;
            // 
            // tbSellPrice
            // 
            tbSellPrice.AnimateReadOnly = false;
            tbSellPrice.AutoCompleteMode = AutoCompleteMode.None;
            tbSellPrice.AutoCompleteSource = AutoCompleteSource.None;
            tbSellPrice.BackgroundImageLayout = ImageLayout.None;
            tbSellPrice.CharacterCasing = CharacterCasing.Normal;
            tbSellPrice.Depth = 0;
            tbSellPrice.Dock = DockStyle.Fill;
            tbSellPrice.Enabled = false;
            tbSellPrice.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbSellPrice.HideSelection = true;
            tbSellPrice.LeadingIcon = null;
            tbSellPrice.Location = new Point(20, 19);
            tbSellPrice.Margin = new Padding(3, 3, 26, 3);
            tbSellPrice.MaxLength = 32767;
            tbSellPrice.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbSellPrice.Name = "tbSellPrice";
            tbSellPrice.Padding = new Padding(9, 8, 9, 8);
            tbSellPrice.PasswordChar = '\0';
            tbSellPrice.PrefixSuffix = ReaLTaiizor.Controls.MaterialTextBoxEdit.PrefixSuffixTypes.Prefix;
            tbSellPrice.PrefixSuffixText = "$";
            tbSellPrice.ReadOnly = false;
            tbSellPrice.RightToLeft = RightToLeft.No;
            tbSellPrice.SelectedText = "";
            tbSellPrice.SelectionLength = 0;
            tbSellPrice.SelectionStart = 0;
            tbSellPrice.ShortcutsEnabled = true;
            tbSellPrice.Size = new Size(218, 48);
            tbSellPrice.TabIndex = 5;
            tbSellPrice.TabStop = false;
            tbSellPrice.TextAlign = HorizontalAlignment.Left;
            tbSellPrice.TrailingIcon = null;
            tbSellPrice.UseSystemPasswordChar = false;
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
            materialLabel1.TabIndex = 30;
            materialLabel1.Text = "Precio";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel4);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(777, 103);
            groupBox2.TabIndex = 40;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos de la venta";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(panel10, 1, 0);
            tableLayoutPanel4.Controls.Add(panel5, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 19);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(771, 81);
            tableLayoutPanel4.TabIndex = 6;
            // 
            // panel10
            // 
            panel10.Controls.Add(tbSellObservations);
            panel10.Controls.Add(materialLabel3);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(388, 3);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(20, 0, 20, 0);
            panel10.Size = new Size(380, 71);
            panel10.TabIndex = 45;
            // 
            // tbSellObservations
            // 
            tbSellObservations.AnimateReadOnly = false;
            tbSellObservations.AutoCompleteMode = AutoCompleteMode.None;
            tbSellObservations.AutoCompleteSource = AutoCompleteSource.None;
            tbSellObservations.BackgroundImageLayout = ImageLayout.None;
            tbSellObservations.CharacterCasing = CharacterCasing.Normal;
            tbSellObservations.Depth = 0;
            tbSellObservations.Dock = DockStyle.Fill;
            tbSellObservations.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbSellObservations.HideSelection = true;
            tbSellObservations.LeadingIcon = null;
            tbSellObservations.Location = new Point(20, 19);
            tbSellObservations.Margin = new Padding(3, 3, 26, 3);
            tbSellObservations.MaxLength = 32767;
            tbSellObservations.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbSellObservations.Name = "tbSellObservations";
            tbSellObservations.Padding = new Padding(9, 8, 9, 8);
            tbSellObservations.PasswordChar = '\0';
            tbSellObservations.PrefixSuffixText = null;
            tbSellObservations.ReadOnly = false;
            tbSellObservations.RightToLeft = RightToLeft.No;
            tbSellObservations.SelectedText = "";
            tbSellObservations.SelectionLength = 0;
            tbSellObservations.SelectionStart = 0;
            tbSellObservations.ShortcutsEnabled = true;
            tbSellObservations.Size = new Size(340, 48);
            tbSellObservations.TabIndex = 1;
            tbSellObservations.TabStop = false;
            tbSellObservations.TextAlign = HorizontalAlignment.Left;
            tbSellObservations.TrailingIcon = null;
            tbSellObservations.UseSystemPasswordChar = false;
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
            materialLabel3.Size = new Size(124, 19);
            materialLabel3.TabIndex = 4;
            materialLabel3.Text = "Notas de la venta";
            // 
            // panel5
            // 
            panel5.Controls.Add(tbSellClientName);
            panel5.Controls.Add(materialLabel4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(20, 0, 20, 0);
            panel5.Size = new Size(379, 71);
            panel5.TabIndex = 0;
            // 
            // tbSellClientName
            // 
            tbSellClientName.AnimateReadOnly = false;
            tbSellClientName.AutoCompleteMode = AutoCompleteMode.None;
            tbSellClientName.AutoCompleteSource = AutoCompleteSource.None;
            tbSellClientName.BackgroundImageLayout = ImageLayout.None;
            tbSellClientName.CharacterCasing = CharacterCasing.Normal;
            tbSellClientName.Depth = 0;
            tbSellClientName.Dock = DockStyle.Fill;
            tbSellClientName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbSellClientName.HideSelection = true;
            tbSellClientName.LeadingIcon = null;
            tbSellClientName.Location = new Point(20, 19);
            tbSellClientName.Margin = new Padding(3, 3, 26, 3);
            tbSellClientName.MaxLength = 32767;
            tbSellClientName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbSellClientName.Name = "tbSellClientName";
            tbSellClientName.Padding = new Padding(9, 8, 9, 8);
            tbSellClientName.PasswordChar = '\0';
            tbSellClientName.PrefixSuffixText = null;
            tbSellClientName.ReadOnly = false;
            tbSellClientName.RightToLeft = RightToLeft.No;
            tbSellClientName.SelectedText = "";
            tbSellClientName.SelectionLength = 0;
            tbSellClientName.SelectionStart = 0;
            tbSellClientName.ShortcutsEnabled = true;
            tbSellClientName.Size = new Size(339, 48);
            tbSellClientName.TabIndex = 0;
            tbSellClientName.TabStop = false;
            tbSellClientName.TextAlign = HorizontalAlignment.Left;
            tbSellClientName.TrailingIcon = null;
            tbSellClientName.UseSystemPasswordChar = false;
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
            materialLabel4.Size = new Size(132, 19);
            materialLabel4.TabIndex = 8;
            materialLabel4.Text = "Nombre del cliente";
            // 
            // UCNewSellsAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(mepSellsAdd);
            Name = "UCNewSellsAdd";
            Size = new Size(825, 559);
            mepSellsAdd.ResumeLayout(false);
            mepSellsAdd.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Controls.NonCollapsibleMaterialExpansionPanel mepSellsAdd;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel7;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbTotal;
        private ReaLTaiizor.Controls.MaterialLabel lblSubTotal;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dgvProductList;
        private DataGridViewTextBoxColumn CodeProduct;
        private DataGridViewTextBoxColumn NameProduct;
        private DataGridViewTextBoxColumn Quatity;
        private DataGridViewTextBoxColumn PriceProduct;
        private DataGridViewTextBoxColumn PriceTotal;
        private ReaLTaiizor.Controls.MaterialButton btnProductAddList;
        private Panel panel4;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbSellProductQuantity;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private Panel panel8;
        private ReaLTaiizor.Controls.MaterialComboBox cbSellProductName;
        private ReaLTaiizor.Controls.MaterialLabel lblNombreProducto;
        private Panel panel3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbSellPrice;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel10;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbSellObservations;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private Panel panel5;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbSellClientName;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
    }
}
