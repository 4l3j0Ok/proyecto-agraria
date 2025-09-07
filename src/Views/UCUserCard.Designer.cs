namespace GestionAgraria.Views
{
    partial class UCUserCard
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
            parrotPictureBox1 = new ReaLTaiizor.Controls.ParrotPictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            lblUserArea = new ReaLTaiizor.Controls.MaterialLabel();
            lblUserName = new ReaLTaiizor.Controls.MaterialLabel();
            tableLayoutPanel2 = new TableLayoutPanel();
            materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            btnEdit = new ReaLTaiizor.Controls.MaterialButton();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // parrotPictureBox1
            // 
            parrotPictureBox1.ColorLeft = Color.Black;
            parrotPictureBox1.ColorRight = Color.Black;
            parrotPictureBox1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotPictureBox1.Dock = DockStyle.Fill;
            parrotPictureBox1.FilterAlpha = 200;
            parrotPictureBox1.FilterEnabled = false;
            parrotPictureBox1.Image = Properties.Resources.user_placeholder;
            parrotPictureBox1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.Low;
            parrotPictureBox1.IsElipse = true;
            parrotPictureBox1.IsParallax = false;
            parrotPictureBox1.Location = new Point(10, 10);
            parrotPictureBox1.Margin = new Padding(10);
            parrotPictureBox1.Name = "parrotPictureBox1";
            parrotPictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox1.Size = new Size(50, 50);
            parrotPictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox1.TabIndex = 1;
            parrotPictureBox1.Text = "parrotPictureBox1";
            parrotPictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel1.Controls.Add(parrotPictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.MaximumSize = new Size(0, 120);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(615, 70);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblUserArea);
            panel1.Controls.Add(lblUserName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(80, 10);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(275, 50);
            panel1.TabIndex = 2;
            // 
            // lblUserArea
            // 
            lblUserArea.AutoSize = true;
            lblUserArea.Depth = 0;
            lblUserArea.Dock = DockStyle.Top;
            lblUserArea.Font = new Font("Roboto", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            lblUserArea.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.SubtleEmphasis;
            lblUserArea.Location = new Point(5, 24);
            lblUserArea.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblUserArea.Name = "lblUserArea";
            lblUserArea.Size = new Size(25, 14);
            lblUserArea.TabIndex = 1;
            lblUserArea.Text = "Área";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Depth = 0;
            lblUserName.Dock = DockStyle.Top;
            lblUserName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblUserName.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle1;
            lblUserName.Location = new Point(5, 5);
            lblUserName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(118, 19);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Nombre Apellido";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(materialButton1, 1, 0);
            tableLayoutPanel2.Controls.Add(btnEdit, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(368, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(5);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(244, 64);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.Dock = DockStyle.Fill;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = Properties.Resources.delete;
            materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton1.Location = new Point(126, 11);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.RightToLeft = RightToLeft.No;
            materialButton1.Size = new Size(109, 42);
            materialButton1.TabIndex = 5;
            materialButton1.Text = "Eliminar";
            materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = true;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEdit.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEdit.Depth = 0;
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.HighEmphasis = true;
            btnEdit.Icon = Properties.Resources.edit;
            btnEdit.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEdit.Location = new Point(9, 11);
            btnEdit.Margin = new Padding(4, 6, 4, 6);
            btnEdit.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEdit.Name = "btnEdit";
            btnEdit.NoAccentTextColor = Color.Empty;
            btnEdit.RightToLeft = RightToLeft.No;
            btnEdit.Size = new Size(109, 42);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Editar";
            btnEdit.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEdit.UseAccentColor = false;
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // UCUserCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Cursor = Cursors.Hand;
            MaximumSize = new Size(0, 70);
            MinimumSize = new Size(615, 70);
            Name = "UCUserCard";
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
        private Panel panel1;
        public ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox1;
        public ReaLTaiizor.Controls.MaterialLabel lblUserArea;
        public ReaLTaiizor.Controls.MaterialLabel lblUserName;
        private TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private ReaLTaiizor.Controls.MaterialButton btnEdit;
    }
}
