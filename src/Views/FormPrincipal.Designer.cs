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
            TabPage tabUsers;
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormPrincipal));
            btnAddUser = new ReaLTaiizor.Controls.MaterialFloatingActionButton();
            flpUsersList = new FlowLayoutPanel();
            lblEmptyUsers = new ReaLTaiizor.Controls.MaterialLabel();
            panel5 = new Panel();
            materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel6 = new Panel();
            cbEstadoUserSearch = new ReaLTaiizor.Controls.MaterialComboBox();
            materialLabel5 = new ReaLTaiizor.Controls.MaterialLabel();
            panel7 = new Panel();
            cbRole = new ReaLTaiizor.Controls.MaterialComboBox();
            materialLabel6 = new ReaLTaiizor.Controls.MaterialLabel();
            panel8 = new Panel();
            tbSearchUsers = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel7 = new ReaLTaiizor.Controls.MaterialLabel();
            imgList = new ImageList(components);
            tabVegetablesArea = new TabPage();
            btnAddPlanta = new ReaLTaiizor.Controls.MaterialFloatingActionButton();
            flpVegetalList = new FlowLayoutPanel();
            lblEmptyVegetables = new ReaLTaiizor.Controls.MaterialLabel();
            panel9 = new Panel();
            materialLabel8 = new ReaLTaiizor.Controls.MaterialLabel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel11 = new Panel();
            cbEntornoFiltro = new ReaLTaiizor.Controls.MaterialComboBox();
            materialLabel10 = new ReaLTaiizor.Controls.MaterialLabel();
            panel13 = new Panel();
            cbEstadoFiltroPlantas = new ReaLTaiizor.Controls.MaterialComboBox();
            materialLabel12 = new ReaLTaiizor.Controls.MaterialLabel();
            panel12 = new Panel();
            tbSearchPlante = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel11 = new ReaLTaiizor.Controls.MaterialLabel();
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
            materialTabSelector1 = new ReaLTaiizor.Controls.MaterialTabSelector();
            tcIndustrias = new ReaLTaiizor.Controls.MaterialTabControl();
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
            flpFormativeEnvironmentsList = new FlowLayoutPanel();
            lblEmptyFormativeEnvironments = new ReaLTaiizor.Controls.MaterialLabel();
            panel1 = new Panel();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel4 = new Panel();
            cbEstadoBusquedaEntonor = new ReaLTaiizor.Controls.MaterialComboBox();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            panel2 = new Panel();
            cbAreasFiltro = new ReaLTaiizor.Controls.MaterialComboBox();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            panel3 = new Panel();
            tbSeachFormativeEnvironments = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblUsuario = new ReaLTaiizor.Controls.MaterialLabel();
            tabBlackBoard = new TabPage();
            btnAddBlackBoard = new ReaLTaiizor.Controls.MaterialFloatingActionButton();
            lblEmptyBlackBoards = new ReaLTaiizor.Controls.MaterialLabel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            tabCerrarSesion = new TabPage();
            tabUsers = new TabPage();
            tabUsers.SuspendLayout();
            flpUsersList.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            tabVegetablesArea.SuspendLayout();
            flpVegetalList.SuspendLayout();
            panel9.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel11.SuspendLayout();
            panel13.SuspendLayout();
            panel12.SuspendLayout();
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
            flpFormativeEnvironmentsList.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tabBlackBoard.SuspendLayout();
            SuspendLayout();
            // 
            // tabUsers
            // 
            tabUsers.AutoScroll = true;
            tabUsers.CausesValidation = false;
            tabUsers.Controls.Add(btnAddUser);
            tabUsers.Controls.Add(flpUsersList);
            tabUsers.Controls.Add(panel5);
            tabUsers.ImageKey = "user.png";
            tabUsers.Location = new Point(4, 39);
            tabUsers.Name = "tabUsers";
            tabUsers.Padding = new Padding(20);
            tabUsers.Size = new Size(960, 489);
            tabUsers.TabIndex = 3;
            tabUsers.Text = "Usuarios";
            tabUsers.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            btnAddUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddUser.Depth = 0;
            btnAddUser.Icon = Properties.Resources.add;
            btnAddUser.Location = new Point(877, 446);
            btnAddUser.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(56, 56);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "Agregar Usuario";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // flpUsersList
            // 
            flpUsersList.BackColor = Color.Transparent;
            flpUsersList.Controls.Add(lblEmptyUsers);
            flpUsersList.Dock = DockStyle.Top;
            flpUsersList.Location = new Point(20, 132);
            flpUsersList.Name = "flpUsersList";
            flpUsersList.Size = new Size(920, 340);
            flpUsersList.TabIndex = 1;
            // 
            // lblEmptyUsers
            // 
            lblEmptyUsers.BackColor = Color.Transparent;
            lblEmptyUsers.Depth = 0;
            lblEmptyUsers.Dock = DockStyle.Top;
            lblEmptyUsers.FlatStyle = FlatStyle.Flat;
            lblEmptyUsers.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblEmptyUsers.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            lblEmptyUsers.Location = new Point(3, 0);
            lblEmptyUsers.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblEmptyUsers.Name = "lblEmptyUsers";
            lblEmptyUsers.Size = new Size(920, 357);
            lblEmptyUsers.TabIndex = 5;
            lblEmptyUsers.Text = "Aún no tienes usuarios agregados... Comienza por agregar uno.";
            lblEmptyUsers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(materialLabel4);
            panel5.Controls.Add(tableLayoutPanel3);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(20, 20);
            panel5.Name = "panel5";
            panel5.Size = new Size(920, 112);
            panel5.TabIndex = 17;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(3, 3);
            materialLabel4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(73, 19);
            materialLabel4.TabIndex = 5;
            materialLabel4.Text = "Filtrar por:";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(panel6, 2, 0);
            tableLayoutPanel3.Controls.Add(panel7, 1, 0);
            tableLayoutPanel3.Controls.Add(panel8, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Bottom;
            tableLayoutPanel3.Location = new Point(0, 33);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(920, 79);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(cbEstadoUserSearch);
            panel6.Controls.Add(materialLabel5);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(690, 1);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20, 0, 20, 0);
            panel6.Size = new Size(230, 78);
            panel6.TabIndex = 37;
            // 
            // cbEstadoUserSearch
            // 
            cbEstadoUserSearch.AutoResize = false;
            cbEstadoUserSearch.BackColor = Color.FromArgb(255, 255, 255);
            cbEstadoUserSearch.Depth = 0;
            cbEstadoUserSearch.Dock = DockStyle.Top;
            cbEstadoUserSearch.DrawMode = DrawMode.OwnerDrawVariable;
            cbEstadoUserSearch.DropDownHeight = 174;
            cbEstadoUserSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstadoUserSearch.DropDownWidth = 121;
            cbEstadoUserSearch.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbEstadoUserSearch.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbEstadoUserSearch.FormattingEnabled = true;
            cbEstadoUserSearch.IntegralHeight = false;
            cbEstadoUserSearch.ItemHeight = 43;
            cbEstadoUserSearch.Items.AddRange(new object[] { "Activo", "Inactivo", "Todos" });
            cbEstadoUserSearch.Location = new Point(20, 19);
            cbEstadoUserSearch.MaxDropDownItems = 4;
            cbEstadoUserSearch.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbEstadoUserSearch.Name = "cbEstadoUserSearch";
            cbEstadoUserSearch.Size = new Size(190, 49);
            cbEstadoUserSearch.StartIndex = 0;
            cbEstadoUserSearch.TabIndex = 10;
            cbEstadoUserSearch.SelectedIndexChanged += cbEstadoUserSearch_SelectedIndexChanged;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Dock = DockStyle.Top;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(20, 0);
            materialLabel5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(50, 19);
            materialLabel5.TabIndex = 4;
            materialLabel5.Text = "Estado";
            // 
            // panel7
            // 
            panel7.Controls.Add(cbRole);
            panel7.Controls.Add(materialLabel6);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(460, 1);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(20, 0, 20, 0);
            panel7.Size = new Size(230, 78);
            panel7.TabIndex = 36;
            // 
            // cbRole
            // 
            cbRole.AutoResize = false;
            cbRole.BackColor = Color.FromArgb(255, 255, 255);
            cbRole.Depth = 0;
            cbRole.Dock = DockStyle.Top;
            cbRole.DrawMode = DrawMode.OwnerDrawVariable;
            cbRole.DropDownHeight = 174;
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.DropDownWidth = 121;
            cbRole.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbRole.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbRole.FormattingEnabled = true;
            cbRole.IntegralHeight = false;
            cbRole.ItemHeight = 43;
            cbRole.Items.AddRange(new object[] { "Todos" });
            cbRole.Location = new Point(20, 19);
            cbRole.MaxDropDownItems = 4;
            cbRole.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(190, 49);
            cbRole.StartIndex = 0;
            cbRole.TabIndex = 10;
            cbRole.SelectedIndexChanged += cbRole_SelectedIndexChanged;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Dock = DockStyle.Top;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(20, 0);
            materialLabel6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(24, 19);
            materialLabel6.TabIndex = 4;
            materialLabel6.Text = "Rol";
            // 
            // panel8
            // 
            panel8.Controls.Add(tbSearchUsers);
            panel8.Controls.Add(materialLabel7);
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(0, 1);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(20, 0, 20, 0);
            panel8.Size = new Size(460, 78);
            panel8.TabIndex = 22;
            // 
            // tbSearchUsers
            // 
            tbSearchUsers.AnimateReadOnly = false;
            tbSearchUsers.AutoCompleteMode = AutoCompleteMode.None;
            tbSearchUsers.AutoCompleteSource = AutoCompleteSource.None;
            tbSearchUsers.BackgroundImageLayout = ImageLayout.None;
            tbSearchUsers.CharacterCasing = CharacterCasing.Normal;
            tbSearchUsers.Depth = 0;
            tbSearchUsers.Dock = DockStyle.Fill;
            tbSearchUsers.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbSearchUsers.HideSelection = true;
            tbSearchUsers.LeadingIcon = null;
            tbSearchUsers.Location = new Point(20, 19);
            tbSearchUsers.Margin = new Padding(3, 3, 26, 3);
            tbSearchUsers.MaxLength = 32767;
            tbSearchUsers.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbSearchUsers.Name = "tbSearchUsers";
            tbSearchUsers.Padding = new Padding(9, 8, 9, 8);
            tbSearchUsers.PasswordChar = '\0';
            tbSearchUsers.PrefixSuffixText = null;
            tbSearchUsers.ReadOnly = false;
            tbSearchUsers.RightToLeft = RightToLeft.No;
            tbSearchUsers.SelectedText = "";
            tbSearchUsers.SelectionLength = 0;
            tbSearchUsers.SelectionStart = 0;
            tbSearchUsers.ShortcutsEnabled = true;
            tbSearchUsers.Size = new Size(420, 48);
            tbSearchUsers.TabIndex = 0;
            tbSearchUsers.TabStop = false;
            tbSearchUsers.TextAlign = HorizontalAlignment.Left;
            tbSearchUsers.TrailingIcon = null;
            tbSearchUsers.UseSystemPasswordChar = false;
            tbSearchUsers.TextChanged += tbSearchUsers_TextChanged;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Dock = DockStyle.Top;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(20, 0);
            materialLabel7.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(81, 19);
            materialLabel7.TabIndex = 4;
            materialLabel7.Text = "Buscar por:";
            // 
            // imgList
            // 
            imgList.ColorDepth = ColorDepth.Depth32Bit;
            imgList.ImageStream = (ImageListStreamer)resources.GetObject("imgList.ImageStream");
            imgList.TransparentColor = Color.Transparent;
            imgList.Images.SetKeyName(0, "user.png");
            imgList.Images.SetKeyName(1, "home.png");
            imgList.Images.SetKeyName(2, "pizarron.png");
            imgList.Images.SetKeyName(3, "animal-area.png");
            imgList.Images.SetKeyName(4, "industry-area.png");
            imgList.Images.SetKeyName(5, "vegetable-area.png");
            imgList.Images.SetKeyName(6, "userGroup.png");
            imgList.Images.SetKeyName(7, "cerrar-sesion.png");
            // 
            // tabVegetablesArea
            // 
            tabVegetablesArea.Controls.Add(btnAddPlanta);
            tabVegetablesArea.Controls.Add(flpVegetalList);
            tabVegetablesArea.Controls.Add(panel9);
            tabVegetablesArea.ImageKey = "vegetable-area.png";
            tabVegetablesArea.Location = new Point(4, 39);
            tabVegetablesArea.Name = "tabVegetablesArea";
            tabVegetablesArea.Padding = new Padding(20);
            tabVegetablesArea.Size = new Size(960, 489);
            tabVegetablesArea.TabIndex = 2;
            tabVegetablesArea.Text = "Vegetales";
            tabVegetablesArea.UseVisualStyleBackColor = true;
            // 
            // btnAddPlanta
            // 
            btnAddPlanta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddPlanta.Depth = 0;
            btnAddPlanta.FlatStyle = FlatStyle.Flat;
            btnAddPlanta.Icon = Properties.Resources.add_user;
            btnAddPlanta.Location = new Point(877, 446);
            btnAddPlanta.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAddPlanta.Name = "btnAddPlanta";
            btnAddPlanta.RightToLeft = RightToLeft.No;
            btnAddPlanta.Size = new Size(58, 60);
            btnAddPlanta.TabIndex = 18;
            btnAddPlanta.Text = "Agregar Planta";
            btnAddPlanta.UseVisualStyleBackColor = true;
            btnAddPlanta.Click += btnAddPlanta_Click;
            // 
            // flpVegetalList
            // 
            flpVegetalList.Controls.Add(lblEmptyVegetables);
            flpVegetalList.Dock = DockStyle.Top;
            flpVegetalList.Location = new Point(20, 132);
            flpVegetalList.Name = "flpVegetalList";
            flpVegetalList.Size = new Size(920, 331);
            flpVegetalList.TabIndex = 19;
            // 
            // lblEmptyVegetables
            // 
            lblEmptyVegetables.Depth = 0;
            lblEmptyVegetables.FlatStyle = FlatStyle.Flat;
            lblEmptyVegetables.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblEmptyVegetables.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            lblEmptyVegetables.Location = new Point(3, 0);
            lblEmptyVegetables.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblEmptyVegetables.Name = "lblEmptyVegetables";
            lblEmptyVegetables.Size = new Size(917, 331);
            lblEmptyVegetables.TabIndex = 1;
            lblEmptyVegetables.Text = "Aún no tienes vegetales agregados... Comienza por agregar uno.";
            lblEmptyVegetables.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            panel9.Controls.Add(materialLabel8);
            panel9.Controls.Add(tableLayoutPanel4);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(20, 20);
            panel9.Name = "panel9";
            panel9.Size = new Size(920, 112);
            panel9.TabIndex = 20;
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(3, 3);
            materialLabel8.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(73, 19);
            materialLabel8.TabIndex = 5;
            materialLabel8.Text = "Filtrar por:";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Controls.Add(panel11, 1, 0);
            tableLayoutPanel4.Controls.Add(panel13, 2, 0);
            tableLayoutPanel4.Controls.Add(panel12, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Bottom;
            tableLayoutPanel4.Location = new Point(0, 33);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(920, 79);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.Controls.Add(cbEntornoFiltro);
            panel11.Controls.Add(materialLabel10);
            panel11.Dock = DockStyle.Bottom;
            panel11.Location = new Point(460, 1);
            panel11.Margin = new Padding(0);
            panel11.Name = "panel11";
            panel11.Padding = new Padding(20, 0, 20, 0);
            panel11.Size = new Size(230, 78);
            panel11.TabIndex = 39;
            // 
            // cbEntornoFiltro
            // 
            cbEntornoFiltro.AutoResize = false;
            cbEntornoFiltro.BackColor = Color.FromArgb(255, 255, 255);
            cbEntornoFiltro.Depth = 0;
            cbEntornoFiltro.Dock = DockStyle.Top;
            cbEntornoFiltro.DrawMode = DrawMode.OwnerDrawVariable;
            cbEntornoFiltro.DropDownHeight = 174;
            cbEntornoFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEntornoFiltro.DropDownWidth = 121;
            cbEntornoFiltro.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbEntornoFiltro.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbEntornoFiltro.FormattingEnabled = true;
            cbEntornoFiltro.IntegralHeight = false;
            cbEntornoFiltro.ItemHeight = 43;
            cbEntornoFiltro.Items.AddRange(new object[] { "Todos" });
            cbEntornoFiltro.Location = new Point(20, 19);
            cbEntornoFiltro.MaxDropDownItems = 4;
            cbEntornoFiltro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbEntornoFiltro.Name = "cbEntornoFiltro";
            cbEntornoFiltro.Size = new Size(190, 49);
            cbEntornoFiltro.StartIndex = 0;
            cbEntornoFiltro.TabIndex = 10;
            cbEntornoFiltro.SelectedIndexChanged += cbEntornoFiltro_SelectedIndexChanged;
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Dock = DockStyle.Top;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(20, 0);
            materialLabel10.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(175, 19);
            materialLabel10.TabIndex = 4;
            materialLabel10.Text = "Entorno al que pertenece";
            // 
            // panel13
            // 
            panel13.Controls.Add(cbEstadoFiltroPlantas);
            panel13.Controls.Add(materialLabel12);
            panel13.Dock = DockStyle.Bottom;
            panel13.Location = new Point(690, 1);
            panel13.Margin = new Padding(0);
            panel13.Name = "panel13";
            panel13.Padding = new Padding(20, 0, 20, 0);
            panel13.Size = new Size(230, 78);
            panel13.TabIndex = 38;
            // 
            // cbEstadoFiltroPlantas
            // 
            cbEstadoFiltroPlantas.AutoResize = false;
            cbEstadoFiltroPlantas.BackColor = Color.FromArgb(255, 255, 255);
            cbEstadoFiltroPlantas.Depth = 0;
            cbEstadoFiltroPlantas.Dock = DockStyle.Top;
            cbEstadoFiltroPlantas.DrawMode = DrawMode.OwnerDrawVariable;
            cbEstadoFiltroPlantas.DropDownHeight = 174;
            cbEstadoFiltroPlantas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstadoFiltroPlantas.DropDownWidth = 121;
            cbEstadoFiltroPlantas.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbEstadoFiltroPlantas.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbEstadoFiltroPlantas.FormattingEnabled = true;
            cbEstadoFiltroPlantas.IntegralHeight = false;
            cbEstadoFiltroPlantas.ItemHeight = 43;
            cbEstadoFiltroPlantas.Items.AddRange(new object[] { "Activo", "Inactivo", "Todos" });
            cbEstadoFiltroPlantas.Location = new Point(20, 19);
            cbEstadoFiltroPlantas.MaxDropDownItems = 4;
            cbEstadoFiltroPlantas.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbEstadoFiltroPlantas.Name = "cbEstadoFiltroPlantas";
            cbEstadoFiltroPlantas.Size = new Size(190, 49);
            cbEstadoFiltroPlantas.StartIndex = 0;
            cbEstadoFiltroPlantas.TabIndex = 10;
            cbEstadoFiltroPlantas.SelectedIndexChanged += cbEstadoFiltroPlantas_SelectedIndexChanged;
            // 
            // materialLabel12
            // 
            materialLabel12.AutoSize = true;
            materialLabel12.Depth = 0;
            materialLabel12.Dock = DockStyle.Top;
            materialLabel12.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel12.Location = new Point(20, 0);
            materialLabel12.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel12.Name = "materialLabel12";
            materialLabel12.Size = new Size(50, 19);
            materialLabel12.TabIndex = 4;
            materialLabel12.Text = "Estado";
            // 
            // panel12
            // 
            panel12.Controls.Add(tbSearchPlante);
            panel12.Controls.Add(materialLabel11);
            panel12.Dock = DockStyle.Bottom;
            panel12.Location = new Point(0, 1);
            panel12.Margin = new Padding(0);
            panel12.Name = "panel12";
            panel12.Padding = new Padding(20, 0, 20, 0);
            panel12.Size = new Size(460, 78);
            panel12.TabIndex = 22;
            // 
            // tbSearchPlante
            // 
            tbSearchPlante.AnimateReadOnly = false;
            tbSearchPlante.AutoCompleteMode = AutoCompleteMode.None;
            tbSearchPlante.AutoCompleteSource = AutoCompleteSource.None;
            tbSearchPlante.BackgroundImageLayout = ImageLayout.None;
            tbSearchPlante.CharacterCasing = CharacterCasing.Normal;
            tbSearchPlante.Depth = 0;
            tbSearchPlante.Dock = DockStyle.Fill;
            tbSearchPlante.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbSearchPlante.HideSelection = true;
            tbSearchPlante.LeadingIcon = null;
            tbSearchPlante.Location = new Point(20, 19);
            tbSearchPlante.Margin = new Padding(3, 3, 26, 3);
            tbSearchPlante.MaxLength = 32767;
            tbSearchPlante.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbSearchPlante.Name = "tbSearchPlante";
            tbSearchPlante.Padding = new Padding(9, 8, 9, 8);
            tbSearchPlante.PasswordChar = '\0';
            tbSearchPlante.PrefixSuffixText = null;
            tbSearchPlante.ReadOnly = false;
            tbSearchPlante.RightToLeft = RightToLeft.No;
            tbSearchPlante.SelectedText = "";
            tbSearchPlante.SelectionLength = 0;
            tbSearchPlante.SelectionStart = 0;
            tbSearchPlante.ShortcutsEnabled = true;
            tbSearchPlante.Size = new Size(420, 48);
            tbSearchPlante.TabIndex = 0;
            tbSearchPlante.TabStop = false;
            tbSearchPlante.TextAlign = HorizontalAlignment.Left;
            tbSearchPlante.TrailingIcon = null;
            tbSearchPlante.UseSystemPasswordChar = false;
            tbSearchPlante.TextChanged += tbSearchPlante_TextChanged;
            // 
            // materialLabel11
            // 
            materialLabel11.AutoSize = true;
            materialLabel11.Depth = 0;
            materialLabel11.Dock = DockStyle.Top;
            materialLabel11.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel11.Location = new Point(20, 0);
            materialLabel11.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new Size(81, 19);
            materialLabel11.TabIndex = 4;
            materialLabel11.Text = "Buscar por:";
            // 
            // tabHome
            // 
            tabHome.Controls.Add(tableLayoutPanel1);
            tabHome.ImageKey = "home.png";
            tabHome.Location = new Point(4, 39);
            tabHome.Name = "tabHome";
            tabHome.Padding = new Padding(20);
            tabHome.Size = new Size(960, 489);
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
            tableLayoutPanel1.Size = new Size(920, 449);
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
            pictureBox1.Size = new Size(880, 303);
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
            lblWelcome.Location = new Point(3, 343);
            lblWelcome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(914, 41);
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
            tcPrincipal.Location = new Point(0, 80);
            tcPrincipal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tcPrincipal.Multiline = true;
            tcPrincipal.Name = "tcPrincipal";
            tcPrincipal.Padding = new Point(10, 3);
            tcPrincipal.SelectedIndex = 0;
            tcPrincipal.Size = new Size(968, 532);
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
            tabAnimalArea.Size = new Size(960, 489);
            tabAnimalArea.TabIndex = 5;
            tabAnimalArea.Text = "Animales";
            tabAnimalArea.UseVisualStyleBackColor = true;
            // 
            // btnAddAnimal
            // 
            btnAddAnimal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddAnimal.Depth = 0;
            btnAddAnimal.Icon = Properties.Resources.add;
            btnAddAnimal.Location = new Point(877, 446);
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
            lblEmptyAnimals.Size = new Size(920, 449);
            lblEmptyAnimals.TabIndex = 18;
            lblEmptyAnimals.Text = "Aún no tienes animales agregados... Comienza por agregar uno.";
            lblEmptyAnimals.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flpAnimalsList
            // 
            flpAnimalsList.Dock = DockStyle.Fill;
            flpAnimalsList.Location = new Point(20, 20);
            flpAnimalsList.Name = "flpAnimalsList";
            flpAnimalsList.Size = new Size(920, 449);
            flpAnimalsList.TabIndex = 17;
            // 
            // tabIndustryArea
            // 
            tabIndustryArea.BackColor = Color.White;
            tabIndustryArea.Controls.Add(materialTabSelector1);
            tabIndustryArea.Controls.Add(tcIndustrias);
            tabIndustryArea.ImageKey = "industry-area.png";
            tabIndustryArea.Location = new Point(4, 39);
            tabIndustryArea.Margin = new Padding(0);
            tabIndustryArea.Name = "tabIndustryArea";
            tabIndustryArea.Size = new Size(960, 489);
            tabIndustryArea.TabIndex = 4;
            tabIndustryArea.Text = "Industria";
            // 
            // materialTabSelector1
            // 
            materialTabSelector1.BaseTabControl = tcIndustrias;
            materialTabSelector1.CharacterCasing = ReaLTaiizor.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            materialTabSelector1.Depth = 0;
            materialTabSelector1.Dock = DockStyle.Top;
            materialTabSelector1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTabSelector1.HeadAlignment = ReaLTaiizor.Controls.MaterialTabSelector.Alignment.Center;
            materialTabSelector1.Location = new Point(0, 0);
            materialTabSelector1.Margin = new Padding(0);
            materialTabSelector1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialTabSelector1.Name = "materialTabSelector1";
            materialTabSelector1.Size = new Size(960, 48);
            materialTabSelector1.TabIndex = 4;
            materialTabSelector1.TabIndicatorHeight = 3;
            materialTabSelector1.Text = "materialTabSelector1";
            // 
            // tcIndustrias
            // 
            tcIndustrias.Controls.Add(tabProduct);
            tcIndustrias.Controls.Add(tabCompras);
            tcIndustrias.Controls.Add(tabVentas);
            tcIndustrias.Depth = 0;
            tcIndustrias.Dock = DockStyle.Fill;
            tcIndustrias.Location = new Point(0, 0);
            tcIndustrias.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tcIndustrias.Multiline = true;
            tcIndustrias.Name = "tcIndustrias";
            tcIndustrias.SelectedIndex = 0;
            tcIndustrias.Size = new Size(960, 489);
            tcIndustrias.TabIndex = 2;
            // 
            // tabProduct
            // 
            tabProduct.Controls.Add(btnAddProduct);
            tabProduct.Controls.Add(lblEmptyProducts);
            tabProduct.Location = new Point(4, 24);
            tabProduct.Name = "tabProduct";
            tabProduct.Padding = new Padding(17);
            tabProduct.Size = new Size(952, 461);
            tabProduct.TabIndex = 0;
            tabProduct.Text = "Productos";
            tabProduct.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddProduct.Depth = 0;
            btnAddProduct.Icon = Properties.Resources.add;
            btnAddProduct.Location = new Point(876, 385);
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
            lblEmptyProducts.Size = new Size(918, 427);
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
            tabCompras.Size = new Size(952, 461);
            tabCompras.TabIndex = 1;
            tabCompras.Text = "Compras";
            tabCompras.UseVisualStyleBackColor = true;
            // 
            // btnAddCompras
            // 
            btnAddCompras.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddCompras.Depth = 0;
            btnAddCompras.Icon = Properties.Resources.add;
            btnAddCompras.Location = new Point(876, 385);
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
            lblEmptyPurchases.Size = new Size(918, 427);
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
            tabVentas.Size = new Size(952, 461);
            tabVentas.TabIndex = 2;
            tabVentas.Text = "Ventas";
            tabVentas.UseVisualStyleBackColor = true;
            // 
            // btnAddVentas
            // 
            btnAddVentas.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddVentas.Depth = 0;
            btnAddVentas.Icon = Properties.Resources.add;
            btnAddVentas.Location = new Point(877, 385);
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
            lblEmptySells.Size = new Size(918, 427);
            lblEmptySells.TabIndex = 5;
            lblEmptySells.Text = "Aún no tienes ventas registradas... Comienza por agregar una.";
            lblEmptySells.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabEntorno
            // 
            tabEntorno.Controls.Add(btnAddEntorno);
            tabEntorno.Controls.Add(flpFormativeEnvironmentsList);
            tabEntorno.Controls.Add(panel1);
            tabEntorno.ImageKey = "userGroup.png";
            tabEntorno.Location = new Point(4, 39);
            tabEntorno.Name = "tabEntorno";
            tabEntorno.Padding = new Padding(20);
            tabEntorno.Size = new Size(960, 489);
            tabEntorno.TabIndex = 6;
            tabEntorno.Text = "Entornos";
            tabEntorno.UseVisualStyleBackColor = true;
            // 
            // btnAddEntorno
            // 
            btnAddEntorno.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddEntorno.Depth = 0;
            btnAddEntorno.Icon = Properties.Resources.add;
            btnAddEntorno.Location = new Point(877, 413);
            btnAddEntorno.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAddEntorno.Name = "btnAddEntorno";
            btnAddEntorno.Size = new Size(56, 56);
            btnAddEntorno.TabIndex = 14;
            btnAddEntorno.Text = "Agregar Usuario";
            btnAddEntorno.UseVisualStyleBackColor = true;
            btnAddEntorno.Click += btnAddEntorno_Click;
            // 
            // flpFormativeEnvironmentsList
            // 
            flpFormativeEnvironmentsList.Controls.Add(lblEmptyFormativeEnvironments);
            flpFormativeEnvironmentsList.Dock = DockStyle.Top;
            flpFormativeEnvironmentsList.Location = new Point(20, 132);
            flpFormativeEnvironmentsList.Name = "flpFormativeEnvironmentsList";
            flpFormativeEnvironmentsList.Size = new Size(920, 359);
            flpFormativeEnvironmentsList.TabIndex = 15;
            // 
            // lblEmptyFormativeEnvironments
            // 
            lblEmptyFormativeEnvironments.Depth = 0;
            lblEmptyFormativeEnvironments.Dock = DockStyle.Top;
            lblEmptyFormativeEnvironments.FlatStyle = FlatStyle.Flat;
            lblEmptyFormativeEnvironments.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblEmptyFormativeEnvironments.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            lblEmptyFormativeEnvironments.Location = new Point(3, 0);
            lblEmptyFormativeEnvironments.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblEmptyFormativeEnvironments.Name = "lblEmptyFormativeEnvironments";
            lblEmptyFormativeEnvironments.Size = new Size(920, 359);
            lblEmptyFormativeEnvironments.TabIndex = 18;
            lblEmptyFormativeEnvironments.Text = "Aún no tienes entornos formativos agregados... Comienza por agregar uno.";
            lblEmptyFormativeEnvironments.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(materialLabel1);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 112);
            panel1.TabIndex = 16;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(3, 3);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(73, 19);
            materialLabel1.TabIndex = 5;
            materialLabel1.Text = "Filtrar por:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(panel4, 2, 0);
            tableLayoutPanel2.Controls.Add(panel2, 1, 0);
            tableLayoutPanel2.Controls.Add(panel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 33);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(920, 79);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(cbEstadoBusquedaEntonor);
            panel4.Controls.Add(materialLabel2);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(690, 1);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20, 0, 20, 0);
            panel4.Size = new Size(230, 78);
            panel4.TabIndex = 37;
            // 
            // cbEstadoBusquedaEntonor
            // 
            cbEstadoBusquedaEntonor.AutoResize = false;
            cbEstadoBusquedaEntonor.BackColor = Color.FromArgb(255, 255, 255);
            cbEstadoBusquedaEntonor.Depth = 0;
            cbEstadoBusquedaEntonor.Dock = DockStyle.Top;
            cbEstadoBusquedaEntonor.DrawMode = DrawMode.OwnerDrawVariable;
            cbEstadoBusquedaEntonor.DropDownHeight = 174;
            cbEstadoBusquedaEntonor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstadoBusquedaEntonor.DropDownWidth = 121;
            cbEstadoBusquedaEntonor.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbEstadoBusquedaEntonor.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbEstadoBusquedaEntonor.FormattingEnabled = true;
            cbEstadoBusquedaEntonor.IntegralHeight = false;
            cbEstadoBusquedaEntonor.ItemHeight = 43;
            cbEstadoBusquedaEntonor.Items.AddRange(new object[] { "Activo", "Inactivo", "Todos" });
            cbEstadoBusquedaEntonor.Location = new Point(20, 19);
            cbEstadoBusquedaEntonor.MaxDropDownItems = 4;
            cbEstadoBusquedaEntonor.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbEstadoBusquedaEntonor.Name = "cbEstadoBusquedaEntonor";
            cbEstadoBusquedaEntonor.Size = new Size(190, 49);
            cbEstadoBusquedaEntonor.StartIndex = 0;
            cbEstadoBusquedaEntonor.TabIndex = 10;
            cbEstadoBusquedaEntonor.SelectedIndexChanged += cbEstadoBusquedaEntonor_SelectedIndexChanged;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Dock = DockStyle.Top;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(20, 0);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(50, 19);
            materialLabel2.TabIndex = 4;
            materialLabel2.Text = "Estado";
            // 
            // panel2
            // 
            panel2.Controls.Add(cbAreasFiltro);
            panel2.Controls.Add(materialLabel3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(460, 1);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 0, 20, 0);
            panel2.Size = new Size(230, 78);
            panel2.TabIndex = 36;
            // 
            // cbAreasFiltro
            // 
            cbAreasFiltro.AutoResize = false;
            cbAreasFiltro.BackColor = Color.FromArgb(255, 255, 255);
            cbAreasFiltro.Depth = 0;
            cbAreasFiltro.Dock = DockStyle.Top;
            cbAreasFiltro.DrawMode = DrawMode.OwnerDrawVariable;
            cbAreasFiltro.DropDownHeight = 174;
            cbAreasFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAreasFiltro.DropDownWidth = 121;
            cbAreasFiltro.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbAreasFiltro.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbAreasFiltro.FormattingEnabled = true;
            cbAreasFiltro.IntegralHeight = false;
            cbAreasFiltro.ItemHeight = 43;
            cbAreasFiltro.Items.AddRange(new object[] { "Todos" });
            cbAreasFiltro.Location = new Point(20, 19);
            cbAreasFiltro.MaxDropDownItems = 4;
            cbAreasFiltro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbAreasFiltro.Name = "cbAreasFiltro";
            cbAreasFiltro.Size = new Size(190, 49);
            cbAreasFiltro.StartIndex = 0;
            cbAreasFiltro.TabIndex = 10;
            cbAreasFiltro.SelectedIndexChanged += cbAreasFiltro_SelectedIndexChanged;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Dock = DockStyle.Top;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(20, 0);
            materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(33, 19);
            materialLabel3.TabIndex = 4;
            materialLabel3.Text = "Area";
            // 
            // panel3
            // 
            panel3.Controls.Add(tbSeachFormativeEnvironments);
            panel3.Controls.Add(lblUsuario);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 1);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 0, 20, 0);
            panel3.Size = new Size(460, 78);
            panel3.TabIndex = 22;
            // 
            // tbSeachFormativeEnvironments
            // 
            tbSeachFormativeEnvironments.AnimateReadOnly = false;
            tbSeachFormativeEnvironments.AutoCompleteMode = AutoCompleteMode.None;
            tbSeachFormativeEnvironments.AutoCompleteSource = AutoCompleteSource.None;
            tbSeachFormativeEnvironments.BackgroundImageLayout = ImageLayout.None;
            tbSeachFormativeEnvironments.CharacterCasing = CharacterCasing.Normal;
            tbSeachFormativeEnvironments.Depth = 0;
            tbSeachFormativeEnvironments.Dock = DockStyle.Fill;
            tbSeachFormativeEnvironments.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbSeachFormativeEnvironments.HideSelection = true;
            tbSeachFormativeEnvironments.LeadingIcon = null;
            tbSeachFormativeEnvironments.Location = new Point(20, 19);
            tbSeachFormativeEnvironments.Margin = new Padding(3, 3, 26, 3);
            tbSeachFormativeEnvironments.MaxLength = 32767;
            tbSeachFormativeEnvironments.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbSeachFormativeEnvironments.Name = "tbSeachFormativeEnvironments";
            tbSeachFormativeEnvironments.Padding = new Padding(9, 8, 9, 8);
            tbSeachFormativeEnvironments.PasswordChar = '\0';
            tbSeachFormativeEnvironments.PrefixSuffixText = null;
            tbSeachFormativeEnvironments.ReadOnly = false;
            tbSeachFormativeEnvironments.RightToLeft = RightToLeft.No;
            tbSeachFormativeEnvironments.SelectedText = "";
            tbSeachFormativeEnvironments.SelectionLength = 0;
            tbSeachFormativeEnvironments.SelectionStart = 0;
            tbSeachFormativeEnvironments.ShortcutsEnabled = true;
            tbSeachFormativeEnvironments.Size = new Size(420, 48);
            tbSeachFormativeEnvironments.TabIndex = 0;
            tbSeachFormativeEnvironments.TabStop = false;
            tbSeachFormativeEnvironments.TextAlign = HorizontalAlignment.Left;
            tbSeachFormativeEnvironments.TrailingIcon = null;
            tbSeachFormativeEnvironments.UseSystemPasswordChar = false;
            tbSeachFormativeEnvironments.TextChanged += tbSeachFormativeEnvironments_TextChanged;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Depth = 0;
            lblUsuario.Dock = DockStyle.Top;
            lblUsuario.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblUsuario.Location = new Point(20, 0);
            lblUsuario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(81, 19);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Buscar por:";
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
            tabBlackBoard.Size = new Size(960, 489);
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
            lblEmptyBlackBoards.Size = new Size(920, 449);
            lblEmptyBlackBoards.TabIndex = 8;
            lblEmptyBlackBoards.Text = "Aún no tienes pizzarrones agregados... Comienza por agregar uno.";
            lblEmptyBlackBoards.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.Location = new Point(20, 20);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(920, 449);
            flowLayoutPanel4.TabIndex = 2;
            // 
            // tabCerrarSesion
            // 
            tabCerrarSesion.ImageKey = "cerrar-sesion.png";
            tabCerrarSesion.Location = new Point(4, 39);
            tabCerrarSesion.Name = "tabCerrarSesion";
            tabCerrarSesion.Padding = new Padding(3);
            tabCerrarSesion.Size = new Size(960, 489);
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
            CausesValidation = false;
            ClientSize = new Size(968, 615);
            Controls.Add(tcPrincipal);
            DrawerIsOpen = true;
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = tcPrincipal;
            DrawerUseColors = true;
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_56;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 600);
            Name = "FormPrincipal";
            Padding = new Padding(0, 80, 0, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión Agraria";
            Load += FormPrincipal_Load;
            tabUsers.ResumeLayout(false);
            flpUsersList.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            tabVegetablesArea.ResumeLayout(false);
            flpVegetalList.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
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
            flpFormativeEnvironmentsList.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        //public TabPage tabVegetablesArea;
        //public TabPage tabAnimalArea;
        public TabPage tabEntorno;
        private FlowLayoutPanel flpUsersList;
        private FlowLayoutPanel flpVegetalList;
        private FlowLayoutPanel flpAnimalsList;
        private FlowLayoutPanel flpFormativeEnvironmentsList;
        private FlowLayoutPanel flowLayoutPanel4;
        public TabPage tabProduct;
        public TabPage tabCompras;
        public TabPage tabVentas;
        private ReaLTaiizor.Controls.MaterialLabel lblEmptyVegetables;
        private ReaLTaiizor.Controls.MaterialLabel lblEmptyAnimals;
        private ReaLTaiizor.Controls.MaterialLabel lblEmptyProducts;
        private ReaLTaiizor.Controls.MaterialLabel lblEmptyPurchases;
        private ReaLTaiizor.Controls.MaterialLabel lblEmptySells;
        private ReaLTaiizor.Controls.MaterialLabel lblEmptyUsers;
        private ReaLTaiizor.Controls.MaterialFloatingActionButton btnAddProduct;
        private ReaLTaiizor.Controls.MaterialFloatingActionButton btnAddBlackBoard;
        private ReaLTaiizor.Controls.MaterialLabel lblEmptyBlackBoards;
        public TabPage tabBlackBoard;
        private ReaLTaiizor.Controls.MaterialTabSelector materialTabSelector1;
        public ReaLTaiizor.Controls.MaterialTabControl tcIndustrias;
        private ReaLTaiizor.Controls.MaterialLabel lblEmptyFormativeEnvironments;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbSeachFormativeEnvironments;
        private ReaLTaiizor.Controls.MaterialLabel lblUsuario;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private Panel panel4;
        private ReaLTaiizor.Controls.MaterialComboBox cbEstadoBusquedaEntonor;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private Panel panel2;
        private ReaLTaiizor.Controls.MaterialComboBox cbAreasFiltro;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        public TabPage tabUsers;
        private Panel panel5;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel6;
        private ReaLTaiizor.Controls.MaterialComboBox cbEstadoUserSearch;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel5;
        private Panel panel7;
        private ReaLTaiizor.Controls.MaterialComboBox cbRole;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel6;
        private Panel panel8;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbSearchUsers;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel7;
        private Panel panel9;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel8;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel12;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbSearchPlante;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel11;
        private Panel panel13;
        private ReaLTaiizor.Controls.MaterialComboBox cbEstadoFiltroPlantas;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel12;
        private Panel panel11;
        private ReaLTaiizor.Controls.MaterialComboBox cbEntornoFiltro;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel10;
    }
}