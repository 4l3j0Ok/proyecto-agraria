using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    <title>Reporte de Producto</title>
    <style>
        * { margin: 0; padding: 0; box-sizing: border-box; }
        body { font-family: 'Segoe UI', Arial, sans-serif; padding: 20mm; }
        .header { text-align: center; margin-bottom: 30px; border-bottom: 3px solid #2c3e50; padding-bottom: 20px; }
        .header h1 { color: #2c3e50; font-size: 28px; margin-bottom: 10px; }
        .header .date { color: #7f8c8d; font-size: 14px; }
        .section { margin: 20px 0; }
        .section-title { background: #3498db; color: white; padding: 10px; font-size: 18px; margin-bottom: 15px; }
        .info-grid { display: grid; grid-template-columns: 1fr 1fr; gap: 15px; }
        .info-item { padding: 10px; border: 1px solid #ecf0f1; background: #f8f9fa; }
        .info-label { font-weight: bold; color: #34495e; display: block; margin-bottom: 5px; }
        .info-value { color: #2c3e50; font-size: 16px; }
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
        <h1>Reporte de Producto</h1>
        <div class='date'>Generado: {{ date.now | date.to_string '%d/%m/%Y %H:%M' }}</div>
    </div>

    <div class='section'>
        <div class='section-title'>Información General</div>
        <div class='info-grid'>
            <div class='info-item'>
                <span class='info-label'>Código:</span>
                <span class='info-value'>{{ code }}</span>
            </div>
            <div class='info-item'>
                <span class='info-label'>Nombre:</span>
                <span class='info-value'>{{ name }}</span>
            </div>
            <div class='info-item'>
                <span class='info-label'>Cantidad en Stock:</span>
                <span class='info-value'>{{ quantity }}</span>
            </div>
            <div class='info-item'>
                <span class='info-label'>Estado:</span>
                <span class='info-value'>{{ is_active ? 'Activo' : 'Inactivo' }}</span>
            </div>
            <div class='info-item'>
                <span class='info-label'>Entorno Formativo:</span>
                <span class='info-value'>{{ formative_environment }}</span>
            </div>
        </div>
    </div>

    {{ if observations }}
    <div class='observations'>
        <div class='info-label'>Observaciones:</div>
        <div>{{ observations }}</div>
    </div>
    {{ end }}

    <div class='footer'>
        Gestión Agraria - Sistema de Información
    </div>
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
