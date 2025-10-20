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
using GestionAgraria.controllers;
using GestionAgraria.models;

namespace GestionAgraria.Views
{
    public partial class UCBlackBoardAdd : UserControl
    {
        private BlackBoardController blackBoardController;
        private FormativeEnvironmentController formativeEnvironmentController;
        private FormPrincipal? formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();
        private BlackBoardModel currentBlackboard;

        public UCBlackBoardAdd(BlackBoardModel? blackboard = null)
        {
            blackBoardController = new BlackBoardController();
            formativeEnvironmentController = new FormativeEnvironmentController();
            InitializeComponent();

            if (blackboard != null)
            {
                mepBlackBoard.Title = "Modificar Pizarrón";
                mepBlackBoard.Description = "Edita los datos del pizarrón seleccionado";
                currentBlackboard = blackboard;
                tbTitle.Text = blackboard.title;
                cbFormativeEnvironment.SelectedItem = blackboard.entorno;
                txtObservaciones.Text = blackboard.observaciones;
                
                // Configurar el DataGridView con datos existentes si los hay
                InitializeDataGridView();
            }
            else
            {
                currentBlackboard = new BlackBoardModel();
                InitializeDataGridView();
            }
        }

        private void UCBlackBoardAdd_Load(object sender, EventArgs e)
        {
            LoadFormativeEnvironments();
        }

        private void LoadFormativeEnvironments()
        {
            List<FormativeEnvironmentModel> environments = formativeEnvironmentController.GetAllFormativeEnvironmentsActive();
            cbFormativeEnvironment.Items.Clear();
            
            foreach (FormativeEnvironmentModel environment in environments)
            {
                cbFormativeEnvironment.Items.Add(environment.Name);
            }
        }

        private void InitializeDataGridView()
        {
            // Configuración básica del DataGridView para permitir entrada de datos
            dgvData.AllowUserToAddRows = true;
            dgvData.AllowUserToDeleteRows = true;
            dgvData.EditMode = DataGridViewEditMode.EditOnEnter;
            
            // Si no tiene columnas, agregar algunas por defecto
            if (dgvData.Columns.Count == 0)
            {
                dgvData.Columns.Add("Columna1", "Columna 1");
                dgvData.Columns.Add("Columna2", "Columna 2");
                dgvData.Columns.Add("Columna3", "Columna 3");
            }
        }

        private bool ValidateFields()
        {
            List<string> emptyFields = new List<string>();

            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(tbTitle.Text))
                emptyFields.Add("Título");

            if (cbFormativeEnvironment.SelectedItem == null || string.IsNullOrWhiteSpace(cbFormativeEnvironment.SelectedItem.ToString()))
                emptyFields.Add("Entorno Formativo");

            // Mostrar mensaje de error si hay campos vacíos
            if (emptyFields.Count > 0)
            {
                string message = "Los siguientes campos son obligatorios:\n\n" + string.Join("\n", emptyFields);
                MessageBox.Show(message, "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void mepBlackBoard_SaveClick(object sender, EventArgs e)
        {
            // Validar campos antes de guardar
            if (!ValidateFields())
                return;

            // Asignar valores del formulario al modelo
            currentBlackboard.title = tbTitle.Text;
            currentBlackboard.entorno = cbFormativeEnvironment.SelectedItem?.ToString() ?? "";
            currentBlackboard.observaciones = txtObservaciones.Text;
            currentBlackboard.dateRecord = DateTime.Now.Year; // Usar año actual como dateRecord
            currentBlackboard.idTraining = ""; // Por ahora dejarlo vacío, se puede modificar según necesidades

            bool success;
            if (currentBlackboard.Id == 0)
                success = blackBoardController.CreateBlackBoard(currentBlackboard);
            else
                success = blackBoardController.UpdateBlackBoard(currentBlackboard);

            if (success)
            {
                MessageBox.Show("Pizarrón guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formPrincipal?.RestaurarFormularioTab(formPrincipal.tabBlackBoard);
            }
            else
            {
                MessageBox.Show("Error al guardar el pizarrón. Ya existe un pizarrón con el mismo título.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mepBlackBoard_CancelClick(object sender, EventArgs e)
        {
            formPrincipal?.RestaurarFormularioTab(formPrincipal.tabBlackBoard);
        }
    }
}
