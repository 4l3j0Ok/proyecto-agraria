using ReaLTaiizor.Colors;
using ReaLTaiizor.Enum.Crown;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System.Windows.Forms;
using GestionAgraria.data;

using GestionAgraria.models;

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
            DbInitializer.CreateTablesIfNotExists();
            UserModel? user = DbInitializer.CreateAdminUserIfNotExists();
            if (user != null)
            {
                MessageBox.Show(
                    text: $"Se creó el usuario administrador por defecto con los siguientes datos:\n" +
                            $"Usuario: {user.Username}\n" +
                            $"Contraseña: {user.Password}\n" +
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
            UserModel? user = UserRepository.Get(username);
            if (user == null || user.Password != password)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormPrincipal formPrincipal = new FormPrincipal(currentUser: user);
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
