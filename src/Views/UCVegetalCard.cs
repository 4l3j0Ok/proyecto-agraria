using GestionAgraria.Models;
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
    public partial class UCVegetalCard : UserControl
    {
        private VegetalModel _vegetal;

        public UCVegetalCard(VegetalModel vegetal)
        {
            InitializeComponent();
            _vegetal = vegetal;

            lblPlantType.Text = vegetal.PlantType;
            lblPlantQuantity.Text = vegetal.Quantity.ToString();
            Utils.CardSetupClickEvent(this, OnVegetalCardClick);
        }

        private void OnVegetalCardClick(object? sender, EventArgs? e)
        {
            OpenFormAdd(_vegetal);
        }

        public static void OpenFormAdd(VegetalModel vegetal)
        {
            UCVegetalAdd vegetalAdd = new UCVegetalAdd(vegetal);
            FormPrincipal? formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();
            formPrincipal?.VerFormularioTab(vegetalAdd, formPrincipal.tabVegetablesArea);
        }
    }
}
