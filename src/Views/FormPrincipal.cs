using GestionAgraria.controllers;
using GestionAgraria.Controllers;
using GestionAgraria.models;
using GestionAgraria.Models;
using GestionAgraria.Views;
using GestionAgraria.Controls;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static GestionAgraria.Utils;

namespace GestionAgraria
{
    public partial class FormPrincipal : MaterialForm
    {
        private readonly UserModel currentUser;
        private readonly Dictionary<System.Windows.Forms.TabPage, List<Control>> originalTabContents = new Dictionary<System.Windows.Forms.TabPage, List<Control>>();

        private RoleController roleController;
        private AnimalController animalController;

        private UCPaginator paginatorUsers;
        private UCPaginator paginatorVegetables;
        private UCPaginator paginatorAnimals;
        private UCPaginator paginatorEnvironments;
        private UCPaginator paginatorProducts;
        private UCPaginator paginatorBlackBoards;

        private System.Windows.Forms.Timer? resizeTimerUsers;
        private System.Windows.Forms.Timer? resizeTimerVegetables;
        private System.Windows.Forms.Timer? resizeTimerAnimals;
        private System.Windows.Forms.Timer? resizeTimerEnvironments;
        private System.Windows.Forms.Timer? resizeTimerProducts;
        private System.Windows.Forms.Timer? resizeTimerBlackBoards;

        public FormPrincipal(UserModel currentUser)
        {
            roleController = new RoleController();
            this.currentUser = currentUser;
            UIConfig.GetSkinManager().AddFormToManage(this);
            InitializeComponent(); ;
            InitializeResizeTimers();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            SaveOriginalTabContents();
            LoadCards();


            flpUsersList.ClientSizeChanged += (s, ev) => { resizeTimerUsers?.Stop(); resizeTimerUsers?.Start(); };
            flpVegetalList.ClientSizeChanged += (s, ev) => { resizeTimerVegetables?.Stop(); resizeTimerVegetables?.Start(); };
            flpAnimalsList.ClientSizeChanged += (s, ev) => { resizeTimerAnimals?.Stop(); resizeTimerAnimals?.Start(); };
            flpFormativeEnvironmentsList.ClientSizeChanged += (s, ev) => { resizeTimerEnvironments?.Stop(); resizeTimerEnvironments?.Start(); };
            flpProductList.ClientSizeChanged += (s, ev) => { resizeTimerProducts?.Stop(); resizeTimerProducts?.Start(); };
            flowLayoutPanel4.ClientSizeChanged += (s, ev) => { resizeTimerBlackBoards?.Stop(); resizeTimerBlackBoards?.Start(); };

            PositionFloatingButtons();
        }

        private UCPaginator EnsurePaginatorExists(ref UCPaginator? paginator, System.Windows.Forms.TabPage tabPage, EventHandler<int> pageChangedHandler)
        {
            if (paginator == null)
            {
                Debug.WriteLine($"[PAGINATOR] Creando nuevo paginador para tab: {tabPage.Name}");
                paginator = new UCPaginator();
                paginator.Dock = DockStyle.Bottom;
                paginator.PageChanged += pageChangedHandler;
                tabPage.Controls.Add(paginator);
                paginator.BringToFront();
                Debug.WriteLine($"[PAGINATOR] Paginador creado y agregado. Visible: {paginator.Visible}, Dock: {paginator.Dock}");
            }
            else
            {
                Debug.WriteLine($"[PAGINATOR] Paginador ya existe para tab: {tabPage.Name}");
            }
            return paginator;
        }

