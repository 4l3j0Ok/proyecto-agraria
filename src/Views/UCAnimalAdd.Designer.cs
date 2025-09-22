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
    partial class UCAnimalAdd
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
            mepAnimalAdd = new ReaLTaiizor.Controls.MaterialExpansionPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            groupBox3 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel8 = new Panel();
            cbAnimalObservations = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel8 = new ReaLTaiizor.Controls.MaterialLabel();
            groupBox2 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel1 = new Panel();
            cbAnimalFormativeEnvironment = new ReaLTaiizor.Controls.MaterialComboBox();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            panel9 = new Panel();
            cbAnimalProductiveState = new ReaLTaiizor.Controls.MaterialComboBox();
            materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            panel5 = new Panel();
            cbAnimalSex = new ReaLTaiizor.Controls.MaterialComboBox();
            materialLabel5 = new ReaLTaiizor.Controls.MaterialLabel();
            groupBox1 = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel6 = new Panel();
            dtAnimalEntryDate = new ReaLTaiizor.Controls.PoisonDateTime();
            materialLabel6 = new ReaLTaiizor.Controls.MaterialLabel();
            panel7 = new Panel();
            cbAnimalType = new ReaLTaiizor.Controls.MaterialComboBox();
            materialLabel7 = new ReaLTaiizor.Controls.MaterialLabel();
            panel3 = new Panel();
            tbAnimalCode = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblUsuario = new ReaLTaiizor.Controls.MaterialLabel();
            mepAnimalAdd.SuspendLayout();
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
            SuspendLayout();
            // 
            // mepAnimalAdd
            // 
            mepAnimalAdd.AutoScroll = true;
            mepAnimalAdd.BackColor = Color.FromArgb(255, 255, 255);
            mepAnimalAdd.CancelButtonText = "Cancelar";
            mepAnimalAdd.Controls.Add(tableLayoutPanel2);
            mepAnimalAdd.Depth = 0;
            mepAnimalAdd.Description = "Registra un nuevo animal";
            mepAnimalAdd.Dock = DockStyle.Top;
            mepAnimalAdd.ExpandHeight = 423;
            mepAnimalAdd.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            mepAnimalAdd.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mepAnimalAdd.Location = new Point(0, 0);
            mepAnimalAdd.Margin = new Padding(3, 16, 3, 16);
            mepAnimalAdd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mepAnimalAdd.Name = "mepAnimalAdd";
            mepAnimalAdd.Padding = new Padding(24, 64, 24, 16);
            mepAnimalAdd.ShowCollapseExpand = false;
            mepAnimalAdd.Size = new Size(1008, 423);
            mepAnimalAdd.TabIndex = 1;
            mepAnimalAdd.Title = "Agregar animal";
            mepAnimalAdd.ValidationButtonEnable = true;
            mepAnimalAdd.ValidationButtonText = "Guardar";
            mepAnimalAdd.SaveClick += mepAnimalAdd_SaveClick;
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
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 344F));
            tableLayoutPanel2.Size = new Size(960, 343);
            tableLayoutPanel2.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(954, 337);
            panel2.TabIndex = 11;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel3);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(0, 200);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(954, 100);
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
            tableLayoutPanel3.Size = new Size(948, 78);
            tableLayoutPanel3.TabIndex = 27;
            // 
            // panel8
            // 
            panel8.Controls.Add(cbAnimalObservations);
            panel8.Controls.Add(materialLabel8);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(20, 0, 20, 0);
            panel8.Size = new Size(948, 78);
            panel8.TabIndex = 26;
            // 
            // cbAnimalObservations
            // 
            cbAnimalObservations.AnimateReadOnly = false;
            cbAnimalObservations.AutoCompleteMode = AutoCompleteMode.None;
            cbAnimalObservations.AutoCompleteSource = AutoCompleteSource.None;
            cbAnimalObservations.BackgroundImageLayout = ImageLayout.None;
            cbAnimalObservations.CharacterCasing = CharacterCasing.Normal;
            cbAnimalObservations.Depth = 0;
            cbAnimalObservations.Dock = DockStyle.Fill;
            cbAnimalObservations.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbAnimalObservations.HideSelection = true;
            cbAnimalObservations.LeadingIcon = null;
            cbAnimalObservations.Location = new Point(20, 19);
            cbAnimalObservations.Margin = new Padding(3, 3, 26, 3);
            cbAnimalObservations.MaxLength = 32767;
            cbAnimalObservations.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbAnimalObservations.Name = "cbAnimalObservations";
            cbAnimalObservations.Padding = new Padding(9, 8, 9, 8);
            cbAnimalObservations.PasswordChar = '\0';
            cbAnimalObservations.PrefixSuffixText = null;
            cbAnimalObservations.ReadOnly = false;
            cbAnimalObservations.RightToLeft = RightToLeft.No;
            cbAnimalObservations.SelectedText = "";
            cbAnimalObservations.SelectionLength = 0;
            cbAnimalObservations.SelectionStart = 0;
            cbAnimalObservations.ShortcutsEnabled = true;
            cbAnimalObservations.Size = new Size(908, 48);
            cbAnimalObservations.TabIndex = 0;
            cbAnimalObservations.TabStop = false;
            cbAnimalObservations.TextAlign = HorizontalAlignment.Left;
            cbAnimalObservations.TrailingIcon = null;
            cbAnimalObservations.UseSystemPasswordChar = false;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel4);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 100);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(954, 100);
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
            tableLayoutPanel4.Location = new Point(3, 19);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(948, 78);
            tableLayoutPanel4.TabIndex = 30;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbAnimalFormativeEnvironment);
            panel1.Controls.Add(materialLabel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(630, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 0, 20, 0);
            panel1.Size = new Size(318, 78);
            panel1.TabIndex = 32;
            // 
            // cbAnimalFormativeEnvironment
            // 
            cbAnimalFormativeEnvironment.AutoResize = false;
            cbAnimalFormativeEnvironment.BackColor = Color.FromArgb(255, 255, 255);
            cbAnimalFormativeEnvironment.Depth = 0;
            cbAnimalFormativeEnvironment.Dock = DockStyle.Top;
            cbAnimalFormativeEnvironment.DrawMode = DrawMode.OwnerDrawVariable;
            cbAnimalFormativeEnvironment.DropDownHeight = 174;
            cbAnimalFormativeEnvironment.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAnimalFormativeEnvironment.DropDownWidth = 121;
            cbAnimalFormativeEnvironment.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbAnimalFormativeEnvironment.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbAnimalFormativeEnvironment.FormattingEnabled = true;
            cbAnimalFormativeEnvironment.IntegralHeight = false;
            cbAnimalFormativeEnvironment.ItemHeight = 43;
            cbAnimalFormativeEnvironment.Location = new Point(20, 19);
            cbAnimalFormativeEnvironment.MaxDropDownItems = 4;
            cbAnimalFormativeEnvironment.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbAnimalFormativeEnvironment.Name = "cbAnimalFormativeEnvironment";
            cbAnimalFormativeEnvironment.Size = new Size(278, 49);
            cbAnimalFormativeEnvironment.StartIndex = 0;
            cbAnimalFormativeEnvironment.TabIndex = 10;
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
            materialLabel1.Size = new Size(154, 19);
            materialLabel1.TabIndex = 4;
            materialLabel1.Text = "Entorno perteneciente";
            // 
            // panel9
            // 
            panel9.Controls.Add(cbAnimalProductiveState);
            panel9.Controls.Add(materialLabel4);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(315, 0);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(20, 0, 20, 0);
            panel9.Size = new Size(315, 78);
            panel9.TabIndex = 31;
            // 
            // cbAnimalProductiveState
            // 
            cbAnimalProductiveState.AutoResize = false;
            cbAnimalProductiveState.BackColor = Color.FromArgb(255, 255, 255);
            cbAnimalProductiveState.Depth = 0;
            cbAnimalProductiveState.Dock = DockStyle.Top;
            cbAnimalProductiveState.DrawMode = DrawMode.OwnerDrawVariable;
            cbAnimalProductiveState.DropDownHeight = 174;
            cbAnimalProductiveState.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAnimalProductiveState.DropDownWidth = 121;
            cbAnimalProductiveState.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbAnimalProductiveState.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbAnimalProductiveState.FormattingEnabled = true;
            cbAnimalProductiveState.IntegralHeight = false;
            cbAnimalProductiveState.ItemHeight = 43;
            cbAnimalProductiveState.Items.AddRange(new object[] { "Productivo", "No Productivo" });
            cbAnimalProductiveState.Location = new Point(20, 19);
            cbAnimalProductiveState.MaxDropDownItems = 4;
            cbAnimalProductiveState.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbAnimalProductiveState.Name = "cbAnimalProductiveState";
            cbAnimalProductiveState.Size = new Size(275, 49);
            cbAnimalProductiveState.StartIndex = 0;
            cbAnimalProductiveState.TabIndex = 10;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Dock = DockStyle.Top;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(20, 0);
            materialLabel4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(130, 19);
            materialLabel4.TabIndex = 4;
            materialLabel4.Text = "Estado Productivo";
            // 
            // panel5
            // 
            panel5.Controls.Add(cbAnimalSex);
            panel5.Controls.Add(materialLabel5);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(20, 0, 20, 0);
            panel5.Size = new Size(315, 78);
            panel5.TabIndex = 30;
            // 
            // cbAnimalSex
            // 
            cbAnimalSex.AutoResize = false;
            cbAnimalSex.BackColor = Color.FromArgb(255, 255, 255);
            cbAnimalSex.Depth = 0;
            cbAnimalSex.Dock = DockStyle.Top;
            cbAnimalSex.DrawMode = DrawMode.OwnerDrawVariable;
            cbAnimalSex.DropDownHeight = 174;
            cbAnimalSex.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAnimalSex.DropDownWidth = 121;
            cbAnimalSex.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbAnimalSex.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbAnimalSex.FormattingEnabled = true;
            cbAnimalSex.IntegralHeight = false;
            cbAnimalSex.ItemHeight = 43;
            cbAnimalSex.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cbAnimalSex.Location = new Point(20, 19);
            cbAnimalSex.MaxDropDownItems = 4;
            cbAnimalSex.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbAnimalSex.Name = "cbAnimalSex";
            cbAnimalSex.Size = new Size(275, 49);
            cbAnimalSex.StartIndex = 0;
            cbAnimalSex.TabIndex = 10;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Dock = DockStyle.Top;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(20, 0);
            materialLabel5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(36, 19);
            materialLabel5.TabIndex = 4;
            materialLabel5.Text = "Sexo";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel5);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(954, 100);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del animal";
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
            tableLayoutPanel5.Size = new Size(948, 78);
            tableLayoutPanel5.TabIndex = 29;
            // 
            // panel6
            // 
            panel6.Controls.Add(dtAnimalEntryDate);
            panel6.Controls.Add(materialLabel6);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(630, 0);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20, 0, 20, 0);
            panel6.Size = new Size(318, 82);
            panel6.TabIndex = 30;
            // 
            // dtAnimalEntryDate
            // 
            dtAnimalEntryDate.Dock = DockStyle.Top;
            dtAnimalEntryDate.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Tall;
            dtAnimalEntryDate.Location = new Point(20, 19);
            dtAnimalEntryDate.Margin = new Padding(0);
            dtAnimalEntryDate.MinimumSize = new Size(0, 35);
            dtAnimalEntryDate.Name = "dtAnimalEntryDate";
            dtAnimalEntryDate.Size = new Size(278, 35);
            dtAnimalEntryDate.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Brown;
            dtAnimalEntryDate.TabIndex = 5;
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
            materialLabel6.Size = new Size(211, 19);
            materialLabel6.TabIndex = 4;
            materialLabel6.Text = "Fecha de nacimiento/ Ingreso";
            // 
            // panel7
            // 
            panel7.Controls.Add(cbAnimalType);
            panel7.Controls.Add(materialLabel7);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(315, 0);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(20, 0, 20, 0);
            panel7.Size = new Size(315, 82);
            panel7.TabIndex = 29;
            // 
            // cbAnimalType
            // 
            cbAnimalType.AutoResize = false;
            cbAnimalType.BackColor = Color.FromArgb(255, 255, 255);
            cbAnimalType.Depth = 0;
            cbAnimalType.Dock = DockStyle.Top;
            cbAnimalType.DrawMode = DrawMode.OwnerDrawVariable;
            cbAnimalType.DropDownHeight = 174;
            cbAnimalType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAnimalType.DropDownWidth = 121;
            cbAnimalType.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbAnimalType.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbAnimalType.FormattingEnabled = true;
            cbAnimalType.IntegralHeight = false;
            cbAnimalType.ItemHeight = 43;
            cbAnimalType.Location = new Point(20, 19);
            cbAnimalType.MaxDropDownItems = 4;
            cbAnimalType.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbAnimalType.Name = "cbAnimalType";
            cbAnimalType.Size = new Size(275, 49);
            cbAnimalType.StartIndex = 0;
            cbAnimalType.TabIndex = 9;
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
            materialLabel7.Size = new Size(87, 19);
            materialLabel7.TabIndex = 4;
            materialLabel7.Text = "Tipo Animal";
            // 
            // panel3
            // 
            panel3.Controls.Add(tbAnimalCode);
            panel3.Controls.Add(lblUsuario);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 0, 20, 0);
            panel3.Size = new Size(315, 82);
            panel3.TabIndex = 21;
            // 
            // tbAnimalCode
            // 
            tbAnimalCode.AnimateReadOnly = false;
            tbAnimalCode.AutoCompleteMode = AutoCompleteMode.None;
            tbAnimalCode.AutoCompleteSource = AutoCompleteSource.None;
            tbAnimalCode.BackgroundImageLayout = ImageLayout.None;
            tbAnimalCode.CharacterCasing = CharacterCasing.Normal;
            tbAnimalCode.Depth = 0;
            tbAnimalCode.Dock = DockStyle.Fill;
            tbAnimalCode.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbAnimalCode.HideSelection = true;
            tbAnimalCode.LeadingIcon = null;
            tbAnimalCode.Location = new Point(20, 19);
            tbAnimalCode.Margin = new Padding(3, 3, 26, 3);
            tbAnimalCode.MaxLength = 32767;
            tbAnimalCode.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbAnimalCode.Name = "tbAnimalCode";
            tbAnimalCode.Padding = new Padding(9, 8, 9, 8);
            tbAnimalCode.PasswordChar = '\0';
            tbAnimalCode.PrefixSuffixText = null;
            tbAnimalCode.ReadOnly = false;
            tbAnimalCode.RightToLeft = RightToLeft.No;
            tbAnimalCode.SelectedText = "";
            tbAnimalCode.SelectionLength = 0;
            tbAnimalCode.SelectionStart = 0;
            tbAnimalCode.ShortcutsEnabled = true;
            tbAnimalCode.Size = new Size(275, 48);
            tbAnimalCode.TabIndex = 0;
            tbAnimalCode.TabStop = false;
            tbAnimalCode.TextAlign = HorizontalAlignment.Left;
            tbAnimalCode.TrailingIcon = null;
            tbAnimalCode.UseSystemPasswordChar = false;
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
            lblUsuario.Size = new Size(51, 19);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Codigo";
            // 
            // UCAnimalAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mepAnimalAdd);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCAnimalAdd";
            Size = new Size(1008, 422);
            Load += UCAnimalAdd_Load;
            mepAnimalAdd.ResumeLayout(false);
            mepAnimalAdd.PerformLayout();
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
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialExpansionPanel mepAnimalAdd;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel8;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit cbAnimalObservations;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel8;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel1;
        private ReaLTaiizor.Controls.MaterialComboBox cbAnimalFormativeEnvironment;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private Panel panel9;
        private ReaLTaiizor.Controls.MaterialComboBox cbAnimalProductiveState;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private Panel panel5;
        private ReaLTaiizor.Controls.MaterialComboBox cbAnimalSex;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel5;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel6;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel6;
        private Panel panel7;
        private ReaLTaiizor.Controls.MaterialComboBox cbAnimalType;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel7;
        private Panel panel3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbAnimalCode;
        private ReaLTaiizor.Controls.MaterialLabel lblUsuario;
        private ReaLTaiizor.Controls.PoisonDateTime dtAnimalEntryDate;
    }
}
