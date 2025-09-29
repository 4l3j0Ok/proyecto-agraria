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
        }

        private void LoadComboBoxes()
        {
            // No hay ComboBoxes específicos para este formulario
            // Los tipos de plantas se pueden escribir directamente
        }

        private void LoadVegetalData(VegetableModel vegetal)
        {
            tbUsuario.Text = vegetal.PlantType;
            materialComboBox1.Text = vegetal.Quantity.ToString();
            materialTextBoxEdit8.Text = vegetal.Observations;
        }

        private bool ValidateFields()
        {
            List<string> emptyFields = new List<string>();

            if (string.IsNullOrWhiteSpace(tbUsuario.Text))
                emptyFields.Add("Tipo de Planta");

            if (string.IsNullOrWhiteSpace(materialComboBox1.Text))
                emptyFields.Add("Cantidad");

            if (emptyFields.Count > 0)
            {
                string message = "Los siguientes campos son obligatorios:\n\n" + string.Join("\n", emptyFields);
                MessageBox.Show(message, "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar cantidad
            if (!int.TryParse(materialComboBox1.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("La cantidad debe ser un número entero mayor a 0.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void mepVegetalAdd_SaveClick(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            currentVegetal.PlantType = tbUsuario.Text;
            currentVegetal.Quantity = int.Parse(materialComboBox1.Text);
            currentVegetal.Observations = materialTextBoxEdit8.Text;

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
    }
}