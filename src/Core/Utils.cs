using GestionAgraria.controllers;
using GestionAgraria.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAgraria.Core
{
    internal class Utils
    {
        public static string GenerateRandomString(int length)
        {
            Random random = new Random();
            string characters = Config.random_password_characters;
            string password = "";
            int index;
            for (int i = 0; i < length; i++)
            {
                index = random.Next(characters.Length);
                password += characters[index];
            }
            return password;
        }
        public static void CardSetupClickEvent(Control obj, EventHandler OnUserCardClick)
        {
            // Agregar evento click al UserControl principal
            obj.Click += OnUserCardClick;
            obj.Cursor = Cursors.Hand; // Cambiar cursor para indicar que es clickeable

            // Agregar evento click a todos los controles hijos recursivamente
            CardAddClickEventToControls(obj.Controls, OnUserCardClick);
        }

        public static void CardAddClickEventToControls(Control.ControlCollection controls, EventHandler function)
        {
            foreach (Control control in controls)
            {
                control.Click += function;
                control.Cursor = Cursors.Hand;

                // Si el control tiene controles hijos, agregar el evento recursivamente
                if (control.HasChildren)
                {
                    CardAddClickEventToControls(control.Controls, function);
                }
            }
        }
        public static byte[]? ImageToByteArray(Image? imageIn)
        {
            if (imageIn == null)
                return null;

            using (var ms = new MemoryStream())
            {
                // Usar PNG como formato predeterminado para evitar problemas con RawFormat
                imageIn.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public static Image? ByteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn == null || byteArrayIn.Length == 0) return null;
            using (var ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }
        public static void SetControlsReadOnly(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                control.Enabled = false;
            }
        }
        /// <summary>
        /// Deshabilita los atajos de teclado (Ctrl+C, Ctrl+V, etc.) en todos los TextBox y RichTextBox
        /// contenidos dentro de un Form o UserControl.
        /// </summary>
        public static void DeshabilitarShortcuts(Control contenedor)
        {
            if (contenedor == null) return;

            foreach (Control control in contenedor.Controls)
            {
                if (control is TextBoxBase textBox)
                {
                    textBox.ShortcutsEnabled = false;
                }

                // 🔹 Si el control contiene otros controles (como Panel, GroupBox, TabPage, UserControl, etc.)
                if (control.HasChildren)
                {
                    DeshabilitarShortcuts(control);
                }
            }
        }

        public static class InputValidator
        {
            public enum TipoValidacion
            {
                Decimal,
                SoloLetras,
                SoloMail,
                LetrasYNumeros,
                SoloNumeros
            }

            /// <summary>
            /// Valida la pulsación de tecla según el tipo especificado.
            /// </summary>
            public static void ValidarEntrada(KeyPressEventArgs e, string textoActual, int maxLargo, TipoValidacion tipo)
            {
                char c = e.KeyChar;

                // 🔹 Permitir siempre Backspace
                if (c == (char)Keys.Back)
                    return;

                switch (tipo)
                {
                    case TipoValidacion.Decimal:
                        ValidarDecimal(e, textoActual, maxLargo);
                        break;

                    case TipoValidacion.SoloLetras:
                        ValidarSoloLetras(e, textoActual, maxLargo);
                        break;

                    case TipoValidacion.SoloMail:
                        ValidarMailKeyPress(e);
                        break;

                    case TipoValidacion.LetrasYNumeros:
                        ValidarLetrasYNumeros(e, textoActual, maxLargo);
                        break;

                    case TipoValidacion.SoloNumeros:
                        ValidarSoloNumeros(e, textoActual, maxLargo);
                        break;
                }
            }

            // 🔸 Submétodos internos privados
            private static void ValidarDecimal(KeyPressEventArgs e, string textoActual, int maxLargo)
            {
                char c = e.KeyChar;

                if (!char.IsDigit(c) && c != ',' && c != '.')
                {
                    e.Handled = true;
                    return;
                }

                // Evita más de una coma o punto
                if ((c == ',' || c == '.') && (textoActual.Contains(",") || textoActual.Contains(".")))
                {
                    e.Handled = true;
                    return;
                }

                // Valida longitud sin coma o punto
                string textoProyectado = textoActual + c;
                string textoSinSeparador = textoProyectado.Replace(",", "").Replace(".", "");
                if (textoSinSeparador.Length > maxLargo)
                {
                    e.Handled = true;
                }
            }

            private static void ValidarSoloLetras(KeyPressEventArgs e, string textoActual, int maxLargo)
            {
                Regex regex = new Regex(@"^[a-zA-Z\s]{0," + maxLargo + "}$");
                if (!regex.IsMatch(textoActual + e.KeyChar))
                {
                    e.Handled = true;
                }
            }

            private static void ValidarMailKeyPress(KeyPressEventArgs e)
            {
                char c = e.KeyChar;
                if (!char.IsLetterOrDigit(c) && c != '@' && c != '.' && c != '-' && c != '_' && c != '\b')
                {
                    e.Handled = true;
                }
            }

            private static void ValidarLetrasYNumeros(KeyPressEventArgs e, string textoActual, int maxLargo)
            {
                Regex regex = new Regex(@"^[a-zA-Z0-9\s-]{0," + maxLargo + "}$");
                if (!regex.IsMatch(textoActual + e.KeyChar))
                {
                    e.Handled = true;
                }
            }

            private static void ValidarSoloNumeros(KeyPressEventArgs e, string textoActual, int maxLargo)
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    return;
                }

                if ((textoActual + e.KeyChar).Length > maxLargo)
                {
                    e.Handled = true;
                }
            }

            /// <summary>
            /// Valida si un texto completo tiene formato de correo electrónico válido.
            /// </summary>
            public static bool EsMailValido(string texto)
            {
                if (string.IsNullOrWhiteSpace(texto))
                    return false;

                string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(texto, patron);
            }
        }
        public static string MayusPrimeraLetra(string? s)
        {
            if (string.IsNullOrEmpty(s)) return s ?? "";
            int i = 0;
            while (i < s.Length && char.IsWhiteSpace(s[i])) i++;
            if (i == s.Length || !char.IsLetter(s[i])) return s;
            return s.Substring(0, i) + char.ToUpper(s[i]) + s.Substring(i + 1);
        }

    }
}
