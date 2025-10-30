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
using GestionAgraria.Core;
using ReaLTaiizor.Controls;

namespace GestionAgraria.Views
{
    public partial class UCProductAdd : UserControl
    {
        private ProductController producController;
        private ProductModel currentProduct;
        private FormPrincipal? formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();

        public UCProductAdd(ProductModel? product = null)
        {
            producController = new ProductController();
            InitializeComponent();

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

            // Usar Session.CurrentUser si es necesario para permisos
            var current = Session.CurrentUser;
            if (current != null && current.Role?.Name == "Invitado")
            {
                Utils.SetControlsReadOnly(tlpMain);
                mepProductAdd.ValidationButtonEnable = false;
            }
        }

        private void LoadProductData(ProductModel product) 
        {
            tbProductCode.Text = product.Code;
            tbProductName.Text = product.Name;
            tbProductStock.Text = product.Stock.ToString();
            tbProductUnitPrice.Text = product.UnitPrice.ToString();
            tbDescription.Text = product.Description;
        }

        private bool ValidateFields()
        {
            List<string> emptyFields = new List<string>();

            if (string.IsNullOrWhiteSpace(tbProductCode.Text))
                emptyFields.Add("Codigo de producto");

            if (string.IsNullOrWhiteSpace(tbProductName.Text))
                emptyFields.Add("nombre de producto");

            if (string.IsNullOrWhiteSpace(tbProductStock.Text))
                emptyFields.Add("Cantidad");

            if (string.IsNullOrWhiteSpace(tbProductUnitPrice.Text))
                emptyFields.Add("Precio unitario");

            if (emptyFields.Count > 0)
            {
                string message = "Los siguientes campos son obligatorios:\n\n" + string.Join("\n", emptyFields);
                MessageBox.Show(message, "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar cantidad
            if (!int.TryParse(tbProductStock.Text, out int quantity) || quantity <= 0)
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
            currentProduct.Code = tbProductCode.Text;
            currentProduct.Name = tbProductName.Text;
            currentProduct.Stock = int.Parse(tbProductStock.Text);
            currentProduct.UnitPrice = decimal.TryParse(tbProductUnitPrice.Text, out decimal price) ? price : 0;
            currentProduct.Description = tbDescription.Text;
            bool success;
            if (currentProduct.Id == 0)
                success = producController.CreateProduct(currentProduct);
            else
                success = producController.UpdateProduct(currentProduct);

            if (success)
            {
                MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formPrincipal?.RestaurarFormularioTab(formPrincipal.tabProducts);
            }
            else
            {
                MessageBox.Show("Error al guardar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mepProductAdd_cancelClick(object sender, EventArgs e)
        {
            formPrincipal?.RestaurarFormularioTab(formPrincipal.tabProducts);
        }
    }
}
