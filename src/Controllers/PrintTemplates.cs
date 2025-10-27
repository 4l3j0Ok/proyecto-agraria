using System;

namespace GestionAgraria.Core
{
    public static class PrintTemplates
    {
        public static string ProductTemplate => @"
<!DOCTYPE html>
<html lang='es'>
<head>
<meta charset='UTF-8'>
<meta name='viewport' content='width=device-width, initial-scale=1.0'>
<title>Etiquetas de Productos</title>
<style>
    @page {
        size: A4;
        margin: 1cm;
    }

    * {
        margin: 0;
        padding: 0;
        box-sizing: border-box;
        -webkit-print-color-adjust: exact !important;
        print-color-adjust: exact !important;
    }

    body {
        font-family: 'Segoe UI', Arial, sans-serif;
        background-color: #ffffff;
        display: flex;
        flex-wrap: wrap;
        justify-content: center;
        align-items: center;
        gap: 0.8cm;
        padding: 1cm;
    }

    .card {
        display: flex;
        align-items: center;
        justify-content: space-between;
        width: calc(100% / 2 - 0.4cm);
        height: 3.8cm;
        outline: 2px solid #d1d5db;
        border-radius: 0.5rem;
        background-color: #fefefe;
        padding: 0.6rem 1rem;
        box-shadow: 0 1px 3px rgba(0,0,0,0.12);
        width: auto;
        break-inside: avoid;
    }

    .logo {
        width: 55px;
        height: 55px;
        object-fit: contain;
        margin-right: 1rem;
    }

    .product-name {
        flex: 1;
        font-weight: 800;
        color: #111827;
        font-size: 1.2rem;
        text-align: center;
        word-wrap: break-word;
        line-height: 1.2;
        margin: 0 0.5rem;
    }

    .barcode-section {
        display: flex;
        flex-direction: column;
        align-items: center;
        justify-content: center;
        margin-left: 1rem;
    }

    .barcode {
        height: 60px;
        object-fit: contain;
        margin-bottom: 0.2rem;
    }

    .barcode-text {
        font-size: 0.8rem;
        font-family: monospace;
        color: #374151;
        letter-spacing: 1px;
        text-align: center;
    }

    .product-price {
        font-size: 1.3rem;
        font-weight: 900;
        color: #065f46;
        background: #d1fae5;
        padding: 0.4rem 0.8rem;
        border-radius: 0.5rem;
        border: 2px solid #047857;
        margin-left: 1rem;
        white-space: nowrap;
    }

    @media print {
        body {
            background: white;
            padding: 0.5cm;
            gap: 0.6cm;
        }
        .card {
            box-shadow: none;
            border: 1px solid #ccc;
        }
    }
</style>
</head>
<body>
    {{ for product in products }}
    <div class='card'>
        <img src='data:image/png;base64,{{ product.logo_base64 }}' alt='Logo' class='logo' />
        <div class='product-name'>{{ product.name }}</div>
        <div class='barcode-section'>
            <img src='data:image/png;base64,{{ product.barcode_base64 }}' class='barcode' alt='Código de barras' />
            <div class='barcode-text'>{{ product.code }}</div>
        </div>
        <div class='product-price'>$ {{ product.price | math.format '0.00' }}</div>
    </div>
    {{ end }}
</body>
</html>";

