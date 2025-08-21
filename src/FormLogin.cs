using System.Windows.Forms;
using ReaLTaiizor.Enum.Crown;
using ReaLTaiizor.Forms;

namespace GestionAgraria
{
    public partial class FormLogin : MaterialForm
    {
        public FormLogin()
        {
            InitializeComponent();

        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                Database.CheckConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    text: ex.Message,
                    caption: "Error de conexi�n",
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK
                );
            }
            Database.CreateDatabaseIfNotExists();
            Database.CreateTablesIfNotExists();
            Dictionary<string, string> user = Database.CreateAdminUserIfNotExists();
            if (user.ContainsKey("username") && user.ContainsKey("password"))
            {
                MessageBox.Show(
                    text: $"Se cre� el usuario administrador por defecto con los siguientes datos:\n" +
                            $"Usuario: {user["username"]}\n" +
                            $"Contrase�a: {user["password"]}\n" +
                            $"Por favor, anotalo para poder loguearte por primera vez.\n" +
                            $"Posteriormente podras eliminarlo si as� lo deseas.",
                    caption: "Usuario administrador creado",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Warning
                );
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsuario.Text;
            string password = tbContrasena.Text;
            string dbPassword = Database.GetUserPassword(username);
            if (string.IsNullOrEmpty(dbPassword) || password != dbPassword)
            {
                MessageBox.Show(
                    text: "El usuario o contrase�a son inv�lidos",
                    caption: "Error de inicio de sesi�n",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error
                );
            }
            // Mostramos el formPrincipal
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
            this.Hide();
        }
        private void tb_TextChanged(object sender, EventArgs e)
        {
            if (tbUsuario.Text.Length > 0 && tbContrasena.Text.Length > 0)
                btnLogin.Enabled = true;
        }
    }
}
