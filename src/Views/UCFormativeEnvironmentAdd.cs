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
using ReaLTaiizor.Controls;
using Panel = System.Windows.Forms.Panel;

namespace GestionAgraria.Views
{
    public partial class UCFormativeEnvironmentAdd : UserControl
    {
        private FormativeEnvironmentController formativeEnvironmentController;
        private UserController userController;
        private FormativeEnvironmentModel currentFormativeEnvironment;
        private FormPrincipal? formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();
        private List<UCFormativeEnvironmentDataAdd> dynamicDataRows = new List<UCFormativeEnvironmentDataAdd>();

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
                AddDynamicDataRow();
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
            tbEnvironmentObservations.Text = formativeEnvironment.Observations;

            if (formativeEnvironment.Responsible != null)
            {
                var responsibleText = $"{formativeEnvironment.Responsible.Name} {formativeEnvironment.Responsible.Surname} - {formativeEnvironment.Responsible.Username}";
                cbEnvironmentResponsable.Text = responsibleText;
            }

            // Cargar datos académicos
            if (formativeEnvironment.AcademicData != null && formativeEnvironment.AcademicData.Any())
            {
                foreach (var data in formativeEnvironment.AcademicData)
                {
                    AddDynamicDataRow(data.Year, data.Course, data.Group);
                }
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

            // Validar campos dinámicos
            for (int i = 0; i < dynamicDataRows.Count; i++)
            {
                var dataControl = dynamicDataRows[i];
                if (!dataControl.IsValid())
                {
                    if (string.IsNullOrWhiteSpace(dataControl.Year.ToString()) || dataControl.Year == 0)
                        emptyFields.Add($"Año (fila {i + 2})");

                    if (string.IsNullOrWhiteSpace(dataControl.Course))
                        emptyFields.Add($"Curso (fila {i + 2})");

                    if (string.IsNullOrWhiteSpace(dataControl.Group))
                        emptyFields.Add($"Grupo (fila {i + 2})");
                }
            }

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
            currentFormativeEnvironment.Observations = tbEnvironmentObservations.Text;

            // Obtener el usuario responsable seleccionado
            var users = userController.GetAllUsers();
            var selectedUserIndex = cbEnvironmentResponsable.SelectedIndex;
            if (selectedUserIndex >= 0 && selectedUserIndex < users.Count)
            {
                currentFormativeEnvironment.ResponsibleUserId = users[selectedUserIndex].Id;
            }

            // Recopilar datos académicos
            var academicDataList = new List<FormativeEnvironmentDataModel>();

            // Filas dinámicas desde los user controls
            foreach (var dataControl in dynamicDataRows)
            {
                if (dataControl.IsValid())
                {
                    academicDataList.Add(new FormativeEnvironmentDataModel
                    {
                        Year = dataControl.Year,
                        Course = dataControl.Course,
                        Group = dataControl.Group,
                        IsActive = true
                    });
                }
            }

            currentFormativeEnvironment.AcademicData = academicDataList;

            bool success;
            if (currentFormativeEnvironment.Id == 0)
                success = formativeEnvironmentController.CreateFormativeEnvironment(currentFormativeEnvironment);
            else
                success = formativeEnvironmentController.UpdateFormativeEnvironment(currentFormativeEnvironment);

            if (success)
            {
                MessageBox.Show("Entorno formativo guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formPrincipal?.RestaurarFormularioTab(formPrincipal.tabEntorno);
            }
            else
            {
                MessageBox.Show("Error al guardar el entorno formativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mepFormativeEnvironmentAdd_CancelClick(object sender, EventArgs e)
        {
            formPrincipal?.RestaurarFormularioTab(formPrincipal.tabEntorno);
        }

        private void btnAddFormativeEnvironmentData_Click(object sender, EventArgs e)
        {
            AddDynamicDataRow();
        }

        private UCFormativeEnvironmentDataAdd AddDynamicDataRow(int year = 1, string course = "", string group = "")
        {
            // Crear el nuevo user control
            var dataControl = new UCFormativeEnvironmentDataAdd(year, course, group)
            {
                Dock = DockStyle.Top,
                Margin = new Padding(0, 0, 0, 10)
            };

            // Suscribirse al evento de eliminar
            dataControl.DeleteRequested += DataControl_DeleteRequested;

            // Agregar el control al panel - se apilará en la parte superior
            panelFormativeEnvironmentData.Controls.Add(dataControl);
            dataControl.BringToFront();

            // Agregar referencias a la lista para tracking
            dynamicDataRows.Add(dataControl);

            // Forzar el redimensionamiento del panel y contenedores padres
            panelFormativeEnvironmentData.PerformLayout();
            tlYearData.PerformLayout();
            groupBox2.PerformLayout();
            tableLayoutPanel1.PerformLayout();
            mepFormativeEnvironmentAdd.PerformLayout();

            return dataControl;
        }

        private void DataControl_DeleteRequested(object? sender, EventArgs e)
        {
            if (sender is UCFormativeEnvironmentDataAdd dataControl)
            {
                // Eliminar el control de la lista
                dynamicDataRows.Remove(dataControl);

                // Eliminar el control del Panel
                panelFormativeEnvironmentData.Controls.Remove(dataControl);

                // Liberar recursos del control
                dataControl.Dispose();

                // Forzar el redimensionamiento del panel y contenedores padres
                panelFormativeEnvironmentData.PerformLayout();
                tlYearData.PerformLayout();
                groupBox2.PerformLayout();
                tableLayoutPanel1.PerformLayout();
                mepFormativeEnvironmentAdd.PerformLayout();
            }
        }
    }
}