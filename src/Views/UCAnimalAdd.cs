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
    public partial class UCAnimalAdd : UserControl
    {
        private AnimalController animalController;
        private AnimalModel currentAnimal;
        private FormPrincipal? formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();

        public UCAnimalAdd(AnimalModel? animal = null)
        {
            animalController = new AnimalController();
            InitializeComponent();

            LoadComboBoxes();

            if (animal != null)
            {
                mepAnimalAdd.Title = "Modificar Animal";
                mepAnimalAdd.Description = "Edita los datos del animal seleccionado";
                currentAnimal = animal;

                LoadAnimalData(animal);
            }
            else
            {
                currentAnimal = new AnimalModel();
            }

            // Verificar permisos del usuario actual
            ApplyUserPermissions();
        }

        private void ApplyUserPermissions()
        {
            var currentUser = Session.CurrentUser;
            if (currentUser?.Role == null) return;

            var accessLevel = currentUser.Role.AnimalsAccess;

            if (accessLevel == AccessLevel.Read)
            {
                // Solo lectura: deshabilitar edición
                Utils.SetControlsReadOnly(this);
                mepAnimalAdd.ValidationButtonEnable = false;
            }
            // Write y Admin tienen acceso completo
        }

        private void UCAnimalAdd_Load(object sender, EventArgs e)
        {
            Utils.DeshabilitarShortcuts(this);
            dtAnimalEntryDate.MaxDate = DateTime.Today;
        }

        private void LoadComboBoxes()
        {
            try
            {
                // Limpiar los combos antes de cargar
                cbAnimalType.Items.Clear();
                cbAnimalSex.Items.Clear();
                cbAnimalProductiveState.Items.Clear();
                cbAnimalFormativeEnvironment.Items.Clear();

                // Cargar tipos de animales
                var animalTypes = animalController.GetAnimalTypes();
                foreach (var type in animalTypes)
                {
                    cbAnimalType.Items.Add(type.Name);
                }
                var formativeEnvironments = animalController.GetAllActiveFormativeEnvironments();

                foreach (var environment in formativeEnvironments)
                {
                    cbAnimalFormativeEnvironment.Items.Add(environment.Name);
                }

                // Cargar sexos
                cbAnimalSex.Items.AddRange(new string[] { "Macho", "Hembra" });

                // Cargar estados productivos
                cbAnimalProductiveState.Items.AddRange(TabConfig.productiveStates.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cbEstado.SelectedIndex = 0; // Por defecto activo
        }

        private void LoadAnimalData(AnimalModel animal)
        {
            tbAnimalCode.Text = animal.Code;
            cbAnimalType.Text = animal.AnimalType.Name;
            cbAnimalSex.Text = animal.Sex;
            cbAnimalProductiveState.Text = animal.ProductiveState;
            cbAnimalObservations.Text = animal.Observations;
            dtAnimalEntryDate.Value = animal.BirthOrEntryDate;
            // Cargar entorno formativo si existe

            if (animal.FormativeEnvironment != null)
            {
                cbAnimalFormativeEnvironment.SelectedIndex = cbAnimalFormativeEnvironment.Items.IndexOf(animal.FormativeEnvironment.Name);
            }

            if (animal.IsActive == false)
                cbEstado.SelectedIndex = 1;
        }

        private bool ValidateFields()
        {
            List<string> emptyFields = new List<string>();

            if (string.IsNullOrWhiteSpace(tbAnimalCode.Text))
                emptyFields.Add("Código");

            if (cbAnimalType.SelectedItem == null || string.IsNullOrWhiteSpace(cbAnimalType.Text))
                emptyFields.Add("Tipo de Animal");

            if (cbAnimalSex.SelectedItem == null || string.IsNullOrWhiteSpace(cbAnimalSex.Text))
                emptyFields.Add("Sexo");

            if (cbAnimalProductiveState.SelectedItem == null || string.IsNullOrWhiteSpace(cbAnimalProductiveState.Text))
                emptyFields.Add("Estado Productivo");

            if (emptyFields.Count > 0)
            {
                string message = "Los siguientes campos son obligatorios:\n\n" + string.Join("\n", emptyFields);
                MessageBox.Show(message, "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void mepAnimalAdd_SaveClick(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            currentAnimal.Code = tbAnimalCode.Text;
            currentAnimal.AnimalType = animalController.GetAnimalTypes().FirstOrDefault(at => at.Name == cbAnimalType.Text);
            currentAnimal.BirthOrEntryDate = dtAnimalEntryDate.Value;
            currentAnimal.Sex = cbAnimalSex.Text;
            currentAnimal.ProductiveState = cbAnimalProductiveState.Text;
            currentAnimal.Observations = cbAnimalObservations.Text;

            if (!(cbEstado.SelectedIndex == 0))
                currentAnimal.IsActive = false;
            else
                currentAnimal.IsActive = true;

            // Verificar si hay entornos formativos disponibles
            var environments = animalController.GetAllActiveFormativeEnvironments();
            if (environments.Count == 0)
            {
                MessageBox.Show("No hay entornos formativos activos disponibles. Debe crear al menos uno antes de registrar un animal.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que se seleccione un entorno formativo (ahora obligatorio)
            if (string.IsNullOrWhiteSpace(cbAnimalFormativeEnvironment.Text))
            {
                MessageBox.Show("Debe seleccionar un entorno formativo.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedEnvironment = environments.FirstOrDefault(env =>
                env.Name == cbAnimalFormativeEnvironment.Text);

            if (selectedEnvironment == null)
            {
                MessageBox.Show("El entorno formativo seleccionado no es válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            currentAnimal.FormativeEnvironment = selectedEnvironment;
            currentAnimal.FormativeEnvironmentId = selectedEnvironment.Id;

            bool success;
            if (currentAnimal.Id == 0)
                success = animalController.CreateAnimal(currentAnimal);
            else
                success = animalController.UpdateAnimal(currentAnimal);

            if (success)
            {
                MessageBox.Show("Animal guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formPrincipal?.RestaurarFormularioTab(formPrincipal.tabAnimalArea);
            }
            else
            {
                MessageBox.Show("Error al guardar el animal. El código ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mepAnimalAdd_CancelClick(object sender, EventArgs e)
        {
            formPrincipal?.RestaurarFormularioTab(formPrincipal.tabAnimalArea);
        }

        private void cbAnimalFormativeEnvironment_DropDown(object sender, EventArgs e)
        {
            // Cargar entornos formativos
            //var formativeEnvironments = animalController.GetAllActiveFormativeEnvironments();
            //foreach (var environment in formativeEnvironments)
            //{
            //    cbAnimalFormativeEnvironment.Items.Add(environment.Name);
            //}
        }

        private void tbAnimalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.InputValidator.ValidarEntrada(e, ((TextBox)sender).Text, 15, Utils.InputValidator.TipoValidacion.LetrasYNumeros);
        }

        private void cbAnimalObservations_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.InputValidator.ValidarEntrada(e, ((TextBox)sender).Text, 50, Utils.InputValidator.TipoValidacion.LetrasYNumeros);
        }
    }
}
