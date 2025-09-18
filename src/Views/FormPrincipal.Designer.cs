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
            btnAddUser = new ReaLTaiizor.Controls.MaterialFloatingActionButton();
            tabVegetablesArea = new TabPage();
            btnAddPlanta = new ReaLTaiizor.Controls.MaterialFloatingActionButton();
            tabHome = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            lblWelcome = new ReaLTaiizor.Controls.MaterialLabel();
            tcPrincipal = new ReaLTaiizor.Controls.MaterialTabControl();
            tabAnimalArea = new TabPage();
            btnAddAnimal = new ReaLTaiizor.Controls.MaterialFloatingActionButton();
            tabIndustryArea = new TabPage();
            tcIndustrias = new TabControl();
            tabProduct = new TabPage();
            btnAddProduct = new ReaLTaiizor.Controls.MaterialFloatingActionButton();
            tabCompras = new TabPage();
            btnAddCompras = new ReaLTaiizor.Controls.MaterialFloatingActionButton();
            tabVentas = new TabPage();
            btnAddVentas = new ReaLTaiizor.Controls.MaterialFloatingActionButton();
            tabEntorno = new TabPage();
            btnAddEntorno = new ReaLTaiizor.Controls.MaterialFloatingActionButton();
            tabUsers.SuspendLayout();
            tabVegetablesArea.SuspendLayout();
            tabHome.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            tcPrincipal.SuspendLayout();
            tabAnimalArea.SuspendLayout();
            tabIndustryArea.SuspendLayout();
            tcIndustrias.SuspendLayout();
            tabProduct.SuspendLayout();
            tabCompras.SuspendLayout();
            tabVentas.SuspendLayout();
            tabEntorno.SuspendLayout();
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
            imgList.Images.SetKeyName(10, "userGroup.png");
            // 
            // tabUsers
            // 
            tabUsers.AutoScroll = true;
            tabUsers.Controls.Add(btnAddUser);
            tabUsers.ImageKey = "user.png";
            tabUsers.Location = new Point(4, 24);
            tabUsers.Name = "tabUsers";
            tabUsers.Padding = new Padding(20);
            tabUsers.Size = new Size(786, 505);
            tabUsers.TabIndex = 3;
            tabUsers.Text = "Usuarios";
            tabUsers.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            btnAddUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddUser.Depth = 0;
            btnAddUser.Icon = Properties.Resources.add_user;
            btnAddUser.Location = new Point(707, 426);
            btnAddUser.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(56, 56);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "Agregar Usuario";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // tabVegetablesArea
            // 
            tabVegetablesArea.Controls.Add(btnAddPlanta);
            tabVegetablesArea.ImageKey = "vegetable-area.png";
            tabVegetablesArea.Location = new Point(4, 24);
            tabVegetablesArea.Name = "tabVegetablesArea";
            tabVegetablesArea.Padding = new Padding(20);
            tabVegetablesArea.Size = new Size(786, 505);
            tabVegetablesArea.TabIndex = 2;
            tabVegetablesArea.Text = "Vegetales";
            tabVegetablesArea.UseVisualStyleBackColor = true;
            // 
            // btnAddPlanta
            // 
            btnAddPlanta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddPlanta.Depth = 0;
            btnAddPlanta.Icon = Properties.Resources.add_user;
            btnAddPlanta.Location = new Point(707, 426);
            btnAddPlanta.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAddPlanta.Name = "btnAddPlanta";
            btnAddPlanta.Size = new Size(56, 56);
            btnAddPlanta.TabIndex = 18;
            btnAddPlanta.Text = "Agregar Planta";
            btnAddPlanta.UseVisualStyleBackColor = true;
            btnAddPlanta.Click += btnAddPlanta_Click;
            // 
            // tabHome
            // 
            tabHome.Controls.Add(tableLayoutPanel1);
            tabHome.ImageKey = "home.png";
            tabHome.Location = new Point(4, 24);
            tabHome.Name = "tabHome";
            tabHome.Padding = new Padding(20);
            tabHome.Size = new Size(786, 505);
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
            tableLayoutPanel1.Controls.Add(lblWelcome, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(20, 20);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 76.4976959F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.5023041F));
            tableLayoutPanel1.Size = new Size(746, 465);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.home;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(20, 20);
            pictureBox1.Margin = new Padding(20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(706, 315);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Depth = 0;
            lblWelcome.Dock = DockStyle.Top;
            lblWelcome.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblWelcome.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H4;
            lblWelcome.Location = new Point(3, 355);
            lblWelcome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(740, 41);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Bienvenido a Gestión Agraria";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tcPrincipal
            // 
            tcPrincipal.Controls.Add(tabHome);
            tcPrincipal.Controls.Add(tabVegetablesArea);
            tcPrincipal.Controls.Add(tabAnimalArea);
            tcPrincipal.Controls.Add(tabIndustryArea);
            tcPrincipal.Controls.Add(tabUsers);
            tcPrincipal.Controls.Add(tabEntorno);
            tcPrincipal.Depth = 0;
            tcPrincipal.Dock = DockStyle.Fill;
            tcPrincipal.ImageList = imgList;
            tcPrincipal.Location = new Point(3, 64);
            tcPrincipal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tcPrincipal.Multiline = true;
            tcPrincipal.Name = "tcPrincipal";
            tcPrincipal.SelectedIndex = 0;
            tcPrincipal.Size = new Size(794, 533);
            tcPrincipal.TabIndex = 0;
            tcPrincipal.SelectedIndexChanged += tcPrincipal_SelectedIndexChanged;
            // 
            // tabAnimalArea
            // 
            tabAnimalArea.Controls.Add(btnAddAnimal);
            tabAnimalArea.ImageKey = "animal-area.png";
            tabAnimalArea.Location = new Point(4, 24);
            tabAnimalArea.Name = "tabAnimalArea";
            tabAnimalArea.Padding = new Padding(20);
            tabAnimalArea.Size = new Size(786, 505);
            tabAnimalArea.TabIndex = 5;
            tabAnimalArea.Text = "Animales";
            tabAnimalArea.UseVisualStyleBackColor = true;
            // 
            // btnAddAnimal
            // 
            btnAddAnimal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddAnimal.Depth = 0;
            btnAddAnimal.Icon = Properties.Resources.add_user;
            btnAddAnimal.Location = new Point(707, 426);
            btnAddAnimal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAddAnimal.Name = "btnAddAnimal";
            btnAddAnimal.Size = new Size(56, 56);
            btnAddAnimal.TabIndex = 16;
            btnAddAnimal.Text = "Agregar Animal";
            btnAddAnimal.UseVisualStyleBackColor = true;
            btnAddAnimal.Click += btnAddAnimal_Click;
            // 
            // tabIndustryArea
            // 
            tabIndustryArea.BackColor = Color.White;
            tabIndustryArea.Controls.Add(tcIndustrias);
            tabIndustryArea.ImageKey = "industry-area.png";
            tabIndustryArea.Location = new Point(4, 24);
            tabIndustryArea.Name = "tabIndustryArea";
            tabIndustryArea.Size = new Size(786, 505);
            tabIndustryArea.TabIndex = 4;
            tabIndustryArea.Text = "Industria";
            // 
            // tcIndustrias
            // 
            tcIndustrias.Controls.Add(tabProduct);
            tcIndustrias.Controls.Add(tabCompras);
            tcIndustrias.Controls.Add(tabVentas);
            tcIndustrias.Dock = DockStyle.Fill;
            tcIndustrias.Location = new Point(0, 0);
            tcIndustrias.Name = "tcIndustrias";
            tcIndustrias.SelectedIndex = 0;
            tcIndustrias.Size = new Size(786, 505);
            tcIndustrias.TabIndex = 2;
            // 
            // tabProduct
            // 
            tabProduct.Controls.Add(btnAddProduct);
            tabProduct.Location = new Point(4, 24);
            tabProduct.Name = "tabProduct";
            tabProduct.Padding = new Padding(17);
            tabProduct.Size = new Size(778, 477);
            tabProduct.TabIndex = 0;
            tabProduct.Text = "Productos";
            tabProduct.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddProduct.Depth = 0;
            btnAddProduct.Icon = Properties.Resources.add_user;
            btnAddProduct.Location = new Point(702, 401);
            btnAddProduct.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(56, 56);
            btnAddProduct.TabIndex = 2;
            btnAddProduct.Text = "Agregar Producto";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click_1;
            // 
            // tabCompras
            // 
            tabCompras.Controls.Add(btnAddCompras);
            tabCompras.Location = new Point(4, 24);
            tabCompras.Name = "tabCompras";
            tabCompras.Padding = new Padding(17);
            tabCompras.Size = new Size(778, 477);
            tabCompras.TabIndex = 1;
            tabCompras.Text = "Compras";
            tabCompras.UseVisualStyleBackColor = true;
            // 
            // btnAddCompras
            // 
            btnAddCompras.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddCompras.Depth = 0;
            btnAddCompras.Icon = Properties.Resources.add_user;
            btnAddCompras.Location = new Point(702, 401);
            btnAddCompras.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAddCompras.Name = "btnAddCompras";
            btnAddCompras.Size = new Size(56, 56);
            btnAddCompras.TabIndex = 3;
            btnAddCompras.Text = "Agregar Producto";
            btnAddCompras.UseVisualStyleBackColor = true;
            btnAddCompras.Click += btnAddCompras_Click;
            // 
            // tabVentas
            // 
            tabVentas.Controls.Add(btnAddVentas);
            tabVentas.Location = new Point(4, 24);
            tabVentas.Name = "tabVentas";
            tabVentas.Padding = new Padding(17);
            tabVentas.Size = new Size(778, 477);
            tabVentas.TabIndex = 2;
            tabVentas.Text = "Ventas";
            tabVentas.UseVisualStyleBackColor = true;
            // 
            // btnAddVentas
            // 
            btnAddVentas.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddVentas.Depth = 0;
            btnAddVentas.Icon = Properties.Resources.add_user;
            btnAddVentas.Location = new Point(702, 401);
            btnAddVentas.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAddVentas.Name = "btnAddVentas";
            btnAddVentas.Size = new Size(56, 56);
            btnAddVentas.TabIndex = 4;
            btnAddVentas.Text = "Agregar Producto";
            btnAddVentas.UseVisualStyleBackColor = true;
            btnAddVentas.Click += btnAddVentas_Click;
            // 
            // tabEntorno
            // 
            tabEntorno.Controls.Add(btnAddEntorno);
            tabEntorno.ImageKey = "userGroup.png";
            tabEntorno.Location = new Point(4, 24);
            tabEntorno.Name = "tabEntorno";
            tabEntorno.Padding = new Padding(3);
            tabEntorno.Size = new Size(786, 505);
            tabEntorno.TabIndex = 6;
            tabEntorno.Text = "Entornos";
            tabEntorno.UseVisualStyleBackColor = true;
            // 
            // btnAddEntorno
            // 
            btnAddEntorno.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddEntorno.Depth = 0;
            btnAddEntorno.Icon = Properties.Resources.add_user;
            btnAddEntorno.Location = new Point(707, 426);
            btnAddEntorno.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAddEntorno.Name = "btnAddEntorno";
            btnAddEntorno.Size = new Size(56, 56);
            btnAddEntorno.TabIndex = 14;
            btnAddEntorno.Text = "Agregar Usuario";
            btnAddEntorno.UseVisualStyleBackColor = true;
            btnAddEntorno.Click += btnAddEntorno_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            BackColor = Color.FromArgb(238, 238, 238);
            ClientSize = new Size(800, 600);
            Controls.Add(tcPrincipal);
            DrawerHighlightWithAccent = false;
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = tcPrincipal;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 600);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión Agraria";
            Load += FormPrincipal_Load;
            tabUsers.ResumeLayout(false);
            tabVegetablesArea.ResumeLayout(false);
            tabHome.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            tcPrincipal.ResumeLayout(false);
            tabAnimalArea.ResumeLayout(false);
            tabIndustryArea.ResumeLayout(false);
            tcIndustrias.ResumeLayout(false);
            tabProduct.ResumeLayout(false);
            tabCompras.ResumeLayout(false);
            tabVentas.ResumeLayout(false);
            tabEntorno.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ImageList imgList;
        private TabPage tabUsers;
        private TabPage tabVegetablesArea;
        private TabPage tabHome;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.MaterialLabel lblWelcome;
        private ReaLTaiizor.Controls.MaterialTabControl tcPrincipal;
        private TabPage tabIndustryArea;
        private TabPage tabAnimalArea;
        private DataGridView dataGridView1;
        private ReaLTaiizor.Controls.MaterialFloatingActionButton btnAddUser;
        private TabPage tabEntorno;
        private ReaLTaiizor.Controls.MaterialFloatingActionButton btnAddEntorno;
        private ReaLTaiizor.Controls.MaterialFloatingActionButton btnAddAnimal;
        private ReaLTaiizor.Controls.MaterialFloatingActionButton btnAddPlanta;
        private TabControl tcIndustrias;
        private TabPage tabProduct;
        private TabPage tabCompras;
        private ReaLTaiizor.Controls.MaterialFloatingActionButton btnAddProduct;
        private TabPage tabVentas;
        private ReaLTaiizor.Controls.MaterialFloatingActionButton btnAddCompras;
        private ReaLTaiizor.Controls.MaterialFloatingActionButton btnAddVentas;
    }
}