        private void InitializeResizeTimers()
        {
            resizeTimerUsers = new System.Windows.Forms.Timer { Interval = 300 };
            resizeTimerUsers.Tick += (s, e) => { resizeTimerUsers.Stop(); flpUsersList.Controls.Clear(); LoadUsersTable(); };

            resizeTimerVegetables = new System.Windows.Forms.Timer { Interval = 300 };
            resizeTimerVegetables.Tick += (s, e) => { resizeTimerVegetables.Stop(); flpVegetalList.Controls.Clear(); LoadVegetablesTable(); };

            resizeTimerAnimals = new System.Windows.Forms.Timer { Interval = 300 };
            resizeTimerAnimals.Tick += (s, e) => { resizeTimerAnimals.Stop(); flpAnimalsList.Controls.Clear(); LoadAnimalsTable(); };

            resizeTimerEnvironments = new System.Windows.Forms.Timer { Interval = 300 };
            resizeTimerEnvironments.Tick += (s, e) => { resizeTimerEnvironments.Stop(); flpFormativeEnvironmentsList.Controls.Clear(); LoadFormativeEnvironments(); };

            resizeTimerProducts = new System.Windows.Forms.Timer { Interval = 300 };
            resizeTimerProducts.Tick += (s, e) => { resizeTimerProducts.Stop(); flpProductList.Controls.Clear(); LoadProductTable(); };

            resizeTimerBlackBoards = new System.Windows.Forms.Timer { Interval = 300 };
            resizeTimerBlackBoards.Tick += (s, e) => { resizeTimerBlackBoards.Stop(); flowLayoutPanel4.Controls.Clear(); LoadBlackBoard(); };
        }

