using GestionAgraria.Controls;


namespace GestionAgraria.Views
{
    partial class UCPurchaseAdd
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
            mepPurchaseAdd = new NonCollapsibleMaterialExpansionPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            dgvProductList = new DataGridView();
            btnProductAddList = new ReaLTaiizor.Controls.MaterialButton();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel11 = new Panel();
            tbPurchaseObservation = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel5 = new ReaLTaiizor.Controls.MaterialLabel();
            panel10 = new Panel();
            tbTotal = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblCodigoProducto = new ReaLTaiizor.Controls.MaterialLabel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel6 = new Panel();
            tbPurchaseItemCost = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            panel7 = new Panel();
            tbPurchaseItemQuantity = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            panel9 = new Panel();
            panel8 = new Panel();
            tbPurchaseItemName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            mepPurchaseAdd.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // mepPurchaseAdd
            // 
            mepPurchaseAdd.BackColor = Color.FromArgb(255, 255, 255);
            mepPurchaseAdd.CancelButtonText = "CANCELAR";
            mepPurchaseAdd.Controls.Add(tableLayoutPanel1);
            mepPurchaseAdd.Depth = 0;
            mepPurchaseAdd.Description = "Registrar nuevo insumo / compra";
            mepPurchaseAdd.Dock = DockStyle.Top;
            mepPurchaseAdd.ExpandHeight = 667;
            mepPurchaseAdd.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            mepPurchaseAdd.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mepPurchaseAdd.Location = new Point(0, 0);
            mepPurchaseAdd.Margin = new Padding(3, 12, 3, 12);
            mepPurchaseAdd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mepPurchaseAdd.Name = "mepPurchaseAdd";
            mepPurchaseAdd.Padding = new Padding(21, 48, 21, 70);
            mepPurchaseAdd.ShowCollapseExpand = false;
            mepPurchaseAdd.Size = new Size(1152, 667);
            mepPurchaseAdd.TabIndex = 4;
            mepPurchaseAdd.Title = "Insumos";
            mepPurchaseAdd.ValidationButtonEnable = true;
            mepPurchaseAdd.ValidationButtonText = "GUARDAR";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(21, 48);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1110, 549);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(dgvProductList, 0, 1);
            tableLayoutPanel2.Controls.Add(btnProductAddList, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 173);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(20, 3, 20, 3);
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1104, 282);
            tableLayoutPanel2.TabIndex = 50;
            // 
            // dgvProductList
            // 
            dgvProductList.AllowUserToAddRows = false;
            dgvProductList.AllowUserToDeleteRows = false;
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Dock = DockStyle.Fill;
            dgvProductList.Location = new Point(23, 50);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.ReadOnly = true;
            dgvProductList.Size = new Size(1058, 226);
            dgvProductList.TabIndex = 38;
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
            btnProductAddList.Size = new Size(1056, 36);
            btnProductAddList.TabIndex = 37;
            btnProductAddList.Text = "AGREGAR";
            btnProductAddList.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnProductAddList.UseAccentColor = false;
            btnProductAddList.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.AutoSize = true;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.77778F));
            tableLayoutPanel5.Controls.Add(panel11, 1, 0);
            tableLayoutPanel5.Controls.Add(panel10, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 461);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.Padding = new Padding(3);
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.Size = new Size(1104, 85);
            tableLayoutPanel5.TabIndex = 47;
            // 
            // panel11
            // 
            panel11.Controls.Add(tbPurchaseObservation);
            panel11.Controls.Add(materialLabel5);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(247, 3);
            panel11.Margin = new Padding(0);
            panel11.Name = "panel11";
            panel11.Padding = new Padding(20, 0, 20, 0);
            panel11.Size = new Size(854, 79);
            panel11.TabIndex = 24;
            // 
            // tbPurchaseObservation
            // 
            tbPurchaseObservation.AnimateReadOnly = false;
            tbPurchaseObservation.AutoCompleteMode = AutoCompleteMode.None;
            tbPurchaseObservation.AutoCompleteSource = AutoCompleteSource.None;
            tbPurchaseObservation.BackgroundImageLayout = ImageLayout.None;
            tbPurchaseObservation.CharacterCasing = CharacterCasing.Normal;
            tbPurchaseObservation.Depth = 0;
            tbPurchaseObservation.Dock = DockStyle.Fill;
            tbPurchaseObservation.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbPurchaseObservation.HideSelection = true;
            tbPurchaseObservation.LeadingIcon = null;
            tbPurchaseObservation.Location = new Point(20, 19);
            tbPurchaseObservation.Margin = new Padding(3, 3, 26, 3);
            tbPurchaseObservation.MaxLength = 32767;
            tbPurchaseObservation.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbPurchaseObservation.Name = "tbPurchaseObservation";
            tbPurchaseObservation.Padding = new Padding(9, 8, 9, 8);
            tbPurchaseObservation.PasswordChar = '\0';
            tbPurchaseObservation.PrefixSuffixText = null;
            tbPurchaseObservation.ReadOnly = false;
            tbPurchaseObservation.RightToLeft = RightToLeft.No;
            tbPurchaseObservation.SelectedText = "";
            tbPurchaseObservation.SelectionLength = 0;
            tbPurchaseObservation.SelectionStart = 0;
            tbPurchaseObservation.ShortcutsEnabled = true;
            tbPurchaseObservation.Size = new Size(814, 48);
            tbPurchaseObservation.TabIndex = 0;
            tbPurchaseObservation.TabStop = false;
            tbPurchaseObservation.TextAlign = HorizontalAlignment.Left;
            tbPurchaseObservation.TrailingIcon = null;
            tbPurchaseObservation.UseSystemPasswordChar = false;
            tbPurchaseObservation.KeyPress += tbPurchaseItemName_KeyPress;
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
            panel10.Size = new Size(244, 79);
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
            tbTotal.Enabled = false;
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
            tbTotal.Size = new Size(204, 48);
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
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(panel6, 1, 1);
            tableLayoutPanel3.Controls.Add(panel7, 0, 1);
            tableLayoutPanel3.Controls.Add(panel9, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(3);
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(1104, 164);
            tableLayoutPanel3.TabIndex = 48;
            // 
            // panel6
            // 
            panel6.Controls.Add(tbPurchaseItemCost);
            panel6.Controls.Add(materialLabel4);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(552, 79);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20, 0, 20, 0);
            panel6.Size = new Size(549, 82);
            panel6.TabIndex = 26;
            // 
            // tbPurchaseItemCost
            // 
            tbPurchaseItemCost.AnimateReadOnly = false;
            tbPurchaseItemCost.AutoCompleteMode = AutoCompleteMode.None;
            tbPurchaseItemCost.AutoCompleteSource = AutoCompleteSource.None;
            tbPurchaseItemCost.BackgroundImageLayout = ImageLayout.None;
            tbPurchaseItemCost.CharacterCasing = CharacterCasing.Normal;
            tbPurchaseItemCost.Depth = 0;
            tbPurchaseItemCost.Dock = DockStyle.Fill;
            tbPurchaseItemCost.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbPurchaseItemCost.HideSelection = true;
            tbPurchaseItemCost.LeadingIcon = null;
            tbPurchaseItemCost.Location = new Point(20, 19);
            tbPurchaseItemCost.Margin = new Padding(3, 3, 26, 3);
            tbPurchaseItemCost.MaxLength = 32767;
            tbPurchaseItemCost.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbPurchaseItemCost.Name = "tbPurchaseItemCost";
            tbPurchaseItemCost.Padding = new Padding(9, 8, 9, 8);
            tbPurchaseItemCost.PasswordChar = '\0';
            tbPurchaseItemCost.PrefixSuffixText = null;
            tbPurchaseItemCost.ReadOnly = false;
            tbPurchaseItemCost.RightToLeft = RightToLeft.No;
            tbPurchaseItemCost.SelectedText = "";
            tbPurchaseItemCost.SelectionLength = 0;
            tbPurchaseItemCost.SelectionStart = 0;
            tbPurchaseItemCost.ShortcutsEnabled = true;
            tbPurchaseItemCost.Size = new Size(509, 48);
            tbPurchaseItemCost.TabIndex = 0;
            tbPurchaseItemCost.TabStop = false;
            tbPurchaseItemCost.TextAlign = HorizontalAlignment.Left;
            tbPurchaseItemCost.TrailingIcon = null;
            tbPurchaseItemCost.UseSystemPasswordChar = false;
            tbPurchaseItemCost.KeyPress += tbPurchaseItemCost_KeyPress;
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
            materialLabel4.Size = new Size(46, 19);
            materialLabel4.TabIndex = 4;
            materialLabel4.Text = "Costo ";
            // 
            // panel7
            // 
            panel7.Controls.Add(tbPurchaseItemQuantity);
            panel7.Controls.Add(materialLabel2);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 79);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(20, 0, 20, 0);
            panel7.Size = new Size(549, 82);
            panel7.TabIndex = 24;
            // 
            // tbPurchaseItemQuantity
            // 
            tbPurchaseItemQuantity.AnimateReadOnly = false;
            tbPurchaseItemQuantity.AutoCompleteMode = AutoCompleteMode.None;
            tbPurchaseItemQuantity.AutoCompleteSource = AutoCompleteSource.None;
            tbPurchaseItemQuantity.BackgroundImageLayout = ImageLayout.None;
            tbPurchaseItemQuantity.CharacterCasing = CharacterCasing.Normal;
            tbPurchaseItemQuantity.Depth = 0;
            tbPurchaseItemQuantity.Dock = DockStyle.Fill;
            tbPurchaseItemQuantity.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbPurchaseItemQuantity.HideSelection = true;
            tbPurchaseItemQuantity.LeadingIcon = null;
            tbPurchaseItemQuantity.Location = new Point(20, 19);
            tbPurchaseItemQuantity.Margin = new Padding(3, 3, 26, 3);
            tbPurchaseItemQuantity.MaxLength = 32767;
            tbPurchaseItemQuantity.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbPurchaseItemQuantity.Name = "tbPurchaseItemQuantity";
            tbPurchaseItemQuantity.Padding = new Padding(9, 8, 9, 8);
            tbPurchaseItemQuantity.PasswordChar = '\0';
            tbPurchaseItemQuantity.PrefixSuffixText = null;
            tbPurchaseItemQuantity.ReadOnly = false;
            tbPurchaseItemQuantity.RightToLeft = RightToLeft.No;
            tbPurchaseItemQuantity.SelectedText = "";
            tbPurchaseItemQuantity.SelectionLength = 0;
            tbPurchaseItemQuantity.SelectionStart = 0;
            tbPurchaseItemQuantity.ShortcutsEnabled = true;
            tbPurchaseItemQuantity.Size = new Size(509, 48);
            tbPurchaseItemQuantity.TabIndex = 0;
            tbPurchaseItemQuantity.TabStop = false;
            tbPurchaseItemQuantity.TextAlign = HorizontalAlignment.Left;
            tbPurchaseItemQuantity.TrailingIcon = null;
            tbPurchaseItemQuantity.UseSystemPasswordChar = false;
            tbPurchaseItemQuantity.KeyPress += tbPurchaseItemQuantity_KeyPress;
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
            // panel9
            // 
            tableLayoutPanel3.SetColumnSpan(panel9, 2);
            panel9.Controls.Add(panel8);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(3, 3);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(20, 0, 20, 0);
            panel9.Size = new Size(1098, 76);
            panel9.TabIndex = 21;
            // 
            // panel8
            // 
            panel8.Controls.Add(tbPurchaseItemName);
            panel8.Controls.Add(materialLabel3);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(20, 0);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1058, 76);
            panel8.TabIndex = 24;
            // 
            // tbPurchaseItemName
            // 
            tbPurchaseItemName.AnimateReadOnly = false;
            tbPurchaseItemName.AutoCompleteMode = AutoCompleteMode.None;
            tbPurchaseItemName.AutoCompleteSource = AutoCompleteSource.None;
            tbPurchaseItemName.BackgroundImageLayout = ImageLayout.None;
            tbPurchaseItemName.CharacterCasing = CharacterCasing.Normal;
            tbPurchaseItemName.Depth = 0;
            tbPurchaseItemName.Dock = DockStyle.Fill;
            tbPurchaseItemName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbPurchaseItemName.HideSelection = true;
            tbPurchaseItemName.LeadingIcon = null;
            tbPurchaseItemName.Location = new Point(0, 19);
            tbPurchaseItemName.Margin = new Padding(3, 3, 26, 3);
            tbPurchaseItemName.MaxLength = 100;
            tbPurchaseItemName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbPurchaseItemName.Name = "tbPurchaseItemName";
            tbPurchaseItemName.Padding = new Padding(9, 8, 9, 8);
            tbPurchaseItemName.PasswordChar = '\0';
            tbPurchaseItemName.PrefixSuffixText = null;
            tbPurchaseItemName.ReadOnly = false;
            tbPurchaseItemName.RightToLeft = RightToLeft.No;
            tbPurchaseItemName.SelectedText = "";
            tbPurchaseItemName.SelectionLength = 0;
            tbPurchaseItemName.SelectionStart = 0;
            tbPurchaseItemName.ShortcutsEnabled = true;
            tbPurchaseItemName.Size = new Size(1058, 48);
            tbPurchaseItemName.TabIndex = 5;
            tbPurchaseItemName.TabStop = false;
            tbPurchaseItemName.TextAlign = HorizontalAlignment.Left;
            tbPurchaseItemName.TrailingIcon = null;
            tbPurchaseItemName.UseSystemPasswordChar = false;
            tbPurchaseItemName.KeyPress += tbPurchaseItemName_KeyPress;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Dock = DockStyle.Top;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(0, 0);
            materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(57, 19);
            materialLabel3.TabIndex = 4;
            materialLabel3.Text = "Nombre";
            // 
            // UCPurchaseAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(mepPurchaseAdd);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCPurchaseAdd";
            Size = new Size(1152, 667);
            mepPurchaseAdd.ResumeLayout(false);
            mepPurchaseAdd.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private NonCollapsibleMaterialExpansionPanel mepPurchaseAdd;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel11;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbPurchaseObservation;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel5;
        private Panel panel10;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbTotal;
        private ReaLTaiizor.Controls.MaterialLabel lblCodigoProducto;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dgvProductList;
        private ReaLTaiizor.Controls.MaterialButton btnProductAddList;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel6;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbPurchaseItemCost;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private Panel panel7;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbPurchaseItemQuantity;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private Panel panel9;
        private Panel panel8;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbPurchaseItemName;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
    }
}
