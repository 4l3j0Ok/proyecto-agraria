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
using ReaLTaiizor.Forms;

namespace GestionAgraria.Views
{
    public partial class UCUserCard : UserControl
    {
        private UserModel _user;

        public UCUserCard(UserModel user)
        {
            InitializeComponent();
            _user = user;

            lblUserName.Text = user.Name;
            lblUserUsername.Text = user.Username;
            lblUserArea.Text = user.Role?.Name ?? "Sin rol";
            lblUserPhone.Text = user.Phone;
            SetupClickEvent();
        }

        private void SetupClickEvent()
        {
            // Agregar evento click al UserControl principal
            this.Click += OnUserCardClick;
            this.Cursor = Cursors.Hand; // Cambiar cursor para indicar que es clickeable

            // Agregar evento click a todos los controles hijos recursivamente
            AddClickEventToControls(this.Controls);
        }

        private void AddClickEventToControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                control.Click += OnUserCardClick;
                control.Cursor = Cursors.Hand;

                // Si el control tiene controles hijos, agregar el evento recursivamente
                if (control.HasChildren)
                {
                    AddClickEventToControls(control.Controls);
                }
            }
        }

        private void OnUserCardClick(object? sender, EventArgs? e)
        {

            // Comportamiento por defecto
            OpenFormAdd(_user);
        }

        public static void OpenFormAdd(UserModel user)
        {
            UCUserAdd userAdd = new UCUserAdd(user);
            FormPrincipal? formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();
            formPrincipal?.VerFormularioTab(userAdd, formPrincipal.tabUsers);
        }
    }
}
