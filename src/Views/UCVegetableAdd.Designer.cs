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
using ReaLTaiizor.Controls;
using GestionAgraria.Controls;



namespace GestionAgraria.Views
{
    partial class UCVegetableAdd
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            mepVegetalAdd = new NonCollapsibleMaterialExpansionPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new System.Windows.Forms.Panel();
            groupBox3 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel8 = new System.Windows.Forms.Panel();
            materialTextBoxEdit8 = new MaterialTextBoxEdit();
            materialLabel8 = new MaterialLabel();
            groupBox1 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel4 = new System.Windows.Forms.Panel();
            cbEstado = new MaterialComboBox();
            materialLabel3 = new MaterialLabel();
            panel1 = new System.Windows.Forms.Panel();
            cbEntornos = new MaterialComboBox();
            materialLabel2 = new MaterialLabel();
            panel6 = new System.Windows.Forms.Panel();
            cbQuatityPlant = new MaterialComboBox();
            materialLabel6 = new MaterialLabel();
            panel3 = new System.Windows.Forms.Panel();
            tbUsuario = new MaterialTextBoxEdit();
            materialLabel1 = new MaterialLabel();
            mepVegetalAdd.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel8.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // mepVegetalAdd
            // 
            mepVegetalAdd.BackColor = Color.FromArgb(255, 255, 255);
            mepVegetalAdd.CancelButtonText = "Cancelar";
            mepVegetalAdd.Controls.Add(tableLayoutPanel2);
            mepVegetalAdd.Depth = 0;
            mepVegetalAdd.Description = "Registrar una nueva planta";
            mepVegetalAdd.Dock = DockStyle.Fill;
            mepVegetalAdd.ExpandHeight = 344;
            mepVegetalAdd.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            mepVegetalAdd.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mepVegetalAdd.Location = new Point(0, 0);
            mepVegetalAdd.Margin = new Padding(3, 16, 3, 16);
            mepVegetalAdd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mepVegetalAdd.Name = "mepVegetalAdd";
            mepVegetalAdd.Padding = new Padding(24, 64, 24, 20);
            mepVegetalAdd.ShowCollapseExpand = false;
            mepVegetalAdd.Size = new Size(1152, 344);
            mepVegetalAdd.TabIndex = 0;
            mepVegetalAdd.Title = "Agregar Planta";
            mepVegetalAdd.ValidationButtonEnable = true;
            mepVegetalAdd.ValidationButtonText = "Guardar";
            mepVegetalAdd.SaveClick += mepVegetalAdd_SaveClick;
            mepVegetalAdd.CancelClick += mepVegetalAdd_CancelClick;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(24, 64);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 263F));
            tableLayoutPanel2.Size = new Size(1104, 260);
            tableLayoutPanel2.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1098, 254);
            panel2.TabIndex = 11;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel3);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(0, 100);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1098, 100);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(panel8, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 19);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1092, 78);
            tableLayoutPanel3.TabIndex = 27;
            // 
            // panel8
            // 
            panel8.Controls.Add(materialTextBoxEdit8);
            panel8.Controls.Add(materialLabel8);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(20, 0, 20, 0);
            panel8.Size = new Size(1092, 78);
            panel8.TabIndex = 26;
            // 
            // materialTextBoxEdit8
            // 
            materialTextBoxEdit8.AnimateReadOnly = false;
            materialTextBoxEdit8.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit8.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit8.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit8.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit8.Depth = 0;
            materialTextBoxEdit8.Dock = DockStyle.Fill;
            materialTextBoxEdit8.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxEdit8.HideSelection = true;
            materialTextBoxEdit8.LeadingIcon = null;
            materialTextBoxEdit8.Location = new Point(20, 19);
            materialTextBoxEdit8.Margin = new Padding(3, 3, 26, 3);
            materialTextBoxEdit8.MaxLength = 32767;
            materialTextBoxEdit8.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEdit8.Name = "materialTextBoxEdit8";
            materialTextBoxEdit8.Padding = new Padding(9, 8, 9, 8);
            materialTextBoxEdit8.PasswordChar = '\0';
            materialTextBoxEdit8.PrefixSuffixText = null;
            materialTextBoxEdit8.ReadOnly = false;
            materialTextBoxEdit8.RightToLeft = RightToLeft.No;
            materialTextBoxEdit8.SelectedText = "";
            materialTextBoxEdit8.SelectionLength = 0;
            materialTextBoxEdit8.SelectionStart = 0;
            materialTextBoxEdit8.ShortcutsEnabled = true;
            materialTextBoxEdit8.Size = new Size(1052, 48);
            materialTextBoxEdit8.TabIndex = 0;
            materialTextBoxEdit8.TabStop = false;
            materialTextBoxEdit8.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit8.TrailingIcon = null;
            materialTextBoxEdit8.UseSystemPasswordChar = false;
            materialTextBoxEdit8.KeyPress += materialTextBoxEdit8_KeyPress;
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Dock = DockStyle.Top;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(20, 0);
            materialLabel8.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(105, 19);
            materialLabel8.TabIndex = 4;
            materialLabel8.Text = "Observaciones";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel5);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1098, 100);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Entorno";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.Controls.Add(panel4, 3, 0);
            tableLayoutPanel5.Controls.Add(panel1, 2, 0);
            tableLayoutPanel5.Controls.Add(panel6, 1, 0);
            tableLayoutPanel5.Controls.Add(panel3, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 19);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.Size = new Size(1092, 78);
            tableLayoutPanel5.TabIndex = 29;
            // 
            // panel4
            // 
            panel4.Controls.Add(cbEstado);
            panel4.Controls.Add(materialLabel3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(818, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20, 0, 20, 0);
            panel4.Size = new Size(274, 82);
            panel4.TabIndex = 34;
            // 
            // cbEstado
            // 
            cbEstado.AutoResize = false;
            cbEstado.BackColor = Color.FromArgb(255, 255, 255);
            cbEstado.Depth = 0;
            cbEstado.Dock = DockStyle.Top;
            cbEstado.DrawMode = DrawMode.OwnerDrawVariable;
            cbEstado.DropDownHeight = 174;
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.DropDownWidth = 121;
            cbEstado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbEstado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbEstado.FormattingEnabled = true;
            cbEstado.IntegralHeight = false;
            cbEstado.ItemHeight = 43;
            cbEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cbEstado.Location = new Point(20, 19);
            cbEstado.MaxDropDownItems = 4;
            cbEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(234, 49);
            cbEstado.StartIndex = 0;
            cbEstado.TabIndex = 10;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Dock = DockStyle.Top;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(20, 0);
            materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(50, 19);
            materialLabel3.TabIndex = 4;
            materialLabel3.Text = "Estado";
            // 
            // panel1
            // 
            panel1.Controls.Add(cbEntornos);
            panel1.Controls.Add(materialLabel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(545, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 0, 20, 0);
            panel1.Size = new Size(273, 82);
            panel1.TabIndex = 31;
            // 
            // cbEntornos
            // 
            cbEntornos.AutoResize = false;
            cbEntornos.BackColor = Color.FromArgb(255, 255, 255);
            cbEntornos.Depth = 0;
            cbEntornos.Dock = DockStyle.Top;
            cbEntornos.DrawMode = DrawMode.OwnerDrawVariable;
            cbEntornos.DropDownHeight = 174;
            cbEntornos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEntornos.DropDownWidth = 121;
            cbEntornos.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbEntornos.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbEntornos.FormattingEnabled = true;
            cbEntornos.IntegralHeight = false;
            cbEntornos.ItemHeight = 43;
            cbEntornos.Location = new Point(20, 19);
            cbEntornos.MaxDropDownItems = 4;
            cbEntornos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbEntornos.Name = "cbEntornos";
            cbEntornos.Size = new Size(233, 49);
            cbEntornos.StartIndex = 0;
            cbEntornos.TabIndex = 10;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Dock = DockStyle.Top;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(20, 0);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(89, 19);
            materialLabel2.TabIndex = 4;
            materialLabel2.Text = "Relacionado";
            // 
            // panel6
            // 
            panel6.Controls.Add(cbQuatityPlant);
            panel6.Controls.Add(materialLabel6);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(382, 0);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20, 0, 20, 0);
            panel6.Size = new Size(163, 82);
            panel6.TabIndex = 30;
            // 
            // cbQuatityPlant
            // 
            cbQuatityPlant.AutoResize = false;
            cbQuatityPlant.BackColor = Color.FromArgb(255, 255, 255);
            cbQuatityPlant.Depth = 0;
            cbQuatityPlant.Dock = DockStyle.Top;
            cbQuatityPlant.DrawMode = DrawMode.OwnerDrawVariable;
            cbQuatityPlant.DropDownHeight = 174;
            cbQuatityPlant.DropDownStyle = ComboBoxStyle.DropDownList;
            cbQuatityPlant.DropDownWidth = 121;
            cbQuatityPlant.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbQuatityPlant.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbQuatityPlant.FormattingEnabled = true;
            cbQuatityPlant.IntegralHeight = false;
            cbQuatityPlant.ItemHeight = 43;
            cbQuatityPlant.Location = new Point(20, 19);
            cbQuatityPlant.MaxDropDownItems = 4;
            cbQuatityPlant.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbQuatityPlant.Name = "cbQuatityPlant";
            cbQuatityPlant.Size = new Size(123, 49);
            cbQuatityPlant.StartIndex = 0;
            cbQuatityPlant.TabIndex = 10;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Dock = DockStyle.Top;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(20, 0);
            materialLabel6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(65, 19);
            materialLabel6.TabIndex = 4;
            materialLabel6.Text = "Cantidad";
            // 
            // panel3
            // 
            panel3.Controls.Add(tbUsuario);
            panel3.Controls.Add(materialLabel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 0, 20, 0);
            panel3.Size = new Size(382, 82);
            panel3.TabIndex = 21;
            // 
            // tbUsuario
            // 
            tbUsuario.AnimateReadOnly = false;
            tbUsuario.AutoCompleteMode = AutoCompleteMode.None;
            tbUsuario.AutoCompleteSource = AutoCompleteSource.None;
            tbUsuario.BackgroundImageLayout = ImageLayout.None;
            tbUsuario.CharacterCasing = CharacterCasing.Normal;
            tbUsuario.Depth = 0;
            tbUsuario.Dock = DockStyle.Top;
            tbUsuario.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbUsuario.HideSelection = true;
            tbUsuario.LeadingIcon = null;
            tbUsuario.Location = new Point(20, 19);
            tbUsuario.Margin = new Padding(3, 3, 26, 3);
            tbUsuario.MaxLength = 32767;
            tbUsuario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Padding = new Padding(9, 8, 9, 8);
            tbUsuario.PasswordChar = '\0';
            tbUsuario.PrefixSuffixText = null;
            tbUsuario.ReadOnly = false;
            tbUsuario.RightToLeft = RightToLeft.No;
            tbUsuario.SelectedText = "";
            tbUsuario.SelectionLength = 0;
            tbUsuario.SelectionStart = 0;
            tbUsuario.ShortcutsEnabled = true;
            tbUsuario.Size = new Size(342, 48);
            tbUsuario.TabIndex = 0;
            tbUsuario.TabStop = false;
            tbUsuario.TextAlign = HorizontalAlignment.Left;
            tbUsuario.TrailingIcon = null;
            tbUsuario.UseSystemPasswordChar = false;
            tbUsuario.KeyPress += tbUsuario_KeyPress;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Dock = DockStyle.Top;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(20, 0);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(106, 19);
            materialLabel1.TabIndex = 5;
            materialLabel1.Text = "Nombre planta";
            // 
            // UCVegetableAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mepVegetalAdd);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCVegetableAdd";
            Size = new Size(1152, 344);
            mepVegetalAdd.ResumeLayout(false);
            mepVegetalAdd.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbObservacion;
        private ReaLTaiizor.Controls.MaterialLabel lblObservacion;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbEntornoProductivo;
        private ReaLTaiizor.Controls.MaterialLabel lblEntornoProductivo;
        private ReaLTaiizor.Controls.MaterialComboBox cbSexo;
        private ReaLTaiizor.Controls.MaterialLabel lblSexo;
        private System.Windows.Forms.Panel panel4;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbFechaNacieminto_Ingreso;
        private ReaLTaiizor.Controls.MaterialLabel lblFechaNacimiento_Ingres;
        private ReaLTaiizor.Controls.MaterialLabel lblTipoAnimal;
        private ReaLTaiizor.Controls.MaterialLabel lblCodigo;
        private NonCollapsibleMaterialExpansionPanel mepVegetalAdd;
        private TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel8;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit8;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel6;
        private ReaLTaiizor.Controls.MaterialComboBox cbQuatityPlant;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.Panel panel3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbUsuario;
        private ReaLTaiizor.Controls.MaterialLabel lblTipoPlanta;
        private System.Windows.Forms.Panel panel1;
        private MaterialComboBox cbEntornos;
        private MaterialLabel materialLabel2;
        private MaterialLabel materialLabel1;
        private MaterialComboBox cbEstado;
        private MaterialLabel materialLabel3;
    }
}
