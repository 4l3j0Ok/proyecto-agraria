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
    public partial class UCPurchaseAdd : UserControl
    {
        private PurchaseController purchaseController;
        private PurchaseItemController purchaseItemController;
        private UserController userController;

        private List<PurchaseItemModel> currentPurchaseItems = new List<PurchaseItemModel>();

        private PurchaseModel currentPurchase;
        // Obtener usuario actual desde Session en lugar de FormPrincipal
        private UserModel? currentUser = Session.CurrentUser;

        private FormPrincipal? formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();

        public UCPurchaseAdd(PurchaseModel? purchase = null)
        {
            purchaseController = new PurchaseController();
            purchaseItemController = new PurchaseItemController();

            InitializeComponent();

            // Configurar el DataGridView dinámicamente
            ConfigureDataGridView();

            // Configurar eventos
            btnProductAddList.Click += btnProductAddList_Click;
            MepBuysAdd.SaveClick += MepBuysAdd_SaveClick;
            MepBuysAdd.CancelClick += MepBuysAdd_CancelClick;

            if (purchase != null)
            {
                MepBuysAdd.Title = "Modificar Compra";
                MepBuysAdd.Description = "Edita los datos de la compra seleccionada";
                currentPurchase = purchase;
                // Cargar datos de la compra si es necesario
                foreach (var item in purchaseItemController.GetItemsByPurchaseId(purchase.Id))
                {
                    currentPurchaseItems.Add(item);
                    decimal subtotal = item.Quantity * item.Cost;
                    int rowIndex = dgvProductList.Rows.Add();
                    dgvProductList.Rows[rowIndex].Cells["ColName"].Value = item.Name;
                    dgvProductList.Rows[rowIndex].Cells["ColQuantity"].Value = item.Quantity;
                    dgvProductList.Rows[rowIndex].Cells["ColCost"].Value = item.Cost;
                    dgvProductList.Rows[rowIndex].Cells["ColSubtotal"].Value = subtotal;
                }
                tbPurchaseObservation.Text = purchase.Observation;
                UpdateTotal();

            }
            else
            {
                currentPurchase = new PurchaseModel();
            }

            // Hacer el total readonly
            tbTotal.ReadOnly = true;
            var current = Session.CurrentUser;
            if (current != null && current.Role.Name == "Invitado")
            {
                Utils.SetControlsReadOnly(tableLayoutPanel1);
                MepBuysAdd.ValidationButtonEnable = false;
            }
        }

        private void ConfigureDataGridView()
        {
            // Limpiar columnas existentes
            dgvProductList.Columns.Clear();

            // Configurar propiedades generales
            dgvProductList.AllowUserToAddRows = false;
            dgvProductList.AllowUserToDeleteRows = false;
            dgvProductList.ReadOnly = true;
            dgvProductList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Agregar columnas dinámicamente
            dgvProductList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ColName",
                HeaderText = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 40
            });

            dgvProductList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ColQuantity",
                HeaderText = "Cantidad",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 20
            });

            dgvProductList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ColCost",
                HeaderText = "Costo Unitario",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 20,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvProductList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ColSubtotal",
                HeaderText = "Subtotal",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 20,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });
        }

        private void btnProductAddList_Click(object? sender, EventArgs e)
        {
            try
            {
                // Validar campos
                if (string.IsNullOrWhiteSpace(tbPurchaseItemName.Text))
                {
                    MessageBox.Show("Debe ingresar el nombre del ítem.", "Campo requerido",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbPurchaseItemName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbPurchaseItemQuantity.Text))
                {
                    MessageBox.Show("Debe ingresar la cantidad.", "Campo requerido",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbPurchaseItemQuantity.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbPurchaseItemCost.Text))
                {
                    MessageBox.Show("Debe ingresar el costo.", "Campo requerido",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbPurchaseItemCost.Focus();
                    return;
                }

                // Validar cantidad
                if (!int.TryParse(tbPurchaseItemQuantity.Text, out int quantity) || quantity <= 0)
                {
                    MessageBox.Show("La cantidad debe ser un número entero mayor a 0.", "Error de validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbPurchaseItemQuantity.Focus();
                    return;
                }

                // Validar costo
                if (!decimal.TryParse(tbPurchaseItemCost.Text, out decimal cost) || cost <= 0)
                {
                    MessageBox.Show("El costo debe ser un número mayor a 0.", "Error de validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbPurchaseItemCost.Focus();
                    return;
                }

                // Crear nuevo ítem
                var newItem = new PurchaseItemModel
                {
                    Name = tbPurchaseItemName.Text.Trim(),
                    Quantity = quantity,
                    Cost = cost
                };

                currentPurchaseItems.Add(newItem);

                // Calcular subtotal
                decimal subtotal = quantity * cost;

                // Agregar fila al DataGridView
                int rowIndex = dgvProductList.Rows.Add();
                dgvProductList.Rows[rowIndex].Cells["ColName"].Value = newItem.Name;
                dgvProductList.Rows[rowIndex].Cells["ColQuantity"].Value = newItem.Quantity;
                dgvProductList.Rows[rowIndex].Cells["ColCost"].Value = newItem.Cost;
                dgvProductList.Rows[rowIndex].Cells["ColSubtotal"].Value = subtotal;

                // Actualizar total
                UpdateTotal();

                // Limpiar campos
                ClearItemFields();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show($"Error al agregar ítem: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (var item in currentPurchaseItems)
            {
                total += item.Quantity * item.Cost;
            }
            tbTotal.Text = $"${total:0.00}";
        }

        private void ClearItemFields()
        {
            tbPurchaseItemName.Text = "";
            tbPurchaseItemQuantity.Text = "";
            tbPurchaseItemCost.Text = "";
            tbPurchaseItemName.Focus();
        }

        private void MepBuysAdd_SaveClick(object? sender, EventArgs e)
        {
            try
            {
                if (currentPurchaseItems.Count == 0)
                {
                    MessageBox.Show("Debe agregar al menos un ítem a la compra.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (currentUser == null)
                {
                    MessageBox.Show("No se ha identificado el usuario actual.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calcular total
                decimal total = currentPurchaseItems.Sum(item => item.Quantity * item.Cost);

                // Crear la compra
                var newPurchase = new PurchaseModel
                {
                    TotalCost = total,
                    Observation = tbPurchaseObservation.Text.Trim(),
                    UserId = currentUser.Id,
                    RecordDate = DateTime.Now
                };

                // Guardar la compra
                if (!purchaseController.CreatePurchase(newPurchase))
                {
                    MessageBox.Show("Error al guardar la compra.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener la compra recién creada
                var savedPurchase = purchaseController.GetLastPurchase();
                if (savedPurchase == null)
                {
                    MessageBox.Show("Error al obtener la compra guardada.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Guardar los ítems
                foreach (var item in currentPurchaseItems)
                {
                    item.PurchaseId = savedPurchase.Id;
                    purchaseItemController.CreateItem(item);
                }

                MessageBox.Show("Compra registrada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar y volver
                currentPurchaseItems.Clear();
                dgvProductList.Rows.Clear();
                tbTotal.Text = "";
                tbPurchaseObservation.Text = "";

                formPrincipal?.RestaurarFormularioTab(formPrincipal.tabPurchases);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show($"Error al registrar la compra: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MepBuysAdd_CancelClick(object? sender, EventArgs e)
        {
            formPrincipal?.RestaurarFormularioTab(formPrincipal.tabPurchases);
        }

        private void tbPurchaseItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.InputValidator.ValidarEntrada(e, ((TextBox)sender).Text, 50, Utils.InputValidator.TipoValidacion.LetrasYNumeros);
        }

        private void tbPurchaseItemQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.InputValidator.ValidarEntrada(e, ((TextBox)sender).Text, 7, Utils.InputValidator.TipoValidacion.SoloNumeros);
        }

        private void tbPurchaseItemCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.InputValidator.ValidarEntrada(e, ((TextBox)sender).Text, 50, Utils.InputValidator.TipoValidacion.Decimal);
        }
    }
}
