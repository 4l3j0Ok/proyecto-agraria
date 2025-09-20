using GestionAgraria.controllers;
using GestionAgraria.models;
using GestionAgraria.Models;
using GestionAgraria.Views;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System.Diagnostics;
using System.Windows.Forms;

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
            LoadUsersTable();
            LoadVegetablesTable();
            LoadAnimalsTable();
            LoadFormativeEnvironments();
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
        private void LoadVegetablesTable()
        {
            using var vegetalController = new VegetalController();
            List<VegetalModel> vegetals = vegetalController.GetAllVegetables();
            foreach (VegetalModel vegetal in vegetals)
            {
                UCVegetalCard vegetalCard = new UCVegetalCard(vegetal: vegetal);
                vegetalCard.Dock = DockStyle.Top;
                tabVegetablesArea.Controls.Add(vegetalCard);
            }
        }
        private void LoadAnimalsTable()
        {
            using var animalController = new AnimalController();
            List<AnimalModel> animals = animalController.GetAllAnimals();
            foreach (AnimalModel animal in animals)
            {
                UCAnimalCard animalCard = new UCAnimalCard(animal: animal);
                animalCard.Dock = DockStyle.Top;
                tabAnimalArea.Controls.Add(animalCard);
            }
        }
        //TODO
        private void LoadFormativeEnvironments()
        {
            using var environmentController = new FormativeEnvironmentController();
            List<FormativeEnvironmentModel> formativeEnvironments = environmentController.GetAllFormativeEnvironments();
            foreach (FormativeEnvironmentModel formativeEnvironment in formativeEnvironments)
            {
                UCFormativeEnvironmentCard formativeEnvironmentCard = new UCFormativeEnvironmentCard(formativeEnvironment: formativeEnvironment);
                formativeEnvironmentCard.Dock = DockStyle.Top;
                tabEntorno.Controls.Add(formativeEnvironmentCard);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            UCUserAdd userAddControl = new UCUserAdd();
            VerFormularioTab(userAddControl, tabUsers);
        }
        private void btnAddEntorno_Click(object sender, EventArgs e)
        {
            UCFormativeEnvironmentAdd AddControl = new UCFormativeEnvironmentAdd();
            this.VerFormularioTab(AddControl, tabEntorno);
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            UCAnimalAdd AddControl = new UCAnimalAdd();
            this.VerFormularioTab(AddControl, tabAnimalArea);
        }

        public void VerFormularioTab(UserControl uc, System.Windows.Forms.TabPage tabPage)
        {
            uc.Dock = DockStyle.Fill;
            tabPage.Controls.Clear();
            tabPage.Controls.Add(uc);
        }

        private void btnAddPlanta_Click(object sender, EventArgs e)
        {
            UCVegetalAdd AddControl = new UCVegetalAdd();
            this.VerFormularioTab(AddControl, tabVegetablesArea);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            UCCargaProductosAdd AddControl = new UCCargaProductosAdd();
            this.VerFormularioTab(AddControl, tabProduct);
        }

        private void btnAddCompras_Click(object sender, EventArgs e)
        {
            UCComprasAdd AddControl = new UCComprasAdd();
            this.VerFormularioTab(AddControl, tabCompras);
        }

        private void btnAddVentas_Click(object sender, EventArgs e)
        {
            UCVentasAdd AddControl = new UCVentasAdd();
            this.VerFormularioTab(AddControl, tabVentas);
        }
    }
}
