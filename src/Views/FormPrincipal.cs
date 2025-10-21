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

        private RoleController roleController;
        private AnimalController animalController;
        public FormPrincipal(UserModel currentUser)
        {
            roleController = new RoleController();
            this.currentUser = currentUser;
            UIConfig.GetSkinManager().AddFormToManage(this);
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            LoadCards();
            SaveOriginalTabContents();

            // Posicionar botones flotantes
            PositionFloatingButtons();
        }

        private void PositionFloatingButtons()
        {
            // Los botones flotantes están dentro de cada TabPage, no en el formulario directamente
            foreach (System.Windows.Forms.TabPage tabPage in tcPrincipal.TabPages)
            {
                foreach (Control control in tabPage.Controls)
                {
                    if (control is ReaLTaiizor.Controls.MaterialFloatingActionButton btnFloat)
                    {
                        // Asegurar que tenga Anchor correcto
                        btnFloat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

                        // Recalcular posición basada en el tamaño del TabPage
                        btnFloat.Location = new Point(
                            tabPage.ClientSize.Width - btnFloat.Width - 20,
                            tabPage.ClientSize.Height - btnFloat.Height - 20
                        );

                        // Asegurar que esté al frente
                        btnFloat.BringToFront();
                    }
                }
            }
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
            try
            {
                LoadComboBoxesUsersFilter();
                LoadUsersTable();

                LoadComboBoxesFiltroVegetal();
                LoadVegetablesTable();

                LoadComboBoxesFiltroAnimals();
                LoadAnimalsTable();

                LoadComboBoxesEnvironmentsFilter();
                LoadFormativeEnvironments();

                LoadComboBoxesFiltroProduct();
                LoadProductTable();

                LoadBlackBoard();
                DefautlSelecForComboboxes();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void DefautlSelecForComboboxes()
        {
            // Establecer los valores predeterminados para los ComboBoxes de filtro
            cbEstadoFiltroAnimales.SelectedIndex = 0; // Establecer el valor predeterminado
            cbEntornoFiltroAnimales.SelectedIndex = 0; // Establecer el valor predeterminado
            cbTipoAnimalFiltro.SelectedIndex = 0; // Establecer el valor predeterminado
            cbEstadoProductivoFiltro.SelectedIndex = 0; // Establecer el valor predeterminado

            cbEstadoFiltroPlantas.SelectedIndex = 0; // Establecer el valor predeterminado
            cbEntornoFiltro.SelectedIndex = 0; // Establecer el valor predeterminado

            cbEstadoBusquedaEntonor.SelectedIndex = 0; // Establecer el valor predeterminado
            cbAreasFiltro.SelectedIndex = 0; // Establecer el valor predeterminado

            cbEstadoFiltroProducto.SelectedIndex = 0; // Establecer el valor predeterminado
            cbEntornosFiltroProducto.SelectedIndex = 0; // Establecer el valor predeterminado

        }
        private void LoadUsersTable()
        {
            UserController userController = new UserController();
            List<UserModel> users = new List<UserModel>();

            string? role = cbRole.SelectedIndex == 0 ? null : cbRole.SelectedItem?.ToString();

            int estado = cbEstadoUserSearch.SelectedIndex;

            string? searchText = "";
            if (tbSearchUsers.Text.Length > 2)
            {
                searchText = string.IsNullOrWhiteSpace(tbSearchUsers.Text) ? null : tbSearchUsers.Text;
            }
            users = userController.GetUsersForFilter(estado, role, searchText);

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
        private void LoadComboBoxesUsersFilter()
        {
            // Cargar Roles

            List<RoleModel> roles = roleController.GetAllRoles();
            foreach (RoleModel role in roles)
            {
                cbRole.Items.Add(role.Name);
            }
        }
        private void LoadVegetablesTable()
        {
            flpVegetalList.Controls.Clear();

            using var vegetalController = new VegetableController();

            string? entorno = cbEntornoFiltro.SelectedIndex == 0 ? null : cbEntornoFiltro.SelectedItem?.ToString();

            int estado = cbEstadoFiltroPlantas.SelectedIndex;

            string? searchText = "";

            if (tbSearchPlante.Text.Length > 2)
            {
                searchText = string.IsNullOrWhiteSpace(tbSearchPlante.Text) ? null : tbSearchPlante.Text;
            }

            List<VegetableModel> vegetables = vegetalController.GetVegetablesForFiltro(estado, entorno, searchText);
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

        private void LoadComboBoxesFiltroVegetal()
        {
            using var vegetalController = new VegetableController();
            try
            {
                // Limpiar los combos antes de cargar
                // cbEntornoFiltro.Items.Clear();

                // Cargar tipos de animales
                var formativeEnvironments = vegetalController.GetAllActiveFormativeEnvironments();

                foreach (var environment in formativeEnvironments)
                {
                    cbEntornoFiltro.Items.Add(environment.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAnimalsTable()
        {
            using var animalController = new AnimalController();

            string? entorno = cbEntornoFiltroAnimales.SelectedIndex == 0 ? null : cbEntornoFiltroAnimales.SelectedItem?.ToString();

            int estado = cbEstadoFiltroAnimales.SelectedIndex;

            string? searchText = "";

            string? animalType = cbTipoAnimalFiltro.SelectedIndex == 0 ? null : cbTipoAnimalFiltro.SelectedItem?.ToString();

            string? productiveState = cbEstadoProductivoFiltro.SelectedIndex == 0 ? null : cbEstadoProductivoFiltro.SelectedItem?.ToString();


            if (tbSeachAnimalFiltro.Text.Length > 2)
            {
                searchText = string.IsNullOrWhiteSpace(tbSeachAnimalFiltro.Text) ? null : tbSeachAnimalFiltro.Text;
            }

            List<AnimalModel> animals = animalController.GetAnimalsForFiltro(estado, entorno, searchText, animalType, productiveState);
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

        private void LoadComboBoxesFiltroAnimals()
        {
            using var animalController = new AnimalController();

            try
            {
                // Limpiar los combos antes de cargar
                // cbEntornoFiltro.Items.Clear();

                // Cargar tipos de animales
                var formativeEnvironments = animalController.GetAllActiveFormativeEnvironments();

                foreach (var environment in formativeEnvironments)
                {
                    cbEntornoFiltroAnimales.Items.Add(environment.Name);
                }

                var animalTypes = animalController.GetAnimalTypes();
                foreach (var type in animalTypes)
                {
                    cbTipoAnimalFiltro.Items.Add(type.Name);
                }
                // Cargar estados productivos
                cbEstadoProductivoFiltro.Items.AddRange(TabConfig.productiveStates.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFormativeEnvironments()
        {
            using var environmentController = new FormativeEnvironmentController();

            List<FormativeEnvironmentModel> formativeEnvironments = new List<FormativeEnvironmentModel>();

            string? area = cbAreasFiltro.SelectedIndex == 0 ? null : cbAreasFiltro.SelectedItem?.ToString();

            int estado = cbEstadoBusquedaEntonor.SelectedIndex;

            string? searchText = "";

            if (tbSeachFormativeEnvironments.Text.Length > 2)
            {
                searchText = string.IsNullOrWhiteSpace(tbSeachFormativeEnvironments.Text) ? null : tbSeachFormativeEnvironments.Text;
            }
            formativeEnvironments = environmentController.GetFormativeEnvironments(estado, area, searchText);

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

        private void LoadComboBoxesEnvironmentsFilter()
        {
            // Cargar áreas
            cbAreasFiltro.Items.AddRange(Config.defaultAreas.ToArray());
        }

        private void LoadProductTable()
        {
            using var ProducController = new ProductController();


            string? entorno = cbEntornosFiltroProducto.SelectedIndex == 0 ? null : cbEntornosFiltroProducto.SelectedItem?.ToString();

            int estado = cbEstadoFiltroProducto.SelectedIndex;

            string? searchText = "";

            if (tbSearchFiltroProducto.Text.Length > 2)
            {
                searchText = string.IsNullOrWhiteSpace(tbSearchFiltroProducto.Text) ? null : tbSearchFiltroProducto.Text;
            }

            List<ProductModel> products = ProducController.GetProductsForFiltro(estado, entorno, searchText);
            if (products.Count > 0)
                lblEmptyProducts.Visible = false;

            foreach (ProductModel pro in products)
            {
                UCProductCard prodCard = new UCProductCard(pro);
                prodCard.Dock = DockStyle.Top;
                prodCard.Margin = new Padding(0, 0, 0, 20);
                // Agregar directamente a la pestaña ya que no tiene FlowLayoutPanel en el Designer
                flpProductList.Controls.Add(prodCard);
            }
        }

        private void LoadComboBoxesFiltroProduct()
        {
            using var ProducController = new ProductController();

            try
            {
                // Limpiar los combos antes de cargar
                // cbEntornoFiltro.Items.Clear();

                // Cargar tipos de animales
                var formativeEnvironments = ProducController.GetAllActiveFormativeEnvironments();

                foreach (var environment in formativeEnvironments)
                {
                    cbEstadoFiltroProducto.Items.Add(environment.Name);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
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
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                ;
            }
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
                    PositionFloatingButtons();
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
            UCSellAdd AddControl = new UCSellAdd();
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

        private void CargarEnvironmentsSelec(object sender, EventArgs e)
        {
            flpFormativeEnvironmentsList.Controls.Clear();
            LoadFormativeEnvironments();
        }

        private void CargarUsersSelec(object sender, EventArgs e)
        {
            flpUsersList.Controls.Clear();
            LoadUsersTable();
        }

        private void CargarVegetalesSelec(object sender, EventArgs e)
        {
            flpVegetalList.Controls.Clear();
            LoadVegetablesTable();
        }

        private void CargarAnimalesSelec(object sender, EventArgs e)
        {
            flpAnimalsList.Controls.Clear();
            LoadAnimalsTable();
        }

        private void btnAddUser_Click_1(object sender, EventArgs e)
        {
            UCUserAdd AddControl = new UCUserAdd();
            this.VerFormularioTab(AddControl, tabUsers);
        }

        private void CargarProductoCBSelec(object sender, EventArgs e)
        {
            flpProductList.Controls.Clear();
            LoadProductTable();
        }
    }
}
