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
using ReaLTaiizor.Controls;

namespace GestionAgraria.Views
{
    public partial class UCSellAdd : UserControl
    {
        private SellController SellsController;
        private ProductController productController;
        private SellDetailController detailSellsController;
        private UserController userController;

        // List that stores the details to be saved and avoids re-fetching products by name/id
        private List<SellDetailModel> currentDetailSellsList = new List<SellDetailModel>();
        private List<ProductModel> availableProducts = new List<ProductModel>();

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

                // Preload sell fields
                tbSellClientName.Text = sells.ClientName ?? string.Empty;
                tbSellObservations.Text = sells.Observation ?? string.Empty;
                tbTotal.Text = sells.TotalCost.ToString("0.00");

                // Load sell details and populate grid + detail list
                try
                {
                    detailSellsController = new SellDetailController();
                    var details = detailSellsController.GetDetailsBySellId(sells.Id);
                    decimal runningTotal = 0m;
                    foreach (var d in details)
                    {
                        currentDetailSellsList.Add(d);
                        var prod = d.Product;
                        string code = prod?.Code ?? "N/A";
                        string name = prod?.Name ?? "N/A";
                        string cantidad = d.Quatity.ToString();
                        string ProductUnitPrice = d.ProductUnitPrice.ToString("0.00");
                        string totalStr = (d.Quatity * d.ProductUnitPrice).ToString("0.00");
                        LoadDGVProduct(new List<string> { code, name, cantidad, ProductUnitPrice, totalStr }, updateTotal: false);
                        runningTotal += d.Quatity * d.ProductUnitPrice;
                    }
                    tbTotal.Text = runningTotal.ToString("0.00");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            else
            {
                currentSells = new SellModel();
            }

            // subscribe to selection change to update price field
            cbSellProductName.SelectedIndexChanged += cbSellProductName_SelectedIndexChanged;
        }

        private void mepSellsAdd_SaveClick(object sender, EventArgs e)
        {
            try
            {
                // Set current sell data from form
                currentSells.TotalCost = Convert.ToDecimal(tbTotal.Text);
                currentSells.Observation = tbSellObservations.Text;
                currentSells.ClientName = tbSellClientName.Text;
                currentSells.User = currentUser;
                currentSells.UserId = currentSells.User?.Id ?? 0;

                SellsController.CreateSells(currentSells);

                // If we just created a new sell, get its id
                var createdSell = SellsController.GetLastSell();
                if (createdSell != null)
                {
                    currentSells = createdSell;
                }

                // Save detail lines
                detailSellsController = new SellDetailController();
                foreach (SellDetailModel sells in currentDetailSellsList)
                {
                    sells.SellsId = currentSells.Id;
                    detailSellsController.CreateDetailSells(sells);
                }

                MessageBox.Show("Venta registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                currentDetailSellsList.Clear();
                formPrincipal?.RestaurarFormularioTab(formPrincipal.tabSells);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show($"Error al registrar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComboBoxes()
        {
            try
            {
                cbSellProductName.Items.Clear();
                availableProducts = productController.GetAllProduct();
                foreach (ProductModel pro in availableProducts)
                {
                    cbSellProductName.Items.Add(pro.Name);
                }

                if (availableProducts.Count > 0)
                {
                    cbSellProductName.SelectedIndex = 0;
                    tbSellPrice.Text = availableProducts[0].UnitPrice.ToString("0.00");
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
            try
            {
                if (cbSellProductName.SelectedIndex < 0)
                {
                    MessageBox.Show("Seleccione un producto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var product = availableProducts[cbSellProductName.SelectedIndex];

                if (!int.TryParse(tbSellProductQuantity.Text, out int qty) || qty <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad válida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(tbSellPrice.Text, out decimal price) || price <= 0)
                {
                    // fallback to product unit price
                    price = product.UnitPrice;
                }

                currentDetailSells = new SellDetailModel
                {
                    Quatity = qty,
                    ProductUnitPrice = price,
                    ProductId = product.Id
                };

                currentDetailSellsList.Add(currentDetailSells);

                string code = product.Code;
                string name = product.Name;
                string cantidad = qty.ToString();
                string ProductUnitPrice = price.ToString("0.00");

                LoadDGVProduct(new List<string> { code, name, cantidad, ProductUnitPrice, (qty * price).ToString("0.00") });
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }

        decimal total = 0m;
        private void LoadDGVProduct(List<string> listProduct, bool updateTotal = true)
        {
            int rows = dgvProductList.Rows.Add();
            dgvProductList.Rows[rows].Cells[0].Value = listProduct[0];
            dgvProductList.Rows[rows].Cells[1].Value = listProduct[1];
            dgvProductList.Rows[rows].Cells[2].Value = listProduct[2];
            dgvProductList.Rows[rows].Cells[3].Value = listProduct[3];
            dgvProductList.Rows[rows].Cells[4].Value = listProduct[4];

            if (updateTotal)
            {
                if (int.TryParse(listProduct[2], out int qty) && decimal.TryParse(listProduct[3], out decimal unitPrice))
                {
                    total += qty * unitPrice;
                    tbTotal.Text = total.ToString("0.00");
                }
            }
        }

        private void cbSellProductName_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cbSellProductName.SelectedIndex >= 0 && cbSellProductName.SelectedIndex < availableProducts.Count)
            {
                var prod = availableProducts[cbSellProductName.SelectedIndex];
                tbSellPrice.Text = prod.UnitPrice.ToString("0.00");
            }
        }
    }
}
