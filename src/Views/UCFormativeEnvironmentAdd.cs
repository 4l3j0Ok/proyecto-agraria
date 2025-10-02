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
        private List<Panel> dynamicDataRows = new List<Panel>();

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
            tbEnvironmentObservations.Text = formativeEnvironment.Observations;

            if (formativeEnvironment.Responsible != null)
            {
                var responsibleText = $"{formativeEnvironment.Responsible.Name} {formativeEnvironment.Responsible.Surname} - {formativeEnvironment.Responsible.Username}";
                cbEnvironmentResponsable.Text = responsibleText;
            }

            // Cargar datos académicos
            if (formativeEnvironment.AcademicData != null && formativeEnvironment.AcademicData.Any())
            {
                var firstData = formativeEnvironment.AcademicData.First();
                cbEnvironmentYear1.Text = firstData.Year.ToString();
                tbEnvironmentCourse1.Text = firstData.Course;
                tbEnvironmentGroup1.Text = firstData.Group;

                // Cargar datos adicionales si existen
                foreach (var data in formativeEnvironment.AcademicData.Skip(1))
                {
                    AddDynamicDataRow(data.Year.ToString(), data.Course, data.Group);
                }
            }
            else
            {
                // Compatibilidad con datos antiguos
#pragma warning disable CS0618 // Type or member is obsolete
                cbEnvironmentYear1.Text = formativeEnvironment.Year.ToString();
                tbEnvironmentCourse1.Text = formativeEnvironment.Course;
                tbEnvironmentGroup1.Text = formativeEnvironment.Group;
#pragma warning restore CS0618 // Type or member is obsolete
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

            if (string.IsNullOrWhiteSpace(cbEnvironmentYear1.Text))
                emptyFields.Add("Año");

            if (string.IsNullOrWhiteSpace(tbEnvironmentCourse1.Text))
                emptyFields.Add("Curso");

            if (string.IsNullOrWhiteSpace(tbEnvironmentGroup1.Text))
                emptyFields.Add("Grupo");

            // Validar campos dinámicos
            for (int i = 1; i < tlYearData.RowCount - 1; i++) // Excluir la primera fila (ya validada) y la del botón
            {
                var yearPanel = tlYearData.GetControlFromPosition(0, i);
                var coursePanel = tlYearData.GetControlFromPosition(1, i);
                var groupPanel = tlYearData.GetControlFromPosition(2, i);

                if (yearPanel != null && coursePanel != null && groupPanel != null)
                {
                    var yearCombo = yearPanel.Controls.OfType<MaterialComboBox>().FirstOrDefault();
                    var courseText = coursePanel.Controls.OfType<MaterialTextBoxEdit>().FirstOrDefault();
                    var groupText = groupPanel.Controls.OfType<MaterialTextBoxEdit>().FirstOrDefault();

                    if (yearCombo != null && string.IsNullOrWhiteSpace(yearCombo.Text))
                        emptyFields.Add($"Año (fila {i + 1})");

                    if (courseText != null && string.IsNullOrWhiteSpace(courseText.Text))
                        emptyFields.Add($"Curso (fila {i + 1})");

                    if (groupText != null && string.IsNullOrWhiteSpace(groupText.Text))
                        emptyFields.Add($"Grupo (fila {i + 1})");
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

            // Primer fila (siempre presente)
            academicDataList.Add(new FormativeEnvironmentDataModel
            {
                Year = int.Parse(cbEnvironmentYear1.Text),
                Course = tbEnvironmentCourse1.Text,
                Group = tbEnvironmentGroup1.Text,
                IsActive = true
            });

            // Filas dinámicas
            for (int i = 1; i < tlYearData.RowCount - 1; i++) // Excluir la primera fila y la del botón
            {
                var yearPanel = tlYearData.GetControlFromPosition(0, i);
                var coursePanel = tlYearData.GetControlFromPosition(1, i);
                var groupPanel = tlYearData.GetControlFromPosition(2, i);

                if (yearPanel != null && coursePanel != null && groupPanel != null)
                {
                    var yearCombo = yearPanel.Controls.OfType<MaterialComboBox>().FirstOrDefault();
                    var courseText = coursePanel.Controls.OfType<MaterialTextBoxEdit>().FirstOrDefault();
                    var groupText = groupPanel.Controls.OfType<MaterialTextBoxEdit>().FirstOrDefault();

                    if (yearCombo != null && courseText != null && groupText != null &&
                        !string.IsNullOrWhiteSpace(yearCombo.Text) &&
                        !string.IsNullOrWhiteSpace(courseText.Text) &&
                        !string.IsNullOrWhiteSpace(groupText.Text))
                    {
                        academicDataList.Add(new FormativeEnvironmentDataModel
                        {
                            Year = int.Parse(yearCombo.Text),
                            Course = courseText.Text,
                            Group = groupText.Text,
                            IsActive = true
                        });
                    }
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

        private void btnAddCourseData_Click(object sender, EventArgs e)
        {
            AddDynamicDataRow();
        }

        private Panel AddDynamicDataRow(string year = "", string course = "", string group = "")
        {
            int rowIndex = tlYearData.RowCount - 1; // Insertar antes del botón
            tlYearData.RowCount++;
            tlYearData.RowStyles.Insert(rowIndex, new RowStyle(SizeType.AutoSize));

            // Crear panel para el año
            var panelYear = new Panel
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(0),
                Padding = new Padding(20, 0, 20, 0)
            };

            var labelYear = new MaterialLabel
            {
                Text = "Año",
                AutoSize = true,
                Dock = DockStyle.Top,
                Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
            };

            var cbYear = new MaterialComboBox
            {
                Name = $"cbEnvironmentYear{dynamicDataRows.Count + 2}",
                Dock = DockStyle.Top,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cbYear.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7" });
            if (!string.IsNullOrEmpty(year))
                cbYear.Text = year;

            panelYear.Controls.Add(cbYear);
            panelYear.Controls.Add(labelYear);

            // Crear panel para el curso
            var panelCourse = new Panel
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(0),
                Padding = new Padding(20, 0, 20, 0)
            };

            var labelCourse = new MaterialLabel
            {
                Text = "Curso",
                AutoSize = true,
                Dock = DockStyle.Top,
                Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
            };

            var tbCourse = new MaterialTextBoxEdit
            {
                Name = $"tbEnvironmentCourse{dynamicDataRows.Count + 2}",
                Text = course,
                Dock = DockStyle.Fill,
                MaxLength = 1
            };

            panelCourse.Controls.Add(tbCourse);
            panelCourse.Controls.Add(labelCourse);

            // Crear panel para el grupo
            var panelGroup = new Panel
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(0),
                Padding = new Padding(20, 0, 20, 0)
            };

            var labelGroup = new MaterialLabel
            {
                Text = "Grupo",
                AutoSize = true,
                Dock = DockStyle.Top,
                Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
            };

            var tbGroup = new MaterialTextBoxEdit
            {
                Name = $"tbEnvironmentGroup{dynamicDataRows.Count + 2}",
                Text = group,
                Dock = DockStyle.Fill,
                MaxLength = 1
            };

            panelGroup.Controls.Add(tbGroup);
            panelGroup.Controls.Add(labelGroup);

            // Agregar controles al TableLayoutPanel
            tlYearData.Controls.Add(panelYear, 0, rowIndex);
            tlYearData.Controls.Add(panelCourse, 1, rowIndex);
            tlYearData.Controls.Add(panelGroup, 2, rowIndex);

            // Mover el botón a la última fila
            tlYearData.SetRow(btnAddCourseData, tlYearData.RowCount - 1);

            // Agregar referencias a la lista para tracking
            dynamicDataRows.Add(panelYear);

            return panelYear;
        }
    }
}