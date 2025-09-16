using GestionAgraria.data;
using GestionAgraria.models;
using GestionAgraria.Views;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

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
            tableLayoutPanel2 = new TableLayoutPanel();
            lblUserUsername = new ReaLTaiizor.Controls.MaterialLabel();
            lblUserPhone = new ReaLTaiizor.Controls.MaterialLabel();
            lblUserArea = new ReaLTaiizor.Controls.MaterialLabel();
            lblUserName = new ReaLTaiizor.Controls.MaterialLabel();
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
            parrotPictureBox1.Location = new Point(11, 13);
            parrotPictureBox1.Margin = new Padding(11, 13, 11, 13);
            parrotPictureBox1.Name = "parrotPictureBox1";
            parrotPictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox1.Size = new Size(57, 67);
            parrotPictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox1.TabIndex = 1;
            parrotPictureBox1.Text = "parrotPictureBox1";
            parrotPictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.Controls.Add(parrotPictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.MaximumSize = new Size(0, 160);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(703, 93);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(lblUserName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(90, 13);
            panel1.Margin = new Padding(11, 13, 11, 13);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(6, 7, 6, 7);
            panel1.Size = new Size(602, 67);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(lblUserUsername, 0, 0);
            tableLayoutPanel2.Controls.Add(lblUserPhone, 2, 0);
            tableLayoutPanel2.Controls.Add(lblUserArea, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(6, 26);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(590, 14);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // lblUserUsername
            // 
            lblUserUsername.AutoSize = true;
            lblUserUsername.Depth = 0;
            lblUserUsername.Dock = DockStyle.Fill;
            lblUserUsername.Font = new Font("Roboto", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            lblUserUsername.FontType = MaterialSkinManager.FontType.SubtleEmphasis;
            lblUserUsername.Location = new Point(3, 0);
            lblUserUsername.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblUserUsername.Name = "lblUserUsername";
            lblUserUsername.Size = new Size(190, 14);
            lblUserUsername.TabIndex = 6;
            lblUserUsername.Text = "Nombre de usuario";
            // 
            // lblUserPhone
            // 
            lblUserPhone.AutoSize = true;
            lblUserPhone.Depth = 0;
            lblUserPhone.Dock = DockStyle.Fill;
            lblUserPhone.Font = new Font("Roboto", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            lblUserPhone.FontType = MaterialSkinManager.FontType.SubtleEmphasis;
            lblUserPhone.Location = new Point(395, 0);
            lblUserPhone.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblUserPhone.Name = "lblUserPhone";
            lblUserPhone.Size = new Size(192, 14);
            lblUserPhone.TabIndex = 4;
            lblUserPhone.Text = "Teléfono";
            lblUserPhone.TextAlign = ContentAlignment.TopRight;
            // 
            // lblUserArea
            // 
            lblUserArea.AutoSize = true;
            lblUserArea.Depth = 0;
            lblUserArea.Dock = DockStyle.Fill;
            lblUserArea.Font = new Font("Roboto", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            lblUserArea.FontType = MaterialSkinManager.FontType.SubtleEmphasis;
            lblUserArea.Location = new Point(199, 0);
            lblUserArea.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblUserArea.Name = "lblUserArea";
            lblUserArea.Size = new Size(190, 14);
            lblUserArea.TabIndex = 5;
            lblUserArea.Text = "Área";
            lblUserArea.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Depth = 0;
            lblUserName.Dock = DockStyle.Top;
            lblUserName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblUserName.FontType = MaterialSkinManager.FontType.Subtitle1;
            lblUserName.Location = new Point(6, 7);
            lblUserName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(118, 19);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Nombre Apellido";
            // 
            // UCUserCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Cursor = Cursors.Hand;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(0, 93);
            MinimumSize = new Size(703, 93);
            Name = "UCUserCard";
            Size = new Size(703, 93);
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
        public ReaLTaiizor.Controls.MaterialLabel lblUserName;
        private TableLayoutPanel tableLayoutPanel2;
        public ReaLTaiizor.Controls.MaterialLabel lblUserPhone;
        public ReaLTaiizor.Controls.MaterialLabel lblUserUsername;
        public ReaLTaiizor.Controls.MaterialLabel lblUserArea;
    }
}
