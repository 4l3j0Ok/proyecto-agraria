using GestionAgraria.controllers;
using GestionAgraria.Controllers;
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
        private readonly Dictionary<System.Windows.Forms.TabPage, List<Control>> originalTabContents = new Dictionary<System.Windows.Forms.TabPage, List<Control>>();

        public FormPrincipal(UserModel currentUser)
        {
            this.currentUser = currentUser;
            UIConfig.GetSkinManager().AddFormToManage(this);
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            LoadCards();
            // Guardar el estado inicial de todos los tabs
            SaveOriginalTabContents();
        }

        private void SaveOriginalTabContents()
        {
            foreach (System.Windows.Forms.TabPage tabPage in tcPrincipal.TabPages)
            {
                var controls = new List<Control>();
                foreach (Control control in tabPage.Controls)
                {
                    controls.Add(control);
                }
                originalTabContents[tabPage] = controls;
            }
        }

        public void LoadCards(Type? clearObjectsOfType = null)
        {
            if (clearObjectsOfType != null)
            {
                foreach (System.Windows.Forms.TabPage tabPage in tcPrincipal.TabPages)
                {
                    // Elimina todos los controles del tipo especificado
                    var controlsToRemove = tabPage.Controls.Cast<Control>()
                        .Where(c => c.GetType() == clearObjectsOfType)
                        .ToList();
                    foreach (var control in controlsToRemove)
                    {
                        tabPage.Controls.Remove(control);
                        control.Dispose();
                    }
                }
            }
            LoadUsersTable();
            LoadVegetablesTable();
            LoadAnimalsTable();
            LoadFormativeEnvironments();
            LoadProductTable();
            LoadSellsTable();
        }
        private void LoadUsersTable()
        {
            UserController userController = new UserController();
            List<UserModel> users = userController.GetAllUsers();
            if (users.Count > 0)
                lblEmptyUsers.Visible = false;
            foreach (UserModel user in users)
            {
                UCUserCard userCard = new UCUserCard(user: user);
                userCard.Dock = DockStyle.Top;
                userCard.Margin = new Padding(10);
                flpUsersList.Controls.Add(userCard);
            }
        }
        private void LoadVegetablesTable()
        {
            using var vegetalController = new VegetalController();
            List<VegetalModel> vegetables = vegetalController.GetAllVegetables();
            if (vegetables.Count > 0)
                lblEmptyVegetables.Visible = false;
            foreach (VegetalModel vegetable in vegetables)
            {
                UCVegetalCard vegetalCard = new UCVegetalCard(vegetal: vegetable);
                vegetalCard.Dock = DockStyle.Top;
                vegetalCard.Margin = new Padding(10);
                tabVegetablesArea.Controls.Add(vegetalCard);
            }
        }
        private void LoadAnimalsTable()
        {
            using var animalController = new AnimalController();
            List<AnimalModel> animals = animalController.GetAllAnimals();
            if (animals.Count > 0)
                lblEmptyAnimals.Visible = false;
            foreach (AnimalModel animal in animals)
            {
                UCAnimalCard animalCard = new UCAnimalCard(animal: animal);
                animalCard.Dock = DockStyle.Top;
                animalCard.Margin = new Padding(10);
                tabAnimalArea.Controls.Add(animalCard);
            }
        }
        private void LoadFormativeEnvironments()
        {
            using var environmentController = new FormativeEnvironmentController();
            List<FormativeEnvironmentModel> formativeEnvironments = environmentController.GetAllFormativeEnvironments();
            if (formativeEnvironments.Count > 0)
                lblEmptyFormativeEnvironments.Visible = false;
            foreach (FormativeEnvironmentModel formativeEnvironment in formativeEnvironments)
            {
                UCFormativeEnvironmentCard formativeEnvironmentCard = new UCFormativeEnvironmentCard(formativeEnvironment: formativeEnvironment);
                formativeEnvironmentCard.Dock = DockStyle.Top;
                formativeEnvironmentCard.Margin = new Padding(10);
                tabEntorno.Controls.Add(formativeEnvironmentCard);
            }
        }
        private void LoadProductTable()
        {
            using var ProducController = new ProductController();
            List<ProductModel> products = ProducController.GetAllProduct();
            if (products.Count > 0)
                lblEmptyProducts.Visible = false;
            foreach (ProductModel pro in products)
            {
                UCProductosCard prodCard = new UCProductosCard(pro);
                prodCard.Dock = DockStyle.Top;
                prodCard.Margin = new Padding(0, 0, 0, 20);
                tabProduct.Controls.Add(prodCard);
            }
        }
        private void LoadSellsTable()
        {
            using var sellsController = new SellsController();
            List<SellsModel> sells = sellsController.GetAllSells();
            if (sells.Count > 0)
                lblEmptyProducts.Visible = false;
            foreach (SellsModel se in sells)
            {
                UCSellsCard sellsCard = new UCSellsCard(se);
                sellsCard.Dock = DockStyle.Top;
                sellsCard.Margin = new Padding(0, 0, 0, 20);
                tabProduct.Controls.Add(sellsCard);
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
            // Guardar el estado actual del tab si no está guardado o si ha cambiado
            if (!originalTabContents.ContainsKey(tabPage))
            {
                var controls = new List<Control>();
                foreach (Control control in tabPage.Controls)
                {
                    controls.Add(control);
                }
                originalTabContents[tabPage] = controls;
            }

            uc.Dock = DockStyle.Fill;
            tabPage.Controls.Clear();
            tabPage.Controls.Add(uc);
        }

        public void RestaurarFormularioTab(System.Windows.Forms.TabPage tabPage)
        {
            // Limpiar el contenido actual
            tabPage.Controls.Clear();

            // Verificar si hay contenido original guardado para este tab
            if (originalTabContents.ContainsKey(tabPage))
            {
                // Restaurar el contenido original
                foreach (Control control in originalTabContents[tabPage])
                {
                    tabPage.Controls.Add(control);
                }
            }
            else
            {
                // Si no hay contenido guardado, recargar según el tipo de tab
                ReloadTabContent(tabPage);
            }
        }

        private void ReloadTabContent(System.Windows.Forms.TabPage tabPage)
        {
            // Identificar qué tab es y recargar su contenido apropiado
            if (tabPage == tabUsers)
            {
                LoadUsersTable();
            }
            else if (tabPage == tabVegetablesArea)
            {
                LoadVegetablesTable();
            }
            else if (tabPage == tabAnimalArea)
            {
                LoadAnimalsTable();
            }
            else if (tabPage == tabEntorno)
            {
                LoadFormativeEnvironments();
            }
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
            UCBuysAdd AddControl = new UCBuysAdd(currentUser);
            this.VerFormularioTab(AddControl, tabCompras);
        }

        private void btnAddVentas_Click(object sender, EventArgs e)
        {
            UCSellsAdd AddControl = new UCSellsAdd(currentUser);
            this.VerFormularioTab(AddControl, tabVentas);
        }

        private void tabCerrarSesion_Click(object sender, EventArgs e)
        {
            // Reiniciar el programa
            Application.Restart();
        }
    }
}
