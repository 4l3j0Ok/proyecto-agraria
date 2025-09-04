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
            materialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            materialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabHome = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            tcPrincipal = new ReaLTaiizor.Controls.MaterialTabControl();
            tabAnimalArea = new TabPage();
            tabIndustryArea = new TabPage();
            materialTabControl2 = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            tabVegetablesArea.SuspendLayout();
            materialTabControl1.SuspendLayout();
            tabHome.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            tcPrincipal.SuspendLayout();
            tabAnimalArea.SuspendLayout();
            materialTabControl2.SuspendLayout();
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
            imgList.Images.SetKeyName(5, "Chancho (2).png");
            imgList.Images.SetKeyName(6, "Gallina.png");
            imgList.Images.SetKeyName(7, "Vaca (2).png");
            imgList.Images.SetKeyName(8, "Abeja (2).png");
            imgList.Images.SetKeyName(9, "Conejo (2).png");
            // 
            // tabUsers
            // 
            tabUsers.Controls.Add(dataGridView1);
            tabUsers.ImageKey = "user.png";
            tabUsers.Location = new Point(4, 29);
            tabUsers.Margin = new Padding(4);
            tabUsers.Name = "tabUsers";
            tabUsers.Size = new Size(1546, 643);
            tabUsers.TabIndex = 3;
            tabUsers.Text = "Usuarios";
            tabUsers.UseVisualStyleBackColor = true;
            // 
            // tabVegetablesArea
            // 
            tabVegetablesArea.Controls.Add(materialTabControl1);
            tabVegetablesArea.ImageKey = "vegetable-area.png";
            tabVegetablesArea.Location = new Point(4, 29);
            tabVegetablesArea.Margin = new Padding(4);
            tabVegetablesArea.Name = "tabVegetablesArea";
            tabVegetablesArea.Size = new Size(1546, 643);
            tabVegetablesArea.TabIndex = 2;
            tabVegetablesArea.Text = "Vegetales";
            tabVegetablesArea.UseVisualStyleBackColor = true;
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = imgList;
            materialTabControl1.Location = new Point(0, 0);
            materialTabControl1.Margin = new Padding(4);
            materialTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1546, 643);
            materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.ImageKey = "user.png";
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(1538, 610);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(1538, 610);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabHome
            // 
            tabHome.Controls.Add(tableLayoutPanel1);
            tabHome.ImageKey = "home.png";
            tabHome.Location = new Point(4, 29);
            tabHome.Margin = new Padding(4);
            tabHome.Name = "tabHome";
            tabHome.Padding = new Padding(4);
            tabHome.Size = new Size(1546, 643);
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
            tableLayoutPanel1.Location = new Point(4, 4);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 76.4976959F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.5023041F));
            tableLayoutPanel1.Size = new Size(1538, 635);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.home;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(25, 25);
            pictureBox1.Margin = new Padding(25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1488, 435);
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
            materialLabel1.Location = new Point(4, 485);
            materialLabel1.Margin = new Padding(4, 0, 4, 0);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(1530, 150);
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
            tcPrincipal.Location = new Point(4, 80);
            tcPrincipal.Margin = new Padding(4);
            tcPrincipal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tcPrincipal.Multiline = true;
            tcPrincipal.Name = "tcPrincipal";
            tcPrincipal.SelectedIndex = 0;
            tcPrincipal.Size = new Size(1554, 676);
            tcPrincipal.TabIndex = 0;
            tcPrincipal.SelectedIndexChanged += tcPrincipal_SelectedIndexChanged;
            // 
            // tabAnimalArea
            // 
            tabAnimalArea.Controls.Add(materialTabControl2);
            tabAnimalArea.ImageKey = "animal-area.png";
            tabAnimalArea.Location = new Point(4, 29);
            tabAnimalArea.Margin = new Padding(4);
            tabAnimalArea.Name = "tabAnimalArea";
            tabAnimalArea.Size = new Size(1546, 643);
            tabAnimalArea.TabIndex = 5;
            tabAnimalArea.Text = "Animales";
            tabAnimalArea.UseVisualStyleBackColor = true;
            // 
            // tabIndustryArea
            // 
            tabIndustryArea.ImageKey = "industry-area.png";
            tabIndustryArea.Location = new Point(4, 29);
            tabIndustryArea.Margin = new Padding(4);
            tabIndustryArea.Name = "tabIndustryArea";
            tabIndustryArea.Size = new Size(1546, 643);
            tabIndustryArea.TabIndex = 4;
            tabIndustryArea.Text = "Industria";
            tabIndustryArea.UseVisualStyleBackColor = true;
            // 
            // materialTabControl2
            // 
            materialTabControl2.Controls.Add(tabPage3);
            materialTabControl2.Controls.Add(tabPage4);
            materialTabControl2.Controls.Add(tabPage5);
            materialTabControl2.Controls.Add(tabPage6);
            materialTabControl2.Controls.Add(tabPage7);
            materialTabControl2.Depth = 0;
            materialTabControl2.Dock = DockStyle.Fill;
            materialTabControl2.ImageList = imgList;
            materialTabControl2.Location = new Point(0, 0);
            materialTabControl2.Margin = new Padding(4);
            materialTabControl2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialTabControl2.Multiline = true;
            materialTabControl2.Name = "materialTabControl2";
            materialTabControl2.SelectedIndex = 0;
            materialTabControl2.Size = new Size(1546, 643);
            materialTabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.ImageKey = "Vaca (2).png";
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(4);
            tabPage3.Size = new Size(1538, 610);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Bovinos";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.ImageKey = "Chancho (2).png";
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(4);
            tabPage4.Size = new Size(1538, 610);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Cerdos";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.ImageKey = "Conejo (2).png";
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1538, 610);
            tabPage5.TabIndex = 2;
            tabPage5.Text = "Conejos";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.ImageKey = "Gallina.png";
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(1538, 610);
            tabPage6.TabIndex = 3;
            tabPage6.Text = "Pollos";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.ImageKey = "Abeja (2).png";
            tabPage7.Location = new Point(4, 29);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(1538, 610);
            tabPage7.TabIndex = 4;
            tabPage7.Text = "Abejas";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1562, 760);
            Controls.Add(tcPrincipal);
            DrawerHighlightWithAccent = false;
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = tcPrincipal;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormPrincipal";
            Padding = new Padding(4, 80, 4, 4);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión Agraria";
            Load += FormPrincipal_Load;
            tabUsers.ResumeLayout(false);
            tabVegetablesArea.ResumeLayout(false);
            materialTabControl1.ResumeLayout(false);
            tabHome.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            tcPrincipal.ResumeLayout(false);
            tabAnimalArea.ResumeLayout(false);
            materialTabControl2.ResumeLayout(false);
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
        private ReaLTaiizor.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private ReaLTaiizor.Controls.MaterialTabControl materialTabControl2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
    }
}