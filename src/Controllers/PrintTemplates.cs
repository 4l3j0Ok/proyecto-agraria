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
    }

    body {
        font-family: 'Segoe UI', Arial, sans-serif;
        background-color: #fff;
        display: flex;
        flex-wrap: wrap;
        justify-content: flex-start;
        align-items: flex-start;
        gap: 1cm;
        padding: 1cm;
    }

    .card {
        display: flex;
        flex-direction: column;
        justify-content: space-between;
        width: calc(50% - 0.5cm);
        outline: 1.5px solid #d1d5db;
        border-radius: 0.6rem;
        background-color: #ffffff;
        padding: 1rem;
        box-shadow: 0 1px 3px rgba(0,0,0,0.08);
        page-break-inside: avoid;
        break-inside: avoid;
    }

    .header {
        display: flex;
        align-items: center;
        gap: 0.75rem;
        margin-bottom: 0.75rem;
    }

    .logo {
        width: 55px;
        height: 55px;
        object-fit: contain;
        flex-shrink: 0;
    }

    .product-name {
        font-weight: 700;
        color: #111827;
        font-size: 1.4rem;
        line-height: 1.1;
        word-wrap: break-word;
    }

    .barcode-container {
        display: flex;
        flex-direction: column;
        align-items: center;
        justify-content: center;
        margin: 0.75rem 0;
    }

    .barcode {
        max-height: 70px;
        object-fit: contain;
    }

    .barcode-text {
        margin-top: 0.25rem;
        font-size: 0.8rem;
        font-family: monospace;
        color: #374151;
        letter-spacing: 1px;
    }

    .sell-info {
        display: flex;
        justify-content: space-between;
        align-items: center;
        background: #f9fafb;
        border: 1px solid #e5e7eb;
        border-radius: 0.5rem;
        padding: 0.4rem 0.8rem;
        margin-top: 0.5rem;
    }

    .product-price {
        font-size: 1.2rem;
        font-weight: 800;
        color: #047857;
    }

    .product-description {
        margin-top: 0.6rem;
        font-size: 0.8rem;
        color: #4b5563;
        line-height: 1.3;
    }

    @media print {
        body {
            background: white;
            gap: 0.8cm;
            padding: 0.5cm;
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
        <div class='header'>
            <img src='data:image/png;base64,{{ product.logo_base64 }}' alt='Logo' class='logo' />
            <div class='product-details'>
                <p class='product-name'>{{ product.name }}</p>
            </div>
        </div>

        <div class='barcode-container'>
            <img src='data:image/png;base64,{{ product.barcode_base64 }}' class='barcode' alt='Código de barras' />
            <div class='barcode-text'>{{ product.code }}</div>
        </div>

        <div class='sell-info'>
            <div></div>
            <div class='product-price'>$ {{ product.price | math.format '0.00' }}</div>
        </div>

        {{ if product.description }}
        <div class='product-description'>
            {{ product.description }}
        </div>
        {{ end }}
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
    <title>Reporte de Compra</title>
    <style>
        * { margin: 0; padding: 0; box-sizing: border-box; }
        body { font-family: 'Segoe UI', Arial, sans-serif; padding: 20mm; }
        .header { text-align: center; margin-bottom: 30px; border-bottom: 3px solid #27ae60; padding-bottom: 20px; }
        .header h1 { color: #27ae60; font-size: 28px; margin-bottom: 10px; }
        .header .date { color: #7f8c8d; font-size: 14px; }
        .section { margin: 20px 0; }
        .section-title { background: #27ae60; color: white; padding: 10px; font-size: 18px; margin-bottom: 15px; }
        .info-grid { display: grid; grid-template-columns: 1fr 1fr; gap: 15px; margin-bottom: 20px; }
        .info-item { padding: 10px; border: 1px solid #ecf0f1; background: #f8f9fa; }
        .info-label { font-weight: bold; color: #34495e; display: block; margin-bottom: 5px; }
        .info-value { color: #2c3e50; font-size: 16px; }
        table { width: 100%; border-collapse: collapse; margin-top: 15px; }
        thead { background: #27ae60; color: white; }
        th, td { padding: 12px; text-align: left; border: 1px solid #bdc3c7; }
        tbody tr:nth-child(even) { background: #ecf0f1; }
        .total-row { background: #d5f4e6 !important; font-weight: bold; font-size: 18px; }
        .observations { margin-top: 20px; padding: 15px; border: 1px solid #bdc3c7; background: #ecf0f1; }
        .footer { margin-top: 40px; text-align: center; font-size: 12px; color: #95a5a6; border-top: 1px solid #bdc3c7; padding-top: 20px; }
        @media print {
            body { padding: 10mm; }
            .no-print { display: none; }
        }
    </style>
</head>
<body>
    <div class='header'>
        <h1>Comprobante de Compra #{{ id }}</h1>
        <div class='date'>Generado: {{ date.now | date.to_string '%d/%m/%Y %H:%M' }}</div>
    </div>

    <div class='section'>
        <div class='section-title'>Información de la Compra</div>
        <div class='info-grid'>
            <div class='info-item'>
                <span class='info-label'>Fecha de Registro:</span>
                <span class='info-value'>{{ record_date | date.to_string '%d/%m/%Y' }}</span>
            </div>
            <div class='info-item'>
                <span class='info-label'>Usuario:</span>
                <span class='info-value'>{{ user_name }}</span>
            </div>
        </div>
    </div>

    <div class='section'>
        <div class='section-title'>Detalle de Ítems</div>
        <table>
            <thead>
                <tr>
                    <th>Ítem</th>
                    <th>Cantidad</th>
                    <th>Costo Unitario</th>
                    <th>Subtotal</th>
                </tr>
            </thead>
            <tbody>
                {{ for item in items }}
                <tr>
                    <td>{{ item.name }}</td>
                    <td>{{ item.quantity }}</td>
                    <td>${{ item.cost | math.format '0.00' }}</td>
                    <td>${{ item.subtotal | math.format '0.00' }}</td>
                </tr>
                {{ end }}
                <tr class='total-row'>
                    <td colspan='3' style='text-align: right;'>TOTAL:</td>
                    <td>${{ total_cost | math.format '0.00' }}</td>
                </tr>
            </tbody>
        </table>
    </div>

    {{ if observation }}
    <div class='observations'>
        <div class='info-label'>Observaciones:</div>
        <div>{{ observation }}</div>
    </div>
    {{ end }}

    <div class='footer'>
        Gestión Agraria - Sistema de Información
    </div>
</body>
</html>";

        public static string SellTemplate => @"
<!DOCTYPE html>
<html lang='es'>
<head>
    <meta charset='UTF-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <title>Reporte de Venta</title>
    <style>
        * { margin: 0; padding: 0; box-sizing: border-box; }
        body { font-family: 'Segoe UI', Arial, sans-serif; padding: 20mm; }
        .header { text-align: center; margin-bottom: 30px; border-bottom: 3px solid #e74c3c; padding-bottom: 20px; }
        .header h1 { color: #e74c3c; font-size: 28px; margin-bottom: 10px; }
        .header .date { color: #7f8c8d; font-size: 14px; }
        .section { margin: 20px 0; }
        .section-title { background: #e74c3c; color: white; padding: 10px; font-size: 18px; margin-bottom: 15px; }
        .info-grid { display: grid; grid-template-columns: 1fr 1fr; gap: 15px; margin-bottom: 20px; }
        .info-item { padding: 10px; border: 1px solid #ecf0f1; background: #f8f9fa; }
        .info-label { font-weight: bold; color: #34495e; display: block; margin-bottom: 5px; }
        .info-value { color: #2c3e50; font-size: 16px; }
        table { width: 100%; border-collapse: collapse; margin-top: 15px; }
        thead { background: #e74c3c; color: white; }
        th, td { padding: 12px; text-align: left; border: 1px solid #bdc3c7; }
        tbody tr:nth-child(even) { background: #ecf0f1; }
        .total-row { background: #fadbd8 !important; font-weight: bold; font-size: 18px; }
        .observations { margin-top: 20px; padding: 15px; border: 1px solid #bdc3c7; background: #ecf0f1; }
        .footer { margin-top: 40px; text-align: center; font-size: 12px; color: #95a5a6; border-top: 1px solid #bdc3c7; padding-top: 20px; }
        @media print {
            body { padding: 10mm; }
            .no-print { display: none; }
        }
    </style>
</head>
<body>
    <div class='header'>
        <h1>Comprobante de Venta #{{ id }}</h1>
        <div class='date'>Generado: {{ date.now | date.to_string '%d/%m/%Y %H:%M' }}</div>
    </div>

    <div class='section'>
        <div class='section-title'>Información de la Venta</div>
        <div class='info-grid'>
            <div class='info-item'>
                <span class='info-label'>Fecha de Registro:</span>
                <span class='info-value'>{{ record_date | date.to_string '%d/%m/%Y' }}</span>
            </div>
            <div class='info-item'>
                <span class='info-label'>Usuario:</span>
                <span class='info-value'>{{ user_name }}</span>
            </div>
        </div>
    </div>

    <div class='section'>
        <div class='section-title'>Detalle de Productos</div>
        <table>
            <thead>
                <tr>
                    <th>Código</th>
                    <th>Producto</th>
                    <th>Cantidad</th>
                    <th>Precio Unitario</th>
                    <th>Subtotal</th>
                </tr>
            </thead>
            <tbody>
                {{ for detail in details }}
                <tr>
                    <td>{{ detail.product_code }}</td>
                    <td>{{ detail.product_name }}</td>
                    <td>{{ detail.quantity }}</td>
                    <td>${{ detail.price_unit | math.format '0.00' }}</td>
                    <td>${{ detail.subtotal | math.format '0.00' }}</td>
                </tr>
                {{ end }}
                <tr class='total-row'>
                    <td colspan='4' style='text-align: right;'>TOTAL:</td>
                    <td>${{ total_cost | math.format '0.00' }}</td>
                </tr>
            </tbody>
        </table>
    </div>

    {{ if observation }}
    <div class='observations'>
        <div class='info-label'>Observaciones:</div>
        <div>{{ observation }}</div>
    </div>
    {{ end }}

    <div class='footer'>
        Gestión Agraria - Sistema de Información
    </div>
</body>
</html>";
    }
}
