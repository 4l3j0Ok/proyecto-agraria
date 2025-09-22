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
using GestionAgraria.controllers;

namespace GestionAgraria.Views
{
    public partial class UCFormativeEnvironmentAdd : UserControl
    {
        private FormativeEnvironmentController formativeEnvironmentController;
        private UserController userController;
        private FormativeEnvironmentModel currentFormativeEnvironment;

        public UCFormativeEnvironmentAdd(FormativeEnvironmentModel? formativeEnvironment = null)
        {
            formativeEnvironmentController = new FormativeEnvironmentController();
            userController = new UserController();
            InitializeComponent();

            LoadComboBoxes();

            if (formativeEnvironment != null)
            {
                mepFormativeEnvironmentAdd.Title = "Modificar Entorno Formativo";
                mepFormativeEnvironmentAdd.Description = "Edita los datos del entorno formativo seleccionado";
                currentFormativeEnvironment = formativeEnvironment;
                LoadFormativeEnvironmentData(formativeEnvironment);
            }
            else
            {
                currentFormativeEnvironment = new FormativeEnvironmentModel();
            }
        }

        private void LoadComboBoxes()
        {
            // Cargar usuarios responsables
            var users = userController.GetAllUsers();
            cbEnvironmentResponsable.Items.Clear();
            foreach (var user in users)
            {
                cbEnvironmentResponsable.Items.Add($"{user.Name} {user.Surname} - {user.Username}");
            }

            // Cargar áreas
            cbEnvironmentArea.Items.AddRange(Config.defaultAreas.ToArray());
        }

        private void LoadFormativeEnvironmentData(FormativeEnvironmentModel formativeEnvironment)
        {
            tbEnvironmentName.Text = formativeEnvironment.Name;
            cbEnvironmentArea.Text = formativeEnvironment.Area;
            cbEnvironmentYear.Text = formativeEnvironment.Year.ToString();
            tbEnvironmentCourse.Text = formativeEnvironment.Course;
            tbEnvironmentGroup.Text = formativeEnvironment.Group;
            tbEnvironmentObservations.Text = formativeEnvironment.Observations;

            if (formativeEnvironment.Responsible != null)
            {
                var responsibleText = $"{formativeEnvironment.Responsible.Name} {formativeEnvironment.Responsible.Surname} - {formativeEnvironment.Responsible.Username}";
                cbEnvironmentResponsable.Text = responsibleText;
            }
        }

        private bool ValidateFields()
        {
            List<string> emptyFields = new List<string>();

            if (string.IsNullOrWhiteSpace(tbEnvironmentName.Text))
                emptyFields.Add("Nombre de entorno");

            if (cbEnvironmentArea.SelectedItem == null || string.IsNullOrWhiteSpace(cbEnvironmentArea.Text))
                emptyFields.Add("Área");

            if (cbEnvironmentResponsable.SelectedItem == null)
                emptyFields.Add("Responsable");

            if (string.IsNullOrWhiteSpace(cbEnvironmentYear.Text))
                emptyFields.Add("Año");

            if (string.IsNullOrWhiteSpace(tbEnvironmentCourse.Text))
                emptyFields.Add("Curso");

            if (string.IsNullOrWhiteSpace(tbEnvironmentGroup.Text))
                emptyFields.Add("Grupo");

            if (emptyFields.Count > 0)
            {
                string message = "Los siguientes campos son obligatorios:\n\n" + string.Join("\n", emptyFields);
                MessageBox.Show(message, "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void mepFormativeEnvironmentAdd_SaveClick(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            currentFormativeEnvironment.Name = tbEnvironmentName.Text;
            currentFormativeEnvironment.Area = cbEnvironmentArea.Text;
            currentFormativeEnvironment.Year = int.Parse(cbEnvironmentYear.Text);
            currentFormativeEnvironment.Course = tbEnvironmentCourse.Text;
            currentFormativeEnvironment.Group = tbEnvironmentGroup.Text;
            currentFormativeEnvironment.Observations = tbEnvironmentObservations.Text;

            // Obtener el usuario responsable seleccionado
            var users = userController.GetAllUsers();
            var selectedUserIndex = cbEnvironmentResponsable.SelectedIndex;
            if (selectedUserIndex >= 0 && selectedUserIndex < users.Count)
            {
                currentFormativeEnvironment.ResponsibleUserId = users[selectedUserIndex].Id;
            }

            bool success;
            if (currentFormativeEnvironment.Id == 0)
                success = formativeEnvironmentController.CreateFormativeEnvironment(currentFormativeEnvironment);
            else
                success = formativeEnvironmentController.UpdateFormativeEnvironment(currentFormativeEnvironment);

            if (success)
            {
                MessageBox.Show("Entorno formativo guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormPrincipal? formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();
                formPrincipal?.RestaurarFormularioTab(formPrincipal.tabEntorno);
                formPrincipal?.LoadCards(clearCurrent: true);
            }
            else
            {
                MessageBox.Show("Error al guardar el entorno formativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}