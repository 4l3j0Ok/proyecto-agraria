using GestionAgraria.Core;
using GestionAgraria.Models;
using Scriban;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;

namespace GestionAgraria.Controllers
{
    public class PrintController
    {
        private string? htmlContent;

        public void PrintProduct(ProductModel product)
        {
            PrintProducts(new List<ProductModel> { product });
        }

        public void PrintProducts(List<ProductModel> products)
        {
            try
            {
                var template = Template.Parse(PrintTemplates.ProductTemplate);

                // Convertir logo a Base64 una vez
                string logoBase64 = Convert.ToBase64String(Utils.ImageToByteArray(Properties.Resources.eesan1) ?? new byte[0]);

                var productsList = products.Select(product => new
                {
                    code = product.Code,
                    name = product.Name,
                    // stock removed from template, keep for compatibility if needed
                    description = product.Description,
                    is_active = product.IsActive,
                    price = product.UnitPrice,
                    barcode_base64 = GenerateBarcodeBase64(product.Code),
                    logo_base64 = logoBase64
                }).ToList();

                var model = new { products = productsList };

                htmlContent = template.Render(model);
                OpenHtmlInDefaultBrowserWithAutoPrint(htmlContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar reporte: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex);
            }
        }



        private void OpenHtmlInDefaultBrowserWithAutoPrint(string html)
        {
            try
            {
                string script = "<script>window.onload = function(){ window.print(); };</script>";
                string modified = html.Replace("</body>", script + "</body>");

                string tempPath = Path.Combine(Path.GetTempPath(), $"GestionAgraria_Print_{Guid.NewGuid()}.html");
                File.WriteAllText(tempPath, modified, Encoding.UTF8);

                Process.Start(new ProcessStartInfo
                {
                    FileName = tempPath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir vista previa en el navegador: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex);
            }
        }

        private string GenerateBarcodeBase64(string code)
        {
            var writer = new BarcodeWriterPixelData
            {
                Format = BarcodeFormat.CODE_128,
                Options = new EncodingOptions
                {
                    Height = 80,
                    Width = 300,
                    Margin = 2
                }
            };

            var pixelData = writer.Write(code);
            using var bitmap = new Bitmap(pixelData.Width, pixelData.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            var bitmapData = bitmap.LockBits(
                new Rectangle(0, 0, pixelData.Width, pixelData.Height),
                System.Drawing.Imaging.ImageLockMode.WriteOnly,
                bitmap.PixelFormat);
            try
            {
                System.Runtime.InteropServices.Marshal.Copy(pixelData.Pixels, 0, bitmapData.Scan0, pixelData.Pixels.Length);
            }
            finally
            {
                bitmap.UnlockBits(bitmapData);
            }

            using var ms = new MemoryStream();
            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return Convert.ToBase64String(ms.ToArray());
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
                OpenHtmlInDefaultBrowserWithAutoPrint(htmlContent);
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
                    product_code = d.Product?.Code ?? "N/A",
                    product_name = d.Product?.Name ?? "N/A",
                    stock = d.Quatity,
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
                OpenHtmlInDefaultBrowserWithAutoPrint(htmlContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar reporte: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex);
            }
        }
    }
}
