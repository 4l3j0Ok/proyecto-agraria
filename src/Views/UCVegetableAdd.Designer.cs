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
            tbVegetableObservations = new MaterialTextBoxEdit();
            materialLabel8 = new MaterialLabel();
            groupBox1 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel4 = new System.Windows.Forms.Panel();
            cbVegetableStatus = new MaterialComboBox();
            materialLabel3 = new MaterialLabel();
            panel1 = new System.Windows.Forms.Panel();
            cbVegetableEnvironment = new MaterialComboBox();
            materialLabel2 = new MaterialLabel();
            panel6 = new System.Windows.Forms.Panel();
            tbVegetableQuantity = new MaterialTextBoxEdit();
            materialLabel6 = new MaterialLabel();
            panel3 = new System.Windows.Forms.Panel();
            tbVegetableUser = new MaterialTextBoxEdit();
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
            mepVegetalAdd.AutoSize = true;
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
            mepVegetalAdd.Padding = new Padding(24, 64, 24, 70);
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
            tableLayoutPanel2.AutoScroll = true;
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(24, 64);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 263F));
            tableLayoutPanel2.Size = new Size(1104, 210);
            tableLayoutPanel2.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1098, 204);
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
            panel8.Controls.Add(tbVegetableObservations);
            panel8.Controls.Add(materialLabel8);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(20, 0, 20, 0);
            panel8.Size = new Size(1092, 78);
            panel8.TabIndex = 26;
            // 
            // tbVegetableObservations
            // 
            tbVegetableObservations.AnimateReadOnly = false;
            tbVegetableObservations.AutoCompleteMode = AutoCompleteMode.None;
            tbVegetableObservations.AutoCompleteSource = AutoCompleteSource.None;
            tbVegetableObservations.BackgroundImageLayout = ImageLayout.None;
            tbVegetableObservations.CharacterCasing = CharacterCasing.Normal;
            tbVegetableObservations.Depth = 0;
            tbVegetableObservations.Dock = DockStyle.Fill;
            tbVegetableObservations.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbVegetableObservations.HideSelection = true;
            tbVegetableObservations.LeadingIcon = null;
            tbVegetableObservations.Location = new Point(20, 19);
            tbVegetableObservations.Margin = new Padding(3, 3, 26, 3);
            tbVegetableObservations.MaxLength = 32767;
            tbVegetableObservations.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbVegetableObservations.Name = "tbVegetableObservations";
            tbVegetableObservations.Padding = new Padding(9, 8, 9, 8);
            tbVegetableObservations.PasswordChar = '\0';
            tbVegetableObservations.PrefixSuffixText = null;
            tbVegetableObservations.ReadOnly = false;
            tbVegetableObservations.RightToLeft = RightToLeft.No;
            tbVegetableObservations.SelectedText = "";
            tbVegetableObservations.SelectionLength = 0;
            tbVegetableObservations.SelectionStart = 0;
            tbVegetableObservations.ShortcutsEnabled = true;
            tbVegetableObservations.Size = new Size(1052, 48);
            tbVegetableObservations.TabIndex = 0;
            tbVegetableObservations.TabStop = false;
            tbVegetableObservations.TextAlign = HorizontalAlignment.Left;
            tbVegetableObservations.TrailingIcon = null;
            tbVegetableObservations.UseSystemPasswordChar = false;
            tbVegetableObservations.KeyPress += materialTextBoxEdit8_KeyPress;
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
            panel4.Controls.Add(cbVegetableStatus);
            panel4.Controls.Add(materialLabel3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(818, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20, 0, 20, 0);
            panel4.Size = new Size(274, 82);
            panel4.TabIndex = 34;
            // 
            // cbVegetableStatus
            // 
            cbVegetableStatus.AutoResize = false;
            cbVegetableStatus.BackColor = Color.FromArgb(255, 255, 255);
            cbVegetableStatus.Depth = 0;
            cbVegetableStatus.Dock = DockStyle.Top;
            cbVegetableStatus.DrawMode = DrawMode.OwnerDrawVariable;
            cbVegetableStatus.DropDownHeight = 174;
            cbVegetableStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVegetableStatus.DropDownWidth = 121;
            cbVegetableStatus.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbVegetableStatus.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbVegetableStatus.FormattingEnabled = true;
            cbVegetableStatus.IntegralHeight = false;
            cbVegetableStatus.ItemHeight = 43;
            cbVegetableStatus.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cbVegetableStatus.Location = new Point(20, 19);
            cbVegetableStatus.MaxDropDownItems = 4;
            cbVegetableStatus.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbVegetableStatus.Name = "cbVegetableStatus";
            cbVegetableStatus.Size = new Size(234, 49);
            cbVegetableStatus.StartIndex = 0;
            cbVegetableStatus.TabIndex = 10;
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
            panel1.Controls.Add(cbVegetableEnvironment);
            panel1.Controls.Add(materialLabel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(545, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 0, 20, 0);
            panel1.Size = new Size(273, 82);
            panel1.TabIndex = 31;
            // 
            // cbVegetableEnvironment
            // 
            cbVegetableEnvironment.AutoResize = false;
            cbVegetableEnvironment.BackColor = Color.FromArgb(255, 255, 255);
            cbVegetableEnvironment.Depth = 0;
            cbVegetableEnvironment.Dock = DockStyle.Top;
            cbVegetableEnvironment.DrawMode = DrawMode.OwnerDrawVariable;
            cbVegetableEnvironment.DropDownHeight = 174;
            cbVegetableEnvironment.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVegetableEnvironment.DropDownWidth = 121;
            cbVegetableEnvironment.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbVegetableEnvironment.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbVegetableEnvironment.FormattingEnabled = true;
            cbVegetableEnvironment.IntegralHeight = false;
            cbVegetableEnvironment.ItemHeight = 43;
            cbVegetableEnvironment.Location = new Point(20, 19);
            cbVegetableEnvironment.MaxDropDownItems = 4;
            cbVegetableEnvironment.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbVegetableEnvironment.Name = "cbVegetableEnvironment";
            cbVegetableEnvironment.Size = new Size(233, 49);
            cbVegetableEnvironment.StartIndex = 0;
            cbVegetableEnvironment.TabIndex = 10;
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
            panel6.Controls.Add(tbVegetableQuantity);
            panel6.Controls.Add(materialLabel6);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(382, 0);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20, 0, 20, 0);
            panel6.Size = new Size(163, 82);
            panel6.TabIndex = 30;
            // 
            // tbVegetableQuantity
            // 
            tbVegetableQuantity.AnimateReadOnly = false;
            tbVegetableQuantity.AutoCompleteMode = AutoCompleteMode.None;
            tbVegetableQuantity.AutoCompleteSource = AutoCompleteSource.None;
            tbVegetableQuantity.BackgroundImageLayout = ImageLayout.None;
            tbVegetableQuantity.CharacterCasing = CharacterCasing.Normal;
            tbVegetableQuantity.Depth = 0;
            tbVegetableQuantity.Dock = DockStyle.Fill;
            tbVegetableQuantity.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbVegetableQuantity.HideSelection = true;
            tbVegetableQuantity.LeadingIcon = null;
            tbVegetableQuantity.Location = new Point(20, 19);
            tbVegetableQuantity.MaxLength = 3;
            tbVegetableQuantity.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbVegetableQuantity.Name = "tbVegetableQuantity";
            tbVegetableQuantity.PasswordChar = '\0';
            tbVegetableQuantity.PrefixSuffixText = null;
            tbVegetableQuantity.ReadOnly = false;
            tbVegetableQuantity.RightToLeft = RightToLeft.No;
            tbVegetableQuantity.SelectedText = "";
            tbVegetableQuantity.SelectionLength = 0;
            tbVegetableQuantity.SelectionStart = 0;
            tbVegetableQuantity.ShortcutsEnabled = true;
            tbVegetableQuantity.Size = new Size(123, 48);
            tbVegetableQuantity.TabIndex = 5;
            tbVegetableQuantity.TabStop = false;
            tbVegetableQuantity.TextAlign = HorizontalAlignment.Center;
            tbVegetableQuantity.TrailingIcon = null;
            tbVegetableQuantity.UseSystemPasswordChar = false;
            tbVegetableQuantity.KeyPress += tbVegetableQuantity_KeyPress;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Dock = DockStyle.Top;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(20, 0);
            materialLabel6.Margin = new Padding(3, 0, 3, 3);
            materialLabel6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(65, 19);
            materialLabel6.TabIndex = 4;
            materialLabel6.Text = "Cantidad";
            // 
            // panel3
            // 
            panel3.Controls.Add(tbVegetableUser);
            panel3.Controls.Add(materialLabel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 0, 20, 0);
            panel3.Size = new Size(382, 82);
            panel3.TabIndex = 21;
            // 
            // tbVegetableUser
            // 
            tbVegetableUser.AnimateReadOnly = false;
            tbVegetableUser.AutoCompleteMode = AutoCompleteMode.None;
            tbVegetableUser.AutoCompleteSource = AutoCompleteSource.None;
            tbVegetableUser.BackgroundImageLayout = ImageLayout.None;
            tbVegetableUser.CharacterCasing = CharacterCasing.Normal;
            tbVegetableUser.Depth = 0;
            tbVegetableUser.Dock = DockStyle.Top;
            tbVegetableUser.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbVegetableUser.HideSelection = true;
            tbVegetableUser.LeadingIcon = null;
            tbVegetableUser.Location = new Point(20, 19);
            tbVegetableUser.Margin = new Padding(3, 3, 26, 3);
            tbVegetableUser.MaxLength = 32767;
            tbVegetableUser.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbVegetableUser.Name = "tbVegetableUser";
            tbVegetableUser.Padding = new Padding(9, 8, 9, 8);
            tbVegetableUser.PasswordChar = '\0';
            tbVegetableUser.PrefixSuffixText = null;
            tbVegetableUser.ReadOnly = false;
            tbVegetableUser.RightToLeft = RightToLeft.No;
            tbVegetableUser.SelectedText = "";
            tbVegetableUser.SelectionLength = 0;
            tbVegetableUser.SelectionStart = 0;
            tbVegetableUser.ShortcutsEnabled = true;
            tbVegetableUser.Size = new Size(342, 48);
            tbVegetableUser.TabIndex = 0;
            tbVegetableUser.TabStop = false;
            tbVegetableUser.TextAlign = HorizontalAlignment.Left;
            tbVegetableUser.TrailingIcon = null;
            tbVegetableUser.UseSystemPasswordChar = false;
            tbVegetableUser.KeyPress += tbUsuario_KeyPress;
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
            AutoScroll = true;
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
            PerformLayout();
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
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbVegetableObservations;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel6;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.Panel panel3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbVegetableUser;
        private ReaLTaiizor.Controls.MaterialLabel lblTipoPlanta;
        private System.Windows.Forms.Panel panel1;
        private MaterialComboBox cbVegetableEnvironment;
        private MaterialLabel materialLabel2;
        private MaterialLabel materialLabel1;
        private MaterialComboBox cbVegetableStatus;
        private MaterialLabel materialLabel3;
        private MaterialTextBoxEdit tbVegetableQuantity;
    }
}
