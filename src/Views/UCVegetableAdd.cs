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
using GestionAgraria.controllers;
using GestionAgraria.models;
using Microsoft.VisualBasic.ApplicationServices;
using GestionAgraria.Core;

namespace GestionAgraria.Views
{
    public partial class UCVegetableAdd : UserControl
    {
        private VegetableController vegetalController;
        private VegetableModel currentVegetal;
        private FormPrincipal? formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();

        public UCVegetableAdd(VegetableModel? vegetal = null)
        {
            vegetalController = new VegetableController();
            InitializeComponent();

            LoadComboBoxes();

            if (vegetal != null)
            {
                mepVegetalAdd.Title = "Modificar Vegetal";
                mepVegetalAdd.Description = "Edita los datos del vegetal seleccionado";
                currentVegetal = vegetal;
                LoadVegetalData(vegetal);
            }
            else
            {
                currentVegetal = new VegetableModel();
            }

            // Verificar permisos del usuario actual
            ApplyUserPermissions();
        }

        private void ApplyUserPermissions()
        {
            var currentUser = Session.CurrentUser;
            if (currentUser?.Role == null) return;

            var accessLevel = currentUser.Role.VegetablesAccess;

            if (accessLevel == AccessLevel.Read)
            {
                // Solo lectura: deshabilitar edición
                Utils.SetControlsReadOnly(this);
                mepVegetalAdd.ValidationButtonEnable = false;
            }
            // Write y Admin tienen acceso completo
        }

        private void LoadComboBoxes()
        {
            Utils.DeshabilitarShortcuts(this);
            // No hay ComboBoxes específicos para este formulario
            // Los tipos de plantas se pueden escribir directamente
            vegetalController = new VegetableController();
            try
            {
                // Limpiar los combos antes de cargar
                cbEntornos.Items.Clear();

                // Cargar tipos de animales
                var formativeEnvironments = vegetalController.GetAllActiveFormativeEnvironments();

                foreach (var environment in formativeEnvironments)
                {
                    cbEntornos.Items.Add(environment.Name);
                }
                for (int i = 0; i <= 50; i++)
                {
                    cbQuatityPlant.Items.Add(i.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadVegetalData(VegetableModel vegetal)
        {
            tbUsuario.Text = vegetal.PlantType;
            cbQuatityPlant.Text = vegetal.Quantity.ToString();
            if (vegetal.IsActive == false)
                cbEstado.SelectedIndex = 1;
            materialTextBoxEdit8.Text = vegetal.Observations;

            if (vegetal.FormativeEnvironment != null)
            {
                cbEntornos.SelectedIndex = cbEntornos.Items.IndexOf(vegetal.FormativeEnvironment.Name);
            }
        }

        private bool ValidateFields()
        {
            List<string> emptyFields = new List<string>();

            if (string.IsNullOrWhiteSpace(tbUsuario.Text))
                emptyFields.Add("Tipo de Planta");

            if (string.IsNullOrWhiteSpace(cbQuatityPlant.Text))
                emptyFields.Add("Cantidad");

            if (emptyFields.Count > 0)
            {
                string message = "Los siguientes campos son obligatorios:\n\n" + string.Join("\n", emptyFields);
                MessageBox.Show(message, "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar cantidad
            if (!int.TryParse(cbQuatityPlant.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("La cantidad debe ser un número entero mayor a 0.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void mepVegetalAdd_SaveClick(object sender, EventArgs e)
        {
            // Verificar si hay entornos formativos disponibles
            var environments = vegetalController.GetAllActiveFormativeEnvironments();
            if (environments.Count == 0)
            {
                MessageBox.Show("No hay entornos formativos activos disponibles. Debe crear al menos uno antes de registrar un animal.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidateFields())
                return;

            currentVegetal.PlantType = tbUsuario.Text;
            currentVegetal.Quantity = int.Parse(cbQuatityPlant.Text);
            currentVegetal.Observations = materialTextBoxEdit8.Text;


            var selectedEnvironment = environments.FirstOrDefault(env =>
                env.Name == cbEntornos.Text);
            if (selectedEnvironment == null)
            {
                MessageBox.Show("No hay entornos formativos seleccionado.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            currentVegetal.FormativeEnvironment = selectedEnvironment;
            currentVegetal.FormativeEnvironmentId = selectedEnvironment.Id;

            bool success;
            if (currentVegetal.Id == 0)
                success = vegetalController.CreateVegetal(currentVegetal);
            else
                success = vegetalController.UpdateVegetal(currentVegetal);

            if (success)
            {
                MessageBox.Show("Vegetal guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formPrincipal?.RestaurarFormularioTab(formPrincipal.tabVegetablesArea);
            }
            else
            {
                MessageBox.Show("Error al guardar el vegetal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mepVegetalAdd_CancelClick(object sender, EventArgs e)
        {
            formPrincipal?.RestaurarFormularioTab(formPrincipal.tabVegetablesArea);
        }
        private void tbUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.InputValidator.ValidarEntrada(e, ((TextBox)sender).Text, 50, Utils.InputValidator.TipoValidacion.LetrasYNumeros);

        }

        private void materialTextBoxEdit8_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.InputValidator.ValidarEntrada(e, ((TextBox)sender).Text, 50, Utils.InputValidator.TipoValidacion.LetrasYNumeros);
        }
    }
}