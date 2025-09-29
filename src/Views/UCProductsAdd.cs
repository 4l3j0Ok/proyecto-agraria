using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionAgraria.controllers;
using GestionAgraria.Controllers;
using GestionAgraria.Models;
using ReaLTaiizor.Controls;

namespace GestionAgraria.Views
{
    public partial class UCProductsAdd : UserControl
    {
        private ProductController producController;
        private ProductModel currentProduct;
        private FormPrincipal? formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();

        public UCProductsAdd(ProductModel? product = null)
        {
            producController = new ProductController();
            InitializeComponent();

            LoadComboBox();

            if (product != null)
            {
                mepProductAdd.Title = "Modificar Producto";
                mepProductAdd.Description = "Edita los datos del Producto seleccionado";
                currentProduct = product;
                LoadProductData(product);
            }
            else
            {
                currentProduct = new ProductModel();
            }
        }
        private void LoadComboBox() 
        {

            //cbProductStock.Items.Add = "1";

            try
            {
                cbProductFormativeEnvironment.Items.Clear();
                var formativeEnviroments = producController.GetAllActiveFormativeEnvironments();
                foreach(var environment in formativeEnviroments)
                {
                    cbProductFormativeEnvironment.Items.Add(environment.Name);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error al cargar los datos:{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProductData(ProductModel product) 
        {
            tbProductCode.Text = product.code;
            tbProductName.Text = product.Name;
            cbProductStock.Text = product.Quantity.ToString(); 
            if (product.FormativeEnvironment != null) 
            { 
            cbProductFormativeEnvironment.SelectedIndex = cbProductFormativeEnvironment.Items.IndexOf(product.FormativeEnvironment.Name);
            }
        }

        private bool ValidateFields()
        {
            List<string> emptyFields = new List<string>();

            if (string.IsNullOrWhiteSpace(tbProductCode.Text))
                emptyFields.Add("Codigo de producto");

            if (string.IsNullOrWhiteSpace(tbProductName.Text))
                emptyFields.Add("nombre de producto");

            if (string.IsNullOrWhiteSpace(cbProductStock.Text))
                emptyFields.Add("Cantidad");

            if (emptyFields.Count > 0)
            {
                string message = "Los siguientes campos son obligatorios:\n\n" + string.Join("\n", emptyFields);
                MessageBox.Show(message, "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar cantidad
            if (!int.TryParse(cbProductStock.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("La cantidad debe ser un número entero mayor a 0.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void mepProductAdd_SaveClick(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;
            currentProduct.code = tbProductCode.Text;
            currentProduct.Name = tbProductName.Text;
            currentProduct.Quantity = int.Parse(cbProductStock.Text);
            currentProduct.Observations = tbDescription.Text;

            var environments = producController.GetAllActiveFormativeEnvironments();

            if (environments.Count == 0)
            {
                MessageBox.Show("No hay entornos formativos activos disponibles. Debe crear al menos uno antes de registrar un animal.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(cbProductFormativeEnvironment.Text))
            {
                MessageBox.Show("Debe seleccionar un entorno formativo.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedEnvironment = environments.FirstOrDefault(env =>
                env.Name == cbProductFormativeEnvironment.Text);

            currentProduct.FormativeEnvironment = selectedEnvironment;
            currentProduct.FormativeEnvironmentId = selectedEnvironment.Id;


            bool success;
            if (currentProduct.Id == 0)
                success = producController.CreateProduct(currentProduct);
            else
                success = producController.UpdateProduct(currentProduct);

            if (success)
            {
                MessageBox.Show("Vegetal producto correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formPrincipal?.RestaurarFormularioTab(formPrincipal.tabProduct);
            }
            else
            {
                MessageBox.Show("Error al guardar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mepProductAdd_cancelClick(object sender, EventArgs e)
        {
            formPrincipal?.RestaurarFormularioTab(formPrincipal.tabProduct);
        }

    }
}
