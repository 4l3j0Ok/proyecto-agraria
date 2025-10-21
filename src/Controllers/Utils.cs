using GestionAgraria.controllers;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAgraria
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
            Utils.CardAddClickEventToControls(obj.Controls, OnUserCardClick);
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
                    Utils.CardAddClickEventToControls(control.Controls, function);
                }
            }
        }
        public static byte[]? ImageToByteArray(System.Drawing.Image? imageIn)
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
        public static System.Drawing.Image? ByteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn == null || byteArrayIn.Length == 0) return null;
            using (var ms = new MemoryStream(byteArrayIn))
            {
                return System.Drawing.Image.FromStream(ms);
            }
        }

        public static int CalcularPageSize(FlowLayoutPanel panel, UserControl ejemploCard)
        {
            if (ejemploCard == null || ejemploCard.Height == 0)
                return 1;

            // Se calcula cuántos entran verticalmente
            int disponibles = panel.Height / (ejemploCard.Height + ejemploCard.Margin.Vertical);
            return Math.Max(disponibles, 1); // mínimo 1
        }

        public static class Paginator
        {
            public static void CargarPaginaGrid<T>(
        FlowLayoutPanel panel,
        List<T> items,
        ref int currentPage,
        Func<T, UserControl> createCard)
            {
                if (items == null || items.Count == 0)
                {
                    panel.Controls.Clear();
                    currentPage = 1;
                    return;
                }

                // 1) Tarjeta de ejemplo para medir
                var sample = createCard(items[0]);
                // Asegurá márgenes por si el createCard no los setea
                if (sample.Margin == Padding.Empty) sample.Margin = new Padding(8);

                // Si tu tarjeta tiene AutoSize = true, PreferredSize suele ser lo mejor
                var cardSize = sample.PreferredSize.IsEmpty ? sample.Size : sample.PreferredSize;
                var margin = sample.Margin;

                // 2) Área disponible (sin padding)
                int availW = Math.Max(1, panel.ClientSize.Width - panel.Padding.Horizontal);
                int availH = Math.Max(1, panel.ClientSize.Height - panel.Padding.Vertical);

                // 3) Columnas y filas que entran
                int cols = Math.Max(1, availW / (cardSize.Width + margin.Horizontal));
                int rows = Math.Max(1, availH / (cardSize.Height + margin.Vertical));
                int pageSize = Math.Max(1, rows * cols);

                // 4) Clamp de página
                int totalPages = (int)Math.Ceiling((double)items.Count / pageSize);
                currentPage = Math.Min(Math.Max(1, currentPage), Math.Max(1, totalPages));

                int start = (currentPage - 1) * pageSize;
                var slice = items.Skip(start).Take(pageSize).ToList();

                // 5) Render
                panel.SuspendLayout();
                panel.AutoScroll = false; // paginado, no scroll
                panel.WrapContents = true;
                panel.FlowDirection = FlowDirection.LeftToRight;
                panel.Controls.Clear();

                foreach (var it in slice)
                {
                    var card = createCard(it);
                    card.Dock = DockStyle.None;            // <- IMPORTANTE
                    if (card.Margin == Padding.Empty)      // <- asegura separación
                        card.Margin = margin;

                    panel.Controls.Add(card);
                }

                panel.ResumeLayout();
            }

            public static int GetTotalPages<T>(List<T> items, int pageSize)
            {
                return (int)Math.Ceiling((double)items.Count / pageSize);
            }
        }

    }
}
