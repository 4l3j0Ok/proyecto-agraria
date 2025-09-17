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

        public UCUserAdd()
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

        private void SaveUser()
        {
            try
            {
                var user = new UserModel
                {
                    // Username = tbUsername.Text,
                    // Password = tbPassword.Text,
                    // Name = tbName.Text,
                    // Surname = tbSurname.Text,
                    // Email = tbEmail.Text,
                    // Phone = tbPhone.Text,
                    // PersonId = tbPersonId.Text,
                    // RoleId = (int)cbRoles.SelectedValue,
                    IsActive = true
                };

                if (userController.CreateUser(user))
                {
                    MessageBox.Show("Usuario creado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Error al crear usuario. Verifique que los datos sean únicos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            // Limpiar todos los controles
            // tbUsername.Clear();
            // tbPassword.Clear();
            // tbName.Clear();
            // etc...
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                userController?.Dispose();
            }
            base.Dispose(disposing);
        }

        private void materialTextBoxEdit5_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
