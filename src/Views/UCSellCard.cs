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
    public partial class UCSellCard : UserControl
    {
        private SellModel _sell;
        private FormPrincipal? _formPrincipal;
        public UCSellCard(SellModel sell)
        {
            InitializeComponent();
            _sell = sell;
            _formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();
            lblUserUsername.Text = sell.User.Name +" "+ sell.User.Surname;
            lblRecordDatetime.Text = sell.RecordDate.ToString();
            lblTotal.Text = sell.TotalCost.ToString();
        }

        private void chbSell_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSell.Checked)
            {
                // Agregar sell a la lista de seleccionados si no está ya
                if (!FormPrincipal.SelectedSells.Any(p => p.Id == _sell.Id))
                {
                    FormPrincipal.SelectedSells.Add(_sell);
                }
            }
            else
            {
                // Remover sell de la lista de seleccionados
                FormPrincipal.SelectedSells.RemoveAll(p => p.Id == _sell.Id);
            }

            // Actualizar el estado del botón de impresión
            UpdatePrintButtonState();
        }
        private void UpdatePrintButtonState()
        {
            if (_formPrincipal != null)
            {
                // Buscar el botón de impresión (btnPrintSells) en la pestaña de ventas
                var btnPrintSells = _formPrincipal.tabSells.Controls
                    .OfType<ReaLTaiizor.Controls.MaterialFloatingActionButton>()
                    .FirstOrDefault(btn => btn.Name == "btnPrintSells");

                if (btnPrintSells != null)
                {
                    btnPrintSells.Enabled = FormPrincipal.SelectedSells.Count > 0;
                }
            }
        }

        private void OnSellsCardOnClick(object? sender, EventArgs? e)
        {
            OpenFormAdd(_sell);
        }

        public static void OpenFormAdd(SellModel sell)
        {
            UCSellAdd sellAdd = new UCSellAdd(null, sell);
            FormPrincipal? formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();
            formPrincipal?.VerFormularioTab(sellAdd, formPrincipal.tabSells);
        }
    }
}
