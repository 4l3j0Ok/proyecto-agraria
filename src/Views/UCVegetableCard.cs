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
    public partial class UCVegetableCard : UserControl
    {
        private VegetableModel _vegetal;

        public UCVegetableCard(VegetableModel vegetal)
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

        public static void OpenFormAdd(VegetableModel vegetal)
        {
            UCVegetableAdd vegetalAdd = new UCVegetableAdd(vegetal);
            FormPrincipal? formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();
            formPrincipal?.VerFormularioTab(vegetalAdd, formPrincipal.tabVegetablesArea);
        }
    }
}
