using GestionAgraria.controllers;
using GestionAgraria.Controllers;
using GestionAgraria.models;
using GestionAgraria.Models;
using GestionAgraria.Views;
using GestionAgraria.Controls;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static GestionAgraria.Core.Utils;
using GestionAgraria.Core;

namespace GestionAgraria
{
    public partial class FormPrincipal : MaterialForm
    {
        public readonly UserModel currentUser = Session.CurrentUser!;
        private readonly Dictionary<System.Windows.Forms.TabPage, List<Control>> originalTabContents = new Dictionary<System.Windows.Forms.TabPage, List<Control>>();

        private RoleController roleController;
        private AnimalController animalController;

        private Controls.Paginator paginatorUsers;
        private Controls.Paginator paginatorVegetables;
        private Controls.Paginator paginatorAnimals;
        private Controls.Paginator paginatorEnvironments;
        private Controls.Paginator paginatorProducts;
        private Controls.Paginator paginatorPurchases;
        private Controls.Paginator paginatorBlackBoards;
        private Controls.Paginator paginatorSells;
        private Controls.Paginator paginatorActivityRecord;

        private System.Windows.Forms.Timer? resizeTimerUsers;
        private System.Windows.Forms.Timer? resizeTimerVegetables;
        private System.Windows.Forms.Timer? resizeTimerAnimals;
        private System.Windows.Forms.Timer? resizeTimerEnvironments;
        private System.Windows.Forms.Timer? resizeTimerProducts;
        private System.Windows.Forms.Timer? resizeTimerActivityRecord;
        private System.Windows.Forms.Timer? resizeTimerPurchases;
        private System.Windows.Forms.Timer? resizeTimerSells;

        // Lista estática para productos seleccionados
        public static List<ProductModel> SelectedProducts = new List<ProductModel>();
        public static List<PurchaseModel> SelectedPurchases = new List<PurchaseModel>();
        public static List<SellModel> SelectedSells = new List<SellModel>();

