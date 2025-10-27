namespace GestionAgraria.Views
{
    partial class UCProductCard
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
            tableLayoutPanel1 = new TableLayoutPanel();
            parrotPictureBox1 = new ReaLTaiizor.Controls.ParrotPictureBox();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblUnitPrice = new ReaLTaiizor.Controls.MaterialLabel();
            lblCode = new ReaLTaiizor.Controls.MaterialLabel();
            lblStock = new ReaLTaiizor.Controls.MaterialLabel();
            lblNombreProducto = new ReaLTaiizor.Controls.MaterialLabel();
            chbProduct = new ReaLTaiizor.Controls.MaterialCheckBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(parrotPictureBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 2, 0);
            tableLayoutPanel1.Controls.Add(chbProduct, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(453, 70);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // parrotPictureBox1
            // 
            parrotPictureBox1.ColorLeft = Color.Black;
            parrotPictureBox1.ColorRight = Color.Black;
            parrotPictureBox1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotPictureBox1.Dock = DockStyle.Fill;
            parrotPictureBox1.FilterAlpha = 200;
            parrotPictureBox1.FilterEnabled = false;
            parrotPictureBox1.Image = Properties.Resources.farm_placeholder;
            parrotPictureBox1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.Low;
            parrotPictureBox1.IsElipse = true;
            parrotPictureBox1.IsParallax = false;
            parrotPictureBox1.Location = new Point(45, 10);
            parrotPictureBox1.Margin = new Padding(10);
            parrotPictureBox1.Name = "parrotPictureBox1";
            parrotPictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox1.Size = new Size(50, 50);
            parrotPictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox1.TabIndex = 5;
            parrotPictureBox1.Text = "parrotPictureBox1";
            parrotPictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(lblNombreProducto);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(115, 10);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(328, 50);
            panel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33444F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3344421F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3311157F));
            tableLayoutPanel2.Controls.Add(lblUnitPrice, 2, 0);
            tableLayoutPanel2.Controls.Add(lblCode, 0, 0);
            tableLayoutPanel2.Controls.Add(lblStock, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(5, 24);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(318, 14);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Depth = 0;
            lblUnitPrice.Dock = DockStyle.Fill;
            lblUnitPrice.Font = new Font("Roboto", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            lblUnitPrice.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.SubtleEmphasis;
            lblUnitPrice.Location = new Point(215, 0);
            lblUnitPrice.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(100, 14);
            lblUnitPrice.TabIndex = 7;
            lblUnitPrice.Text = "Precio Unitario";
            lblUnitPrice.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Depth = 0;
            lblCode.Dock = DockStyle.Fill;
            lblCode.Font = new Font("Roboto", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            lblCode.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.SubtleEmphasis;
            lblCode.Location = new Point(3, 0);
            lblCode.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(100, 14);
            lblCode.TabIndex = 6;
            lblCode.Text = "Código";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Depth = 0;
            lblStock.Dock = DockStyle.Fill;
            lblStock.Font = new Font("Roboto", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            lblStock.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.SubtleEmphasis;
            lblStock.Location = new Point(109, 0);
            lblStock.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(100, 14);
            lblStock.TabIndex = 5;
            lblStock.Text = "Stock";
            lblStock.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Depth = 0;
            lblNombreProducto.Dock = DockStyle.Top;
            lblNombreProducto.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblNombreProducto.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle1;
            lblNombreProducto.Location = new Point(5, 5);
            lblNombreProducto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(150, 19);
            lblNombreProducto.TabIndex = 0;
            lblNombreProducto.Text = "Nombre del Producto";
            // 
            // chbProduct
            // 
            chbProduct.AutoSize = true;
            chbProduct.Depth = 0;
            chbProduct.Dock = DockStyle.Fill;
            chbProduct.Location = new Point(0, 0);
            chbProduct.Margin = new Padding(0);
            chbProduct.MouseLocation = new Point(-1, -1);
            chbProduct.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            chbProduct.Name = "chbProduct";
            chbProduct.ReadOnly = false;
            chbProduct.Ripple = true;
            chbProduct.Size = new Size(35, 70);
            chbProduct.TabIndex = 8;
            chbProduct.UseAccentColor = false;
            chbProduct.UseVisualStyleBackColor = true;
            chbProduct.CheckedChanged += chbProduct_CheckedChanged;
            // 
            // UCProductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(250, 70);
            Name = "UCProductCard";
            Size = new Size(453, 70);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        public ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        public ReaLTaiizor.Controls.MaterialLabel lblCode;
        public ReaLTaiizor.Controls.MaterialLabel lblStock;
        public ReaLTaiizor.Controls.MaterialLabel lblNombreProducto;
        private ReaLTaiizor.Controls.MaterialCheckBox chbProduct;
        public ReaLTaiizor.Controls.MaterialLabel lblUnitPrice;
    }
}
