using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionAgraria.models;
using GestionAgraria.controllers;


namespace GestionAgraria.Views
{
    partial class UCFormativeEnvironmentAdd
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
            mepFormativeEnvironmentAdd = new ReaLTaiizor.Controls.MaterialExpansionPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            tlYearData = new TableLayoutPanel();
            panelFormativeEnvironmentData = new Panel();
            btnAddFormativeEnvironmentData = new ReaLTaiizor.Controls.MaterialButton();
            groupBox1 = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel6 = new Panel();
            cbEnvironmentResponsable = new ReaLTaiizor.Controls.MaterialComboBox();
            materialLabel6 = new ReaLTaiizor.Controls.MaterialLabel();
            panel7 = new Panel();
            cbEnvironmentArea = new ReaLTaiizor.Controls.MaterialComboBox();
            materialLabel7 = new ReaLTaiizor.Controls.MaterialLabel();
            panel3 = new Panel();
            tbEnvironmentName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblUsuario = new ReaLTaiizor.Controls.MaterialLabel();
            groupBox4 = new GroupBox();
            tbEnvironmentObservations = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            mepFormativeEnvironmentAdd.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            tlYearData.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // mepFormativeEnvironmentAdd
            // 
            mepFormativeEnvironmentAdd.AutoSize = true;
            mepFormativeEnvironmentAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mepFormativeEnvironmentAdd.BackColor = Color.FromArgb(255, 255, 255);
            mepFormativeEnvironmentAdd.CancelButtonText = "Cancelar";
            mepFormativeEnvironmentAdd.Controls.Add(tableLayoutPanel1);
            mepFormativeEnvironmentAdd.Depth = 0;
            mepFormativeEnvironmentAdd.Description = "Registrar un nuevo entorno formativo";
            mepFormativeEnvironmentAdd.Dock = DockStyle.Top;
            mepFormativeEnvironmentAdd.ExpandHeight = 453;
            mepFormativeEnvironmentAdd.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            mepFormativeEnvironmentAdd.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mepFormativeEnvironmentAdd.Location = new Point(0, 0);
            mepFormativeEnvironmentAdd.Margin = new Padding(3, 16, 3, 16);
            mepFormativeEnvironmentAdd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mepFormativeEnvironmentAdd.Name = "mepFormativeEnvironmentAdd";
            mepFormativeEnvironmentAdd.Padding = new Padding(24, 20, 24, 20);
            mepFormativeEnvironmentAdd.ShowCollapseExpand = false;
            mepFormativeEnvironmentAdd.Size = new Size(954, 453);
            mepFormativeEnvironmentAdd.TabIndex = 0;
            mepFormativeEnvironmentAdd.Title = "Agregar Entorno Formativo";
            mepFormativeEnvironmentAdd.ValidationButtonEnable = true;
            mepFormativeEnvironmentAdd.ValidationButtonText = "Guardar";
            mepFormativeEnvironmentAdd.SaveClick += mepFormativeEnvironmentAdd_SaveClick;
            mepFormativeEnvironmentAdd.CancelClick += mepFormativeEnvironmentAdd_CancelClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox4, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(24, 20);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(906, 301);
            tableLayoutPanel1.TabIndex = 24;
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox2.Controls.Add(tlYearData);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 142);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(900, 76);
            groupBox2.TabIndex = 32;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos adicionales";
            // 
            // tlYearData
            // 
            tlYearData.AutoSize = true;
            tlYearData.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlYearData.ColumnCount = 1;
            tlYearData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlYearData.Controls.Add(panelFormativeEnvironmentData, 0, 0);
            tlYearData.Controls.Add(btnAddFormativeEnvironmentData, 0, 1);
            tlYearData.Dock = DockStyle.Fill;
            tlYearData.Location = new Point(3, 19);
            tlYearData.Name = "tlYearData";
            tlYearData.RowCount = 2;
            tlYearData.RowStyles.Add(new RowStyle());
            tlYearData.RowStyles.Add(new RowStyle());
            tlYearData.Size = new Size(894, 54);
            tlYearData.TabIndex = 30;
            // 
            // panelFormativeEnvironmentData
            // 
            panelFormativeEnvironmentData.AutoSize = true;
            panelFormativeEnvironmentData.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelFormativeEnvironmentData.Dock = DockStyle.Top;
            panelFormativeEnvironmentData.Location = new Point(3, 3);
            panelFormativeEnvironmentData.Name = "panelFormativeEnvironmentData";
            panelFormativeEnvironmentData.Size = new Size(888, 0);
            panelFormativeEnvironmentData.TabIndex = 1;
            // 
            // btnAddFormativeEnvironmentData
            // 
            btnAddFormativeEnvironmentData.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddFormativeEnvironmentData.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddFormativeEnvironmentData.Depth = 0;
            btnAddFormativeEnvironmentData.Dock = DockStyle.Top;
            btnAddFormativeEnvironmentData.HighEmphasis = true;
            btnAddFormativeEnvironmentData.Icon = null;
            btnAddFormativeEnvironmentData.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAddFormativeEnvironmentData.Location = new Point(50, 12);
            btnAddFormativeEnvironmentData.Margin = new Padding(50, 6, 50, 6);
            btnAddFormativeEnvironmentData.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAddFormativeEnvironmentData.Name = "btnAddFormativeEnvironmentData";
            btnAddFormativeEnvironmentData.NoAccentTextColor = Color.Empty;
            btnAddFormativeEnvironmentData.Size = new Size(794, 36);
            btnAddFormativeEnvironmentData.TabIndex = 0;
            btnAddFormativeEnvironmentData.Text = "Agregar";
            btnAddFormativeEnvironmentData.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddFormativeEnvironmentData.UseAccentColor = false;
            btnAddFormativeEnvironmentData.UseVisualStyleBackColor = true;
            btnAddFormativeEnvironmentData.Click += btnAddFormativeEnvironmentData_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel5);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(900, 133);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Entorno";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.Controls.Add(panel6, 2, 0);
            tableLayoutPanel5.Controls.Add(panel7, 1, 0);
            tableLayoutPanel5.Controls.Add(panel3, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 19);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.Size = new Size(894, 111);
            tableLayoutPanel5.TabIndex = 29;
            // 
            // panel6
            // 
            panel6.Controls.Add(cbEnvironmentResponsable);
            panel6.Controls.Add(materialLabel6);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(594, 0);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20, 0, 20, 0);
            panel6.Size = new Size(300, 161);
            panel6.TabIndex = 30;
            // 
            // cbEnvironmentResponsable
            // 
            cbEnvironmentResponsable.AutoResize = false;
            cbEnvironmentResponsable.BackColor = Color.FromArgb(255, 255, 255);
            cbEnvironmentResponsable.Depth = 0;
            cbEnvironmentResponsable.Dock = DockStyle.Top;
            cbEnvironmentResponsable.DrawMode = DrawMode.OwnerDrawVariable;
            cbEnvironmentResponsable.DropDownHeight = 174;
            cbEnvironmentResponsable.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEnvironmentResponsable.DropDownWidth = 121;
            cbEnvironmentResponsable.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbEnvironmentResponsable.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbEnvironmentResponsable.FormattingEnabled = true;
            cbEnvironmentResponsable.IntegralHeight = false;
            cbEnvironmentResponsable.ItemHeight = 43;
            cbEnvironmentResponsable.Location = new Point(20, 19);
            cbEnvironmentResponsable.MaxDropDownItems = 4;
            cbEnvironmentResponsable.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbEnvironmentResponsable.Name = "cbEnvironmentResponsable";
            cbEnvironmentResponsable.Size = new Size(260, 49);
            cbEnvironmentResponsable.StartIndex = 0;
            cbEnvironmentResponsable.TabIndex = 10;
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
            materialLabel6.Size = new Size(92, 19);
            materialLabel6.TabIndex = 4;
            materialLabel6.Text = "Responsable";
            // 
            // panel7
            // 
            panel7.Controls.Add(cbEnvironmentArea);
            panel7.Controls.Add(materialLabel7);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(297, 0);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(20, 0, 20, 0);
            panel7.Size = new Size(297, 161);
            panel7.TabIndex = 29;
            // 
            // cbEnvironmentArea
            // 
            cbEnvironmentArea.AutoResize = false;
            cbEnvironmentArea.BackColor = Color.FromArgb(255, 255, 255);
            cbEnvironmentArea.Depth = 0;
            cbEnvironmentArea.Dock = DockStyle.Top;
            cbEnvironmentArea.DrawMode = DrawMode.OwnerDrawVariable;
            cbEnvironmentArea.DropDownHeight = 174;
            cbEnvironmentArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEnvironmentArea.DropDownWidth = 121;
            cbEnvironmentArea.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbEnvironmentArea.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbEnvironmentArea.FormattingEnabled = true;
            cbEnvironmentArea.IntegralHeight = false;
            cbEnvironmentArea.ItemHeight = 43;
            cbEnvironmentArea.Location = new Point(20, 19);
            cbEnvironmentArea.MaxDropDownItems = 4;
            cbEnvironmentArea.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbEnvironmentArea.Name = "cbEnvironmentArea";
            cbEnvironmentArea.Size = new Size(257, 49);
            cbEnvironmentArea.StartIndex = 0;
            cbEnvironmentArea.TabIndex = 9;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Dock = DockStyle.Top;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(20, 0);
            materialLabel7.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(33, 19);
            materialLabel7.TabIndex = 4;
            materialLabel7.Text = "Área";
            // 
            // panel3
            // 
            panel3.Controls.Add(tbEnvironmentName);
            panel3.Controls.Add(lblUsuario);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 0, 20, 0);
            panel3.Size = new Size(297, 161);
            panel3.TabIndex = 21;
            // 
            // tbEnvironmentName
            // 
            tbEnvironmentName.AnimateReadOnly = false;
            tbEnvironmentName.AutoCompleteMode = AutoCompleteMode.None;
            tbEnvironmentName.AutoCompleteSource = AutoCompleteSource.None;
            tbEnvironmentName.BackgroundImageLayout = ImageLayout.None;
            tbEnvironmentName.CharacterCasing = CharacterCasing.Normal;
            tbEnvironmentName.Depth = 0;
            tbEnvironmentName.Dock = DockStyle.Fill;
            tbEnvironmentName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbEnvironmentName.HideSelection = true;
            tbEnvironmentName.LeadingIcon = null;
            tbEnvironmentName.Location = new Point(20, 19);
            tbEnvironmentName.Margin = new Padding(3, 3, 26, 3);
            tbEnvironmentName.MaxLength = 32767;
            tbEnvironmentName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbEnvironmentName.Name = "tbEnvironmentName";
            tbEnvironmentName.Padding = new Padding(9, 8, 9, 8);
            tbEnvironmentName.PasswordChar = '\0';
            tbEnvironmentName.PrefixSuffixText = null;
            tbEnvironmentName.ReadOnly = false;
            tbEnvironmentName.RightToLeft = RightToLeft.No;
            tbEnvironmentName.SelectedText = "";
            tbEnvironmentName.SelectionLength = 0;
            tbEnvironmentName.SelectionStart = 0;
            tbEnvironmentName.ShortcutsEnabled = true;
            tbEnvironmentName.Size = new Size(257, 48);
            tbEnvironmentName.TabIndex = 0;
            tbEnvironmentName.TabStop = false;
            tbEnvironmentName.TextAlign = HorizontalAlignment.Left;
            tbEnvironmentName.TrailingIcon = null;
            tbEnvironmentName.UseSystemPasswordChar = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Depth = 0;
            lblUsuario.Dock = DockStyle.Top;
            lblUsuario.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblUsuario.Location = new Point(20, 0);
            lblUsuario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(136, 19);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Nombre de entorno";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tbEnvironmentObservations);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(3, 224);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(900, 74);
            groupBox4.TabIndex = 33;
            groupBox4.TabStop = false;
            groupBox4.Text = "Observaciones";
            // 
            // tbEnvironmentObservations
            // 
            tbEnvironmentObservations.AnimateReadOnly = false;
            tbEnvironmentObservations.AutoCompleteMode = AutoCompleteMode.None;
            tbEnvironmentObservations.AutoCompleteSource = AutoCompleteSource.None;
            tbEnvironmentObservations.BackgroundImageLayout = ImageLayout.None;
            tbEnvironmentObservations.CharacterCasing = CharacterCasing.Normal;
            tbEnvironmentObservations.Depth = 0;
            tbEnvironmentObservations.Dock = DockStyle.Fill;
            tbEnvironmentObservations.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbEnvironmentObservations.HideSelection = true;
            tbEnvironmentObservations.LeadingIcon = null;
            tbEnvironmentObservations.Location = new Point(3, 19);
            tbEnvironmentObservations.Margin = new Padding(3, 3, 26, 3);
            tbEnvironmentObservations.MaxLength = 32767;
            tbEnvironmentObservations.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbEnvironmentObservations.Name = "tbEnvironmentObservations";
            tbEnvironmentObservations.Padding = new Padding(9, 8, 9, 8);
            tbEnvironmentObservations.PasswordChar = '\0';
            tbEnvironmentObservations.PrefixSuffixText = null;
            tbEnvironmentObservations.ReadOnly = false;
            tbEnvironmentObservations.RightToLeft = RightToLeft.No;
            tbEnvironmentObservations.SelectedText = "";
            tbEnvironmentObservations.SelectionLength = 0;
            tbEnvironmentObservations.SelectionStart = 0;
            tbEnvironmentObservations.ShortcutsEnabled = true;
            tbEnvironmentObservations.Size = new Size(894, 48);
            tbEnvironmentObservations.TabIndex = 1;
            tbEnvironmentObservations.TabStop = false;
            tbEnvironmentObservations.TextAlign = HorizontalAlignment.Left;
            tbEnvironmentObservations.TrailingIcon = null;
            tbEnvironmentObservations.UseSystemPasswordChar = false;
            // 
            // UCFormativeEnvironmentAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(mepFormativeEnvironmentAdd);
            Name = "UCFormativeEnvironmentAdd";
            Size = new Size(954, 440);
            mepFormativeEnvironmentAdd.ResumeLayout(false);
            mepFormativeEnvironmentAdd.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tlYearData.ResumeLayout(false);
            tlYearData.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialExpansionPanel mepFormativeEnvironmentAdd;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox2;
        private TableLayoutPanel tlYearData;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel6;
        private ReaLTaiizor.Controls.MaterialComboBox cbEnvironmentResponsable;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel6;
        private Panel panel7;
        private ReaLTaiizor.Controls.MaterialComboBox cbEnvironmentArea;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel7;
        private Panel panel3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbEnvironmentName;
        private ReaLTaiizor.Controls.MaterialLabel lblUsuario;
        private GroupBox groupBox4;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbEnvironmentObservations;
        private ReaLTaiizor.Controls.MaterialButton btnAddFormativeEnvironmentData;
        private Panel panelFormativeEnvironmentData;
    }
}
