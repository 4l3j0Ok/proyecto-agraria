using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAgraria.Views
{
    public partial class UCFormativeEnvironmentDataAdd : UserControl
    {
        // Evento para cuando se solicita eliminar este control
        public event EventHandler? DeleteRequested;

        public UCFormativeEnvironmentDataAdd(int year = 1, string course = "", string group = "")
        {
            InitializeComponent();

            // Asignar valores a los controles
            cbFormativeEnvironmentDataYear.SelectedItem = year.ToString();
            tbFormativeEnvironmentDataCourse.Text = course;
            tbFormativeEnvironmentDataGroup.Text = group;

            // Suscribir al evento del botón eliminar
            btnDelete.Click += BtnDelete_Click;
        }

        // Propiedades para acceder a los valores
        public int Year
        {
            get
            {
                if (int.TryParse(cbFormativeEnvironmentDataYear.Text, out int year))
                    return year;
                return 1;
            }
            set
            {
                cbFormativeEnvironmentDataYear.SelectedItem = value.ToString();
            }
        }

        public string Course
        {
            get => tbFormativeEnvironmentDataCourse.Text;
            set => tbFormativeEnvironmentDataCourse.Text = value;
        }

        public string Group
        {
            get => tbFormativeEnvironmentDataGroup.Text;
            set => tbFormativeEnvironmentDataGroup.Text = value;
        }

        // Método para validar si los campos están completos
        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(cbFormativeEnvironmentDataYear.Text) &&
                   !string.IsNullOrWhiteSpace(tbFormativeEnvironmentDataCourse.Text) &&
                   !string.IsNullOrWhiteSpace(tbFormativeEnvironmentDataGroup.Text);
        }

        // Manejador del evento de eliminar
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            DeleteRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
