using GestionAgraria.Models;
using Scriban;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAgraria.Core
{
    public class PrintService : IDisposable
    {
        private WebBrowser? webBrowser;
        private string? htmlContent;
        private bool isPrinting = false;

        public void PrintProduct(ProductModel product)
        {
            try
            {
                var template = Template.Parse(PrintTemplates.ProductTemplate);
                
                var model = new
                {
                    code = product.code,
                    name = product.Name,
                    quantity = product.Quantity,
                    observations = product.Observations,
                    is_active = product.IsActive,
                    formative_environment = product.FormativeEnvironment?.Name ?? "N/A"
                };

                htmlContent = template.Render(model);
                ShowPrintPreview();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar reporte: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex);
            }
        }

        public void PrintPurchase(PurchaseModel purchase, List<PurchaseItemModel> items)
        {
            try
            {
                var template = Template.Parse(PrintTemplates.PurchaseTemplate);

                var itemsList = items.Select(i => new
                {
                    name = i.Name,
                    quantity = i.Quantity,
                    cost = i.Cost,
                    subtotal = i.Quantity * i.Cost
                }).ToList();

                var model = new
                {
                    id = purchase.Id,
                    record_date = purchase.RecordDate,
                    user_name = $"{purchase.User?.Name} {purchase.User?.Surname}",
                    total_cost = purchase.TotalCost,
                    observation = purchase.Observation,
                    items = itemsList
                };

                htmlContent = template.Render(model);
                ShowPrintPreview();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar reporte: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex);
            }
        }

        public void PrintSell(SellModel sell, List<SellDetailModel> details)
        {
            try
            {
                var template = Template.Parse(PrintTemplates.SellTemplate);

                var detailsList = details.Select(d => new
                {
                    product_code = d.Product?.code ?? "N/A",
                    product_name = d.Product?.Name ?? "N/A",
                    quantity = d.Quatity,
                    price_unit = d.PriceUnit,
                    subtotal = d.Quatity * d.PriceUnit
                }).ToList();

                var model = new
                {
                    id = sell.Id,
                    record_date = sell.RecordDate,
                    user_name = $"{sell.User?.Name} {sell.User?.Surname}",
                    total_cost = sell.TotalCost,
                    observation = sell.Observation,
                    details = detailsList
                };

                htmlContent = template.Render(model);
                ShowPrintPreview();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar reporte: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex);
            }
        }

        private void ShowPrintPreview()
        {
            if (string.IsNullOrEmpty(htmlContent))
            {
                MessageBox.Show("No hay contenido para mostrar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Form previewForm = new Form
            {
                Text = "Vista previa de impresión",
                Width = 900,
                Height = 700,
                StartPosition = FormStartPosition.CenterScreen,
                ShowIcon = false
            };

            webBrowser = new WebBrowser
            {
                Dock = DockStyle.Fill,
                ScriptErrorsSuppressed = true
            };

            webBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;

            Panel buttonPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 60,
                Padding = new Padding(10)
            };

            Button btnPrint = new Button
            {
                Text = "Imprimir",
                Width = 120,
                Height = 40,
                Location = new System.Drawing.Point(10, 10)
            };
            btnPrint.Click += (s, e) => Print();

            Button btnSavePdf = new Button
            {
                Text = "Guardar PDF",
                Width = 120,
                Height = 40,
                Location = new System.Drawing.Point(140, 10)
            };
            btnSavePdf.Click += (s, e) => SaveAsPdf();

            Button btnClose = new Button
            {
                Text = "Cerrar",
                Width = 120,
                Height = 40,
                Location = new System.Drawing.Point(270, 10)
            };
            btnClose.Click += (s, e) => previewForm.Close();

            buttonPanel.Controls.Add(btnPrint);
            buttonPanel.Controls.Add(btnSavePdf);
            buttonPanel.Controls.Add(btnClose);

            previewForm.Controls.Add(webBrowser);
            previewForm.Controls.Add(buttonPanel);

            webBrowser.DocumentText = htmlContent;

            previewForm.ShowDialog();
        }

        private void WebBrowser_DocumentCompleted(object? sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser != null && webBrowser.Document != null && isPrinting)
            {
                webBrowser.Document.ExecCommand("Print", true, null);
                isPrinting = false;
            }
        }

        private void Print()
        {
            if (webBrowser?.Document == null)
            {
                MessageBox.Show("El documento no está listo para imprimir.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                isPrinting = true;
                webBrowser.ShowPrintDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al imprimir: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex);
                isPrinting = false;
            }
        }

        private void SaveAsPdf()
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|HTML files (*.html)|*.html";
                    saveFileDialog.Title = "Guardar reporte";
                    saveFileDialog.FileName = $"reporte_{DateTime.Now:yyyyMMdd_HHmmss}";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        if (saveFileDialog.FilterIndex == 2) // HTML
                        {
                            File.WriteAllText(saveFileDialog.FileName, htmlContent, Encoding.UTF8);
                            MessageBox.Show("Archivo HTML guardado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else // PDF
                        {
                            MessageBox.Show(
                                $"Para guardar como PDF:\n\n" +
                                $"1. Se abrirá el diálogo de impresión\n" +
                                $"2. Selecciona 'Microsoft Print to PDF' como impresora\n" +
                                $"3. Guarda el archivo en: {saveFileDialog.FileName}",
                                "Guardar como PDF",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            webBrowser?.ShowPrintDialog();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar archivo: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex);
            }
        }

        public void Dispose()
        {
            webBrowser?.Dispose();
        }
    }
}
