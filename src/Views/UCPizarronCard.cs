using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionAgraria.Models;

namespace GestionAgraria.Views
{
    public partial class UCPizarronCard : UserControl
    {
        private BlackBoardModel _blackboard;

        public UCPizarronCard(BlackBoardModel blackboard)
        {
            InitializeComponent();
            _blackboard = blackboard;

            // Aquí agregarías la lógica para mostrar los datos en los controles
            // Por ejemplo:
            // lblTitle.Text = blackboard.title;
            // lblEntorno.Text = blackboard.entorno;
            // etc.

            Utils.CardSetupClickEvent(this, OnPizarronCardClick);
        }

        private void OnPizarronCardClick(object? sender, EventArgs? e)
        {
            OpenFormAdd(_blackboard);
        }

        public static void OpenFormAdd(BlackBoardModel blackboard)
        {
            UCPizarronAdd pizarronAdd = new UCPizarronAdd(blackboard);
            FormPrincipal? formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();
            formPrincipal?.VerFormularioTab(pizarronAdd, formPrincipal.tabEntorno);
        }
    }
}