        public static string PurchaseTemplate => @"
<!DOCTYPE html>
<html lang='es'>
<head>
<meta charset='UTF-8'>
<meta name='viewport' content='width=device-width, initial-scale=1.0'>
<title>Informe de Compras</title>
<style>
    * { margin: 0; padding: 0; box-sizing: border-box;
        -webkit-print-color-adjust: exact !important;
        print-color-adjust: exact !important;
    }
    body { font-family: 'Segoe UI', Arial, sans-serif; padding: 20mm; background: #EEEEEE; }
    h1 { text-align: center; color: #234602; margin-bottom: 20px; }
    .date { text-align: center; color: #666; margin-bottom: 30px; }
    table { width: 100%; border-collapse: collapse; margin-top: 10px; background: white; }
    thead { background: #396f04; color: white; }
    th, td { padding: 10px; text-align: left; border: 1px solid #ccc; font-size: 14px; }
    tbody tr:nth-child(even) { background: #f5fbe9; }
    tfoot td { font-weight: bold; background: #d7f4b0; }
    .footer { text-align: center; margin-top: 40px; color: #555; font-size: 12px;
              border-top: 1px solid #ccc; padding-top: 15px; }
    @media print { body { padding: 10mm; background: white; } }
</style>
</head>
<body>
    <h1>Informe de Compras</h1>
    <div class='date'>Generado: {{ date.now | date.to_string '%d/%m/%Y %H:%M' }}</div>

    <table>
        <thead>
            <tr>
                <th>ID Compra</th>
                <th>Fecha</th>
                <th>Usuario</th>
                <th>Insumo</th>
                <th>Cantidad</th>
                <th>Costo Unitario</th>
                <th>Subtotal</th>
            </tr>
        </thead>
        <tbody>
            {{ for purchase in purchases }}
            <tr>
                <td>{{ purchase.purchase_id }}</td>
                <td>{{ purchase.date | date.to_string '%d/%m/%Y' }}</td>
                <td>{{ purchase.user }}</td>
                <td>{{ purchase.item_name }}</td>
                <td>{{ purchase.quantity }}</td>
                <td>${{ purchase.unit_cost | math.format '0.00' }}</td>
                <td>${{ purchase.subtotal | math.format '0.00' }}</td>
            </tr>
            {{ end }}
        </tbody>
        <tfoot>
            <tr>
                <td colspan='6' style='text-align: right;'>Total Comprado:</td>
                <td>${{ total_cost | math.format '0.00' }}</td>
            </tr>
        </tfoot>
    </table>

    <div class='footer'>
        Gestión Agraria - Informe General de Compras
    </div>
</body>
</html>";


        public static string SellTemplate => @"
<!DOCTYPE html>
<html lang='es'>
<head>
<meta charset='UTF-8'>
<meta name='viewport' content='width=device-width, initial-scale=1.0'>
<title>Informe de Ventas</title>
<style>
    * { margin: 0; padding: 0; box-sizing: border-box;
        -webkit-print-color-adjust: exact !important;
        print-color-adjust: exact !important;
    }
    body { font-family: 'Segoe UI', Arial, sans-serif; padding: 20mm; background: #EEEEEE; }
    h1 { text-align: center; color: #234602; margin-bottom: 20px; }
    .date { text-align: center; color: #666; margin-bottom: 30px; }
    table { width: 100%; border-collapse: collapse; margin-top: 10px; background: white; }
    thead { background: #396f04; color: white; }
    th, td { padding: 10px; text-align: left; border: 1px solid #ccc; font-size: 14px; }
    tbody tr:nth-child(even) { background: #f5fbe9; }
    tfoot td { font-weight: bold; background: #d7f4b0; }
    .footer { text-align: center; margin-top: 40px; color: #555; font-size: 12px;
            border-top: 1px solid #ccc; padding-top: 15px; }
    @media print { body { padding: 10mm; background: white; } }
</style>
</head>
<body>
    <h1>Informe de Ventas</h1>
    <div class='date'>Generado: {{ date.now | date.to_string '%d/%m/%Y %H:%M' }}</div>

    <table>
        <thead>
            <tr>
                <th>ID Venta</th>
                <th>Fecha</th>
                <th>Usuario</th>
                <th>Cliente</th>
                <th>Producto</th>
                <th>Cantidad</th>
                <th>Precio Unitario</th>
                <th>Subtotal</th>
            </tr>
        </thead>
        <tbody>
            {{ for sale in sales }}
            <tr>
                <td>{{ sale.id }}</td>
                <td>{{ sale.date | date.to_string '%d/%m/%Y' }}</td>
                <td>{{ sale.user }}</td>
                <td>{{ sale.client }}</td>
                <td>{{ sale.product_name }}</td>
                <td>{{ sale.quantity }}</td>
                <td>${{ sale.unit_price | math.format '0.00' }}</td>
                <td>${{ sale.subtotal | math.format '0.00' }}</td>
            </tr>
            {{ end }}
        </tbody>
        <tfoot>
            <tr>
                <td colspan='7' style='text-align: right;'>Total Vendido:</td>
                <td>${{ total_sales | math.format '0.00' }}</td>
            </tr>
        </tfoot>
    </table>

    <div class='footer'>
        Gestión Agraria - Informe General de Ventas
    </div>
</body>
</html>";

    }
}
