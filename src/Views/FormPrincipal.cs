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
            LoadBlackBoard();
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
            using var vegetalController = new VegetableController();
            List<VegetableModel> vegetables = vegetalController.GetAllVegetables();
            if (vegetables.Count > 0)
                lblEmptyVegetables.Visible = false;
            foreach (VegetableModel vegetable in vegetables)
            {
                UCVegetableCard vegetalCard = new UCVegetableCard(vegetal: vegetable);
                vegetalCard.Dock = DockStyle.Top;
                vegetalCard.Margin = new Padding(10);
                // Usar el FlowLayoutPanel correcto según el Designer
                flpVegetalList.Controls.Add(vegetalCard);
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
                // Usar el FlowLayoutPanel correcto
                flpAnimalsList.Controls.Add(animalCard);
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
                // Usar el FlowLayoutPanel correcto
                flpFormativeEnvironmentsList.Controls.Add(formativeEnvironmentCard);
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
                UCProductCard prodCard = new UCProductCard(pro);
                prodCard.Dock = DockStyle.Top;
                prodCard.Margin = new Padding(0, 0, 0, 20);
                // Agregar directamente a la pestaña ya que no tiene FlowLayoutPanel en el Designer
                tabProduct.Controls.Add(prodCard);
            }
        }
        private void LoadBlackBoard()
        {
            using var blackBoardController = new BlackBoardController();
            List<BlackBoardModel> blackboards = blackBoardController.GetAllBlackBoards();
            if (blackboards.Count > 0)
                lblEmptyBlackBoards.Visible = false;
            foreach (BlackBoardModel blackboard in blackboards)
            {
                UCBlackBoardCard blackboardCard = new UCBlackBoardCard(blackboard: blackboard);
                blackboardCard.Dock = DockStyle.Top;
                blackboardCard.Margin = new Padding(10);
                // Usar el FlowLayoutPanel correcto
                flowLayoutPanel4.Controls.Add(blackboardCard);
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
            // Paso 1: Limpiar la pestaña completamente (esto elimina el formulario Add)
            tabPage.Controls.Clear();

            // Paso 2: Restaurar los controles originales del Designer
            if (originalTabContents.ContainsKey(tabPage))
            {
                foreach (Control control in originalTabContents[tabPage])
                {
                    tabPage.Controls.Add(control);
                }
            }

            // Paso 3: Limpiar solo las tarjetas dinámicas de los contenedores
            RemoveDynamicControls(tabPage);

            // Paso 4: Recargar el contenido específico del tab
            ReloadTabContent(tabPage);
        }

        private void RemoveDynamicControls(System.Windows.Forms.TabPage tabPage)
        {
            // Identificar y limpiar solo los contenedores de datos dinámicos
            if (tabPage == tabUsers)
            {
                // Limpiar solo las tarjetas del FlowLayoutPanel, no el FlowLayoutPanel mismo
                flpUsersList.Controls.Clear();
                lblEmptyUsers.Visible = true;
            }
            else if (tabPage == tabVegetablesArea)
            {
                // Limpiar solo el FlowLayoutPanel de vegetales
                flpVegetalList.Controls.Clear();
                lblEmptyVegetables.Visible = true;
            }
            else if (tabPage == tabAnimalArea)
            {
                // Limpiar solo el FlowLayoutPanel de animales
                flpAnimalsList.Controls.Clear();
                lblEmptyAnimals.Visible = true;
            }
            else if (tabPage == tabEntorno)
            {
                // Limpiar solo el FlowLayoutPanel de entornos formativos
                flpFormativeEnvironmentsList.Controls.Clear();
                lblEmptyFormativeEnvironments.Visible = true;
            }
            else if (tabPage == tabProduct)
            {
                // Para productos, limpiar solo las tarjetas que se agregan directamente a la pestaña
                var controlsToRemove = tabProduct.Controls.Cast<Control>()
                    .Where(c => c is UCProductCard)
                    .ToList();
                foreach (var control in controlsToRemove)
                {
                    tabProduct.Controls.Remove(control);
                    control.Dispose();
                }
                lblEmptyProducts.Visible = true;
            }
            else if (tabPage == tabBlackBoard)
            {
                // Limpiar solo el FlowLayoutPanel de pizarrones
                flowLayoutPanel4.Controls.Clear();
                lblEmptyBlackBoards.Visible = true;
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
            else if (tabPage == tabProduct)
            {
                LoadProductTable();
            }
            else if (tabPage == tabBlackBoard)
            {
                LoadBlackBoard();
            }
        }

        // También actualizar el método ReloadTabContent() sin parámetros para manejar todos los tabs
        private void ReloadTabContent()
        {
            // Limpiar todos los contenedores antes de cargar
            flpUsersList.Controls.Clear();
            tabVegetablesArea.Controls.Clear();
            tabAnimalArea.Controls.Clear();
            tabEntorno.Controls.Clear();
            tabProduct.Controls.Clear();
            tabBlackBoard.Controls.Clear();

            // Resetear todos los labels de vacío
            lblEmptyUsers.Visible = true;
            lblEmptyVegetables.Visible = true;
            lblEmptyAnimals.Visible = true;
            lblEmptyFormativeEnvironments.Visible = true;
            lblEmptyProducts.Visible = true;
            lblEmptyBlackBoards.Visible = true;

            // Cargar todo el contenido
            LoadUsersTable();
            LoadVegetablesTable();
            LoadAnimalsTable();
            LoadFormativeEnvironments();
            LoadProductTable();
            LoadBlackBoard();
        }

        private void btnAddPlanta_Click(object sender, EventArgs e)
        {
            UCVegetableAdd AddControl = new UCVegetableAdd();
            this.VerFormularioTab(AddControl, tabVegetablesArea);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            UCProductAdd AddControl = new UCProductAdd();
            this.VerFormularioTab(AddControl, tabProduct);
        }

        private void btnAddCompras_Click(object sender, EventArgs e)
        {
            UCPurchasesAdd AddControl = new UCPurchasesAdd();
            this.VerFormularioTab(AddControl, tabCompras);
        }

        private void btnAddVentas_Click(object sender, EventArgs e)
        {
            UCSellAdd AddControl = new UCSellAdd(currentUser);
            this.VerFormularioTab(AddControl, tabVentas);
        }

        private void tabCerrarSesion_Click(object sender, EventArgs e)
        {
            // Reiniciar el programa
            Application.Restart();
        }

        private void btnAddBlackBoard_Click(object sender, EventArgs e)
        {
            UCBlackBoardAdd AddControl = new UCBlackBoardAdd();
            this.VerFormularioTab(AddControl, tabBlackBoard);
        }
    }
}
