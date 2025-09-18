namespace GestionAgraria.Views
{
    partial class UCVegetalCard
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
            lblTipoPlanta = new ReaLTaiizor.Controls.MaterialLabel();
            parrotPictureBox1 = new ReaLTaiizor.Controls.ParrotPictureBox();
            lblCantidad = new ReaLTaiizor.Controls.MaterialLabel();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(lblTipoPlanta);
            panel1.Location = new Point(90, 13);
            panel1.Margin = new Padding(11, 13, 11, 13);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(6, 7, 6, 7);
            panel1.Size = new Size(602, 67);
            panel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(lblCantidad, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(6, 26);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(590, 14);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // lblTipoPlanta
            // 
            lblTipoPlanta.AutoSize = true;
            lblTipoPlanta.Depth = 0;
            lblTipoPlanta.Dock = DockStyle.Top;
            lblTipoPlanta.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTipoPlanta.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle1;
            lblTipoPlanta.Location = new Point(6, 7);
            lblTipoPlanta.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblTipoPlanta.Name = "lblTipoPlanta";
            lblTipoPlanta.Size = new Size(104, 19);
            lblTipoPlanta.TabIndex = 0;
            lblTipoPlanta.Text = "Tipo de Planta";
            // 
            // parrotPictureBox1
            // 
            parrotPictureBox1.BackColor = SystemColors.Control;
            parrotPictureBox1.ColorLeft = Color.Gray;
            parrotPictureBox1.ColorRight = Color.Gray;
            parrotPictureBox1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotPictureBox1.FilterAlpha = 200;
            parrotPictureBox1.FilterEnabled = true;
            parrotPictureBox1.ForeColor = SystemColors.ActiveBorder;
            parrotPictureBox1.Image = Properties.Resources.Vegetales;
            parrotPictureBox1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotPictureBox1.IsElipse = false;
            parrotPictureBox1.IsParallax = false;
            parrotPictureBox1.Location = new Point(9, 8);
            parrotPictureBox1.Name = "parrotPictureBox1";
            parrotPictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox1.Size = new Size(73, 76);
            parrotPictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox1.TabIndex = 5;
            parrotPictureBox1.Text = "parrotPictureBox1";
            parrotPictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Depth = 0;
            lblCantidad.Dock = DockStyle.Fill;
            lblCantidad.Font = new Font("Roboto", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            lblCantidad.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.SubtleEmphasis;
            lblCantidad.Location = new Point(298, 0);
            lblCantidad.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(289, 14);
            lblCantidad.TabIndex = 5;
            lblCantidad.Text = "Cantidad";
            lblCantidad.TextAlign = ContentAlignment.TopCenter;
            // 
            // UCVegetalCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(parrotPictureBox1);
            Controls.Add(panel1);
            Name = "UCVegetalCard";
            Size = new Size(703, 93);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        public ReaLTaiizor.Controls.MaterialLabel lblTipoPlanta;
        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox1;
        public ReaLTaiizor.Controls.MaterialLabel lblCantidad;
    }
}
