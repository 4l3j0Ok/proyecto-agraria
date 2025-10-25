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
        private SellModel _sells;
        public UCPurchaseCard(SellModel sells)
        {
            InitializeComponent();
            _sells = sells;
            lblUserUsername.Text = sells.User.Name +" "+ sells.User.Surname;
            lblRecordDatetime.Text = sells.RecordDate.ToString();
            lblTotal.Text = sells.TotalCost.ToString();
        }

        private void OnSellsCardOnClick(object? sender, EventArgs? e)
        {
            openFormAdd(_sells);
        }

        public static void openFormAdd(SellModel sells)
        {
            UCSellAdd sellsAdd = new UCSellAdd();
            FormPrincipal? formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();
            formPrincipal?.VerFormularioTab(sellsAdd, formPrincipal.tabVentas);
        }
    }
}
