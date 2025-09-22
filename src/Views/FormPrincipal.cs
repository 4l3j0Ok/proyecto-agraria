using GestionAgraria.controllers;
using GestionAgraria.models;
using GestionAgraria.Models;
using GestionAgraria.Views;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GestionAgraria
{
    public partial class FormPrincipal : MaterialForm
    {
        private readonly UserModel currentUser;
        private readonly List<Dictionary<string, List<Control>>> previousTabPages = new List<Dictionary<string, List<Control>>>();
        public FormPrincipal(UserModel currentUser)
        {
            this.currentUser = currentUser;
            UIConfig.GetSkinManager().AddFormToManage(this);
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            LoadCards();
        }
        public void LoadCards(bool clearCurrent=false)
        {
            if (clearCurrent)
            {
                foreach (System.Windows.Forms.TabPage tabPage in tcPrincipal.TabPages)
                {
                    List<UserControl> userControls = tabPage.Controls.OfType<UserControl>().ToList();
                    foreach (UserControl uc in userControls)
                    {
                        tabPage.Controls.Remove(uc);
                        uc.Dispose();
                    }
                }
            }
            LoadUsersTable();
            LoadVegetablesTable();
            LoadAnimalsTable();
            LoadFormativeEnvironments();
        }
        private void LoadUsersTable()
        {
            UserController userController = new UserController();
            List<UserModel> users = userController.GetAllUsers();

            foreach (UserModel user in users)
            {
                UCUserCard userCard = new UCUserCard(user: user);
                userCard.Dock = DockStyle.Top;
                userCard.Margin = new Padding(0,0,0,20);
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

        // Reemplaza la línea problemática en el método VerFormularioTab
        public void VerFormularioTab(UserControl uc, System.Windows.Forms.TabPage tabPage)
        {
            uc.Dock = DockStyle.Fill;
            // Guardar una copia de los controles actuales antes de agregar el nuevo UserControl
            var previousControls = new List<Control>();
            foreach (Control control in tabPage.Controls)
            {
                previousControls.Add(control);
            }
            Dictionary<string, List<Control>> previousTabPage = new Dictionary<string, List<Control>>();
            previousTabPage[tabPage.Name ?? ""] = previousControls;
            previousTabPages.Add(previousTabPage);
            tabPage.Controls.Clear();
            tabPage.Controls.Add(uc);
        }
        public void RestaurarFormularioTab(System.Windows.Forms.TabPage tabPage)
        {
            // Si el tabPage.Name está en la lista previousTabPages, restaurar los controles anteriores
            var previousTabPage = previousTabPages.LastOrDefault(tp => tp.ContainsKey(tabPage.Name ?? ""));
            if (previousTabPage != null)
            {
                tabPage.Controls.Clear();
                foreach (var control in previousTabPage[tabPage.Name ?? ""])
                {
                    tabPage.Controls.Add(control);
                }
                previousTabPages.Remove(previousTabPage);
                LoadCards(clearCurrent: true);
            }
        }

        private void btnAddPlanta_Click(object sender, EventArgs e)
        {
            UCVegetalAdd AddControl = new UCVegetalAdd();
            this.VerFormularioTab(AddControl, tabVegetablesArea);
        }
    }
}
