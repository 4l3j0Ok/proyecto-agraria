using GestionAgraria.controllers;
using GestionAgraria.Controllers;
using GestionAgraria.Controls;
using GestionAgraria.Core;
using GestionAgraria.models;
using ReaLTaiizor.Controls;
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
        private RoleController roleController;
        private UserModel? userModify = new UserModel();
        private bool isEditMode = false;
        private FormPrincipal? formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();

        public UCUserAdd(UserModel? user = null)
        {
            userController = new UserController();
            roleController = new RoleController();
            if (user != null)
                userModify = user;
            isEditMode = true;
            InitializeComponent();
            if (user != null)
            {
                mepUserAdd.Title = "Modificar Usuario";
                mepUserAdd.Description = "Edita los datos del usuario seleccionado";
                tbUserName.Text = userModify.Name;
                tbUserSurname.Text = userModify.Surname;
                tbUserUsername.Text = userModify.Username;
                tbUserPhone.Text = userModify.Phone;
                tbUserEmail.Text = userModify.Email;
                tbUserPassword.Text = userModify.Password;
                tbUserPasswordConfirm.Text = userModify.Password;
                tbUserPersonId.Text = userModify.PersonId;
                pbUserProfilePicture.Image = Utils.ByteArrayToImage(userModify.ProfilePicture);
                cmbRole.SelectedItem = userModify.Role?.Name ?? "Sin rol";
                if (userModify.IsActive)
                    cbEstadoUser.SelectedIndex = 0;
                else
                    cbEstadoUser.SelectedIndex = 1;
            }
            ApplyUserPermissions();
        }

        private void ApplyUserPermissions()
        {
            var currentUser = Session.CurrentUser;
            if (currentUser?.Role == null) return;

            var accessLevel = currentUser.Role.UsersAccess;

            if (accessLevel == AccessLevel.Read)
            {
                // Solo lectura: deshabilitar edición
                Utils.SetControlsReadOnly(this);
                mepUserAdd.ValidationButtonEnable = false;
            }
            else if (accessLevel == AccessLevel.Write)
            {
                // Escritura: permitir edición pero no cambios de roles superiores
                // (ya se maneja en UCUserAdd_Load con roleController.GetLowerRoles)
            }
            // Admin tiene acceso completo
        }

        private void btnUploadProfilePicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imágen|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbUserProfilePicture.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void UCUserAdd_Load(object sender, EventArgs e)
        {
            Utils.DeshabilitarShortcuts(this);
            cbEstadoUser.SelectedIndex = 0;
            UserModel currentUser = Session.CurrentUser!;
            List<RoleModel> roles = roleController.GetLowerRoles(currentUser.Role.Level);
            cmbRole.Items.Clear();
            foreach (var role in roles)
            {
                cmbRole.Items.Add(role.Name);
            }
            if (isEditMode && userModify?.Role?.Level == 1)
            {
                // No permitimos modificar el rol de un administrador
                //Agregamos al indice 0 "Administrador"
                cmbRole.Items.Insert(0, "Administrador");
                cmbRole.Enabled = false;
            }
            cmbRole.SelectedIndex = 0;
        }

        private void mepUserAdd_SaveClick(object sender, EventArgs e)
        {
            bool success = false;
            try
            {
                // Validar campos antes de guardar
                if (!ValidateFields())
                    return;

                userModify.Name = tbUserName.Text;
                userModify.Surname = tbUserSurname.Text;
                userModify.Username = tbUserUsername.Text;
                userModify.Phone = tbUserPhone.Text;
                userModify.Email = tbUserEmail.Text;
                userModify.Password = tbUserPassword.Text;
                userModify.PersonId = tbUserPersonId.Text;

                if (!(cbEstadoUser.SelectedIndex == 0))
                    userModify.IsActive = false;
                else
                    userModify.IsActive = true;

                userModify.ProfilePicture = Utils.ImageToByteArray(pbUserProfilePicture.Image);
                RoleModel? selectedRole = roleController.GetRoleByName(cmbRole.SelectedItem?.ToString() ?? "");
                if (selectedRole != null)
                {
                    userModify.RoleId = selectedRole.Id;
                    userModify.Role = selectedRole;
                }

                if (userModify.Id == 0)
                    success = userController.CreateUser(userModify);
                else
                    success = userController.UpdateUser(userModify);
                if (success)
                {
                    MessageBox.Show("Usuario guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al guardar el usuario. El nombre de usuario, email o identificación ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                formPrincipal.RestaurarFormularioTab(formPrincipal.tabUsers);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void mepUserAdd_CancelClick(object sender, EventArgs e)
        {
            formPrincipal?.RestaurarFormularioTab(formPrincipal.tabUsers);
        }
        private void tbUserUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.InputValidator.ValidarEntrada(e, ((TextBox)sender).Text, 50, Utils.InputValidator.TipoValidacion.LetrasYNumeros);
        }

        private void tbUserPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.InputValidator.ValidarEntrada(e, ((TextBox)sender).Text, 20, Utils.InputValidator.TipoValidacion.LetrasYNumeros);
        }

        private void tbUserPersonId_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.InputValidator.ValidarEntrada(e, ((TextBox)sender).Text, 11, Utils.InputValidator.TipoValidacion.SoloNumeros);

        }

        private void tbUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.InputValidator.ValidarEntrada(e, ((TextBox)sender).Text, 20, Utils.InputValidator.TipoValidacion.LetrasYNumeros);
        }

        private void tbUserPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.InputValidator.ValidarEntrada(e, ((TextBox)sender).Text, 11, Utils.InputValidator.TipoValidacion.SoloNumeros);
        }

        private void tbUserEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.InputValidator.ValidarEntrada(e, ((TextBox)sender).Text, 50, Utils.InputValidator.TipoValidacion.SoloMail);
        }

        private bool ValidateFields()
        {
            List<string> emptyFields = new List<string>();

            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(tbUserName.Text))
                emptyFields.Add("Nombre");

            if (string.IsNullOrWhiteSpace(tbUserSurname.Text))
                emptyFields.Add("Apellido");

            if (string.IsNullOrWhiteSpace(tbUserUsername.Text))
                emptyFields.Add("Nombre de usuario");

            if (string.IsNullOrWhiteSpace(tbUserPersonId.Text))
                emptyFields.Add("Documento");

            if (string.IsNullOrWhiteSpace(tbUserEmail.Text))
                emptyFields.Add("Correo electrónico");

            if (string.IsNullOrWhiteSpace(tbUserPhone.Text))
                emptyFields.Add("Número de teléfono");

            if (string.IsNullOrWhiteSpace(tbUserPassword.Text))
                emptyFields.Add("Contraseña");

            if (string.IsNullOrWhiteSpace(tbUserPasswordConfirm.Text))
                emptyFields.Add("Confirmación de contraseña");

            if (cmbRole.SelectedItem == null)
                emptyFields.Add("Rol");

            // Mostrar mensaje de error si hay campos vacíos
            if (emptyFields.Count > 0)
            {
                string message = "Los siguientes campos son obligatorios:\n\n" + string.Join("\n", emptyFields);
                MessageBox.Show(message, "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que las contraseñas coincidan
            if (tbUserPassword.Text != tbUserPasswordConfirm.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar formato de email básico
            if (!tbUserEmail.Text.Contains("@") || !tbUserEmail.Text.Contains("."))
            {
                MessageBox.Show("El formato del correo electrónico no es válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}