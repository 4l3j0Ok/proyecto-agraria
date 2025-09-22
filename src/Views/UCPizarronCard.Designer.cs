namespace GestionAgraria.Views
{
    partial class UCPizarronCard
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
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblFecha = new ReaLTaiizor.Controls.MaterialLabel();
            lblProcedimientos = new ReaLTaiizor.Controls.MaterialLabel();
            parrotPictureBox1 = new ReaLTaiizor.Controls.ParrotPictureBox();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(lblProcedimientos);
            panel1.Location = new Point(77, 10);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(527, 50);
            panel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(lblFecha, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(5, 24);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(517, 14);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Depth = 0;
            lblFecha.Dock = DockStyle.Fill;
            lblFecha.Font = new Font("Roboto", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            lblFecha.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.SubtleEmphasis;
            lblFecha.Location = new Point(261, 0);
            lblFecha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(253, 14);
            lblFecha.TabIndex = 5;
            lblFecha.Text = "Fecha";
            lblFecha.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblProcedimientos
            // 
            lblProcedimientos.AutoSize = true;
            lblProcedimientos.Depth = 0;
            lblProcedimientos.Dock = DockStyle.Top;
            lblProcedimientos.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblProcedimientos.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle1;
            lblProcedimientos.Location = new Point(5, 5);
            lblProcedimientos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblProcedimientos.Name = "lblProcedimientos";
            lblProcedimientos.Size = new Size(111, 19);
            lblProcedimientos.TabIndex = 0;
            lblProcedimientos.Text = "Procedimientos";
            // 
            // parrotPictureBox1
            // 
            parrotPictureBox1.ColorLeft = Color.Black;
            parrotPictureBox1.ColorRight = Color.Black;
            parrotPictureBox1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotPictureBox1.FilterAlpha = 200;
            parrotPictureBox1.FilterEnabled = false;
            parrotPictureBox1.Image = Properties.Resources.user_placeholder;
            parrotPictureBox1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotPictureBox1.IsElipse = true;
            parrotPictureBox1.IsParallax = false;
            parrotPictureBox1.Location = new Point(8, 6);
            parrotPictureBox1.Margin = new Padding(3, 2, 3, 2);
            parrotPictureBox1.Name = "parrotPictureBox1";
            parrotPictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox1.Size = new Size(62, 58);
            parrotPictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox1.TabIndex = 6;
            parrotPictureBox1.Text = "parrotPictureBox1";
            parrotPictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // UCPizarronCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(parrotPictureBox1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCPizarronCard";
            Size = new Size(613, 68);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        public ReaLTaiizor.Controls.MaterialLabel lblProcedimientos;
        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox1;
        public ReaLTaiizor.Controls.MaterialLabel lblFecha;
    }
}
