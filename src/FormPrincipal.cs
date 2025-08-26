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
        public MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        public FormPrincipal()
        {
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialColorScheme(
                primary: ColorScheme.primary,
                darkPrimary: ColorScheme.primary,
                lightPrimary: ColorScheme.primary,
                accent: ColorScheme.accent,
                textShade: MaterialTextShade.LIGHT
            );
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