        private void PositionFloatingButtons()
        {
            foreach (System.Windows.Forms.TabPage tabPage in tcPrincipal.TabPages)
            {
                foreach (Control control in tabPage.Controls)
                {
                    if (control is ReaLTaiizor.Controls.MaterialFloatingActionButton btnFloat)
                    {
                        btnFloat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

                        btnFloat.Location = new Point(
                            tabPage.ClientSize.Width - btnFloat.Width - 20,
                            tabPage.ClientSize.Height - btnFloat.Height - 20
                        );

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
                Debug.WriteLine($"[SAVE_ORIGINAL] Tab: {tabPage.Name}, Controles guardados: {controls.Count}");
            }
        }

        public void LoadCards(Type? clearObjectsOfType = null)
        {
            Debug.WriteLine("[LOAD_CARDS] Iniciando carga de cards...");
            if (clearObjectsOfType != null)
            {
                foreach (System.Windows.Forms.TabPage tabPage in tcPrincipal.TabPages)
                {
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
                Debug.WriteLine($"[LOAD_CARDS] ERROR: {ex.Message}");
                Debug.WriteLine(ex);
            }
        }

        private void DefautlSelecForComboboxes()
        {
            cbEstadoFiltroAnimales.SelectedIndex = 0; cbEntornoFiltroAnimales.SelectedIndex = 0; cbTipoAnimalFiltro.SelectedIndex = 0; cbEstadoProductivoFiltro.SelectedIndex = 0;
            cbEstadoFiltroPlantas.SelectedIndex = 0; cbEntornoFiltro.SelectedIndex = 0;
            cbEstadoBusquedaEntonor.SelectedIndex = 0; cbAreasFiltro.SelectedIndex = 0;
            cbEstadoFiltroProducto.SelectedIndex = 0; cbEntornosFiltroProducto.SelectedIndex = 0;
        }

        private void LoadCardsInGrid<T>(FlowLayoutPanel panel, List<T> items, Func<T, UserControl> createCard)
        {
            panel.SuspendLayout();
            panel.Controls.Clear();

            panel.AutoScroll = false;
            panel.WrapContents = true;
            panel.FlowDirection = FlowDirection.LeftToRight;

            if (items == null || items.Count == 0)
            {
                panel.ResumeLayout();
                return;
            }

            int availableWidth = panel.ClientSize.Width - panel.Padding.Horizontal;

            int margin = 10;
            int maxColumns = 3;
            int minCardWidth = 250;

            int maxPossibleColumns = Math.Max(1, (availableWidth + margin) / (minCardWidth + margin));
            int actualColumns = Math.Min(maxColumns, maxPossibleColumns);

            int standardCardWidth = (availableWidth - (margin * (actualColumns + 1))) / actualColumns;
            standardCardWidth = Math.Max(standardCardWidth, minCardWidth);

            int totalCards = items.Count;
            int fullRows = totalCards / actualColumns;
            int cardsInLastRow = totalCards % actualColumns;
            bool hasPartialLastRow = cardsInLastRow > 0;

            int lastRowCardWidth = standardCardWidth;
            if (hasPartialLastRow)
            {
                lastRowCardWidth = (availableWidth - (margin * (cardsInLastRow + 1))) / cardsInLastRow;
                lastRowCardWidth = Math.Max(lastRowCardWidth, minCardWidth);
            }

            int cardIndex = 0;
            foreach (var item in items)
            {
                bool isInLastRow = hasPartialLastRow && (cardIndex >= fullRows * actualColumns);

                var card = createCard(item);
                card.Width = isInLastRow ? lastRowCardWidth : standardCardWidth;
                card.Height = 70;
                card.Margin = new Padding(margin, margin, 0, 0);
                card.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                panel.Controls.Add(card);

                cardIndex++;
            }

            panel.ResumeLayout();
        }

        private void LoadUsersTable()
        {
            Debug.WriteLine("[LOAD_USERS] Iniciando carga de usuarios...");
            UserController userController = new UserController();
            List<UserModel> users = new List<UserModel>();

            string? role = cbRole.SelectedIndex == 0 ? null : cbRole.SelectedItem?.ToString();
            int estado = cbEstadoUserSearch.SelectedIndex;
            string? searchText = "";

            if (tbSearchUsers.Text.Length > 2)
            {
                searchText = string.IsNullOrWhiteSpace(tbSearchUsers.Text) ? null : tbSearchUsers.Text;
            }

            int currentPage = paginatorUsers?.CurrentPage ?? 1;
            int pageSize = UCPaginator.GetPageSize();

            Debug.WriteLine($"[LOAD_USERS] Obteniendo usuarios - Página: {currentPage}, PageSize: {pageSize}");
            users = userController.GetUsersForFilter(estado, role, searchText, currentPage, pageSize);
            int totalCount = userController.GetUsersCountForFilter(estado, role, searchText);
            int totalPages = UCPaginator.CalculateTotalPages(totalCount);

            Debug.WriteLine($"[LOAD_USERS] Usuarios obtenidos: {users.Count}, Total: {totalCount}, Páginas: {totalPages}");
            Debug.WriteLine($"[LOAD_USERS] paginatorUsers es null: {paginatorUsers == null}");

            var paginator = EnsurePaginatorExists(ref paginatorUsers, tabUsers, (s, page) => LoadUsersTable());
            paginator.TotalPages = totalPages;

            Debug.WriteLine($"[LOAD_USERS] Paginador configurado - TotalPages: {paginator.TotalPages}, Visible: {paginator.Visible}, Parent: {paginator.Parent?.Name}");
            Debug.WriteLine($"[LOAD_USERS] Controles en tabUsers: {tabUsers.Controls.Count}");
            foreach (Control ctrl in tabUsers.Controls)
            {
                Debug.WriteLine($"  - {ctrl.GetType().Name} ({ctrl.Name}), Visible: {ctrl.Visible}, Dock: {ctrl.Dock}");
            }

            if (users.Count > 0)
                lblEmptyUsers.Visible = false;

            LoadCardsInGrid(flpUsersList, users, user => new UCUserCard(user));
            Debug.WriteLine("[LOAD_USERS] Carga completada");
        }
        private void LoadComboBoxesUsersFilter()
        {

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

            int currentPage = paginatorVegetables?.CurrentPage ?? 1;
            int pageSize = UCPaginator.GetPageSize();

            List<VegetableModel> vegetables = vegetalController.GetVegetablesForFiltro(estado, entorno, searchText, currentPage, pageSize);
            int totalCount = vegetalController.GetVegetablesCountForFilter(estado, entorno, searchText);
            int totalPages = UCPaginator.CalculateTotalPages(totalCount);

            var paginator = EnsurePaginatorExists(ref paginatorVegetables, tabVegetablesArea, (s, page) => LoadVegetablesTable());
            paginator.TotalPages = totalPages;

            if (vegetables.Count > 0)
                lblEmptyVegetables.Visible = false;

            LoadCardsInGrid(flpVegetalList, vegetables, vegetable => new UCVegetableCard(vegetable));
        }

        private void LoadComboBoxesFiltroVegetal()
        {
            using var vegetalController = new VegetableController();
            try
            {

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

            int currentPage = paginatorAnimals?.CurrentPage ?? 1;
            int pageSize = UCPaginator.GetPageSize();

            List<AnimalModel> animals = animalController.GetAnimalsForFiltro(estado, entorno, searchText, animalType, productiveState, currentPage, pageSize);
            int totalCount = animalController.GetAnimalsCountForFilter(estado, entorno, searchText, animalType, productiveState);
            int totalPages = UCPaginator.CalculateTotalPages(totalCount);

            var paginator = EnsurePaginatorExists(ref paginatorAnimals, tabAnimalArea, (s, page) => LoadAnimalsTable());
            paginator.TotalPages = totalPages;

            if (animals.Count > 0)
                lblEmptyAnimals.Visible = false;

            LoadCardsInGrid(flpAnimalsList, animals, animal => new UCAnimalCard(animal));
        }

        private void LoadComboBoxesFiltroAnimals()
        {
            using var animalController = new AnimalController();

            try
            {

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

            int currentPage = paginatorEnvironments?.CurrentPage ?? 1;
            int pageSize = UCPaginator.GetPageSize();

            formativeEnvironments = environmentController.GetFormativeEnvironments(estado, area, searchText, currentPage, pageSize);
            int totalCount = environmentController.GetFormativeEnvironmentsCountForFilter(estado, area, searchText);
            int totalPages = UCPaginator.CalculateTotalPages(totalCount);

            var paginator = EnsurePaginatorExists(ref paginatorEnvironments, tabEntorno, (s, page) => LoadFormativeEnvironments());
            paginator.TotalPages = totalPages;

            if (formativeEnvironments.Count > 0)
                lblEmptyFormativeEnvironments.Visible = false;

            LoadCardsInGrid(flpFormativeEnvironmentsList, formativeEnvironments, env => new UCFormativeEnvironmentCard(env));
        }

        private void LoadComboBoxesEnvironmentsFilter()
        {
            cbAreasFiltro.Items.AddRange(Config.defaultAreas.ToArray());
        }

        public static int currentPage = 1;
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

            int currentPage = paginatorProducts?.CurrentPage ?? 10;
            int pageSize = UCPaginator.GetPageSize();

            List<ProductModel> products = ProducController.GetProductsForFiltro(estado, entorno, searchText, currentPage, pageSize);
            int totalCount = ProducController.GetProductsCountForFilter(estado, entorno, searchText);
            int totalPages = UCPaginator.CalculateTotalPages(totalCount);

            var paginator = EnsurePaginatorExists(ref paginatorProducts, tabProduct, (s, page) => LoadProductTable());
            paginator.TotalPages = totalPages;

            if (products.Count > 0)
                lblEmptyProducts.Visible = false;

            LoadCardsInGrid(flpProductList, products, product => new UCProductCard(product));
        }

        private void LoadComboBoxesFiltroProduct()
        {
            using var ProducController = new ProductController();

            try
            {

                var formativeEnvironments = ProducController.GetAllActiveFormativeEnvironments();

                foreach (var environment in formativeEnvironments)
                {
                    cbEntornosFiltroProducto.Items.Add(environment.Name);
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

            int currentPage = paginatorBlackBoards?.CurrentPage ?? 1;
            int pageSize = UCPaginator.GetPageSize();

            List<BlackBoardModel> blackboards = blackBoardController.GetAllBlackBoards(currentPage, pageSize);
            int totalCount = blackBoardController.GetBlackBoardsCount();
            int totalPages = UCPaginator.CalculateTotalPages(totalCount);

            var paginator = EnsurePaginatorExists(ref paginatorBlackBoards, tabBlackBoard, (s, page) => LoadBlackBoard());
            paginator.TotalPages = totalPages;

            if (blackboards.Count > 0)
                lblEmptyBlackBoards.Visible = false;

            LoadCardsInGrid(flowLayoutPanel4, blackboards, blackboard => new UCBlackBoardCard(blackboard));
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
            Debug.WriteLine($"[RESTORE_TAB] Restaurando tab: {tabPage.Name}");

            tabPage.Controls.Clear();

            if (originalTabContents.ContainsKey(tabPage))
            {
                Debug.WriteLine($"[RESTORE_TAB] Restaurando {originalTabContents[tabPage].Count} controles originales");
                foreach (Control control in originalTabContents[tabPage])
                {
                    if (!tabPage.Controls.Contains(control))
                    {
                        tabPage.Controls.Add(control);
                        Debug.WriteLine($"  - Restaurado: {control.GetType().Name} ({control.Name})");
                    }
                }
                PositionFloatingButtons();
            }

            RemoveDynamicControls(tabPage);

            ReloadTabContent(tabPage);

            Debug.WriteLine($"[RESTORE_TAB] Controles finales en {tabPage.Name}: {tabPage.Controls.Count}");
            foreach (Control ctrl in tabPage.Controls)
            {
                Debug.WriteLine($"  - {ctrl.GetType().Name} ({ctrl.Name}), Visible: {ctrl.Visible}, Dock: {ctrl.Dock}");
            }
        }

        private void RemoveDynamicControls(System.Windows.Forms.TabPage tabPage)
        {
            if (tabPage == tabUsers)
            {
                flpUsersList.Controls.Clear();
                lblEmptyUsers.Visible = true;
            }
            else if (tabPage == tabVegetablesArea)
            {
                flpVegetalList.Controls.Clear();
                lblEmptyVegetables.Visible = true;
            }
            else if (tabPage == tabAnimalArea)
            {
                flpAnimalsList.Controls.Clear();
                lblEmptyAnimals.Visible = true;
            }
            else if (tabPage == tabEntorno)
            {
                flpFormativeEnvironmentsList.Controls.Clear();
                lblEmptyFormativeEnvironments.Visible = true;
            }
            else if (tabPage == tabProduct)
            {
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
                flowLayoutPanel4.Controls.Clear();
                lblEmptyBlackBoards.Visible = true;
            }
        }

        private void ReloadTabContent(System.Windows.Forms.TabPage tabPage)
        {
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
            Application.Restart();
        }

        private void btnAddBlackBoard_Click(object sender, EventArgs e)
        {
            UCBlackBoardAdd AddControl = new UCBlackBoardAdd();
            this.VerFormularioTab(AddControl, tabBlackBoard);
        }

        private void CargarEnvironmentsSelec(object sender, EventArgs e)
        {
            paginatorEnvironments?.Reset();
            flpFormativeEnvironmentsList.Controls.Clear();
            LoadFormativeEnvironments();
        }

        private void CargarUsersSelec(object sender, EventArgs e)
        {
            paginatorUsers?.Reset();
            flpUsersList.Controls.Clear();
            LoadUsersTable();
        }

        private void CargarVegetalesSelec(object sender, EventArgs e)
        {
            paginatorVegetables?.Reset();
            flpVegetalList.Controls.Clear();
            LoadVegetablesTable();
        }

        private void CargarAnimalesSelec(object sender, EventArgs e)
        {
            paginatorAnimals?.Reset();
            flpAnimalsList.Controls.Clear();
            LoadAnimalsTable();
        }

        private void CargarProductoCBSelec(object sender, EventArgs e)
        {
            paginatorProducts?.Reset();
            flpProductList.Controls.Clear();
            LoadProductTable();
        }

    }
}
