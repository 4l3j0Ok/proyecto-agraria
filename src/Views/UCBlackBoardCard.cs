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
using GestionAgraria.Models;

namespace GestionAgraria.Views
{
    public partial class UCBlackBoardCard : UserControl
    {
        private BlackBoardModel _blackboard;

        public UCBlackBoardCard(BlackBoardModel blackboard)
        {
            InitializeComponent();
            _blackboard = blackboard;
            lblTitle.Text = blackboard.title;
            lblFecha.Text = blackboard.dateRecord.ToString();
            Utils.CardSetupClickEvent(this, OnPizarronCardClick);
        }

        private void OnPizarronCardClick(object? sender, EventArgs? e)
        {
            OpenFormAdd(_blackboard);
        }

        public static void OpenFormAdd(BlackBoardModel blackboard)
        {
            UCBlackBoardAdd pizarronAdd = new UCBlackBoardAdd(blackboard);
            FormPrincipal? formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();
            formPrincipal?.VerFormularioTab(pizarronAdd, formPrincipal.tabEntorno);
        }
    }
}
