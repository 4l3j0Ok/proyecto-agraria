namespace GestionAgraria.Views
{
    partial class UCVentasAdd
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
            materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel1 = new Panel();
            txtNombreProducto = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            panel5 = new Panel();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            lblPrecioCosto = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            lblNombreProducto = new ReaLTaiizor.Controls.MaterialLabel();
            panel3 = new Panel();
            tbCodigoProducto = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblCodigoProducto = new ReaLTaiizor.Controls.MaterialLabel();
            panel4 = new Panel();
            lblCantidad = new ReaLTaiizor.Controls.MaterialLabel();
            materialMultiLineTextBoxEdit1 = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            groupBox4 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel6 = new Panel();
            txtDescuento = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblDescuento = new ReaLTaiizor.Controls.MaterialLabel();
            panel7 = new Panel();
            txtSubTotal = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblSubTotal = new ReaLTaiizor.Controls.MaterialLabel();
            materialExpansionPanel1 = new ReaLTaiizor.Controls.MaterialExpansionPanel();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            groupBox4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            materialExpansionPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(materialButton1);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(21, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(1110, 556);
            panel2.TabIndex = 12;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.Dock = DockStyle.Top;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton1.Location = new Point(0, 151);
            materialButton1.Margin = new Padding(4);
            materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(1110, 36);
            materialButton1.TabIndex = 35;
            materialButton1.Text = "AGREGAR";
            materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(3, 196);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(1105, 202);
            groupBox2.TabIndex = 34;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ventas Agregadas";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 21);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1095, 169);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel5);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1110, 151);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Producto ";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(panel1, 1, 0);
            tableLayoutPanel5.Controls.Add(panel3, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 19);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 133F));
            tableLayoutPanel5.Size = new Size(1104, 129);
            tableLayoutPanel5.TabIndex = 29;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtNombreProducto);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(lblNombreProducto);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(552, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 0, 20, 0);
            panel1.Size = new Size(552, 133);
            panel1.TabIndex = 22;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.AnimateReadOnly = false;
            txtNombreProducto.AutoCompleteMode = AutoCompleteMode.None;
            txtNombreProducto.AutoCompleteSource = AutoCompleteSource.None;
            txtNombreProducto.BackgroundImageLayout = ImageLayout.None;
            txtNombreProducto.CharacterCasing = CharacterCasing.Normal;
            txtNombreProducto.Depth = 0;
            txtNombreProducto.Dock = DockStyle.Fill;
            txtNombreProducto.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombreProducto.HideSelection = true;
            txtNombreProducto.LeadingIcon = null;
            txtNombreProducto.Location = new Point(20, 19);
            txtNombreProducto.Margin = new Padding(3, 3, 26, 3);
            txtNombreProducto.MaxLength = 32767;
            txtNombreProducto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Padding = new Padding(9, 8, 9, 8);
            txtNombreProducto.PasswordChar = '\0';
            txtNombreProducto.PrefixSuffixText = null;
            txtNombreProducto.ReadOnly = false;
            txtNombreProducto.RightToLeft = RightToLeft.No;
            txtNombreProducto.SelectedText = "";
            txtNombreProducto.SelectionLength = 0;
            txtNombreProducto.SelectionStart = 0;
            txtNombreProducto.ShortcutsEnabled = true;
            txtNombreProducto.Size = new Size(512, 48);
            txtNombreProducto.TabIndex = 0;
            txtNombreProducto.TabStop = false;
            txtNombreProducto.TextAlign = HorizontalAlignment.Left;
            txtNombreProducto.TrailingIcon = null;
            txtNombreProducto.UseSystemPasswordChar = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(materialLabel1);
            panel5.Controls.Add(lblPrecioCosto);
            panel5.Location = new Point(0, 68);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(550, 60);
            panel5.TabIndex = 1;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(16, 0);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(111, 19);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Precio de Costo";
            // 
            // lblPrecioCosto
            // 
            lblPrecioCosto.AnimateReadOnly = false;
            lblPrecioCosto.BackgroundImageLayout = ImageLayout.None;
            lblPrecioCosto.CharacterCasing = CharacterCasing.Normal;
            lblPrecioCosto.Depth = 0;
            lblPrecioCosto.HideSelection = true;
            lblPrecioCosto.Location = new Point(18, 18);
            lblPrecioCosto.Margin = new Padding(3, 2, 3, 2);
            lblPrecioCosto.MaxLength = 32767;
            lblPrecioCosto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            lblPrecioCosto.Name = "lblPrecioCosto";
            lblPrecioCosto.PasswordChar = '\0';
            lblPrecioCosto.ReadOnly = false;
            lblPrecioCosto.ScrollBars = ScrollBars.None;
            lblPrecioCosto.SelectedText = "";
            lblPrecioCosto.SelectionLength = 0;
            lblPrecioCosto.SelectionStart = 0;
            lblPrecioCosto.ShortcutsEnabled = true;
            lblPrecioCosto.Size = new Size(513, 36);
            lblPrecioCosto.TabIndex = 0;
            lblPrecioCosto.TabStop = false;
            lblPrecioCosto.TextAlign = HorizontalAlignment.Left;
            lblPrecioCosto.UseSystemPasswordChar = false;
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
            // panel3
            // 
            panel3.Controls.Add(tbCodigoProducto);
            panel3.Controls.Add(lblCodigoProducto);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 0, 20, 0);
            panel3.Size = new Size(552, 133);
            panel3.TabIndex = 21;
            // 
            // tbCodigoProducto
            // 
            tbCodigoProducto.AnimateReadOnly = false;
            tbCodigoProducto.AutoCompleteMode = AutoCompleteMode.None;
            tbCodigoProducto.AutoCompleteSource = AutoCompleteSource.None;
            tbCodigoProducto.BackgroundImageLayout = ImageLayout.None;
            tbCodigoProducto.CharacterCasing = CharacterCasing.Normal;
            tbCodigoProducto.Depth = 0;
            tbCodigoProducto.Dock = DockStyle.Fill;
            tbCodigoProducto.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbCodigoProducto.HideSelection = true;
            tbCodigoProducto.LeadingIcon = null;
            tbCodigoProducto.Location = new Point(20, 19);
            tbCodigoProducto.Margin = new Padding(3, 3, 26, 3);
            tbCodigoProducto.MaxLength = 32767;
            tbCodigoProducto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbCodigoProducto.Name = "tbCodigoProducto";
            tbCodigoProducto.Padding = new Padding(9, 8, 9, 8);
            tbCodigoProducto.PasswordChar = '\0';
            tbCodigoProducto.PrefixSuffixText = null;
            tbCodigoProducto.ReadOnly = false;
            tbCodigoProducto.RightToLeft = RightToLeft.No;
            tbCodigoProducto.SelectedText = "";
            tbCodigoProducto.SelectionLength = 0;
            tbCodigoProducto.SelectionStart = 0;
            tbCodigoProducto.ShortcutsEnabled = true;
            tbCodigoProducto.Size = new Size(512, 48);
            tbCodigoProducto.TabIndex = 0;
            tbCodigoProducto.TabStop = false;
            tbCodigoProducto.TextAlign = HorizontalAlignment.Left;
            tbCodigoProducto.TrailingIcon = null;
            tbCodigoProducto.UseSystemPasswordChar = false;
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
            // panel4
            // 
            panel4.Controls.Add(lblCantidad);
            panel4.Controls.Add(materialMultiLineTextBoxEdit1);
            panel4.Location = new Point(0, 67);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(550, 60);
            panel4.TabIndex = 0;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Depth = 0;
            lblCantidad.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblCantidad.Location = new Point(20, 2);
            lblCantidad.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(65, 19);
            lblCantidad.TabIndex = 1;
            lblCantidad.Text = "Cantidad";
            // 
            // materialMultiLineTextBoxEdit1
            // 
            materialMultiLineTextBoxEdit1.AnimateReadOnly = false;
            materialMultiLineTextBoxEdit1.BackgroundImageLayout = ImageLayout.None;
            materialMultiLineTextBoxEdit1.CharacterCasing = CharacterCasing.Normal;
            materialMultiLineTextBoxEdit1.Depth = 0;
            materialMultiLineTextBoxEdit1.HideSelection = true;
            materialMultiLineTextBoxEdit1.Location = new Point(18, 18);
            materialMultiLineTextBoxEdit1.Margin = new Padding(3, 2, 3, 2);
            materialMultiLineTextBoxEdit1.MaxLength = 32767;
            materialMultiLineTextBoxEdit1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialMultiLineTextBoxEdit1.Name = "materialMultiLineTextBoxEdit1";
            materialMultiLineTextBoxEdit1.PasswordChar = '\0';
            materialMultiLineTextBoxEdit1.ReadOnly = false;
            materialMultiLineTextBoxEdit1.ScrollBars = ScrollBars.None;
            materialMultiLineTextBoxEdit1.SelectedText = "";
            materialMultiLineTextBoxEdit1.SelectionLength = 0;
            materialMultiLineTextBoxEdit1.SelectionStart = 0;
            materialMultiLineTextBoxEdit1.ShortcutsEnabled = true;
            materialMultiLineTextBoxEdit1.Size = new Size(512, 36);
            materialMultiLineTextBoxEdit1.TabIndex = 0;
            materialMultiLineTextBoxEdit1.TabStop = false;
            materialMultiLineTextBoxEdit1.TextAlign = HorizontalAlignment.Left;
            materialMultiLineTextBoxEdit1.UseSystemPasswordChar = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tableLayoutPanel1);
            groupBox4.Location = new Point(18, 452);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1110, 96);
            groupBox4.TabIndex = 35;
            groupBox4.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel6, 1, 0);
            tableLayoutPanel1.Controls.Add(panel7, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.Size = new Size(1104, 74);
            tableLayoutPanel1.TabIndex = 29;
            // 
            // panel6
            // 
            panel6.Controls.Add(txtDescuento);
            panel6.Controls.Add(lblDescuento);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(552, 0);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20, 0, 20, 0);
            panel6.Size = new Size(552, 82);
            panel6.TabIndex = 22;
            // 
            // txtDescuento
            // 
            txtDescuento.AnimateReadOnly = false;
            txtDescuento.AutoCompleteMode = AutoCompleteMode.None;
            txtDescuento.AutoCompleteSource = AutoCompleteSource.None;
            txtDescuento.BackgroundImageLayout = ImageLayout.None;
            txtDescuento.CharacterCasing = CharacterCasing.Normal;
            txtDescuento.Depth = 0;
            txtDescuento.Dock = DockStyle.Fill;
            txtDescuento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescuento.HideSelection = true;
            txtDescuento.LeadingIcon = null;
            txtDescuento.Location = new Point(20, 19);
            txtDescuento.Margin = new Padding(3, 3, 26, 3);
            txtDescuento.MaxLength = 32767;
            txtDescuento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Padding = new Padding(9, 8, 9, 8);
            txtDescuento.PasswordChar = '\0';
            txtDescuento.PrefixSuffixText = null;
            txtDescuento.ReadOnly = false;
            txtDescuento.RightToLeft = RightToLeft.No;
            txtDescuento.SelectedText = "";
            txtDescuento.SelectionLength = 0;
            txtDescuento.SelectionStart = 0;
            txtDescuento.ShortcutsEnabled = true;
            txtDescuento.Size = new Size(512, 48);
            txtDescuento.TabIndex = 0;
            txtDescuento.TabStop = false;
            txtDescuento.TextAlign = HorizontalAlignment.Left;
            txtDescuento.TrailingIcon = null;
            txtDescuento.UseSystemPasswordChar = false;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Depth = 0;
            lblDescuento.Dock = DockStyle.Top;
            lblDescuento.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblDescuento.Location = new Point(20, 0);
            lblDescuento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(76, 19);
            lblDescuento.TabIndex = 4;
            lblDescuento.Text = "Descuento";
            // 
            // panel7
            // 
            panel7.Controls.Add(txtSubTotal);
            panel7.Controls.Add(lblSubTotal);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(20, 0, 20, 0);
            panel7.Size = new Size(552, 82);
            panel7.TabIndex = 21;
            // 
            // txtSubTotal
            // 
            txtSubTotal.AnimateReadOnly = false;
            txtSubTotal.AutoCompleteMode = AutoCompleteMode.None;
            txtSubTotal.AutoCompleteSource = AutoCompleteSource.None;
            txtSubTotal.BackgroundImageLayout = ImageLayout.None;
            txtSubTotal.CharacterCasing = CharacterCasing.Normal;
            txtSubTotal.Depth = 0;
            txtSubTotal.Dock = DockStyle.Fill;
            txtSubTotal.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSubTotal.HideSelection = true;
            txtSubTotal.LeadingIcon = null;
            txtSubTotal.Location = new Point(20, 19);
            txtSubTotal.Margin = new Padding(3, 3, 26, 3);
            txtSubTotal.MaxLength = 32767;
            txtSubTotal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Padding = new Padding(9, 8, 9, 8);
            txtSubTotal.PasswordChar = '\0';
            txtSubTotal.PrefixSuffixText = null;
            txtSubTotal.ReadOnly = false;
            txtSubTotal.RightToLeft = RightToLeft.No;
            txtSubTotal.SelectedText = "";
            txtSubTotal.SelectionLength = 0;
            txtSubTotal.SelectionStart = 0;
            txtSubTotal.ShortcutsEnabled = true;
            txtSubTotal.Size = new Size(512, 48);
            txtSubTotal.TabIndex = 0;
            txtSubTotal.TabStop = false;
            txtSubTotal.TextAlign = HorizontalAlignment.Left;
            txtSubTotal.TrailingIcon = null;
            txtSubTotal.UseSystemPasswordChar = false;
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
            lblSubTotal.Size = new Size(66, 19);
            lblSubTotal.TabIndex = 4;
            lblSubTotal.Text = "SubTotal";
            // 
            // materialExpansionPanel1
            // 
            materialExpansionPanel1.BackColor = Color.FromArgb(255, 255, 255);
            materialExpansionPanel1.CancelButtonText = "CANCELAR";
            materialExpansionPanel1.Controls.Add(groupBox4);
            materialExpansionPanel1.Controls.Add(panel2);
            materialExpansionPanel1.Depth = 0;
            materialExpansionPanel1.Description = "Registrar un Nueva Venta";
            materialExpansionPanel1.Dock = DockStyle.Fill;
            materialExpansionPanel1.ExpandHeight = 616;
            materialExpansionPanel1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialExpansionPanel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialExpansionPanel1.Location = new Point(0, 0);
            materialExpansionPanel1.Margin = new Padding(3, 12, 3, 12);
            materialExpansionPanel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialExpansionPanel1.Name = "materialExpansionPanel1";
            materialExpansionPanel1.Padding = new Padding(21, 48, 21, 12);
            materialExpansionPanel1.Size = new Size(1152, 616);
            materialExpansionPanel1.TabIndex = 1;
            materialExpansionPanel1.Title = "Ventas";
            materialExpansionPanel1.ValidationButtonText = "GUARDAR";
            // 
            // UCVentasAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialExpansionPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCVentasAdd";
            Size = new Size(1152, 616);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            materialExpansionPanel1.ResumeLayout(false);
            materialExpansionPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNombreProducto;
        private Panel panel5;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit lblPrecioCosto;
        private ReaLTaiizor.Controls.MaterialLabel lblNombreProducto;
        private Panel panel3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbCodigoProducto;
        private ReaLTaiizor.Controls.MaterialLabel lblCodigoProducto;
        private Panel panel4;
        private ReaLTaiizor.Controls.MaterialLabel lblCantidad;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit materialMultiLineTextBoxEdit1;
        private GroupBox groupBox4;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel6;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDescuento;
        private ReaLTaiizor.Controls.MaterialLabel lblDescuento;
        private Panel panel7;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSubTotal;
        private ReaLTaiizor.Controls.MaterialLabel lblSubTotal;
        private ReaLTaiizor.Controls.MaterialExpansionPanel materialExpansionPanel1;
    }
}
