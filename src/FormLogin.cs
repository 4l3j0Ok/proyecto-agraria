using ReaLTaiizor.Colors;
using ReaLTaiizor.Enum.Crown;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System.Windows.Forms;

namespace GestionAgraria
{
    public partial class FormLogin : MaterialForm
    {
        public FormLogin()
        {
            InitializeComponent();
            ColorScheme.GetSkinManager().AddFormToManage(this);
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            Database.CreateTablesIfNotExists();
            Dictionary<string, string> user = Database.CreateAdminUserIfNotExists();
            if (user.ContainsKey("username") && user.ContainsKey("password"))
            {
                MessageBox.Show(
                    text: $"Se creó el usuario administrador por defecto con los siguientes datos:\n" +
                            $"Usuario: {user["username"]}\n" +
                            $"Contraseña: {user["password"]}\n" +
                            $"Por favor, anótalo para poder loguearte por primera vez.\n" +
                            $"Posteriormente podrás eliminarlo si así lo deseas.",
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
                    text: "El usuario o contraseña son inválidos",
                    caption: "Error de inicio de sesión",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error
                );
                return;
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
