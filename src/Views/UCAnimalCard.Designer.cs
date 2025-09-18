namespace GestionAgraria.Views
{
    partial class UCAnimalCard
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
            lbl_Codigo = new ReaLTaiizor.Controls.MaterialLabel();
            lblEProductivo = new ReaLTaiizor.Controls.MaterialLabel();
            lblEspecie = new ReaLTaiizor.Controls.MaterialLabel();
            parrotPictureBox1 = new ReaLTaiizor.Controls.ParrotPictureBox();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(lblEspecie);
            panel1.Location = new Point(79, 10);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(527, 50);
            panel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(lbl_Codigo, 0, 0);
            tableLayoutPanel2.Controls.Add(lblEProductivo, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(5, 24);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(517, 14);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // lbl_Codigo
            // 
            lbl_Codigo.AutoSize = true;
            lbl_Codigo.Depth = 0;
            lbl_Codigo.Dock = DockStyle.Fill;
            lbl_Codigo.Font = new Font("Roboto", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            lbl_Codigo.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.SubtleEmphasis;
            lbl_Codigo.Location = new Point(3, 0);
            lbl_Codigo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lbl_Codigo.Name = "lbl_Codigo";
            lbl_Codigo.Size = new Size(252, 14);
            lbl_Codigo.TabIndex = 6;
            lbl_Codigo.Text = "Código";
            // 
            // lblEProductivo
            // 
            lblEProductivo.AutoSize = true;
            lblEProductivo.Depth = 0;
            lblEProductivo.Dock = DockStyle.Fill;
            lblEProductivo.Font = new Font("Roboto", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            lblEProductivo.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.SubtleEmphasis;
            lblEProductivo.Location = new Point(261, 0);
            lblEProductivo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblEProductivo.Name = "lblEProductivo";
            lblEProductivo.Size = new Size(253, 14);
            lblEProductivo.TabIndex = 5;
            lblEProductivo.Text = "Entorno Productivo";
            lblEProductivo.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblEspecie
            // 
            lblEspecie.AutoSize = true;
            lblEspecie.Depth = 0;
            lblEspecie.Dock = DockStyle.Top;
            lblEspecie.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblEspecie.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle1;
            lblEspecie.Location = new Point(5, 5);
            lblEspecie.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(55, 19);
            lblEspecie.TabIndex = 0;
            lblEspecie.Text = "Especie";
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
            parrotPictureBox1.Image = Properties.Resources.Animales2;
            parrotPictureBox1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotPictureBox1.IsElipse = false;
            parrotPictureBox1.IsParallax = false;
            parrotPictureBox1.Location = new Point(6, 6);
            parrotPictureBox1.Margin = new Padding(3, 2, 3, 2);
            parrotPictureBox1.Name = "parrotPictureBox1";
            parrotPictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox1.Size = new Size(64, 57);
            parrotPictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox1.TabIndex = 4;
            parrotPictureBox1.Text = "parrotPictureBox1";
            parrotPictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // UCAnimalCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(parrotPictureBox1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCAnimalCard";
            Size = new Size(615, 70);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        public ReaLTaiizor.Controls.MaterialLabel lbl_Codigo;
        public ReaLTaiizor.Controls.MaterialLabel lblEProductivo;
        public ReaLTaiizor.Controls.MaterialLabel lblEspecie;
        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox1;
    }
}
