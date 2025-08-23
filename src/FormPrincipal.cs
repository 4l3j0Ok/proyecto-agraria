using System.Data;
using System.Windows.Forms;
using ReaLTaiizor.Forms;

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
        }

        private void tcPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage selectedTab = tcPrincipal.SelectedTab ?? throw new InvalidOperationException("No tab is selected.");
            this.Text = $"{Config.application_name} > {selectedTab.Text}";
        }
    }
}
