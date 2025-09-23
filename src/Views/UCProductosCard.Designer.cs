namespace GestionAgraria.Views
{
    partial class UCProductosCard
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
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            lbl_CodigoProducto = new ReaLTaiizor.Controls.MaterialLabel();
            lblStock = new ReaLTaiizor.Controls.MaterialLabel();
            lblNombreProducto = new ReaLTaiizor.Controls.MaterialLabel();
            parrotPictureBox1 = new ReaLTaiizor.Controls.ParrotPictureBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(parrotPictureBox1, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(615, 70);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(lblNombreProducto);
            panel1.Location = new Point(80, 10);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(525, 50);
            panel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(lbl_CodigoProducto, 0, 0);
            tableLayoutPanel2.Controls.Add(lblStock, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(5, 24);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(515, 14);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // lbl_CodigoProducto
            // 
            lbl_CodigoProducto.AutoSize = true;
            lbl_CodigoProducto.Depth = 0;
            lbl_CodigoProducto.Dock = DockStyle.Fill;
            lbl_CodigoProducto.Font = new Font("Roboto", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            lbl_CodigoProducto.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.SubtleEmphasis;
            lbl_CodigoProducto.Location = new Point(3, 0);
            lbl_CodigoProducto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lbl_CodigoProducto.Name = "lbl_CodigoProducto";
            lbl_CodigoProducto.Size = new Size(251, 14);
            lbl_CodigoProducto.TabIndex = 6;
            lbl_CodigoProducto.Text = "Código";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Depth = 0;
            lblStock.Dock = DockStyle.Fill;
            lblStock.Font = new Font("Roboto", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            lblStock.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.SubtleEmphasis;
            lblStock.Location = new Point(260, 0);
            lblStock.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(252, 14);
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
            parrotPictureBox1.Location = new Point(10, 10);
            parrotPictureBox1.Margin = new Padding(10);
            parrotPictureBox1.Name = "parrotPictureBox1";
            parrotPictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox1.Size = new Size(50, 50);
            parrotPictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox1.TabIndex = 2;
            parrotPictureBox1.Text = "parrotPictureBox1";
            parrotPictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // UCProductosCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCProductosCard";
            Size = new Size(615, 70);
            tableLayoutPanel1.ResumeLayout(false);
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
        public ReaLTaiizor.Controls.MaterialLabel lbl_CodigoProducto;
        public ReaLTaiizor.Controls.MaterialLabel lblStock;
        public ReaLTaiizor.Controls.MaterialLabel lblNombreProducto;
    }
}
