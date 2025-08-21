using System.Data;
using System.Windows.Forms;
using ReaLTaiizor.Forms;
using Microsoft.Data.SqlClient;

namespace GestionAgraria
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = $"{Config.application_name} > {tcPrincipal.SelectedTab?.Text ?? "Inicio"}";
            string query = File.ReadAllText(".\\queries\\06-select-users.sql");
            SqlDataReader data = Database.ExecuteReader(query);
            DataTable dataTable = new DataTable();
            dataTable.Load(data);
            dgvRRHHUsers.DataSource = dataTable;
        }

        private void tcPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage selectedTab = tcPrincipal.SelectedTab ?? throw new InvalidOperationException("No tab is selected.");
            this.Text = $"{Config.application_name} > {selectedTab.Text}";
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
        }
    }
}
