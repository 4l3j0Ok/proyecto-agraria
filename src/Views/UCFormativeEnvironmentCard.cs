using GestionAgraria.Core;
using GestionAgraria.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAgraria.Views
{
    public partial class UCFormativeEnvironmentCard : UserControl
    {
        private FormativeEnvironmentModel _formativeEnvironment;

        public UCFormativeEnvironmentCard(FormativeEnvironmentModel formativeEnvironment)
        {
            InitializeComponent();
            _formativeEnvironment = formativeEnvironment;

            // Mostrar los datos del entorno formativo
            lblUserName.Text = formativeEnvironment.Name;
            lblUserArea.Text = formativeEnvironment.Area;
            lblUserUsername.Text = $"Año: {formativeEnvironment.Year}";
            lblUserPhone.Text = $"{formativeEnvironment.Course} - {formativeEnvironment.Group}";

            Utils.CardSetupClickEvent(this, OnFormativeEnvironmentCardClick);
        }        private void OnFormativeEnvironmentCardClick(object? sender, EventArgs? e)
        {
            OpenFormAdd(_formativeEnvironment);
        }

        public static void OpenFormAdd(FormativeEnvironmentModel formativeEnvironment)
        {
            UCFormativeEnvironmentAdd formativeEnvironmentAdd = new UCFormativeEnvironmentAdd(formativeEnvironment);
            FormPrincipal? formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();
            formPrincipal?.VerFormularioTab(formativeEnvironmentAdd, formPrincipal.tabEntorno);
        }
    }
}
