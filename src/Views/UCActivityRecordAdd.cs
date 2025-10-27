using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionAgraria.controllers;
using GestionAgraria.Controllers;
using GestionAgraria.Core;
using GestionAgraria.models;
using GestionAgraria.Models;

namespace GestionAgraria.Views
{
    public partial class UCActivityRecordAdd : UserControl
    {
        private ActivityRecordController activityRecordController;
        private ActivityRecordModel currentActivityRecord;
        private UserModel currentUser;

        private FormPrincipal? formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();
        public UCActivityRecordAdd(UserModel? CurrentUser = null, ActivityRecordModel? ActivityRecord = null)
        {
            InitializeComponent();
            LoadComboBoxes();
            defComboBox();
            currentUser = CurrentUser;
            if (ActivityRecord != null)
            {
                mepActivityRecord.Title = "Modificar actividad";
                mepActivityRecord.Description = "Edita los datos de la actividad seleccionada";
                currentActivityRecord = ActivityRecord;

                LoadActivityData(ActivityRecord);
            }
            else
            {
                currentActivityRecord = ActivityRecord ?? new ActivityRecordModel();
            }
        }
        private void defComboBox()
        {
            cbEstado.SelectedIndex = 0;
            cbFormativeEnvironment.SelectedIndex = 0;
            cbStateRecord.SelectedIndex = 0;
        }
        private void LoadComboBoxes()
        {
            activityRecordController = new ActivityRecordController();
            try
            {
                // Limpiar los combos antes de cargar
                cbFormativeEnvironment.Items.Clear();
                cbStateRecord.Items.Clear();

                // Cargar tipos

                cbStateRecord.Items.AddRange(TabConfig.defaultProcesoType.ToArray());

                var formativeEnvironments = activityRecordController.GetAllActiveFormativeEnvironments();
                if (formativeEnvironments != null)
                {
                    foreach (var environment in formativeEnvironments)
                    {
                        cbFormativeEnvironment.Items.Add(environment.Name);
                    }
                }
                else
                    MessageBox.Show($"Ingrese entorno formativo para poder empezar a usar este menu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Cargar estados de actividad'

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cbEstado.SelectedIndex = 0; // Por defecto activo
        }
        private void LoadActivityData(ActivityRecordModel actividad)
        {
            tbTitleActivity.Text = actividad.Titulo;
            tbObservaciones.Text = actividad.Observations;
            // Cargar entorno formativo si existe

            if (actividad.FormativeEnvironment != null)
            {
                cbFormativeEnvironment.SelectedIndex = cbFormativeEnvironment.Items.IndexOf(actividad.FormativeEnvironment.Name);
            }
            if (actividad.StateActivity != null)
            {
                cbStateRecord.SelectedIndex = cbStateRecord.Items.IndexOf(actividad.StateActivity);
            }

            if (actividad.IsActive == false)
                cbEstado.SelectedIndex = 1;
        }
        private void mepActivityAdd_SaveClick(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateActivityFields())
                    return;

                currentActivityRecord.Titulo = tbTitleActivity.Text;
                currentActivityRecord.StateActivity = cbStateRecord.Text;
                currentActivityRecord.Observations = tbObservaciones.Text;

                // Estado (Activo/Inactivo)
                currentActivityRecord.IsActive = (cbEstado.SelectedIndex == 0);

                // 📌 Verificar que existan entornos formativos activos
                var environments = activityRecordController.GetAllActiveFormativeEnvironments();

                if (environments.Count == 0)
                {
                    MessageBox.Show("No hay entornos formativos activos disponibles. Debe crear al menos uno antes de registrar una actividad.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 📌 Validar entorno seleccionado
                var selectedEnvironment = environments.FirstOrDefault(env =>
                    env.Name == cbFormativeEnvironment.Text);

                if (selectedEnvironment == null)
                {
                    MessageBox.Show("El entorno formativo seleccionado no es válido.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                currentActivityRecord.FormativeEnvironmentId = selectedEnvironment.Id;
                currentActivityRecord.UserId = currentUser.Id;

                // Guardar (crear o actualizar)
                bool success;
                if (currentActivityRecord.Id == 0)
                    success = activityRecordController.CreateActivity(currentActivityRecord);
                else
                    success = activityRecordController.UpdateActivity(currentActivityRecord);

                if (success)
                {
                    MessageBox.Show("Actividad guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formPrincipal?.RestaurarFormularioTab(formPrincipal.tabActividad);
                }
                else
                {
                    MessageBox.Show("Error al guardar la actividad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
        private void mepActivityAdd_CancelClick(object sender, EventArgs e)
        {
            formPrincipal?.RestaurarFormularioTab(formPrincipal.tabActividad);
        }

        private bool ValidateActivityFields()
        {
            List<string> emptyFields = new List<string>();

            if (string.IsNullOrWhiteSpace(tbTitleActivity.Text))
                emptyFields.Add("Título de la Actividad");

            if (cbStateRecord.SelectedItem == null || string.IsNullOrWhiteSpace(cbStateRecord.Text))
                emptyFields.Add("Estado de la Actividad");


            if (cbFormativeEnvironment.SelectedItem == null || string.IsNullOrWhiteSpace(cbFormativeEnvironment.Text))
                emptyFields.Add("Entorno Formativo");

            if (emptyFields.Count > 0)
            {
                string message = "Los siguientes campos son obligatorios:\n\n" + string.Join("\n", emptyFields);
                MessageBox.Show(message, "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void UCActivityRecordAdd_Load(object sender, EventArgs e)
        {
        }
    }
}
