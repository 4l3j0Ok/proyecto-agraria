using GestionAgraria.controllers;
using GestionAgraria.Core;
using GestionAgraria.Models;
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
    public partial class UCProductCard : UserControl
    {
        private ProductModel _product;
        private FormPrincipal? _formPrincipal;

        public UCProductCard(ProductModel product)
        {
            InitializeComponent();

            _product = product;
            _formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();

            lblNombreProducto.Text = product.Name;
            lblCode.Text = product.Code;
            lblStock.Text = product.Stock.ToString();
            lblUnitPrice.Text = $"${product.UnitPrice:F2}";
            Utils.CardSetupClickEvent(this, OnProductCardClick);
        }

        private void OnProductCardClick(object? sender, EventArgs? e)
        {
            // Solo abrir el formulario si el click no fue en el checkbox
            if (sender is Control control && control != chbProduct && !IsChildOf(sender as Control, chbProduct))
            {
                OpenFormAdd(_product);
            }
        }

        private bool IsChildOf(Control? control, Control parent)
        {
            while (control != null)
            {
                if (control == parent)
                    return true;
                control = control.Parent;
            }
            return false;
        }

        public static void OpenFormAdd(ProductModel product)
        {
            UCProductAdd ProductlAdd = new UCProductAdd(product);
            FormPrincipal? formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();
            formPrincipal?.VerFormularioTab(ProductlAdd, formPrincipal.tabProducts);
        }

        private void chbProduct_CheckedChanged(object sender, EventArgs e)
        {
            if (chbProduct.Checked)
            {
                // Agregar producto a la lista de seleccionados si no está ya
                if (!FormPrincipal.SelectedProducts.Any(p => p.Id == _product.Id))
                {
                    FormPrincipal.SelectedProducts.Add(_product);
                }
            }
            else
            {
                // Remover producto de la lista de seleccionados
                FormPrincipal.SelectedProducts.RemoveAll(p => p.Id == _product.Id);
            }

            // Actualizar el estado del botón de impresión
            UpdatePrintButtonState();
        }

        private void UpdatePrintButtonState()
        {
            if (_formPrincipal != null)
            {
                // Buscar el botón de impresión (btnPrintProduct)
                var btnPrintProduct = _formPrincipal.tabProducts.Controls
                    .OfType<ReaLTaiizor.Controls.MaterialFloatingActionButton>()
                    .FirstOrDefault(btn => btn.Name == "btnPrintProduct");

                if (btnPrintProduct != null)
                {
                    btnPrintProduct.Enabled = FormPrincipal.SelectedProducts.Count > 0;
                }
            }
        }
    }
}
