namespace GestionAgraria.Views
{
    partial class UCActivityRecordCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCActivityRecordCard));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            lblObservation = new ReaLTaiizor.Controls.MaterialLabel();
            panel1 = new Panel();
            lblFecha = new ReaLTaiizor.Controls.MaterialLabel();
            lblTitle = new ReaLTaiizor.Controls.MaterialLabel();
            parrotPictureBox1 = new ReaLTaiizor.Controls.ParrotPictureBox();
            lblStateRecord = new ReaLTaiizor.Controls.MaterialLabel();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 491F));
            tableLayoutPanel1.Controls.Add(panel2, 2, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(parrotPictureBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.MaximumSize = new Size(800, 70);
            tableLayoutPanel1.MinimumSize = new Size(400, 70);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(745, 70);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblStateRecord);
            panel2.Controls.Add(lblObservation);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(264, 10);
            panel2.Margin = new Padding(10);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20);
            panel2.Size = new Size(471, 50);
            panel2.TabIndex = 10;
            // 
            // lblObservation
            // 
            lblObservation.AutoSize = true;
            lblObservation.Depth = 0;
            lblObservation.Font = new Font("Roboto", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            lblObservation.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.SubtleEmphasis;
            lblObservation.Location = new Point(9, 24);
            lblObservation.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblObservation.Name = "lblObservation";
            lblObservation.Size = new Size(64, 14);
            lblObservation.TabIndex = 7;
            lblObservation.Text = "Descripcion";
            lblObservation.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(80, 10);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(164, 50);
            panel1.TabIndex = 7;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Depth = 0;
            lblFecha.Dock = DockStyle.Fill;
            lblFecha.Font = new Font("Roboto", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            lblFecha.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.SubtleEmphasis;
            lblFecha.Location = new Point(5, 24);
            lblFecha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(34, 14);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha";
            lblFecha.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Depth = 0;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTitle.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle1;
            lblTitle.Location = new Point(5, 5);
            lblTitle.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(132, 19);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Titulo de actividad";
            // 
            // parrotPictureBox1
            // 
            parrotPictureBox1.ColorLeft = Color.DodgerBlue;
            parrotPictureBox1.ColorRight = Color.DodgerBlue;
            parrotPictureBox1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.Default;
            parrotPictureBox1.Dock = DockStyle.Fill;
            parrotPictureBox1.FilterAlpha = 200;
            parrotPictureBox1.FilterEnabled = false;
            parrotPictureBox1.Image = (Image)resources.GetObject("parrotPictureBox1.Image");
            parrotPictureBox1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotPictureBox1.IsElipse = false;
            parrotPictureBox1.IsParallax = false;
            parrotPictureBox1.Location = new Point(3, 3);
            parrotPictureBox1.Name = "parrotPictureBox1";
            parrotPictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox1.Size = new Size(64, 64);
            parrotPictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox1.TabIndex = 8;
            parrotPictureBox1.Text = "parrotPictureBox1";
            parrotPictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // lblStateRecord
            // 
            lblStateRecord.AutoSize = true;
            lblStateRecord.Depth = 0;
            lblStateRecord.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblStateRecord.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle1;
            lblStateRecord.Location = new Point(9, 5);
            lblStateRecord.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblStateRecord.Name = "lblStateRecord";
            lblStateRecord.Size = new Size(140, 19);
            lblStateRecord.TabIndex = 8;
            lblStateRecord.Text = "Estado de actividad";
            // 
            // UCActivityRecordCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UCActivityRecordCard";
            Size = new Size(745, 73);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        public ReaLTaiizor.Controls.MaterialLabel lblFecha;
        public ReaLTaiizor.Controls.MaterialLabel lblTitle;
        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox1;
        private Panel panel2;
        public ReaLTaiizor.Controls.MaterialLabel lblObservation;
        public ReaLTaiizor.Controls.MaterialLabel lblStateRecord;
    }
}
