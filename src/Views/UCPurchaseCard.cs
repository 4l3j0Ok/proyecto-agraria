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

namespace GestionAgraria.Views
{
    public partial class UCPurchaseCard : UserControl
    {
        private PurchaseModel _purchase;
        private FormPrincipal? _formPrincipal;
        public UCPurchaseCard(PurchaseModel purchase)
        {
            InitializeComponent();
            _purchase = purchase;
            _formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();

            if (purchase.User != null)
            {
                lblUserUsername.Text = purchase.User.Name + " " + purchase.User.Surname;
            }
            else
            {
                lblUserUsername.Text = "Usuario desconocido";
            }
            
            lblRecordDatetime.Text = purchase.RecordDate.ToString();
            lblTotal.Text = purchase.TotalCost.ToString();
        }

        private void chbPurchase_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPurchase.Checked)
            {
                // Agregar purchase a la lista de seleccionados si no está ya
                if (!FormPrincipal.SelectedPurchases.Any(p => p.Id == _purchase.Id))
                {
                    FormPrincipal.SelectedPurchases.Add(_purchase);
                }
            }
            else
            {
                // Remover purchae de la lista de seleccionados
                FormPrincipal.SelectedPurchases.RemoveAll(p => p.Id == _purchase.Id);
            }

            // Actualizar el estado del botón de impresión
            UpdatePrintButtonState();
        }
        private void UpdatePrintButtonState()
        {
            if (_formPrincipal != null)
            {
                // Buscar el botón de impresión (btnPrintPurchases)
                var btnPrintPurchases = _formPrincipal.tabPurchases.Controls
                    .OfType<ReaLTaiizor.Controls.MaterialFloatingActionButton>()
                    .FirstOrDefault(btn => btn.Name == "btnPrintPurchases");

                if (btnPrintPurchases != null)
                {
                    btnPrintPurchases.Enabled = FormPrincipal.SelectedPurchases.Count > 0;
                }
            }
        }
        private void OnPurchasesCardOnClick(object? sender, EventArgs? e)
        {
            openFormAdd(_purchase);
        }

        public static void openFormAdd(PurchaseModel purchase)
        {
            UCPurchaseAdd purchaseAdd = new UCPurchaseAdd();
            FormPrincipal? formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();
            formPrincipal?.VerFormularioTab(purchaseAdd, formPrincipal.tabSells);
        }
    }
}
