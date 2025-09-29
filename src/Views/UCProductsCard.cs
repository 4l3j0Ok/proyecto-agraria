using GestionAgraria.controllers;
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
    public partial class UCProductsCard : UserControl
    {
        private ProductModel _product;
        
        public UCProductsCard(ProductModel product)
        {
            InitializeComponent();

            _product = product;

            lblNombreProducto.Text = product.Name;
            lbl_CodigoProducto.Text = product.code;
            lblStock.Text = product.Quantity.ToString();
            Utils.CardSetupClickEvent(this, OnProductCardClick);
        }

        private void OnProductCardClick(object? sender, EventArgs? e)
        {
            OpenFormAdd(_product);
        }

        public static void OpenFormAdd(ProductModel product)
        {
            UCProductsAdd ProductlAdd = new  UCProductsAdd(product);
            FormPrincipal? formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();
            formPrincipal?.VerFormularioTab(ProductlAdd, formPrincipal.tabProduct);
        }
    }
}
