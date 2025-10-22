namespace GestionAgraria.Views
{
    partial class UCVegetableCard
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
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            tableLayoutPanel1 = new TableLayoutPanel();
            parrotPictureBox1 = new ReaLTaiizor.Controls.ParrotPictureBox();
            panel1 = new Panel();
            lblPlantQuantity = new ReaLTaiizor.Controls.MaterialLabel();
            lblPlantType = new ReaLTaiizor.Controls.MaterialLabel();
            materialCard1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(tableLayoutPanel1);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Fill;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(0, 0);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(10);
            materialCard1.Size = new Size(453, 70);
            materialCard1.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(parrotPictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(433, 50);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // parrotPictureBox1
            // 
            parrotPictureBox1.BackColor = Color.Transparent;
            parrotPictureBox1.ColorLeft = Color.Transparent;
            parrotPictureBox1.ColorRight = Color.Transparent;
            parrotPictureBox1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotPictureBox1.FilterAlpha = 200;
            parrotPictureBox1.FilterEnabled = false;
            parrotPictureBox1.ForeColor = SystemColors.ActiveBorder;
            parrotPictureBox1.Image = Properties.Resources.vegetable_placeholder;
            parrotPictureBox1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotPictureBox1.IsElipse = true;
            parrotPictureBox1.IsParallax = false;
            parrotPictureBox1.Location = new Point(3, 2);
            parrotPictureBox1.Margin = new Padding(3, 2, 3, 2);
            parrotPictureBox1.Name = "parrotPictureBox1";
            parrotPictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox1.Size = new Size(44, 46);
            parrotPictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox1.TabIndex = 9;
            parrotPictureBox1.Text = "parrotPictureBox1";
            parrotPictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblPlantQuantity);
            panel1.Controls.Add(lblPlantType);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(50, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(383, 50);
            panel1.TabIndex = 8;
            // 
            // lblPlantQuantity
            // 
            lblPlantQuantity.AutoSize = true;
            lblPlantQuantity.Depth = 0;
            lblPlantQuantity.Dock = DockStyle.Fill;
            lblPlantQuantity.Font = new Font("Roboto", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            lblPlantQuantity.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.SubtleEmphasis;
            lblPlantQuantity.Location = new Point(5, 24);
            lblPlantQuantity.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblPlantQuantity.Name = "lblPlantQuantity";
            lblPlantQuantity.Size = new Size(51, 14);
            lblPlantQuantity.TabIndex = 6;
            lblPlantQuantity.Text = "Cantidad";
            lblPlantQuantity.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPlantType
            // 
            lblPlantType.AutoSize = true;
            lblPlantType.Depth = 0;
            lblPlantType.Dock = DockStyle.Top;
            lblPlantType.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblPlantType.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle1;
            lblPlantType.Location = new Point(5, 5);
            lblPlantType.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblPlantType.Name = "lblPlantType";
            lblPlantType.Size = new Size(104, 19);
            lblPlantType.TabIndex = 0;
            lblPlantType.Text = "Tipo de Planta";
            // 
            // UCVegetableCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(materialCard1);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(250, 70);
            Name = "UCVegetableCard";
            Size = new Size(250, 70);
            materialCard1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox1;
        private Panel panel1;
        public ReaLTaiizor.Controls.MaterialLabel lblPlantQuantity;
        public ReaLTaiizor.Controls.MaterialLabel lblPlantType;
    }
}
