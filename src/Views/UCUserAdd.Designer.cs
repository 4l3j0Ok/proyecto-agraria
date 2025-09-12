using GestionAgraria.data;
using GestionAgraria.models;
using GestionAgraria.Views;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Controls;

using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
namespace GestionAgraria.Views

{
    partial class UCUserAdd
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
            materialCard1 = new MaterialCard();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new System.Windows.Forms.Panel();
            materialButton1 = new MaterialButton();
            groupBox3 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel8 = new System.Windows.Forms.Panel();
            materialTextBoxEdit8 = new MaterialTextBoxEdit();
            materialLabel8 = new MaterialLabel();
            panel10 = new System.Windows.Forms.Panel();
            materialTextBoxEdit11 = new MaterialTextBoxEdit();
            materialLabel9 = new MaterialLabel();
            groupBox2 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel6 = new System.Windows.Forms.Panel();
            materialTextBoxEdit10 = new MaterialTextBoxEdit();
            materialLabel6 = new MaterialLabel();
            panel5 = new System.Windows.Forms.Panel();
            materialTextBoxEdit9 = new MaterialTextBoxEdit();
            materialLabel5 = new MaterialLabel();
            panel9 = new System.Windows.Forms.Panel();
            materialTextBoxEdit3 = new MaterialTextBoxEdit();
            materialLabel4 = new MaterialLabel();
            groupBox1 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel3 = new System.Windows.Forms.Panel();
            tbUsuario = new MaterialTextBoxEdit();
            lblUsuario = new MaterialLabel();
            panel7 = new System.Windows.Forms.Panel();
            materialComboBox1 = new MaterialComboBox();
            materialLabel7 = new MaterialLabel();
            panel4 = new System.Windows.Forms.Panel();
            materialTextBoxEdit2 = new MaterialTextBoxEdit();
            materialLabel3 = new MaterialLabel();
            panel11 = new System.Windows.Forms.Panel();
            materialTextBoxEdit1 = new MaterialTextBoxEdit();
            materialLabel2 = new MaterialLabel();
            panel12 = new System.Windows.Forms.Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnUploadProfilePicture = new MaterialButton();
            parrotPictureBox1 = new ParrotPictureBox();
            materialCard1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel8.SuspendLayout();
            panel10.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel9.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(tableLayoutPanel2);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Top;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(0, 0);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(1152, 596);
            materialCard1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 1);
            tableLayoutPanel2.Controls.Add(panel12, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(14, 14);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 218F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1124, 568);
            tableLayoutPanel2.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.Controls.Add(materialButton1);
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 221);
            panel2.Name = "panel2";
            panel2.Size = new Size(1118, 344);
            panel2.TabIndex = 11;
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.Dock = DockStyle.Top;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.IconType = MaterialButton.MaterialIconType.Rebase;
            materialButton1.Location = new Point(0, 300);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(1118, 36);
            materialButton1.TabIndex = 20;
            materialButton1.Text = "Guardar usuario";
            materialButton1.Type = MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel3);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(0, 200);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1118, 100);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos de contacto";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(panel8, 0, 0);
            tableLayoutPanel3.Controls.Add(panel10, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 19);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1112, 78);
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
            panel8.Size = new Size(556, 78);
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
            materialTextBoxEdit8.Size = new Size(516, 48);
            materialTextBoxEdit8.TabIndex = 0;
            materialTextBoxEdit8.TabStop = false;
            materialTextBoxEdit8.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit8.TrailingIcon = null;
            materialTextBoxEdit8.UseSystemPasswordChar = false;
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
            materialLabel8.Size = new Size(97, 19);
            materialLabel8.TabIndex = 4;
            materialLabel8.Text = "Nro. Teléfono";
            // 
            // panel10
            // 
            panel10.Controls.Add(materialTextBoxEdit11);
            panel10.Controls.Add(materialLabel9);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(556, 0);
            panel10.Margin = new Padding(0);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(20, 0, 20, 0);
            panel10.Size = new Size(556, 78);
            panel10.TabIndex = 25;
            // 
            // materialTextBoxEdit11
            // 
            materialTextBoxEdit11.AnimateReadOnly = false;
            materialTextBoxEdit11.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit11.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit11.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit11.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit11.Depth = 0;
            materialTextBoxEdit11.Dock = DockStyle.Fill;
            materialTextBoxEdit11.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxEdit11.HideSelection = true;
            materialTextBoxEdit11.LeadingIcon = null;
            materialTextBoxEdit11.Location = new Point(20, 19);
            materialTextBoxEdit11.Margin = new Padding(3, 3, 26, 3);
            materialTextBoxEdit11.MaxLength = 32767;
            materialTextBoxEdit11.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEdit11.Name = "materialTextBoxEdit11";
            materialTextBoxEdit11.Padding = new Padding(9, 8, 9, 8);
            materialTextBoxEdit11.PasswordChar = '\0';
            materialTextBoxEdit11.PrefixSuffixText = null;
            materialTextBoxEdit11.ReadOnly = false;
            materialTextBoxEdit11.RightToLeft = RightToLeft.No;
            materialTextBoxEdit11.SelectedText = "";
            materialTextBoxEdit11.SelectionLength = 0;
            materialTextBoxEdit11.SelectionStart = 0;
            materialTextBoxEdit11.ShortcutsEnabled = true;
            materialTextBoxEdit11.Size = new Size(516, 48);
            materialTextBoxEdit11.TabIndex = 0;
            materialTextBoxEdit11.TabStop = false;
            materialTextBoxEdit11.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit11.TrailingIcon = null;
            materialTextBoxEdit11.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Dock = DockStyle.Top;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(20, 0);
            materialLabel9.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(128, 19);
            materialLabel9.TabIndex = 4;
            materialLabel9.Text = "Correo electrónico";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel4);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 100);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1118, 100);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos personales";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Controls.Add(panel6, 0, 0);
            tableLayoutPanel4.Controls.Add(panel5, 1, 0);
            tableLayoutPanel4.Controls.Add(panel9, 2, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 19);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1112, 78);
            tableLayoutPanel4.TabIndex = 30;
            // 
            // panel6
            // 
            panel6.Controls.Add(materialTextBoxEdit10);
            panel6.Controls.Add(materialLabel6);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20, 0, 20, 0);
            panel6.Size = new Size(370, 78);
            panel6.TabIndex = 24;
            // 
            // materialTextBoxEdit10
            // 
            materialTextBoxEdit10.AnimateReadOnly = false;
            materialTextBoxEdit10.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit10.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit10.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit10.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit10.Depth = 0;
            materialTextBoxEdit10.Dock = DockStyle.Fill;
            materialTextBoxEdit10.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxEdit10.HideSelection = true;
            materialTextBoxEdit10.LeadingIcon = null;
            materialTextBoxEdit10.Location = new Point(20, 19);
            materialTextBoxEdit10.Margin = new Padding(3, 3, 26, 3);
            materialTextBoxEdit10.MaxLength = 32767;
            materialTextBoxEdit10.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEdit10.Name = "materialTextBoxEdit10";
            materialTextBoxEdit10.Padding = new Padding(9, 8, 9, 8);
            materialTextBoxEdit10.PasswordChar = '\0';
            materialTextBoxEdit10.PrefixSuffixText = null;
            materialTextBoxEdit10.ReadOnly = false;
            materialTextBoxEdit10.RightToLeft = RightToLeft.No;
            materialTextBoxEdit10.SelectedText = "";
            materialTextBoxEdit10.SelectionLength = 0;
            materialTextBoxEdit10.SelectionStart = 0;
            materialTextBoxEdit10.ShortcutsEnabled = true;
            materialTextBoxEdit10.Size = new Size(330, 48);
            materialTextBoxEdit10.TabIndex = 0;
            materialTextBoxEdit10.TabStop = false;
            materialTextBoxEdit10.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit10.TrailingIcon = null;
            materialTextBoxEdit10.UseSystemPasswordChar = false;
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
            materialLabel6.Size = new Size(83, 19);
            materialLabel6.TabIndex = 4;
            materialLabel6.Text = "Documento";
            // 
            // panel5
            // 
            panel5.Controls.Add(materialTextBoxEdit9);
            panel5.Controls.Add(materialLabel5);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(370, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(20, 0, 20, 0);
            panel5.Size = new Size(370, 78);
            panel5.TabIndex = 27;
            // 
            // materialTextBoxEdit9
            // 
            materialTextBoxEdit9.AnimateReadOnly = false;
            materialTextBoxEdit9.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit9.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit9.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit9.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit9.Depth = 0;
            materialTextBoxEdit9.Dock = DockStyle.Fill;
            materialTextBoxEdit9.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxEdit9.HideSelection = true;
            materialTextBoxEdit9.LeadingIcon = null;
            materialTextBoxEdit9.Location = new Point(20, 19);
            materialTextBoxEdit9.Margin = new Padding(3, 3, 26, 3);
            materialTextBoxEdit9.MaxLength = 32767;
            materialTextBoxEdit9.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEdit9.Name = "materialTextBoxEdit9";
            materialTextBoxEdit9.Padding = new Padding(9, 8, 9, 8);
            materialTextBoxEdit9.PasswordChar = '\0';
            materialTextBoxEdit9.PrefixSuffixText = null;
            materialTextBoxEdit9.ReadOnly = false;
            materialTextBoxEdit9.RightToLeft = RightToLeft.No;
            materialTextBoxEdit9.SelectedText = "";
            materialTextBoxEdit9.SelectionLength = 0;
            materialTextBoxEdit9.SelectionStart = 0;
            materialTextBoxEdit9.ShortcutsEnabled = true;
            materialTextBoxEdit9.Size = new Size(330, 48);
            materialTextBoxEdit9.TabIndex = 0;
            materialTextBoxEdit9.TabStop = false;
            materialTextBoxEdit9.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit9.TrailingIcon = null;
            materialTextBoxEdit9.UseSystemPasswordChar = false;
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
            materialLabel5.Size = new Size(57, 19);
            materialLabel5.TabIndex = 4;
            materialLabel5.Text = "Nombre";
            // 
            // panel9
            // 
            panel9.Controls.Add(materialTextBoxEdit3);
            panel9.Controls.Add(materialLabel4);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(740, 0);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(20, 0, 20, 0);
            panel9.Size = new Size(372, 78);
            panel9.TabIndex = 29;
            // 
            // materialTextBoxEdit3
            // 
            materialTextBoxEdit3.AnimateReadOnly = false;
            materialTextBoxEdit3.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit3.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit3.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit3.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit3.Depth = 0;
            materialTextBoxEdit3.Dock = DockStyle.Fill;
            materialTextBoxEdit3.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxEdit3.HideSelection = true;
            materialTextBoxEdit3.LeadingIcon = null;
            materialTextBoxEdit3.Location = new Point(20, 19);
            materialTextBoxEdit3.Margin = new Padding(3, 3, 26, 3);
            materialTextBoxEdit3.MaxLength = 32767;
            materialTextBoxEdit3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEdit3.Name = "materialTextBoxEdit3";
            materialTextBoxEdit3.Padding = new Padding(9, 8, 9, 8);
            materialTextBoxEdit3.PasswordChar = '\0';
            materialTextBoxEdit3.PrefixSuffixText = null;
            materialTextBoxEdit3.ReadOnly = false;
            materialTextBoxEdit3.RightToLeft = RightToLeft.No;
            materialTextBoxEdit3.SelectedText = "";
            materialTextBoxEdit3.SelectionLength = 0;
            materialTextBoxEdit3.SelectionStart = 0;
            materialTextBoxEdit3.ShortcutsEnabled = true;
            materialTextBoxEdit3.Size = new Size(332, 48);
            materialTextBoxEdit3.TabIndex = 0;
            materialTextBoxEdit3.TabStop = false;
            materialTextBoxEdit3.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit3.TrailingIcon = null;
            materialTextBoxEdit3.UseSystemPasswordChar = false;
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
            materialLabel4.Size = new Size(58, 19);
            materialLabel4.TabIndex = 4;
            materialLabel4.Text = "Apellido";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel5);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1118, 100);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del sistema";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.Controls.Add(panel3, 0, 0);
            tableLayoutPanel5.Controls.Add(panel7, 3, 0);
            tableLayoutPanel5.Controls.Add(panel4, 2, 0);
            tableLayoutPanel5.Controls.Add(panel11, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 19);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(1112, 78);
            tableLayoutPanel5.TabIndex = 29;
            // 
            // panel3
            // 
            panel3.Controls.Add(tbUsuario);
            panel3.Controls.Add(lblUsuario);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 0, 20, 0);
            panel3.Size = new Size(278, 78);
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
            tbUsuario.Dock = DockStyle.Fill;
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
            tbUsuario.Size = new Size(238, 48);
            tbUsuario.TabIndex = 0;
            tbUsuario.TabStop = false;
            tbUsuario.TextAlign = HorizontalAlignment.Left;
            tbUsuario.TrailingIcon = null;
            tbUsuario.UseSystemPasswordChar = false;
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
            lblUsuario.Size = new Size(135, 19);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Nombre de usuario";
            // 
            // panel7
            // 
            panel7.Controls.Add(materialComboBox1);
            panel7.Controls.Add(materialLabel7);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(834, 0);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(20, 0, 20, 0);
            panel7.Size = new Size(278, 78);
            panel7.TabIndex = 28;
            // 
            // materialComboBox1
            // 
            materialComboBox1.AutoResize = false;
            materialComboBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox1.Depth = 0;
            materialComboBox1.Dock = DockStyle.Top;
            materialComboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox1.DropDownHeight = 174;
            materialComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox1.DropDownWidth = 121;
            materialComboBox1.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox1.FormattingEnabled = true;
            materialComboBox1.IntegralHeight = false;
            materialComboBox1.ItemHeight = 43;
            materialComboBox1.Location = new Point(20, 19);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new Size(238, 49);
            materialComboBox1.StartIndex = 0;
            materialComboBox1.TabIndex = 9;
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
            materialLabel7.Size = new Size(24, 19);
            materialLabel7.TabIndex = 4;
            materialLabel7.Text = "Rol";
            // 
            // panel4
            // 
            panel4.Controls.Add(materialTextBoxEdit2);
            panel4.Controls.Add(materialLabel3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(556, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20, 0, 20, 0);
            panel4.Size = new Size(278, 78);
            panel4.TabIndex = 23;
            // 
            // materialTextBoxEdit2
            // 
            materialTextBoxEdit2.AnimateReadOnly = false;
            materialTextBoxEdit2.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit2.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit2.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit2.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit2.Depth = 0;
            materialTextBoxEdit2.Dock = DockStyle.Fill;
            materialTextBoxEdit2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxEdit2.HideSelection = true;
            materialTextBoxEdit2.LeadingIcon = null;
            materialTextBoxEdit2.Location = new Point(20, 19);
            materialTextBoxEdit2.Margin = new Padding(3, 3, 26, 3);
            materialTextBoxEdit2.MaxLength = 32767;
            materialTextBoxEdit2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEdit2.Name = "materialTextBoxEdit2";
            materialTextBoxEdit2.Padding = new Padding(9, 8, 9, 8);
            materialTextBoxEdit2.PasswordChar = '\0';
            materialTextBoxEdit2.PrefixSuffixText = null;
            materialTextBoxEdit2.ReadOnly = false;
            materialTextBoxEdit2.RightToLeft = RightToLeft.No;
            materialTextBoxEdit2.SelectedText = "";
            materialTextBoxEdit2.SelectionLength = 0;
            materialTextBoxEdit2.SelectionStart = 0;
            materialTextBoxEdit2.ShortcutsEnabled = true;
            materialTextBoxEdit2.Size = new Size(238, 48);
            materialTextBoxEdit2.TabIndex = 0;
            materialTextBoxEdit2.TabStop = false;
            materialTextBoxEdit2.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit2.TrailingIcon = null;
            materialTextBoxEdit2.UseSystemPasswordChar = false;
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
            materialLabel3.Size = new Size(155, 19);
            materialLabel3.TabIndex = 4;
            materialLabel3.Text = "Confirmar contraseña";
            // 
            // panel11
            // 
            panel11.Controls.Add(materialTextBoxEdit1);
            panel11.Controls.Add(materialLabel2);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(278, 0);
            panel11.Margin = new Padding(0);
            panel11.Name = "panel11";
            panel11.Padding = new Padding(20, 0, 20, 0);
            panel11.Size = new Size(278, 78);
            panel11.TabIndex = 22;
            // 
            // materialTextBoxEdit1
            // 
            materialTextBoxEdit1.AnimateReadOnly = false;
            materialTextBoxEdit1.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit1.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit1.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit1.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit1.Depth = 0;
            materialTextBoxEdit1.Dock = DockStyle.Fill;
            materialTextBoxEdit1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxEdit1.HideSelection = true;
            materialTextBoxEdit1.LeadingIcon = null;
            materialTextBoxEdit1.Location = new Point(20, 19);
            materialTextBoxEdit1.Margin = new Padding(3, 3, 26, 3);
            materialTextBoxEdit1.MaxLength = 32767;
            materialTextBoxEdit1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEdit1.Name = "materialTextBoxEdit1";
            materialTextBoxEdit1.Padding = new Padding(9, 8, 9, 8);
            materialTextBoxEdit1.PasswordChar = '\0';
            materialTextBoxEdit1.PrefixSuffixText = null;
            materialTextBoxEdit1.ReadOnly = false;
            materialTextBoxEdit1.RightToLeft = RightToLeft.No;
            materialTextBoxEdit1.SelectedText = "";
            materialTextBoxEdit1.SelectionLength = 0;
            materialTextBoxEdit1.SelectionStart = 0;
            materialTextBoxEdit1.ShortcutsEnabled = true;
            materialTextBoxEdit1.Size = new Size(238, 48);
            materialTextBoxEdit1.TabIndex = 0;
            materialTextBoxEdit1.TabStop = false;
            materialTextBoxEdit1.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit1.TrailingIcon = null;
            materialTextBoxEdit1.UseSystemPasswordChar = false;
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
            materialLabel2.Size = new Size(82, 19);
            materialLabel2.TabIndex = 4;
            materialLabel2.Text = "Contraseña";
            // 
            // panel12
            // 
            panel12.Controls.Add(tableLayoutPanel1);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(3, 3);
            panel12.Name = "panel12";
            panel12.Size = new Size(1118, 212);
            panel12.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnUploadProfilePicture, 0, 1);
            tableLayoutPanel1.Controls.Add(parrotPictureBox1, 0, 0);
            tableLayoutPanel1.Location = new Point(478, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.MaximumSize = new Size(158, 0);
            tableLayoutPanel1.MinimumSize = new Size(158, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(158, 210);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // btnUploadProfilePicture
            // 
            btnUploadProfilePicture.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUploadProfilePicture.Density = MaterialButton.MaterialButtonDensity.Default;
            btnUploadProfilePicture.Depth = 0;
            btnUploadProfilePicture.Dock = DockStyle.Top;
            btnUploadProfilePicture.HighEmphasis = true;
            btnUploadProfilePicture.Icon = Properties.Resources.upload;
            btnUploadProfilePicture.IconType = MaterialButton.MaterialIconType.Rebase;
            btnUploadProfilePicture.Location = new Point(0, 158);
            btnUploadProfilePicture.Margin = new Padding(0);
            btnUploadProfilePicture.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnUploadProfilePicture.Name = "btnUploadProfilePicture";
            btnUploadProfilePicture.NoAccentTextColor = Color.Empty;
            btnUploadProfilePicture.Size = new Size(158, 36);
            btnUploadProfilePicture.TabIndex = 36;
            btnUploadProfilePicture.Text = "Subir foto";
            btnUploadProfilePicture.Type = MaterialButton.MaterialButtonType.Outlined;
            btnUploadProfilePicture.UseAccentColor = false;
            btnUploadProfilePicture.UseVisualStyleBackColor = true;
            // 
            // parrotPictureBox1
            // 
            parrotPictureBox1.ColorLeft = Color.DodgerBlue;
            parrotPictureBox1.ColorRight = Color.DodgerBlue;
            parrotPictureBox1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotPictureBox1.FilterAlpha = 200;
            parrotPictureBox1.FilterEnabled = false;
            parrotPictureBox1.Image = Properties.Resources.user_placeholder;
            parrotPictureBox1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotPictureBox1.IsElipse = true;
            parrotPictureBox1.IsParallax = false;
            parrotPictureBox1.Location = new Point(0, 0);
            parrotPictureBox1.Margin = new Padding(0);
            parrotPictureBox1.MaximumSize = new Size(158, 158);
            parrotPictureBox1.MinimumSize = new Size(158, 158);
            parrotPictureBox1.Name = "parrotPictureBox1";
            parrotPictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox1.Size = new Size(158, 158);
            parrotPictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox1.TabIndex = 34;
            parrotPictureBox1.Text = "parrotPictureBox1";
            parrotPictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // UCUserAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(materialCard1);
            Margin = new Padding(0);
            Name = "UCUserAdd";
            Size = new Size(1152, 604);
            materialCard1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialCard materialCard1;
        private TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private MaterialButton materialButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel8;
        private MaterialTextBoxEdit materialTextBoxEdit8;
        private MaterialLabel materialLabel8;
        private System.Windows.Forms.Panel panel10;
        private MaterialTextBoxEdit materialTextBoxEdit11;
        private MaterialLabel materialLabel9;
        private System.Windows.Forms.GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel6;
        private MaterialTextBoxEdit materialTextBoxEdit10;
        private MaterialLabel materialLabel6;
        private System.Windows.Forms.Panel panel5;
        private MaterialTextBoxEdit materialTextBoxEdit9;
        private MaterialLabel materialLabel5;
        private System.Windows.Forms.Panel panel9;
        private MaterialTextBoxEdit materialTextBoxEdit3;
        private MaterialLabel materialLabel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel3;
        private MaterialTextBoxEdit tbUsuario;
        private MaterialLabel lblUsuario;
        private System.Windows.Forms.Panel panel7;
        private MaterialComboBox materialComboBox1;
        private MaterialLabel materialLabel7;
        private System.Windows.Forms.Panel panel4;
        private MaterialTextBoxEdit materialTextBoxEdit2;
        private MaterialLabel materialLabel3;
        private System.Windows.Forms.Panel panel11;
        private MaterialTextBoxEdit materialTextBoxEdit1;
        private MaterialLabel materialLabel2;
        private System.Windows.Forms.Panel panel12;
        private TableLayoutPanel tableLayoutPanel1;
        private MaterialButton btnUploadProfilePicture;
        private ParrotPictureBox parrotPictureBox1;
    }
}
