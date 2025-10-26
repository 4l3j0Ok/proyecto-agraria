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
using GestionAgraria.Core;

namespace GestionAgraria.Views
{
    public partial class UCSellAdd : UserControl
    {
        private SellController SellsController;
        private ProductController productController;
        private SellDetailController detailSellsController;
        private UserController userController;

        private List<SellDetailModel> currentDetailSellsList = new List<SellDetailModel>();

        private SellModel currentSells;
        private SellDetailModel currentDetailSells;
        private UserModel currentUser;

        private FormPrincipal? formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();
        public UCSellAdd(UserModel? CurrentUser = null, SellModel? sells = null)
        {
            currentUser = CurrentUser;
            SellsController = new SellController();
            productController = new ProductController();
            InitializeComponent();
            LoadComboBoxes();
            if (sells != null)
            {
                mepSellsAdd.Title = "Modificar Venta";
                mepSellsAdd.Description = "Edita los datos de la venta seleccionada";
                currentSells = sells;

            }
            else
            {
                currentSells = new SellModel();
            }
        }

        private void mepSellsAdd_SaveClick(object sender, EventArgs e)
        {
            try 
            {
                currentSells = new SellModel();

                detailSellsController = new SellDetailController();
                userController = new UserController();

                currentSells.TotalCost = Convert.ToDecimal(tbTotal.Text);
                currentSells.Observation = tbSellsObservations.Text;
                currentSells.User = currentUser;
                currentSells.UserId = currentSells.User.Id;

                SellsController.CreateSells(currentSells);

                currentSells = SellsController.GetLastSell();

                foreach (SellDetailModel sells in currentDetailSellsList)
                {
                    sells.SellsId = currentSells.Id;
                    detailSellsController.CreateDetailSells(sells);
                }
                
                MessageBox.Show("Venta registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Preguntar si desea imprimir
                var result = MessageBox.Show("¿Desea imprimir el comprobante de venta?", "Imprimir", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (result == DialogResult.Yes && currentSells != null)
                {
                    var printController = new PrintController();
                    printController.PrintSell(currentSells, currentDetailSellsList);
                }
                
                currentDetailSellsList.Clear();
                formPrincipal?.RestaurarFormularioTab(formPrincipal.tabSells);
            }
            catch (Exception ex) 
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show($"Error al registrar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UCSellsAdd_Load(object sender, EventArgs e)
        {

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
                    cbCodeProduc.Items.Add(pro.Code);
                    cbNameProduct.Items.Add(pro.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mepSellsAdd_CancelClick(object sender, EventArgs e)
        {
            formPrincipal?.RestaurarFormularioTab(formPrincipal.tabSells);
        }

        private void btnProductAddList_Click(object sender, EventArgs e)
        {

            currentDetailSells = new SellDetailModel();
            List<string> listProduct = new List<string>();
            try
            {

                string code = cbCodeProduc.Text;

                ProductModel product = productController.GetProductByCode(code);
                currentDetailSells.SellsId = currentSells.Id;
                currentDetailSells.Quatity = int.Parse(tbQuatity.Text);
                currentDetailSells.PriceUnit = Convert.ToDecimal(tbPrecio.Text);
                currentDetailSells.ProductId = product.Id;

                currentDetailSellsList.Add(currentDetailSells);

                string name = product.Name;
                string cantidad = Convert.ToString(currentDetailSells.Quatity);
                string PriceUnit = Convert.ToString(currentDetailSells.PriceUnit);

                listProduct.Add(code);
                listProduct.Add(name);
                listProduct.Add(cantidad);
                listProduct.Add(PriceUnit);
                LoadDGVProduct(listProduct);
            }
            catch (Exception ex )
            {
                Debug.WriteLine(ex.Message);
            }
            
        }
        int total = 0;
        private void LoadDGVProduct(List<string> listProduct)
        {
            int rows  = dgvProductList.Rows.Add();
            dgvProductList.Rows[rows].Cells[0].Value = listProduct[0];
            dgvProductList.Rows[rows].Cells[1].Value = listProduct[1];
            dgvProductList.Rows[rows].Cells[2].Value = listProduct[2];
            dgvProductList.Rows[rows].Cells[3].Value = listProduct[3];

            if (int.TryParse(listProduct[3], out int value))
            {
                if(int.TryParse(listProduct[2], out int value1))
                dgvProductList.Rows[rows].Cells[4].Value = value * value1;
                total += value * value1;
                tbTotal.Text = Convert.ToString(total );
            }
            else
            {
                dgvProductList.Rows[rows].Cells[4].Value = "Error";
            }
        }
    }
}
