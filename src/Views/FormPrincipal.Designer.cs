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
            lblEmptyUsers = new ReaLTaiizor.Controls.MaterialLabel();
            flpUsersList = new FlowLayoutPanel();
            tabVegetablesArea = new TabPage();
            btnAddPlanta = new ReaLTaiizor.Controls.MaterialFloatingActionButton();
            lblEmptyVegetables = new ReaLTaiizor.Controls.MaterialLabel();
            flpVegetalList = new FlowLayoutPanel();
            tabHome = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            lblWelcome = new ReaLTaiizor.Controls.MaterialLabel();
            tcPrincipal = new ReaLTaiizor.Controls.MaterialTabControl();
            tabAnimalArea = new TabPage();
            btnAddAnimal = new ReaLTaiizor.Controls.MaterialFloatingActionButton();
            lblEmptyAnimals = new ReaLTaiizor.Controls.MaterialLabel();
            flpAnimalsList = new FlowLayoutPanel();
            tabIndustryArea = new TabPage();
            tcIndustrias = new TabControl();
            tabProduct = new TabPage();
            btnAddProduct = new ReaLTaiizor.Controls.MaterialFloatingActionButton();
            lblEmptyProducts = new ReaLTaiizor.Controls.MaterialLabel();
            tabCompras = new TabPage();
            btnAddCompras = new ReaLTaiizor.Controls.MaterialFloatingActionButton();
            lblEmptyPurchases = new ReaLTaiizor.Controls.MaterialLabel();
            tabVentas = new TabPage();
            btnAddVentas = new ReaLTaiizor.Controls.MaterialFloatingActionButton();
            lblEmptySells = new ReaLTaiizor.Controls.MaterialLabel();
            tabEntorno = new TabPage();
            btnAddEntorno = new ReaLTaiizor.Controls.MaterialFloatingActionButton();
            lblEmptyFormativeEnvironments = new ReaLTaiizor.Controls.MaterialLabel();
            flpFormativeEnvironmentsList = new FlowLayoutPanel();
            tabBlackBoard = new TabPage();
            btnAddBlackBoard = new ReaLTaiizor.Controls.MaterialFloatingActionButton();
            lblEmptyBlackBoards = new ReaLTaiizor.Controls.MaterialLabel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            tabCerrarSesion = new TabPage();
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
            tabBlackBoard.SuspendLayout();
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
            imgList.Images.SetKeyName(11, "pizarron.png");
            imgList.Images.SetKeyName(12, "cerrar-sesion.png");
            // 
            // tabUsers
            // 
            tabUsers.AutoScroll = true;
            tabUsers.Controls.Add(btnAddUser);
            tabUsers.Controls.Add(lblEmptyUsers);
            tabUsers.Controls.Add(flpUsersList);
            tabUsers.ImageKey = "user.png";
            tabUsers.Location = new Point(4, 39);
            tabUsers.Name = "tabUsers";
            tabUsers.Padding = new Padding(20);
            tabUsers.Size = new Size(936, 490);
            tabUsers.TabIndex = 3;
            tabUsers.Text = "Usuarios";
            tabUsers.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            btnAddUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddUser.Depth = 0;
            btnAddUser.Icon = Properties.Resources.add;
            btnAddUser.Location = new Point(877, 431);
            btnAddUser.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(56, 56);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "Agregar Usuario";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // lblEmptyUsers
            // 
            lblEmptyUsers.Depth = 0;
            lblEmptyUsers.Dock = DockStyle.Fill;
            lblEmptyUsers.FlatStyle = FlatStyle.Flat;
            lblEmptyUsers.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblEmptyUsers.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            lblEmptyUsers.Location = new Point(20, 20);
            lblEmptyUsers.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblEmptyUsers.Name = "lblEmptyUsers";
            lblEmptyUsers.Size = new Size(896, 450);
            lblEmptyUsers.TabIndex = 5;
            lblEmptyUsers.Text = "Aún no tienes usuarios agregados... Comienza por agregar uno.";
            lblEmptyUsers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flpUsersList
            // 
            flpUsersList.Dock = DockStyle.Fill;
            flpUsersList.Location = new Point(20, 20);
            flpUsersList.Name = "flpUsersList";
            flpUsersList.Size = new Size(896, 450);
            flpUsersList.TabIndex = 1;
            // 
            // tabVegetablesArea
            // 
            tabVegetablesArea.Controls.Add(btnAddPlanta);
            tabVegetablesArea.Controls.Add(lblEmptyVegetables);
            tabVegetablesArea.Controls.Add(flpVegetalList);
            tabVegetablesArea.ImageKey = "vegetable-area.png";
            tabVegetablesArea.Location = new Point(4, 39);
            tabVegetablesArea.Name = "tabVegetablesArea";
            tabVegetablesArea.Padding = new Padding(20);
            tabVegetablesArea.Size = new Size(936, 490);
            tabVegetablesArea.TabIndex = 2;
            tabVegetablesArea.Text = "Vegetales";
            tabVegetablesArea.UseVisualStyleBackColor = true;
            // 
            // btnAddPlanta
            // 
            btnAddPlanta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddPlanta.Depth = 0;
            btnAddPlanta.Icon = Properties.Resources.add_user;
            btnAddPlanta.Location = new Point(877, 431);
            btnAddPlanta.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAddPlanta.Name = "btnAddPlanta";
            btnAddPlanta.Size = new Size(56, 56);
            btnAddPlanta.TabIndex = 18;
            btnAddPlanta.Text = "Agregar Planta";
            btnAddPlanta.UseVisualStyleBackColor = true;
            btnAddPlanta.Click += btnAddPlanta_Click;
            // 
            // lblEmptyVegetables
            // 
            lblEmptyVegetables.Depth = 0;
            lblEmptyVegetables.Dock = DockStyle.Fill;
            lblEmptyVegetables.FlatStyle = FlatStyle.Flat;
            lblEmptyVegetables.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblEmptyVegetables.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            lblEmptyVegetables.Location = new Point(20, 20);
            lblEmptyVegetables.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblEmptyVegetables.Name = "lblEmptyVegetables";
            lblEmptyVegetables.Size = new Size(896, 450);
            lblEmptyVegetables.TabIndex = 1;
            lblEmptyVegetables.Text = "Aún no tienes vegetales agregados... Comienza por agregar uno.";
            lblEmptyVegetables.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flpVegetalList
            // 
            flpVegetalList.Dock = DockStyle.Fill;
            flpVegetalList.Location = new Point(20, 20);
            flpVegetalList.Name = "flpVegetalList";
            flpVegetalList.Size = new Size(896, 450);
            flpVegetalList.TabIndex = 19;
            // 
            // tabHome
            // 
            tabHome.Controls.Add(tableLayoutPanel1);
            tabHome.ImageKey = "home.png";
            tabHome.Location = new Point(4, 39);
            tabHome.Name = "tabHome";
            tabHome.Padding = new Padding(20);
            tabHome.Size = new Size(936, 490);
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
            tableLayoutPanel1.Size = new Size(896, 450);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.homeImage;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(20, 20);
            pictureBox1.Margin = new Padding(20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(856, 304);
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
            lblWelcome.Location = new Point(3, 344);
            lblWelcome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(890, 41);
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
            tcPrincipal.Controls.Add(tabBlackBoard);
            tcPrincipal.Controls.Add(tabCerrarSesion);
            tcPrincipal.Depth = 0;
            tcPrincipal.Dock = DockStyle.Fill;
            tcPrincipal.ImageList = imgList;
            tcPrincipal.ItemSize = new Size(120, 35);
            tcPrincipal.Location = new Point(3, 64);
            tcPrincipal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tcPrincipal.Multiline = true;
            tcPrincipal.Name = "tcPrincipal";
            tcPrincipal.Padding = new Point(10, 3);
            tcPrincipal.SelectedIndex = 0;
            tcPrincipal.Size = new Size(944, 533);
            tcPrincipal.TabIndex = 0;
            // 
            // tabAnimalArea
            // 
            tabAnimalArea.Controls.Add(btnAddAnimal);
            tabAnimalArea.Controls.Add(lblEmptyAnimals);
            tabAnimalArea.Controls.Add(flpAnimalsList);
            tabAnimalArea.ImageKey = "animal-area.png";
            tabAnimalArea.Location = new Point(4, 39);
            tabAnimalArea.Name = "tabAnimalArea";
            tabAnimalArea.Padding = new Padding(20);
            tabAnimalArea.Size = new Size(936, 490);
            tabAnimalArea.TabIndex = 5;
            tabAnimalArea.Text = "Animales";
            tabAnimalArea.UseVisualStyleBackColor = true;
            // 
            // btnAddAnimal
            // 
            btnAddAnimal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddAnimal.Depth = 0;
            btnAddAnimal.Icon = Properties.Resources.add;
            btnAddAnimal.Location = new Point(877, 431);
            btnAddAnimal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAddAnimal.Name = "btnAddAnimal";
            btnAddAnimal.Size = new Size(56, 56);
            btnAddAnimal.TabIndex = 16;
            btnAddAnimal.Text = "Agregar Animal";
            btnAddAnimal.UseVisualStyleBackColor = true;
            btnAddAnimal.Click += btnAddAnimal_Click;
            // 
            // lblEmptyAnimals
            // 
            lblEmptyAnimals.Depth = 0;
            lblEmptyAnimals.Dock = DockStyle.Fill;
            lblEmptyAnimals.FlatStyle = FlatStyle.Flat;
            lblEmptyAnimals.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblEmptyAnimals.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            lblEmptyAnimals.Location = new Point(20, 20);
            lblEmptyAnimals.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblEmptyAnimals.Name = "lblEmptyAnimals";
            lblEmptyAnimals.Size = new Size(896, 450);
            lblEmptyAnimals.TabIndex = 18;
            lblEmptyAnimals.Text = "Aún no tienes animales agregados... Comienza por agregar uno.";
            lblEmptyAnimals.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flpAnimalsList
            // 
            flpAnimalsList.Dock = DockStyle.Fill;
            flpAnimalsList.Location = new Point(20, 20);
            flpAnimalsList.Name = "flpAnimalsList";
            flpAnimalsList.Size = new Size(896, 450);
            flpAnimalsList.TabIndex = 17;
            // 
            // tabIndustryArea
            // 
            tabIndustryArea.BackColor = Color.White;
            tabIndustryArea.Controls.Add(tcIndustrias);
            tabIndustryArea.ImageKey = "industry-area.png";
            tabIndustryArea.Location = new Point(4, 39);
            tabIndustryArea.Name = "tabIndustryArea";
            tabIndustryArea.Padding = new Padding(20);
            tabIndustryArea.Size = new Size(936, 490);
            tabIndustryArea.TabIndex = 4;
            tabIndustryArea.Text = "Industria";
            // 
            // tcIndustrias
            // 
            tcIndustrias.Controls.Add(tabProduct);
            tcIndustrias.Controls.Add(tabCompras);
            tcIndustrias.Controls.Add(tabVentas);
            tcIndustrias.Dock = DockStyle.Fill;
            tcIndustrias.Location = new Point(20, 20);
            tcIndustrias.Name = "tcIndustrias";
            tcIndustrias.SelectedIndex = 0;
            tcIndustrias.Size = new Size(896, 450);
            tcIndustrias.TabIndex = 2;
            // 
            // tabProduct
            // 
            tabProduct.Controls.Add(btnAddProduct);
            tabProduct.Controls.Add(lblEmptyProducts);
            tabProduct.Location = new Point(4, 24);
            tabProduct.Name = "tabProduct";
            tabProduct.Padding = new Padding(17);
            tabProduct.Size = new Size(888, 422);
            tabProduct.TabIndex = 0;
            tabProduct.Text = "Productos";
            tabProduct.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddProduct.Depth = 0;
            btnAddProduct.Icon = Properties.Resources.add;
            btnAddProduct.Location = new Point(812, 346);
            btnAddProduct.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(56, 56);
            btnAddProduct.TabIndex = 3;
            btnAddProduct.Text = "Agregar Usuario";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // lblEmptyProducts
            // 
            lblEmptyProducts.Depth = 0;
            lblEmptyProducts.Dock = DockStyle.Fill;
            lblEmptyProducts.FlatStyle = FlatStyle.Flat;
            lblEmptyProducts.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblEmptyProducts.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            lblEmptyProducts.Location = new Point(17, 17);
            lblEmptyProducts.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblEmptyProducts.Name = "lblEmptyProducts";
            lblEmptyProducts.Size = new Size(854, 388);
            lblEmptyProducts.TabIndex = 2;
            lblEmptyProducts.Text = "Aún no tienes productos agregados... Comienza por agregar uno.";
            lblEmptyProducts.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabCompras
            // 
            tabCompras.Controls.Add(btnAddCompras);
            tabCompras.Controls.Add(lblEmptyPurchases);
            tabCompras.Location = new Point(4, 24);
            tabCompras.Name = "tabCompras";
            tabCompras.Padding = new Padding(17);
            tabCompras.Size = new Size(888, 422);
            tabCompras.TabIndex = 1;
            tabCompras.Text = "Compras";
            tabCompras.UseVisualStyleBackColor = true;
            // 
            // btnAddCompras
            // 
            btnAddCompras.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddCompras.Depth = 0;
            btnAddCompras.Icon = Properties.Resources.add;
            btnAddCompras.Location = new Point(812, 346);
            btnAddCompras.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAddCompras.Name = "btnAddCompras";
            btnAddCompras.Size = new Size(56, 56);
            btnAddCompras.TabIndex = 3;
            btnAddCompras.Text = "Agregar Producto";
            btnAddCompras.UseVisualStyleBackColor = true;
            btnAddCompras.Click += btnAddCompras_Click;
            // 
            // lblEmptyPurchases
            // 
            lblEmptyPurchases.Depth = 0;
            lblEmptyPurchases.Dock = DockStyle.Fill;
            lblEmptyPurchases.FlatStyle = FlatStyle.Flat;
            lblEmptyPurchases.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblEmptyPurchases.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            lblEmptyPurchases.Location = new Point(17, 17);
            lblEmptyPurchases.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblEmptyPurchases.Name = "lblEmptyPurchases";
            lblEmptyPurchases.Size = new Size(854, 388);
            lblEmptyPurchases.TabIndex = 4;
            lblEmptyPurchases.Text = "Aún no tienes compras registradas... Comienza por agregar una.";
            lblEmptyPurchases.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabVentas
            // 
            tabVentas.Controls.Add(btnAddVentas);
            tabVentas.Controls.Add(lblEmptySells);
            tabVentas.Location = new Point(4, 24);
            tabVentas.Name = "tabVentas";
            tabVentas.Padding = new Padding(17);
            tabVentas.Size = new Size(888, 422);
            tabVentas.TabIndex = 2;
            tabVentas.Text = "Ventas";
            tabVentas.UseVisualStyleBackColor = true;
            // 
            // btnAddVentas
            // 
            btnAddVentas.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddVentas.Depth = 0;
            btnAddVentas.Icon = Properties.Resources.add;
            btnAddVentas.Location = new Point(813, 346);
            btnAddVentas.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAddVentas.Name = "btnAddVentas";
            btnAddVentas.Size = new Size(56, 56);
            btnAddVentas.TabIndex = 4;
            btnAddVentas.Text = "Agregar Producto";
            btnAddVentas.UseVisualStyleBackColor = true;
            btnAddVentas.Click += btnAddVentas_Click;
            // 
            // lblEmptySells
            // 
            lblEmptySells.Depth = 0;
            lblEmptySells.Dock = DockStyle.Fill;
            lblEmptySells.FlatStyle = FlatStyle.Flat;
            lblEmptySells.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblEmptySells.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            lblEmptySells.Location = new Point(17, 17);
            lblEmptySells.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblEmptySells.Name = "lblEmptySells";
            lblEmptySells.Size = new Size(854, 388);
            lblEmptySells.TabIndex = 5;
            lblEmptySells.Text = "Aún no tienes ventas registradas... Comienza por agregar una.";
            lblEmptySells.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabEntorno
            // 
            tabEntorno.Controls.Add(btnAddEntorno);
            tabEntorno.Controls.Add(lblEmptyFormativeEnvironments);
            tabEntorno.Controls.Add(flpFormativeEnvironmentsList);
            tabEntorno.ImageKey = "userGroup.png";
            tabEntorno.Location = new Point(4, 39);
            tabEntorno.Name = "tabEntorno";
            tabEntorno.Padding = new Padding(20);
            tabEntorno.Size = new Size(936, 490);
            tabEntorno.TabIndex = 6;
            tabEntorno.Text = "Entornos";
            tabEntorno.UseVisualStyleBackColor = true;
            // 
            // btnAddEntorno
            // 
            btnAddEntorno.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddEntorno.Depth = 0;
            btnAddEntorno.Icon = Properties.Resources.add;
            btnAddEntorno.Location = new Point(877, 431);
            btnAddEntorno.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAddEntorno.Name = "btnAddEntorno";
            btnAddEntorno.Size = new Size(56, 56);
            btnAddEntorno.TabIndex = 14;
            btnAddEntorno.Text = "Agregar Usuario";
            btnAddEntorno.UseVisualStyleBackColor = true;
            btnAddEntorno.Click += btnAddEntorno_Click;
            // 
            // lblEmptyFormativeEnvironments
            // 
            lblEmptyFormativeEnvironments.Depth = 0;
            lblEmptyFormativeEnvironments.Dock = DockStyle.Fill;
            lblEmptyFormativeEnvironments.FlatStyle = FlatStyle.Flat;
            lblEmptyFormativeEnvironments.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblEmptyFormativeEnvironments.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            lblEmptyFormativeEnvironments.Location = new Point(20, 20);
            lblEmptyFormativeEnvironments.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblEmptyFormativeEnvironments.Name = "lblEmptyFormativeEnvironments";
            lblEmptyFormativeEnvironments.Size = new Size(896, 450);
            lblEmptyFormativeEnvironments.TabIndex = 16;
            lblEmptyFormativeEnvironments.Text = "Aún no tienes entornos formativos agregados... Comienza por agregar uno.";
            lblEmptyFormativeEnvironments.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flpFormativeEnvironmentsList
            // 
            flpFormativeEnvironmentsList.Dock = DockStyle.Fill;
            flpFormativeEnvironmentsList.Location = new Point(20, 20);
            flpFormativeEnvironmentsList.Name = "flpFormativeEnvironmentsList";
            flpFormativeEnvironmentsList.Size = new Size(896, 450);
            flpFormativeEnvironmentsList.TabIndex = 15;
            // 
            // tabBlackBoard
            // 
            tabBlackBoard.Controls.Add(btnAddBlackBoard);
            tabBlackBoard.Controls.Add(lblEmptyBlackBoards);
            tabBlackBoard.Controls.Add(flowLayoutPanel4);
            tabBlackBoard.ImageKey = "pizarron.png";
            tabBlackBoard.Location = new Point(4, 39);
            tabBlackBoard.Margin = new Padding(2);
            tabBlackBoard.Name = "tabBlackBoard";
            tabBlackBoard.Padding = new Padding(20);
            tabBlackBoard.Size = new Size(936, 490);
            tabBlackBoard.TabIndex = 7;
            tabBlackBoard.Text = "Pizarrón";
            tabBlackBoard.UseVisualStyleBackColor = true;
            // 
            // btnAddBlackBoard
            // 
            btnAddBlackBoard.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddBlackBoard.Depth = 0;
            btnAddBlackBoard.Icon = Properties.Resources.add;
            btnAddBlackBoard.Location = new Point(877, 431);
            btnAddBlackBoard.Margin = new Padding(10);
            btnAddBlackBoard.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAddBlackBoard.Name = "btnAddBlackBoard";
            btnAddBlackBoard.Size = new Size(56, 56);
            btnAddBlackBoard.TabIndex = 6;
            btnAddBlackBoard.Text = "materialFloatingActionButton1";
            btnAddBlackBoard.UseVisualStyleBackColor = true;
            btnAddBlackBoard.Click += btnAddBlackBoard_Click;
            // 
            // lblEmptyBlackBoards
            // 
            lblEmptyBlackBoards.Depth = 0;
            lblEmptyBlackBoards.Dock = DockStyle.Fill;
            lblEmptyBlackBoards.FlatStyle = FlatStyle.Flat;
            lblEmptyBlackBoards.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblEmptyBlackBoards.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            lblEmptyBlackBoards.Location = new Point(20, 20);
            lblEmptyBlackBoards.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblEmptyBlackBoards.Name = "lblEmptyBlackBoards";
            lblEmptyBlackBoards.Size = new Size(896, 450);
            lblEmptyBlackBoards.TabIndex = 8;
            lblEmptyBlackBoards.Text = "Aún no tienes pizzarrones agregados... Comienza por agregar uno.";
            lblEmptyBlackBoards.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.Location = new Point(20, 20);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(896, 450);
            flowLayoutPanel4.TabIndex = 2;
            // 
            // tabCerrarSesion
            // 
            tabCerrarSesion.ImageKey = "cerrar-sesion.png";
            tabCerrarSesion.Location = new Point(4, 39);
            tabCerrarSesion.Name = "tabCerrarSesion";
            tabCerrarSesion.Padding = new Padding(3);
            tabCerrarSesion.Size = new Size(936, 490);
            tabCerrarSesion.TabIndex = 8;
            tabCerrarSesion.Text = "Cerrar Sesión";
            tabCerrarSesion.UseVisualStyleBackColor = true;
            tabCerrarSesion.Enter += tabCerrarSesion_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(950, 600);
            Controls.Add(tcPrincipal);
            DrawerAutoShow = true;
            DrawerHighlightWithAccent = false;
            DrawerIsOpen = true;
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
            tabBlackBoard.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ImageList imgList;
        public TabPage tabVegetablesArea;
        private TabPage tabHome;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.MaterialLabel lblWelcome;
        private TabPage tabIndustryArea;
        public TabPage tabAnimalArea;
        private DataGridView dataGridView1;
        private ReaLTaiizor.Controls.MaterialFloatingActionButton btnAddUser;
        private ReaLTaiizor.Controls.MaterialFloatingActionButton btnAddEntorno;
        private ReaLTaiizor.Controls.MaterialFloatingActionButton btnAddAnimal;
        private ReaLTaiizor.Controls.MaterialFloatingActionButton btnAddPlanta;
        private TabPage tabCerrarSesion;
        private ReaLTaiizor.Controls.MaterialFloatingActionButton btnAddCompras;
        private ReaLTaiizor.Controls.MaterialFloatingActionButton btnAddVentas;
        public ReaLTaiizor.Controls.MaterialTabControl tcPrincipal;
        public TabPage tabUsers;
        //public TabPage tabVegetablesArea;
        //public TabPage tabAnimalArea;
        public TabPage tabEntorno;
        private FlowLayoutPanel flpUsersList;
        private FlowLayoutPanel flpVegetalList;
        private FlowLayoutPanel flpAnimalsList;
        private FlowLayoutPanel flpFormativeEnvironmentsList;
        private FlowLayoutPanel flowLayoutPanel4;
        public TabControl tcIndustrias;
        public TabPage tabProduct;
        public TabPage tabCompras;
        public TabPage tabVentas;
        private ReaLTaiizor.Controls.MaterialLabel lblEmptyVegetables;
        private ReaLTaiizor.Controls.MaterialLabel lblEmptyAnimals;
        private ReaLTaiizor.Controls.MaterialLabel lblEmptyProducts;
        private ReaLTaiizor.Controls.MaterialLabel lblEmptyPurchases;
        private ReaLTaiizor.Controls.MaterialLabel lblEmptySells;
        private ReaLTaiizor.Controls.MaterialLabel lblEmptyUsers;
        private ReaLTaiizor.Controls.MaterialLabel lblEmptyFormativeEnvironments;
        private ReaLTaiizor.Controls.MaterialFloatingActionButton btnAddProduct;
        private ReaLTaiizor.Controls.MaterialFloatingActionButton btnAddBlackBoard;
        private ReaLTaiizor.Controls.MaterialLabel lblEmptyBlackBoards;
        public TabPage tabBlackBoard;
    }
}