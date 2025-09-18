using GestionAgraria.controllers;
using GestionAgraria.data;
using GestionAgraria.models;
using GestionAgraria.Views;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System.Data;

namespace GestionAgraria
{
    public partial class FormPrincipal : MaterialForm
    {
        private readonly UserModel currentUser;
        public FormPrincipal(UserModel currentUser)
        {
            this.currentUser = currentUser;
            ColorScheme.GetSkinManager().AddFormToManage(this);
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.TabPage selectedTab = tcPrincipal.SelectedTab ?? throw new InvalidOperationException("No se seleccionó ninguna pestaña.");
            this.Text = selectedTab.Text;
            LoadUsersTable();
        }

        private void tcPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TabPage selectedTab = tcPrincipal.SelectedTab ?? throw new InvalidOperationException("No se seleccionó ninguna pestaña.");
            this.Text = selectedTab.Text;
        }

        private void LoadUsersTable()
        {
            using var userController = new UserController();
            List<UserModel> users = userController.GetAllUsers();

            foreach (UserModel user in users)
            {
                UCUserCard userCard = new UCUserCard(user: user);
                userCard.Dock = DockStyle.Top;
                tabUsers.Controls.Add(userCard);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            UCUserAdd userAddControl = new UCUserAdd();
            userAddControl.Dock = DockStyle.Fill;
            tabUsers.Controls.Clear();
            tabUsers.Controls.Add(userAddControl);
        }
        private void btnAddEntorno_Click(object sender, EventArgs e)
        {
            UCEntornoAdd AddControl = new UCEntornoAdd();
            VerFormularioTab(AddControl, tabEntorno);
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            UCAnimalAdd AddControl = new UCAnimalAdd();
            VerFormularioTab(AddControl, tabAnimalArea);
        }

        private void VerFormularioTab(UserControl uc, System.Windows.Forms.TabPage tab)
        {
            UserControl ucUserControl = uc as UserControl;
            ucUserControl.Dock = DockStyle.Fill;
            tab.Controls.Clear();
            tab.Controls.Add(ucUserControl);
        }

        private void btnAddPlanta_Click(object sender, EventArgs e)
        {
            UCVegetalAdd AddControl = new UCVegetalAdd();
            VerFormularioTab(AddControl,tabVegetablesArea);
        }
    }
}
