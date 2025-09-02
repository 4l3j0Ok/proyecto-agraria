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
        public FormPrincipal()
        {
            ColorScheme.GetSkinManager().AddFormToManage(this);
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            TabPage selectedTab = tcPrincipal.SelectedTab ?? throw new InvalidOperationException("No se seleccionó ninguna pestaña.");
            this.Text = selectedTab.Text;
            tsEFVegetables.BackColor = Color.White;
        }

        private void tcPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage selectedTab = tcPrincipal.SelectedTab ?? throw new InvalidOperationException("No se seleccionó ninguna pestaña.");
            this.Text = selectedTab.Text;
        }
    }
}
