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
    public partial class UCPizarronAdd : UserControl
    {
        private BlackBoardModel currentBlackboard;

        public UCPizarronAdd(BlackBoardModel? blackboard = null)
        {
            InitializeComponent();

            if (blackboard != null)
            {
                //mepPizarronAdd.Title = "Modificar Pizarrón";
                //mepPizarronAdd.Description = "Edita los datos del pizarrón seleccionado";
                //currentBlackboard = blackboard;
                // Aquí cargarías los datos del pizarrón en los controles del formulario
                // Por ejemplo:
                // tbTitle.Text = blackboard.title;
                // tbEntorno.Text = blackboard.entorno;
                // etc.
            }
            else
            {
                currentBlackboard = new BlackBoardModel();
            }
        }
    }
}
