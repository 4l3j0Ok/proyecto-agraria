using GestionAgraria.Core;
using GestionAgraria.Controllers;
using GestionAgraria.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionAgraria.Examples
{
    /// <summary>
    /// Clase de ejemplo que demuestra el uso del sistema de impresión
    /// </summary>
    public static class PrintingExamples
    {
        /// <summary>
        /// Ejemplo 1: Imprimir un producto existente por ID
        /// </summary>
        public static void Example1_PrintProductById(int productId)
        {
            using (var controller = new ProductController())
            {
                var product = controller.GetProductById(productId);
                if (product != null)
                {
                    Utils.PrintProduct(product);
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Ejemplo 2: Imprimir una venta con detalles
        /// </summary>
        public static void Example2_PrintSellWithDetails(int sellId)
        {
            using (var controller = new SellController())
            {
                var sell = controller.getSellsById(sellId);
                if (sell != null)
                {
                    // Obtener detalles de la venta
                    using (var detailController = new SellDetailController(controller._context))
                    {
                        var details = detailController.GetAllDetail()
                            .Where(d => d.SellsId == sellId)
                            .ToList();
                        
                        Utils.PrintSell(sell, details);
                    }
                }
            }
        }

        /// <summary>
        /// Ejemplo 3: Imprimir una compra completa
        /// </summary>
        public static void Example3_PrintPurchase(int purchaseId)
        {
            using (var controller = new PurchaseController())
            {
                controller.PrintPurchaseReport(purchaseId);
            }
        }

        /// <summary>
        /// Ejemplo 4: Crear y imprimir un producto nuevo
        /// </summary>
        public static void Example4_CreateAndPrintProduct()
        {
            using (var controller = new ProductController())
            {
                var newProduct = new ProductModel
                {
                    code = "PROD-001",
                    Name = "Fertilizante Orgánico",
                    Quantity = 100,
                    Observations = "Fertilizante natural para cultivos",
                    IsActive = true,
                    FormativeEnvironmentId = 1 // Ajustar según tu BD
                };

                if (controller.CreateProduct(newProduct))
                {
                    // Preguntar si desea imprimir
                    var result = MessageBox.Show(
                        "Producto creado correctamente. ¿Desea imprimir el reporte?", 
                        "Éxito", 
                        MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Obtener el producto recién creado con todas sus relaciones
                        var product = controller.GetProductByCode(newProduct.code);
                        if (product != null)
                        {
                            Utils.PrintProduct(product);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Ejemplo 5: Imprimir múltiples productos (reporte por lotes)
        /// </summary>
        public static void Example5_PrintMultipleProducts(List<int> productIds)
        {
            using (var controller = new ProductController())
            {
                foreach (var productId in productIds)
                {
                    var product = controller.GetProductById(productId);
                    if (product != null)
                    {
                        Utils.PrintProduct(product);
                        // Esperar un momento entre impresiones
                        System.Threading.Thread.Sleep(1000);
                    }
                }
            }
        }

        /// <summary>
        /// Ejemplo 6: Imprimir con manejo de errores completo
        /// </summary>
        public static void Example6_PrintWithErrorHandling(int productId)
        {
            try
            {
                using (var controller = new ProductController())
                {
                    var product = controller.GetProductById(productId);
                    
                    if (product == null)
                    {
                        MessageBox.Show(
                            $"No se encontró el producto con ID {productId}.", 
                            "Error", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Warning);
                        return;
                    }

                    // Verificar que tenga entorno formativo
                    if (product.FormativeEnvironment == null)
                    {
                        MessageBox.Show(
                            "El producto no tiene un entorno formativo asignado.", 
                            "Advertencia", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Warning);
                        // Continuar con la impresión de todos modos
                    }

                    Utils.PrintProduct(product);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al imprimir el producto: {ex.Message}", 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Ejemplo 7: Usar el servicio de impresión directamente
        /// </summary>
        public static void Example7_UseDirectPrintService(ProductModel product)
        {
            using (var printService = new PrintService())
            {
                // Esto abrirá la vista previa automáticamente
                printService.PrintProduct(product);
            }
        }

        /// <summary>
        /// Ejemplo 8: Imprimir después de actualizar un producto
        /// </summary>
        public static void Example8_UpdateAndPrint(ProductModel product)
        {
            using (var controller = new ProductController())
            {
                // Actualizar el producto
                product.Quantity += 50; // Agregar stock
                
                if (controller.UpdateProduct(product))
                {
                    MessageBox.Show("Producto actualizado correctamente.", "Éxito", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Imprimir inmediatamente
                    Utils.PrintProduct(product);
                }
                else
                {
                    MessageBox.Show("Error al actualizar el producto.", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Ejemplo 9: Imprimir ventas de un período
        /// </summary>
        public static void Example9_PrintSellsByPeriod(DateTime startDate, DateTime endDate)
        {
            using (var controller = new SellController())
            using (var detailController = new SellDetailController())
            {
                var sells = controller.GetAllSells()
                    .Where(s => s.RecordDate >= startDate && s.RecordDate <= endDate)
                    .ToList();

                if (sells.Count == 0)
                {
                    MessageBox.Show("No hay ventas en el período seleccionado.", "Información", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var result = MessageBox.Show(
                    $"Se encontraron {sells.Count} ventas. ¿Desea imprimirlas todas?", 
                    "Confirmar", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (var sell in sells)
                    {
                        var details = detailController.GetAllDetail()
                            .Where(d => d.SellsId == sell.Id)
                            .ToList();
                        
                        Utils.PrintSell(sell, details);
                    }
                }
            }
        }

        /// <summary>
        /// Ejemplo 10: Agregar botón de impresión en un formulario
        /// </summary>
        public static void Example10_AddPrintButtonToForm(Form form, ProductModel product)
        {
            // Crear botón de impresión
            Button btnPrint = new Button
            {
                Text = "??? Imprimir",
                Width = 100,
                Height = 35,
                Location = new System.Drawing.Point(10, 10)
            };

            // Agregar evento click
            btnPrint.Click += (sender, e) => Utils.PrintProduct(product);

            // Agregar al formulario
            form.Controls.Add(btnPrint);
        }
    }
}
