using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionAgraria.models;
using GestionAgraria.Models;

namespace GestionAgraria.Views
{
    public partial class UCAnimalCard : UserControl
    {
        public UCAnimalCard(AnimalModel animal)
        {
            InitializeComponent();
            lblType.Text = animal.AnimalType;
            lblCode.Text = animal.Code;
            lblProductiveState.Text = animal.ProductiveState;
        }
    }
}
