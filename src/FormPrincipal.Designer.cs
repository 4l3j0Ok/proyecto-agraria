using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Forms;

namespace GestionAgraria
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormPrincipal));
            imgList = new ImageList(components);
            tabUsers = new TabPage();
            tabVegetablesArea = new TabPage();
            tsEFVegetables = new ReaLTaiizor.Controls.MaterialTabSelector();
            tcEFVegetables = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabHome = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            tcPrincipal = new ReaLTaiizor.Controls.MaterialTabControl();
            tabAnimalArea = new TabPage();
            pictureBox2 = new PictureBox();
            tabIndustryArea = new TabPage();
            tabVegetablesArea.SuspendLayout();
            tcEFVegetables.SuspendLayout();
            tabHome.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            tcPrincipal.SuspendLayout();
            tabAnimalArea.SuspendLayout();
            ((ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // imgList
            // 
            imgList.ColorDepth = ColorDepth.Depth32Bit;
            imgList.ImageStream = (ImageListStreamer)resources.GetObject("imgList.ImageStream");
            imgList.TransparentColor = Color.Transparent;
            imgList.Images.SetKeyName(0, "home.png");
            imgList.Images.SetKeyName(1, "user.png");
            imgList.Images.SetKeyName(2, "vegetable-area.png");
            imgList.Images.SetKeyName(3, "animal-area.png");
            imgList.Images.SetKeyName(4, "industry-area.png");
            // 
            // tabUsers
            // 
            tabUsers.ImageKey = "user.png";
            tabUsers.Location = new Point(4, 24);
            tabUsers.Name = "tabUsers";
            tabUsers.Size = new Size(1236, 513);
            tabUsers.TabIndex = 3;
            tabUsers.Text = "Usuarios";
            tabUsers.UseVisualStyleBackColor = true;
            // 
            // tabVegetablesArea
            // 
            tabVegetablesArea.Controls.Add(tsEFVegetables);
            tabVegetablesArea.Controls.Add(tcEFVegetables);
            tabVegetablesArea.ImageKey = "vegetable-area.png";
            tabVegetablesArea.Location = new Point(4, 24);
            tabVegetablesArea.Name = "tabVegetablesArea";
            tabVegetablesArea.Size = new Size(1236, 513);
            tabVegetablesArea.TabIndex = 2;
            tabVegetablesArea.Text = "Vegetales";
            tabVegetablesArea.UseVisualStyleBackColor = true;
            // 
            // tsEFVegetables
            // 
            tsEFVegetables.BaseTabControl = tcEFVegetables;
            tsEFVegetables.CharacterCasing = ReaLTaiizor.Controls.MaterialTabSelector.CustomCharacterCasing.Proper;
            tsEFVegetables.Depth = 0;
            tsEFVegetables.Dock = DockStyle.Top;
            tsEFVegetables.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            tsEFVegetables.HeadAlignment = ReaLTaiizor.Controls.MaterialTabSelector.Alignment.Left;
            tsEFVegetables.Location = new Point(0, 0);
            tsEFVegetables.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tsEFVegetables.Name = "tsEFVegetables";
            tsEFVegetables.Size = new Size(1236, 48);
            tsEFVegetables.TabIndex = 1;
            tsEFVegetables.Text = "tsEFVegetables";
            // 
            // tcEFVegetables
            // 
            tcEFVegetables.Controls.Add(tabPage1);
            tcEFVegetables.Controls.Add(tabPage2);
            tcEFVegetables.Depth = 0;
            tcEFVegetables.Location = new Point(12, 54);
            tcEFVegetables.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tcEFVegetables.Multiline = true;
            tcEFVegetables.Name = "tcEFVegetables";
            tcEFVegetables.SelectedIndex = 0;
            tcEFVegetables.Size = new Size(1111, 424);
            tcEFVegetables.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1103, 396);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Huerta";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1103, 396);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Vivero";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabHome
            // 
            tabHome.Controls.Add(tableLayoutPanel1);
            tabHome.ImageKey = "home.png";
            tabHome.Location = new Point(4, 24);
            tabHome.Name = "tabHome";
            tabHome.Padding = new Padding(3);
            tabHome.Size = new Size(1236, 513);
            tabHome.TabIndex = 0;
            tabHome.Text = "Inicio";
            tabHome.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(238, 238, 238);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(materialLabel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 76.4976959F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.5023041F));
            tableLayoutPanel1.Size = new Size(1230, 507);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(20, 20);
            pictureBox1.Margin = new Padding(20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1190, 347);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Dock = DockStyle.Fill;
            materialLabel1.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H3;
            materialLabel1.Location = new Point(3, 387);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(1224, 120);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Bienvenido a Gestión Agraria";
            materialLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tcPrincipal
            // 
            tcPrincipal.Controls.Add(tabHome);
            tcPrincipal.Controls.Add(tabVegetablesArea);
            tcPrincipal.Controls.Add(tabAnimalArea);
            tcPrincipal.Controls.Add(tabIndustryArea);
            tcPrincipal.Controls.Add(tabUsers);
            tcPrincipal.Depth = 0;
            tcPrincipal.Dock = DockStyle.Fill;
            tcPrincipal.ImageList = imgList;
            tcPrincipal.Location = new Point(3, 64);
            tcPrincipal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tcPrincipal.Multiline = true;
            tcPrincipal.Name = "tcPrincipal";
            tcPrincipal.SelectedIndex = 0;
            tcPrincipal.Size = new Size(1244, 541);
            tcPrincipal.TabIndex = 0;
            tcPrincipal.SelectedIndexChanged += tcPrincipal_SelectedIndexChanged;
            // 
            // tabAnimalArea
            // 
            tabAnimalArea.Controls.Add(pictureBox2);
            tabAnimalArea.ImageKey = "animal-area.png";
            tabAnimalArea.Location = new Point(4, 24);
            tabAnimalArea.Name = "tabAnimalArea";
            tabAnimalArea.Size = new Size(1236, 513);
            tabAnimalArea.TabIndex = 5;
            tabAnimalArea.Text = "Animales";
            tabAnimalArea.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Animales_removebg_preview;
            pictureBox2.Location = new Point(3, 382);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(210, 143);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // tabIndustryArea
            // 
            tabIndustryArea.ImageKey = "industry-area.png";
            tabIndustryArea.Location = new Point(4, 24);
            tabIndustryArea.Name = "tabIndustryArea";
            tabIndustryArea.Size = new Size(1236, 513);
            tabIndustryArea.TabIndex = 4;
            tabIndustryArea.Text = "Industria";
            tabIndustryArea.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1250, 608);
            Controls.Add(tcPrincipal);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = tcPrincipal;
            DrawerUseColors = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión Agraria";
            Load += FormPrincipal_Load;
            tabVegetablesArea.ResumeLayout(false);
            tcEFVegetables.ResumeLayout(false);
            tabHome.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            tcPrincipal.ResumeLayout(false);
            tabAnimalArea.ResumeLayout(false);
            ((ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imgList;
        private TabPage tabUsers;
        private TabPage tabVegetablesArea;
        private TabPage tabHome;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialTabControl tcPrincipal;
        private TabPage tabIndustryArea;
        private TabPage tabAnimalArea;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.MaterialTabControl tcEFVegetables;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ReaLTaiizor.Controls.MaterialTabSelector tsEFVegetables;
    }
}