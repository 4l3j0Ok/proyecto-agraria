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
            lblUserUsername.Text = purchase.User.Name +" "+ purchase.User.Surname;
            lblRecordDatetime.Text = purchase.RecordDate.ToString();
            lblTotal.Text = purchase.TotalCost.ToString();
        }

        private void OnSellsCardOnClick(object? sender, EventArgs? e)
        {
            openFormAdd(_purchase);
        }

        public static void openFormAdd(PurchaseModel purchase)
        {
            UCProductAdd purchaseAdd = new UCProductAdd();
            FormPrincipal? formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();
            formPrincipal?.VerFormularioTab(purchaseAdd, formPrincipal.tabVentas);
        }
    }
}
