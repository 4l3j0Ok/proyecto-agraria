using GestionAgraria.data;
using GestionAgraria.models;
using GestionAgraria.Views;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System.Data;
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
            TabPage selectedTab = tcPrincipal.SelectedTab ?? throw new InvalidOperationException("No se seleccionó ninguna pestaña.");
            this.Text = selectedTab.Text;
            LoadUsersTable();
        }

        private void tcPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage selectedTab = tcPrincipal.SelectedTab ?? throw new InvalidOperationException("No se seleccionó ninguna pestaña.");
            this.Text = selectedTab.Text;
        }

        private void LoadUsersTable()
        {
            List<UserModel> users = UserRepository.GetAll();
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
            UCEntornoAdd entornoAddControl = new UCEntornoAdd();
            entornoAddControl.Dock = DockStyle.Fill;
            tabEntorno.Controls.Clear();
            tabEntorno.Controls.Add(entornoAddControl);
        }
    }
}
