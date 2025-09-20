using GestionAgraria.controllers;
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
    public partial class UCUserAdd : UserControl
    {
        private UserController userController;

        public UCUserAdd(UserModel user = null)
        {
            InitializeComponent();
            userController = new UserController();
            LoadRoles();
        }

        private void LoadRoles()
        {
            try
            {
                var roles = userController.GetAllRoles();
                // Aquí cargarías los roles en un ComboBox o similar
                // Ejemplo: cbRoles.DataSource = roles;
                // cbRoles.DisplayMember = "Name";
                // cbRoles.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar roles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
