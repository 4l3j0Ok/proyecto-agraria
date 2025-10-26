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
        public UCPurchaseCard(PurchaseModel purchase)
        {
            InitializeComponent();
            _purchase = purchase;
            
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
