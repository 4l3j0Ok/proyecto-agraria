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
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            groupBox3 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel8 = new Panel();
            tbEnvironmentObservations = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel8 = new ReaLTaiizor.Controls.MaterialLabel();
            groupBox2 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel1 = new Panel();
            tbEnvironmentGroup = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            panel9 = new Panel();
            tbEnvironmentCourse = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            panel5 = new Panel();
            cbEnvironmentYear = new ReaLTaiizor.Controls.MaterialComboBox();
            materialLabel5 = new ReaLTaiizor.Controls.MaterialLabel();
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
            mepFormativeEnvironmentAdd = new ReaLTaiizor.Controls.MaterialExpansionPanel();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel8.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel1.SuspendLayout();
            panel9.SuspendLayout();
            panel5.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            mepFormativeEnvironmentAdd.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(27, 85);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 531F));
            tableLayoutPanel2.Size = new Size(1075, 531);
            tableLayoutPanel2.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1069, 523);
            panel2.TabIndex = 11;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel3);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(0, 266);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(1069, 133);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(panel8, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 20);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1063, 109);
            tableLayoutPanel3.TabIndex = 27;
            // 
            // panel8
            // 
            panel8.Controls.Add(tbEnvironmentObservations);
            panel8.Controls.Add(materialLabel8);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(23, 0, 23, 0);
            panel8.Size = new Size(1063, 109);
            panel8.TabIndex = 26;
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
            tbEnvironmentObservations.Location = new Point(23, 19);
            tbEnvironmentObservations.Margin = new Padding(3, 4, 30, 4);
            tbEnvironmentObservations.MaxLength = 32767;
            tbEnvironmentObservations.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbEnvironmentObservations.Name = "tbEnvironmentObservations";
            tbEnvironmentObservations.Padding = new Padding(10, 11, 10, 11);
            tbEnvironmentObservations.PasswordChar = '\0';
            tbEnvironmentObservations.PrefixSuffixText = null;
            tbEnvironmentObservations.ReadOnly = false;
            tbEnvironmentObservations.RightToLeft = RightToLeft.No;
            tbEnvironmentObservations.SelectedText = "";
            tbEnvironmentObservations.SelectionLength = 0;
            tbEnvironmentObservations.SelectionStart = 0;
            tbEnvironmentObservations.ShortcutsEnabled = true;
            tbEnvironmentObservations.Size = new Size(1017, 48);
            tbEnvironmentObservations.TabIndex = 0;
            tbEnvironmentObservations.TabStop = false;
            tbEnvironmentObservations.TextAlign = HorizontalAlignment.Left;
            tbEnvironmentObservations.TrailingIcon = null;
            tbEnvironmentObservations.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Dock = DockStyle.Top;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(23, 0);
            materialLabel8.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(105, 19);
            materialLabel8.TabIndex = 4;
            materialLabel8.Text = "Observaciones";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel4);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 133);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(1069, 133);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos adicionales";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Controls.Add(panel1, 2, 0);
            tableLayoutPanel4.Controls.Add(panel9, 1, 0);
            tableLayoutPanel4.Controls.Add(panel5, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 20);
            tableLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1063, 109);
            tableLayoutPanel4.TabIndex = 30;
            // 
            // panel1
            // 
            panel1.Controls.Add(tbEnvironmentGroup);
            panel1.Controls.Add(materialLabel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(708, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(23, 0, 23, 0);
            panel1.Size = new Size(355, 109);
            panel1.TabIndex = 32;
            // 
            // tbEnvironmentGroup
            // 
            tbEnvironmentGroup.AnimateReadOnly = false;
            tbEnvironmentGroup.AutoCompleteMode = AutoCompleteMode.None;
            tbEnvironmentGroup.AutoCompleteSource = AutoCompleteSource.None;
            tbEnvironmentGroup.BackgroundImageLayout = ImageLayout.None;
            tbEnvironmentGroup.CharacterCasing = CharacterCasing.Normal;
            tbEnvironmentGroup.Depth = 0;
            tbEnvironmentGroup.Dock = DockStyle.Fill;
            tbEnvironmentGroup.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbEnvironmentGroup.HideSelection = true;
            tbEnvironmentGroup.LeadingIcon = null;
            tbEnvironmentGroup.Location = new Point(23, 19);
            tbEnvironmentGroup.Margin = new Padding(3, 4, 30, 4);
            tbEnvironmentGroup.MaxLength = 1;
            tbEnvironmentGroup.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbEnvironmentGroup.Name = "tbEnvironmentGroup";
            tbEnvironmentGroup.Padding = new Padding(10, 11, 10, 11);
            tbEnvironmentGroup.PasswordChar = '\0';
            tbEnvironmentGroup.PrefixSuffixText = null;
            tbEnvironmentGroup.ReadOnly = false;
            tbEnvironmentGroup.RightToLeft = RightToLeft.No;
            tbEnvironmentGroup.SelectedText = "";
            tbEnvironmentGroup.SelectionLength = 0;
            tbEnvironmentGroup.SelectionStart = 0;
            tbEnvironmentGroup.ShortcutsEnabled = true;
            tbEnvironmentGroup.Size = new Size(309, 48);
            tbEnvironmentGroup.TabIndex = 0;
            tbEnvironmentGroup.TabStop = false;
            tbEnvironmentGroup.TextAlign = HorizontalAlignment.Left;
            tbEnvironmentGroup.TrailingIcon = null;
            tbEnvironmentGroup.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Dock = DockStyle.Top;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(23, 0);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(44, 19);
            materialLabel1.TabIndex = 4;
            materialLabel1.Text = "Grupo";
            // 
            // panel9
            // 
            panel9.Controls.Add(tbEnvironmentCourse);
            panel9.Controls.Add(materialLabel4);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(354, 0);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(23, 0, 23, 0);
            panel9.Size = new Size(354, 109);
            panel9.TabIndex = 31;
            // 
            // tbEnvironmentCourse
            // 
            tbEnvironmentCourse.AnimateReadOnly = false;
            tbEnvironmentCourse.AutoCompleteMode = AutoCompleteMode.None;
            tbEnvironmentCourse.AutoCompleteSource = AutoCompleteSource.None;
            tbEnvironmentCourse.BackgroundImageLayout = ImageLayout.None;
            tbEnvironmentCourse.CharacterCasing = CharacterCasing.Normal;
            tbEnvironmentCourse.Depth = 0;
            tbEnvironmentCourse.Dock = DockStyle.Fill;
            tbEnvironmentCourse.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbEnvironmentCourse.HideSelection = true;
            tbEnvironmentCourse.LeadingIcon = null;
            tbEnvironmentCourse.Location = new Point(23, 19);
            tbEnvironmentCourse.Margin = new Padding(3, 4, 30, 4);
            tbEnvironmentCourse.MaxLength = 1;
            tbEnvironmentCourse.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbEnvironmentCourse.Name = "tbEnvironmentCourse";
            tbEnvironmentCourse.Padding = new Padding(10, 11, 10, 11);
            tbEnvironmentCourse.PasswordChar = '\0';
            tbEnvironmentCourse.PrefixSuffixText = null;
            tbEnvironmentCourse.ReadOnly = false;
            tbEnvironmentCourse.RightToLeft = RightToLeft.No;
            tbEnvironmentCourse.SelectedText = "";
            tbEnvironmentCourse.SelectionLength = 0;
            tbEnvironmentCourse.SelectionStart = 0;
            tbEnvironmentCourse.ShortcutsEnabled = true;
            tbEnvironmentCourse.Size = new Size(308, 48);
            tbEnvironmentCourse.TabIndex = 0;
            tbEnvironmentCourse.TabStop = false;
            tbEnvironmentCourse.TextAlign = HorizontalAlignment.Left;
            tbEnvironmentCourse.TrailingIcon = null;
            tbEnvironmentCourse.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Dock = DockStyle.Top;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(23, 0);
            materialLabel4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(42, 19);
            materialLabel4.TabIndex = 4;
            materialLabel4.Text = "Curso";
            // 
            // panel5
            // 
            panel5.Controls.Add(cbEnvironmentYear);
            panel5.Controls.Add(materialLabel5);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(23, 0, 23, 0);
            panel5.Size = new Size(354, 109);
            panel5.TabIndex = 30;
            // 
            // cbEnvironmentYear
            // 
            cbEnvironmentYear.AutoResize = false;
            cbEnvironmentYear.BackColor = Color.FromArgb(255, 255, 255);
            cbEnvironmentYear.Depth = 0;
            cbEnvironmentYear.Dock = DockStyle.Top;
            cbEnvironmentYear.DrawMode = DrawMode.OwnerDrawVariable;
            cbEnvironmentYear.DropDownHeight = 174;
            cbEnvironmentYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEnvironmentYear.DropDownWidth = 121;
            cbEnvironmentYear.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbEnvironmentYear.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbEnvironmentYear.FormattingEnabled = true;
            cbEnvironmentYear.IntegralHeight = false;
            cbEnvironmentYear.ItemHeight = 43;
            cbEnvironmentYear.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7" });
            cbEnvironmentYear.Location = new Point(23, 19);
            cbEnvironmentYear.Margin = new Padding(3, 4, 3, 4);
            cbEnvironmentYear.MaxDropDownItems = 4;
            cbEnvironmentYear.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbEnvironmentYear.Name = "cbEnvironmentYear";
            cbEnvironmentYear.Size = new Size(308, 49);
            cbEnvironmentYear.StartIndex = 0;
            cbEnvironmentYear.TabIndex = 5;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Dock = DockStyle.Top;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(23, 0);
            materialLabel5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(29, 19);
            materialLabel5.TabIndex = 4;
            materialLabel5.Text = "Año";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel5);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1069, 133);
            groupBox1.TabIndex = 30;
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
            tableLayoutPanel5.Location = new Point(3, 20);
            tableLayoutPanel5.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.Size = new Size(1063, 109);
            tableLayoutPanel5.TabIndex = 29;
            // 
            // panel6
            // 
            panel6.Controls.Add(cbEnvironmentResponsable);
            panel6.Controls.Add(materialLabel6);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(708, 0);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(23, 0, 23, 0);
            panel6.Size = new Size(355, 109);
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
            cbEnvironmentResponsable.Location = new Point(23, 19);
            cbEnvironmentResponsable.Margin = new Padding(3, 4, 3, 4);
            cbEnvironmentResponsable.MaxDropDownItems = 4;
            cbEnvironmentResponsable.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbEnvironmentResponsable.Name = "cbEnvironmentResponsable";
            cbEnvironmentResponsable.Size = new Size(309, 49);
            cbEnvironmentResponsable.StartIndex = 0;
            cbEnvironmentResponsable.TabIndex = 10;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Dock = DockStyle.Top;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(23, 0);
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
            panel7.Location = new Point(354, 0);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(23, 0, 23, 0);
            panel7.Size = new Size(354, 109);
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
            cbEnvironmentArea.Location = new Point(23, 19);
            cbEnvironmentArea.Margin = new Padding(3, 4, 3, 4);
            cbEnvironmentArea.MaxDropDownItems = 4;
            cbEnvironmentArea.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbEnvironmentArea.Name = "cbEnvironmentArea";
            cbEnvironmentArea.Size = new Size(308, 49);
            cbEnvironmentArea.StartIndex = 0;
            cbEnvironmentArea.TabIndex = 9;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Dock = DockStyle.Top;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(23, 0);
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
            panel3.Padding = new Padding(23, 0, 23, 0);
            panel3.Size = new Size(354, 109);
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
            tbEnvironmentName.Location = new Point(23, 19);
            tbEnvironmentName.Margin = new Padding(3, 4, 30, 4);
            tbEnvironmentName.MaxLength = 32767;
            tbEnvironmentName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbEnvironmentName.Name = "tbEnvironmentName";
            tbEnvironmentName.Padding = new Padding(10, 11, 10, 11);
            tbEnvironmentName.PasswordChar = '\0';
            tbEnvironmentName.PrefixSuffixText = null;
            tbEnvironmentName.ReadOnly = false;
            tbEnvironmentName.RightToLeft = RightToLeft.No;
            tbEnvironmentName.SelectedText = "";
            tbEnvironmentName.SelectionLength = 0;
            tbEnvironmentName.SelectionStart = 0;
            tbEnvironmentName.ShortcutsEnabled = true;
            tbEnvironmentName.Size = new Size(308, 48);
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
            lblUsuario.Location = new Point(23, 0);
            lblUsuario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(136, 19);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Nombre de entorno";
            // 
            // mepFormativeEnvironmentAdd
            // 
            mepFormativeEnvironmentAdd.AutoScroll = true;
            mepFormativeEnvironmentAdd.BackColor = Color.FromArgb(255, 255, 255);
            mepFormativeEnvironmentAdd.CancelButtonText = "Cancelar";
            mepFormativeEnvironmentAdd.Controls.Add(tableLayoutPanel2);
            mepFormativeEnvironmentAdd.Depth = 0;
            mepFormativeEnvironmentAdd.Description = "Registrar un nuevo entorno formativo";
            mepFormativeEnvironmentAdd.Dock = DockStyle.Top;
            mepFormativeEnvironmentAdd.ExpandHeight = 637;
            mepFormativeEnvironmentAdd.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            mepFormativeEnvironmentAdd.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mepFormativeEnvironmentAdd.Location = new Point(0, 0);
            mepFormativeEnvironmentAdd.Margin = new Padding(3, 21, 3, 21);
            mepFormativeEnvironmentAdd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mepFormativeEnvironmentAdd.Name = "mepFormativeEnvironmentAdd";
            mepFormativeEnvironmentAdd.Padding = new Padding(27, 85, 27, 21);
            mepFormativeEnvironmentAdd.ShowCollapseExpand = false;
            mepFormativeEnvironmentAdd.Size = new Size(1129, 637);
            mepFormativeEnvironmentAdd.TabIndex = 0;
            mepFormativeEnvironmentAdd.Title = "Agregar Entorno Formativo";
            mepFormativeEnvironmentAdd.ValidationButtonEnable = true;
            mepFormativeEnvironmentAdd.ValidationButtonText = "Guardar";
            mepFormativeEnvironmentAdd.SaveClick += mepFormativeEnvironmentAdd_SaveClick;
            mepFormativeEnvironmentAdd.CancelClick += mepFormativeEnvironmentAdd_CancelClick;
            // 
            // UCFormativeEnvironmentAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mepFormativeEnvironmentAdd);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCFormativeEnvironmentAdd";
            Size = new Size(1129, 637);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            mepFormativeEnvironmentAdd.ResumeLayout(false);
            mepFormativeEnvironmentAdd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel8;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbEnvironmentObservations;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel8;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbEnvironmentGroup;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private Panel panel9;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbEnvironmentCourse;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private Panel panel5;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel5;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel6;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel6;
        private Panel panel7;
        private ReaLTaiizor.Controls.MaterialComboBox cbEnvironmentArea;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel7;
        private Panel panel3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbEnvironmentName;
        private ReaLTaiizor.Controls.MaterialLabel lblUsuario;
        private ReaLTaiizor.Controls.MaterialExpansionPanel mepFormativeEnvironmentAdd;
        private ReaLTaiizor.Controls.MaterialComboBox cbEnvironmentResponsable;
        private ReaLTaiizor.Controls.MaterialComboBox cbEnvironmentYear;
    }
}