        public FormPrincipal()
        {
            roleController = new RoleController();
            UIConfig.GetSkinManager().AddFormToManage(this);
            InitializeComponent();
            InitializeResizeTimers();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //Es necessario ? Verlo en clases hoy
            Utils.DeshabilitarShortcuts(this);

            SaveOriginalTabContents();
            LoadCards();
            flpUsersList.ClientSizeChanged += (s, ev) => { resizeTimerUsers?.Stop(); resizeTimerUsers?.Start(); };
            flpVegetalList.ClientSizeChanged += (s, ev) => { resizeTimerVegetables?.Stop(); resizeTimerVegetables?.Start(); };
            flpAnimalsList.ClientSizeChanged += (s, ev) => { resizeTimerAnimals?.Stop(); resizeTimerAnimals?.Start(); };
            flpFormativeEnvironmentsList.ClientSizeChanged += (s, ev) => { resizeTimerEnvironments?.Stop(); resizeTimerEnvironments?.Start(); };
            flpProductList.ClientSizeChanged += (s, ev) => { resizeTimerProducts?.Stop(); resizeTimerProducts?.Start(); };
            flpActivityRecordList.ClientSizeChanged += (s, ev) => { resizeTimerActivityRecord?.Stop(); resizeTimerActivityRecord?.Start(); };
            flpPurchasesList.ClientSizeChanged += (s, ev) => { resizeTimerPurchases?.Stop(); resizeTimerPurchases?.Start(); };
            flpSellsList.ClientSizeChanged += (s, ev) => { resizeTimerSells?.Stop(); resizeTimerSells?.Start(); };
            PositionFloatingButtons();
            SetTabPermissions();
        }
        private Controls.Paginator EnsurePaginatorExists(ref Controls.Paginator? paginator, System.Windows.Forms.TabPage tabPage, EventHandler<int> pageChangedHandler)
        {
            try
            {

                if (paginator == null)
                {
                    Debug.WriteLine($"[PAGINATOR] Creando nuevo paginador para tab: {tabPage.Name}");
                    paginator = new Controls.Paginator();
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
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
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

            resizeTimerPurchases = new System.Windows.Forms.Timer { Interval = 300 };
            resizeTimerPurchases.Tick += (s, e) => { resizeTimerPurchases.Stop(); flpPurchasesList.Controls.Clear(); LoadPurchasesTable(); };

            resizeTimerSells = new System.Windows.Forms.Timer { Interval = 300 };
            resizeTimerSells.Tick += (s, e) => { resizeTimerSells.Stop(); flpSellsList.Controls.Clear(); LoadSellsTable(); };
            //resizeTimerBlackBoards.Tick += (s, e) => { resizeTimerBlackBoards.Stop(); flowLayoutPanel4.Controls.Clear(); LoadBlackBoard(); };
        }

        private void PositionFloatingButtons()
        {
            // Position buttons in main tab control
            PositionFloatingButtonsInTabControl(tcPrincipal);
        }

        /// <summary>
        /// Recursively positions all MaterialFloatingActionButton controls at the bottom-right 
        /// of their parent containers with proper margin
        /// </summary>
        /// <param name="tabControl">The TabControl to process</param>
        private void PositionFloatingButtonsInTabControl(ReaLTaiizor.Controls.MaterialTabControl tabControl)
        {
            const int MARGIN = 30; // Margin from the edges

            foreach (System.Windows.Forms.TabPage tabPage in tabControl.TabPages)
            {
                // First, recursively process nested TabControls
                foreach (Control control in tabPage.Controls)
                {
                    if (control is ReaLTaiizor.Controls.MaterialTabControl nestedTabControl)
                    {
                        PositionFloatingButtonsInTabControl(nestedTabControl);
                    }
                }

                // Then position floating buttons in this tab page
                PositionFloatingButtonsInContainer(tabPage, MARGIN);
            }
        }

        /// <summary>
        /// Positions all MaterialFloatingActionButton controls in a container
        /// at the bottom-right with the specified margin, stacked vertically
        /// </summary>
        /// <param name="container">The container control</param>
        /// <param name="margin">Margin from edges in pixels</param>
        private void PositionFloatingButtonsInContainer(Control container, int margin)
        {
            const int BUTTON_SPACING = 10; // Spacing between buttons

            var floatingButtons = new List<ReaLTaiizor.Controls.MaterialFloatingActionButton>();

            // Collect all floating buttons
            foreach (Control control in container.Controls)
            {
                if (control is ReaLTaiizor.Controls.MaterialFloatingActionButton btnFloat)
                {
                    floatingButtons.Add(btnFloat);
                }
            }

            if (floatingButtons.Count == 0)
                return;

            // Calculate starting Y position (bottom of container minus margin)
            int currentY = container.ClientSize.Height - margin;

            // Position buttons from bottom to top
            for (int i = floatingButtons.Count - 1; i >= 0; i--)
            {
                var btnFloat = floatingButtons[i];
                btnFloat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

                // Position button
                btnFloat.Location = new Point(
                    container.ClientSize.Width - btnFloat.Width - margin,
                    currentY - btnFloat.Height
                );

                btnFloat.BringToFront();

                // Move up for next button
                currentY -= (btnFloat.Height + BUTTON_SPACING);
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
            LoadTables();
        }

        private void LoadTables()
        {
            DefautlSelecForComboboxes();
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
            LoadComboBoxesFiltroPurchase();
            LoadPurchasesTable();
            LoadSellsTable();
        }

        private void DefautlSelecForComboboxes()
        {
            cbEstadoFiltroAnimales.SelectedIndex = 0; cbEntornoFiltroAnimales.SelectedIndex = 0; cbTipoAnimalFiltro.SelectedIndex = 0; cbEstadoProductivoFiltro.SelectedIndex = 0;
            cbEstadoFiltroPlantas.SelectedIndex = 0; cbEntornoFiltro.SelectedIndex = 0;
            cbEstadoBusquedaEntonor.SelectedIndex = 0; cbAreasFiltro.SelectedIndex = 0;
            cbEstadoFiltroProducto.SelectedIndex = 0; cbEntornosFiltroProducto.SelectedIndex = 0;
            cbUserFiltroInsumo.SelectedIndex = 0; cbUserVentaFiltro.SelectedIndex = 0;
            cbRegisteredUserFiltro.SelectedIndex = 0; cbStateRecordFiltro.SelectedIndex = 0; cbEntornosFiltroActividad.SelectedIndex = 0; cbEstadoActivityRecord.SelectedIndex = 0;
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
            int minCardWidth = 250;

            // Determinar cuántas columnas podemos tener (máximo 2)
            int maxColumns = 2;
            int possibleColumns = Math.Max(1, availableWidth / (minCardWidth + margin));
            int actualColumns = Math.Min(maxColumns, possibleColumns);

            // Si solo cabe una columna o solo hay un item, usar el ancho completo
            if (actualColumns == 1 || items.Count == 1)
            {
                foreach (var item in items)
                {
                    var card = createCard(item);
                    card.Width = availableWidth;
                    card.Height = 70;
                    card.Margin = new Padding(0, margin, 0, 0);
                    card.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                    panel.Controls.Add(card);
                }
            }
            else
            {
                // Calcular el ancho de cada card para que ocupen el 100% en columnas
                int totalMargins = margin * (actualColumns - 1); // Márgenes entre cards
                int cardWidth = (availableWidth - totalMargins) / actualColumns;

                int cardIndex = 0;
                foreach (var item in items)
                {
                    var card = createCard(item);
                    card.Height = 70;

                    // Determinar si es la última card de una fila incompleta
                    int cardsRemaining = items.Count - cardIndex;
                    int currentRowPosition = cardIndex % actualColumns;
                    bool isLastInIncompleteRow = (cardsRemaining == 1 && currentRowPosition > 0);

                    if (isLastInIncompleteRow)
                    {
                        // Si es la última card y está sola en su posición, que ocupe el espacio restante
                        int remainingSpace = availableWidth - (currentRowPosition * (cardWidth + margin));
                        card.Width = remainingSpace;
                    }
                    else
                    {
                        card.Width = cardWidth;
                    }

                    // Margen solo a la izquierda (excepto la primera de cada fila) y arriba
                    int leftMargin = (currentRowPosition == 0) ? 0 : margin;
                    card.Margin = new Padding(leftMargin, margin, 0, 0);
                    card.Anchor = AnchorStyles.Top | AnchorStyles.Left;

                    panel.Controls.Add(card);
                    cardIndex++;
                }
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
            int pageSize = Paginator.GetPageSize();

            Debug.WriteLine($"[LOAD_USERS] Obteniendo usuarios - Página: {currentPage}, PageSize: {pageSize}");
            users = userController.GetUsersForFilter(estado, role, searchText, currentPage, pageSize);
            int totalCount = userController.GetUsersCountForFilter(estado, role, searchText);
            int totalPages = Paginator.CalculateTotalPages(totalCount);

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
            int pageSize = Paginator.GetPageSize();

            List<VegetableModel> vegetables = vegetalController.GetVegetablesForFiltro(estado, entorno, searchText, currentPage, pageSize);
            int totalCount = vegetalController.GetVegetablesCountForFilter(estado, entorno, searchText);
            int totalPages = Paginator.CalculateTotalPages(totalCount);

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
            int pageSize = Paginator.GetPageSize();

            List<AnimalModel> animals = animalController.GetAnimalsForFiltro(estado, entorno, searchText, animalType, productiveState, currentPage, pageSize);
            int totalCount = animalController.GetAnimalsCountForFilter(estado, entorno, searchText, animalType, productiveState);
            int totalPages = Paginator.CalculateTotalPages(totalCount);

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
            int pageSize = Paginator.GetPageSize();

            formativeEnvironments = environmentController.GetFormativeEnvironments(estado, area, searchText, currentPage, pageSize);
            int totalCount = environmentController.GetFormativeEnvironmentsCountForFilter(estado, area, searchText);
            int totalPages = Paginator.CalculateTotalPages(totalCount);

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
            using var productController = new ProductController();

            string? entorno = cbEntornosFiltroProducto.SelectedIndex == 0 ? null : cbEntornosFiltroProducto.SelectedItem?.ToString();
            int estado = cbEstadoFiltroProducto.SelectedIndex;
            string? searchText = "";

            if (tbSearchFiltroProducto.Text.Length > 2)
            {
                searchText = string.IsNullOrWhiteSpace(tbSearchFiltroProducto.Text) ? null : tbSearchFiltroProducto.Text;
            }

            int currentPage = paginatorProducts?.CurrentPage ?? 1;
            int pageSize = Paginator.GetPageSize();

            List<ProductModel> products = productController.GetProductsForFiltro(estado, entorno, searchText, currentPage, pageSize);
            int totalCount = productController.GetProductsCountForFilter(estado, entorno, searchText);
            int totalPages = Paginator.CalculateTotalPages(totalCount);

            var paginator = EnsurePaginatorExists(ref paginatorProducts, tabProducts, (s, page) => LoadProductTable());
            paginator.TotalPages = totalPages;

            if (products.Count > 0)
                lblEmptyProducts.Visible = false;

            LoadCardsInGrid(flpProductList, products, product => new UCProductCard(product));
        }

        private void LoadPurchasesTable()
        {
            using var purchaseController = new PurchaseController();
            int currentPage = paginatorPurchases?.CurrentPage ?? 1;
            int pageSize = Paginator.GetPageSize();

            List<PurchaseModel> purchases = purchaseController.GetAllPurchases(); // Cambiar próximamente por GetPurchasesForFiltro
            int totalCount = purchaseController.GetPurchasesCount(); // Cambiar próximamente por GetPurchasesCountForFilter
            int totalPages = Paginator.CalculateTotalPages(totalCount);

            var paginator = EnsurePaginatorExists(ref paginatorPurchases, tabPurchases, (s, page) => LoadPurchasesTable());
            paginator.TotalPages = totalPages;

            if (purchases.Count > 0)
                lblEmptyPurchases.Visible = false;
            LoadCardsInGrid(flpPurchasesList, purchases, purchase => new UCPurchaseCard(purchase));
        }

        private void LoadComboBoxesFiltroProduct()
        {
            using var productController = new ProductController();

            try
            {

                var formativeEnvironments = productController.GetAllActiveFormativeEnvironments();

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

        private void LoadSellsTable()
        {
            using var sellController = new SellController();

            int currentPage = paginatorSells?.CurrentPage ?? 1;
            int pageSize = GestionAgraria.Controls.Paginator.GetPageSize();

            string? usuario = cbUserVentaFiltro.SelectedIndex == 0 ? null : cbUserVentaFiltro.SelectedItem?.ToString();
            string? searchText = null;

            if (tbSearchFiltroVenta.Text.Length > 2) // <- asegurar que sea el textbox correcto
            {
                searchText = string.IsNullOrWhiteSpace(tbSearchFiltroVenta.Text) ? null : tbSearchFiltroVenta.Text;
            }

            List<SellModel> sells = sellController.GetSellsForFiltro(usuario, searchText, currentPage, pageSize);
            int totalCount = sellController.GetSellsCountForFiltro(usuario, searchText);
            int totalPages = Paginator.CalculateTotalPages(totalCount);

            var paginator = EnsurePaginatorExists(ref paginatorSells, tabSells, (s, page) => LoadSellsTable());
            paginator.TotalPages = totalPages;

            lblEmptySells.Visible = sells.Count == 0;

            LoadCardsInGrid(flpSellsList, sells, sell => new UCSellCard(sell));
        }

        private void LoadComboBoxesFiltroPurchase()
        {
            var userController = new UserController();

            try
            {
                var Users = userController.GetAllUsers();

                foreach (var user in Users)
                {
                    cbUserFiltroInsumo.Items.Add(user.Name);
                    cbUserVentaFiltro.Items.Add(user.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadActivityRecord()
        {
            try
            {

                var activityRecordController = new ActivityRecordController();

                string? usuario = cbRegisteredUserFiltro.SelectedIndex == 0 ? null : cbRegisteredUserFiltro.SelectedItem?.ToString();
                string? searchText = null;
                string? estadoActividad = cbStateRecordFiltro.SelectedIndex == 0 ? null : cbStateRecordFiltro.SelectedItem?.ToString();
                string? entorno = cbEntornosFiltroActividad.SelectedIndex == 0 ? null : cbEntornosFiltroActividad.SelectedItem?.ToString();
                int estado = cbEstadoActivityRecord.SelectedIndex;

                if (tbSearchFiltroVenta.Text.Length > 2) // <- asegurar que sea el textbox correcto
                {
                    searchText = string.IsNullOrWhiteSpace(tbSeachFiltroInsumo.Text) ? null : tbSeachFiltroInsumo.Text;
                }

                int currentPage = paginatorBlackBoards?.CurrentPage ?? 1;
                int pageSize = GestionAgraria.Controls.Paginator.GetPageSize();

                List<ActivityRecordModel> activitys = activityRecordController.GetActivitiesForFiltro(
                estado, entorno, searchText, estadoActividad, usuario, currentPage, pageSize);

                int totalCount = activityRecordController.GetActivitiesCountForFilter(
                estado, entorno, searchText, estadoActividad, usuario);

                int totalPages = GestionAgraria.Controls.Paginator.CalculateTotalPages(totalCount);

                var paginator = EnsurePaginatorExists(ref paginatorActivityRecord, tabActividad, (s, page) => LoadActivityRecord());
                paginator.TotalPages = totalPages;

                if (activitys.Count > 0)
                    lblEmptyActivityRecord.Visible = false;

                LoadCardsInGrid(flpActivityRecordList, activitys, activity => new UCActivityRecordAdd(null, activity));
            }
            catch (Exception ex) { Debug.WriteLine(ex); }
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
            else if (tabPage == tabProducts)
            {
                var controlsToRemove = tabProducts.Controls.Cast<Control>()
                .Where(c => c is UCProductCard)
                .ToList();
                foreach (var control in controlsToRemove)
                {
                    tabProducts.Controls.Remove(control);
                    control.Dispose();
                }
                lblEmptyProducts.Visible = true;
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
            else if (tabPage == tabProducts)
            {
                LoadProductTable();
            }
            else if (tabPage == tabPurchases)
            {
                LoadPurchasesTable();
            }
            else if (tabPage == tabSells)
            {
                LoadSellsTable();
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
            this.VerFormularioTab(AddControl, tabProducts);
        }

        private void btnAddCompras_Click(object sender, EventArgs e)
        {
            UCPurchaseAdd AddControl = new UCPurchaseAdd();
            this.VerFormularioTab(AddControl, tabPurchases);
        }

        private void btnAddVentas_Click(object sender, EventArgs e)
        {
            UCSellAdd AddControl = new UCSellAdd();
            this.VerFormularioTab(AddControl, tabSells);
        }
        private void tabCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Restart();
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
        private void CargarPurcheseCBSelec(object sender, EventArgs e)
        {
            paginatorPurchases?.Reset();
            flpPurchasesList.Controls.Clear();
            LoadPurchasesTable();
        }
        private void CargarSellsCBSelec(object sender, EventArgs e)
        {
            paginatorSells?.Reset();
            flpSellsList.Controls.Clear();
            LoadSellsTable();
        }
        private void CargarActivityCBSelec(object sender, EventArgs e)
        {
            paginatorActivityRecord?.Reset();
            flpActivityRecordList.Controls.Clear();
            LoadActivityRecord();
        }

        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            UCActivityRecordAdd AddControl = new UCActivityRecordAdd(currentUser);
            this.VerFormularioTab(AddControl, tabActividad);
        }

        /// <summary>
        /// Manejador para imprimir productos seleccionados
        /// </summary>
        private void btnPrintProduct_Click(object sender, EventArgs e)
        {
            if (SelectedProducts.Count == 0)
            {
                MessageBox.Show("No hay productos seleccionados para imprimir.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var printController = new GestionAgraria.Controllers.PrintController();
                printController.PrintProducts(SelectedProducts);

                // Limpiar selección después de imprimir
                SelectedProducts.Clear();

                // Desmarcar todos los checkboxes
                foreach (Control control in flpProductList.Controls)
                {
                    if (control is UCProductCard productCard)
                    {
                        // Buscar el checkbox dentro de la card
                        var checkbox = FindCheckBox(productCard);
                        if (checkbox != null)
                        {
                            checkbox.Checked = false;
                        }
                    }
                }

                // Deshabilitar botón después de imprimir
                if (btnPrintProduct != null)
                {
                    btnPrintProduct.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al imprimir productos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Busca recursivamente el checkbox en un control
        /// </summary>
        private ReaLTaiizor.Controls.MaterialCheckBox? FindCheckBox(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is ReaLTaiizor.Controls.MaterialCheckBox checkbox)
                {
                    return checkbox;
                }

                var found = FindCheckBox(control);
                if (found != null)
                    return found;
            }
            return null;
        }

        private void btnPrintPurchases_Click(object sender, EventArgs e)
        {
            if (SelectedPurchases.Count == 0)
            {
                MessageBox.Show("No hay insumos seleccionados para imprimir.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var printController = new GestionAgraria.Controllers.PrintController();
                printController.PrintPurchases(SelectedPurchases);

                // Limpiar selección después de imprimir
                SelectedPurchases.Clear();

                // Desmarcar todos los checkboxes en el panel de insumos (si los hubiera)
                foreach (Control control in flpPurchasesList.Controls)
                {
                    if (control is UCPurchaseCard purchaseCard)
                    {
                        var checkbox = FindCheckBox(purchaseCard);
                        if (checkbox != null)
                        {
                            checkbox.Checked = false;
                        }
                    }
                }

                // Deshabilitar botón después de imprimir
                if (btnPrintPurchases != null)
                {
                    btnPrintPurchases.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al imprimir insumos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrintSells_Click(object sender, EventArgs e)
        {
            if (SelectedSells.Count == 0)
            {
                MessageBox.Show("No hay ventas seleccionadas para imprimir.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var printController = new GestionAgraria.Controllers.PrintController();
                printController.PrintSells(SelectedSells);

                // Limpiar selección después de imprimir
                SelectedSells.Clear();

                // Desmarcar todos los checkboxes en el panel de ventas (si los hubiera)  // Actualizando el comentario
                foreach (Control control in flpSellsList.Controls)  // Cambiando flpPurchasesList a flpSellsList
                {
                    if (control is UCSellCard sellCard)
                    {
                        var checkbox = FindCheckBox(sellCard);
                        if (checkbox != null)
                        {
                            checkbox.Checked = false;
                        }
                    }
                }

                // Deshabilitar botón después de imprimir
                if (btnPrintSells != null)
                {
                    btnPrintSells.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al imprimir ventas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SetTabPermissions()
        {
            // Validamos el user logueado. Si el Role.Name == "Invitado", deshabilitamos los botones de agregar
            if (currentUser.Role.Name == "Invitado")
            {
                foreach (System.Windows.Forms.TabPage tabPage in tcPrincipal.TabPages)
                {
                    DisableAddActionButtons(tabPage);
                }
                foreach (System.Windows.Forms.TabPage tabPage in tcIndustrias.TabPages)
                {
                    DisableAddActionButtons(tabPage);
                }
            }
        }
        private void DisableAddActionButtons(System.Windows.Forms.TabPage tabPage)
        {
            foreach (Control control in tabPage.Controls)
            {
                if (control is ReaLTaiizor.Controls.MaterialFloatingActionButton)
                    if (control.Name.Contains("btnAdd"))
                        control.Enabled = false;
            }
        }
    }
}
