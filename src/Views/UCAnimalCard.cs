using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionAgraria.Core;
using GestionAgraria.models;
using GestionAgraria.Models;

namespace GestionAgraria.Views
{
    public partial class UCAnimalCard : UserControl
    {
        private AnimalModel _animal;

        public UCAnimalCard(AnimalModel animal)
        {
            InitializeComponent();
            _animal = animal;

            lblType.Text = animal.AnimalType.Name;
            lblCode.Text = animal.Code;
            lblProductiveState.Text = animal.ProductiveState;
            Utils.CardSetupClickEvent(this, OnAnimalCardClick);
        }

        private void OnAnimalCardClick(object? sender, EventArgs? e)
        {
            OpenFormAdd(_animal);
        }

        public static void OpenFormAdd(AnimalModel animal)
        {
            UCAnimalAdd animalAdd = new UCAnimalAdd(animal);
            FormPrincipal? formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();
            formPrincipal?.VerFormularioTab(animalAdd, formPrincipal.tabAnimalArea);
        }
    }
}
