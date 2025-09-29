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
using GestionAgraria.models;
using GestionAgraria.Models;

namespace GestionAgraria.Views
{
    public partial class UCPurchasesAdd : UserControl
    {

        private ProductController productController;
        private UserController userController;

        private List<PurchaseDetailModel> currentDetailBuysList = new List<PurchaseDetailModel>();

        private PurchaseModel currentBuys;
        private PurchaseDetailModel currentDetailBuys;
        private UserModel currentUser;

        private FormPrincipal? formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();
        public UCPurchasesAdd(UserModel? CurrentUser = null, PurchaseModel? buys = null)
        {
            currentUser = CurrentUser;
            productController = new ProductController();

            InitializeComponent();
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            try
            {
                cbCodeProduc.Items.Clear();
                cbNameProduct.Items.Clear();

                List<ProductModel> products = productController.GetAllProduct();
                foreach (ProductModel pro in products)
                {
                    cbCodeProduc.Items.Add(pro.code);
                    cbNameProduct.Items.Add(pro.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnProductAddList_Click(object sender, EventArgs e)
        {
            currentDetailBuys = new PurchaseDetailModel();
            List<string> listProduct = new List<string>();
            try
            {

                string code = cbCodeProduc.Text;

                currentDetailBuys.Product = productController.GetProductByCode(code);
                //currentDetailBuys.BuysId = currentBuys.Id;
                currentDetailBuys.Quatity = int.Parse(tbQuatity.Text);
                currentDetailBuys.PriceUnit = Convert.ToDecimal(tbPrecio.Text);
                currentDetailBuys.ProductId = currentDetailBuys.Product.Id;

                currentDetailBuysList.Add(currentDetailBuys);

                string name = currentDetailBuys.Product.Name;
                string cantidad = Convert.ToString(currentDetailBuys.Quatity);
                string PriceUnit = Convert.ToString(currentDetailBuys.PriceUnit);

                listProduct.Add(code);
                listProduct.Add(name);
                listProduct.Add(cantidad);
                listProduct.Add(PriceUnit);
                LoadDGVProduct(listProduct);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        int total = 0;
        private void LoadDGVProduct(List<string> listProduct)
        {
            int rows = dgvProductList.Rows.Add();
            dgvProductList.Rows[rows].Cells[0].Value = listProduct[0];
            dgvProductList.Rows[rows].Cells[1].Value = listProduct[1];
            dgvProductList.Rows[rows].Cells[2].Value = listProduct[2];
            dgvProductList.Rows[rows].Cells[3].Value = listProduct[3];

            if (int.TryParse(listProduct[3], out int value))
            {
                if (int.TryParse(listProduct[2], out int value1))
                    dgvProductList.Rows[rows].Cells[4].Value = value * value1;
                total += value * value1;
                tbTotal.Text = Convert.ToString(total);
            }
            else
            {
                dgvProductList.Rows[rows].Cells[4].Value = "Error";
            }
        }

        private void MepBuysAdd_CancelClick(object sender, EventArgs e)
        {
            formPrincipal?.RestaurarFormularioTab(formPrincipal.tabCompras);
        }
    }
}
