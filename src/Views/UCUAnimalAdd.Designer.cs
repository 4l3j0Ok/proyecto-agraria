namespace GestionAgraria.Views
{
    partial class UCUAnimalAdd
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
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            btnGuardarAnimal = new ReaLTaiizor.Controls.MaterialButton();
            groupBox1 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel9 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel8 = new Panel();
            tbObservacion = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblObservacion = new ReaLTaiizor.Controls.MaterialLabel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel6 = new Panel();
            tbEntornoProductivo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblEntornoProductivo = new ReaLTaiizor.Controls.MaterialLabel();
            panel7 = new Panel();
            cbSexo = new ReaLTaiizor.Controls.MaterialComboBox();
            lblSexo = new ReaLTaiizor.Controls.MaterialLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            tbFechaNacieminto_Ingreso = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblFechaNacimiento_Ingres = new ReaLTaiizor.Controls.MaterialLabel();
            panel2 = new Panel();
            tbTipoAnimal = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblTipoAnimal = new ReaLTaiizor.Controls.MaterialLabel();
            panel3 = new Panel();
            tbCodigo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblCodigo = new ReaLTaiizor.Controls.MaterialLabel();
            panel1 = new Panel();
            lblAnimal = new ReaLTaiizor.Controls.MaterialLabel();
            materialCard1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel8.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(btnGuardarAnimal);
            materialCard1.Controls.Add(groupBox1);
            materialCard1.Controls.Add(panel1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(0, 0);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(1317, 795);
            materialCard1.TabIndex = 0;
            // 
            // btnGuardarAnimal
            // 
            btnGuardarAnimal.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGuardarAnimal.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGuardarAnimal.Depth = 0;
            btnGuardarAnimal.Dock = DockStyle.Bottom;
            btnGuardarAnimal.HighEmphasis = true;
            btnGuardarAnimal.Icon = null;
            btnGuardarAnimal.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnGuardarAnimal.Location = new Point(14, 745);
            btnGuardarAnimal.Margin = new Padding(4, 6, 4, 6);
            btnGuardarAnimal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnGuardarAnimal.Name = "btnGuardarAnimal";
            btnGuardarAnimal.NoAccentTextColor = Color.Empty;
            btnGuardarAnimal.Size = new Size(1289, 36);
            btnGuardarAnimal.TabIndex = 2;
            btnGuardarAnimal.Text = "GUARDAR";
            btnGuardarAnimal.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGuardarAnimal.UseAccentColor = false;
            btnGuardarAnimal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel4);
            groupBox1.Controls.Add(tableLayoutPanel3);
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(3, 134);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1311, 608);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Animal";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Controls.Add(panel9, 0, 0);
            tableLayoutPanel4.Location = new Point(0, 602);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1311, 54);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.Location = new Point(3, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(1294, 48);
            panel9.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(panel8, 0, 0);
            tableLayoutPanel3.Location = new Point(0, 278);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1311, 321);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Controls.Add(tbObservacion);
            panel8.Controls.Add(lblObservacion);
            panel8.Location = new Point(3, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(1305, 315);
            panel8.TabIndex = 2;
            // 
            // tbObservacion
            // 
            tbObservacion.AnimateReadOnly = false;
            tbObservacion.AutoCompleteMode = AutoCompleteMode.None;
            tbObservacion.AutoCompleteSource = AutoCompleteSource.None;
            tbObservacion.BackgroundImageLayout = ImageLayout.None;
            tbObservacion.CharacterCasing = CharacterCasing.Normal;
            tbObservacion.Depth = 0;
            tbObservacion.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbObservacion.HideSelection = true;
            tbObservacion.LeadingIcon = null;
            tbObservacion.Location = new Point(11, 44);
            tbObservacion.MaxLength = 32767;
            tbObservacion.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbObservacion.Name = "tbObservacion";
            tbObservacion.PasswordChar = '\0';
            tbObservacion.PrefixSuffixText = null;
            tbObservacion.ReadOnly = false;
            tbObservacion.RightToLeft = RightToLeft.No;
            tbObservacion.SelectedText = "";
            tbObservacion.SelectionLength = 0;
            tbObservacion.SelectionStart = 0;
            tbObservacion.ShortcutsEnabled = true;
            tbObservacion.Size = new Size(1283, 48);
            tbObservacion.TabIndex = 0;
            tbObservacion.TabStop = false;
            tbObservacion.TextAlign = HorizontalAlignment.Left;
            tbObservacion.TrailingIcon = null;
            tbObservacion.UseSystemPasswordChar = false;
            // 
            // lblObservacion
            // 
            lblObservacion.AutoSize = true;
            lblObservacion.Depth = 0;
            lblObservacion.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblObservacion.Location = new Point(11, 17);
            lblObservacion.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblObservacion.Name = "lblObservacion";
            lblObservacion.Size = new Size(105, 19);
            lblObservacion.TabIndex = 1;
            lblObservacion.Text = "Observaciones";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(panel6, 1, 0);
            tableLayoutPanel2.Controls.Add(panel7, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 150);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1311, 125);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(tbEntornoProductivo);
            panel6.Controls.Add(lblEntornoProductivo);
            panel6.Location = new Point(440, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(431, 119);
            panel6.TabIndex = 3;
            // 
            // tbEntornoProductivo
            // 
            tbEntornoProductivo.AnimateReadOnly = false;
            tbEntornoProductivo.AutoCompleteMode = AutoCompleteMode.None;
            tbEntornoProductivo.AutoCompleteSource = AutoCompleteSource.None;
            tbEntornoProductivo.BackgroundImageLayout = ImageLayout.None;
            tbEntornoProductivo.CharacterCasing = CharacterCasing.Normal;
            tbEntornoProductivo.Depth = 0;
            tbEntornoProductivo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbEntornoProductivo.HideSelection = true;
            tbEntornoProductivo.LeadingIcon = null;
            tbEntornoProductivo.Location = new Point(11, 34);
            tbEntornoProductivo.MaxLength = 32767;
            tbEntornoProductivo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbEntornoProductivo.Name = "tbEntornoProductivo";
            tbEntornoProductivo.PasswordChar = '\0';
            tbEntornoProductivo.PrefixSuffixText = null;
            tbEntornoProductivo.ReadOnly = false;
            tbEntornoProductivo.RightToLeft = RightToLeft.No;
            tbEntornoProductivo.SelectedText = "";
            tbEntornoProductivo.SelectionLength = 0;
            tbEntornoProductivo.SelectionStart = 0;
            tbEntornoProductivo.ShortcutsEnabled = true;
            tbEntornoProductivo.Size = new Size(404, 48);
            tbEntornoProductivo.TabIndex = 0;
            tbEntornoProductivo.TabStop = false;
            tbEntornoProductivo.TextAlign = HorizontalAlignment.Left;
            tbEntornoProductivo.TrailingIcon = null;
            tbEntornoProductivo.UseSystemPasswordChar = false;
            // 
            // lblEntornoProductivo
            // 
            lblEntornoProductivo.AutoSize = true;
            lblEntornoProductivo.Depth = 0;
            lblEntornoProductivo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblEntornoProductivo.Location = new Point(11, 13);
            lblEntornoProductivo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblEntornoProductivo.Name = "lblEntornoProductivo";
            lblEntornoProductivo.Size = new Size(136, 19);
            lblEntornoProductivo.TabIndex = 1;
            lblEntornoProductivo.Text = "Entorno Productivo";
            // 
            // panel7
            // 
            panel7.Controls.Add(cbSexo);
            panel7.Controls.Add(lblSexo);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(431, 119);
            panel7.TabIndex = 2;
            // 
            // cbSexo
            // 
            cbSexo.AutoResize = false;
            cbSexo.BackColor = Color.FromArgb(255, 255, 255);
            cbSexo.Depth = 0;
            cbSexo.DrawMode = DrawMode.OwnerDrawVariable;
            cbSexo.DropDownHeight = 174;
            cbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSexo.DropDownWidth = 121;
            cbSexo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbSexo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbSexo.FormattingEnabled = true;
            cbSexo.IntegralHeight = false;
            cbSexo.ItemHeight = 43;
            cbSexo.Location = new Point(11, 34);
            cbSexo.MaxDropDownItems = 4;
            cbSexo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(407, 49);
            cbSexo.StartIndex = 0;
            cbSexo.TabIndex = 2;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Depth = 0;
            lblSexo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSexo.Location = new Point(11, 13);
            lblSexo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(36, 19);
            lblSexo.TabIndex = 1;
            lblSexo.Text = "Sexo";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(panel4, 2, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 26);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1311, 125);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(tbFechaNacieminto_Ingreso);
            panel4.Controls.Add(lblFechaNacimiento_Ingres);
            panel4.Location = new Point(877, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(431, 119);
            panel4.TabIndex = 4;
            // 
            // tbFechaNacieminto_Ingreso
            // 
            tbFechaNacieminto_Ingreso.AnimateReadOnly = false;
            tbFechaNacieminto_Ingreso.AutoCompleteMode = AutoCompleteMode.None;
            tbFechaNacieminto_Ingreso.AutoCompleteSource = AutoCompleteSource.None;
            tbFechaNacieminto_Ingreso.BackgroundImageLayout = ImageLayout.None;
            tbFechaNacieminto_Ingreso.CharacterCasing = CharacterCasing.Normal;
            tbFechaNacieminto_Ingreso.Depth = 0;
            tbFechaNacieminto_Ingreso.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbFechaNacieminto_Ingreso.HideSelection = true;
            tbFechaNacieminto_Ingreso.LeadingIcon = null;
            tbFechaNacieminto_Ingreso.Location = new Point(13, 35);
            tbFechaNacieminto_Ingreso.MaxLength = 32767;
            tbFechaNacieminto_Ingreso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbFechaNacieminto_Ingreso.Name = "tbFechaNacieminto_Ingreso";
            tbFechaNacieminto_Ingreso.PasswordChar = '\0';
            tbFechaNacieminto_Ingreso.PrefixSuffixText = null;
            tbFechaNacieminto_Ingreso.ReadOnly = false;
            tbFechaNacieminto_Ingreso.RightToLeft = RightToLeft.No;
            tbFechaNacieminto_Ingreso.SelectedText = "";
            tbFechaNacieminto_Ingreso.SelectionLength = 0;
            tbFechaNacieminto_Ingreso.SelectionStart = 0;
            tbFechaNacieminto_Ingreso.ShortcutsEnabled = true;
            tbFechaNacieminto_Ingreso.Size = new Size(409, 48);
            tbFechaNacieminto_Ingreso.TabIndex = 0;
            tbFechaNacieminto_Ingreso.TabStop = false;
            tbFechaNacieminto_Ingreso.TextAlign = HorizontalAlignment.Left;
            tbFechaNacieminto_Ingreso.TrailingIcon = null;
            tbFechaNacieminto_Ingreso.UseSystemPasswordChar = false;
            // 
            // lblFechaNacimiento_Ingres
            // 
            lblFechaNacimiento_Ingres.AutoSize = true;
            lblFechaNacimiento_Ingres.Depth = 0;
            lblFechaNacimiento_Ingres.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblFechaNacimiento_Ingres.Location = new Point(11, 13);
            lblFechaNacimiento_Ingres.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblFechaNacimiento_Ingres.Name = "lblFechaNacimiento_Ingres";
            lblFechaNacimiento_Ingres.Size = new Size(221, 19);
            lblFechaNacimiento_Ingres.TabIndex = 1;
            lblFechaNacimiento_Ingres.Text = "Fecha de Nacieminto / Ingreso ";
            // 
            // panel2
            // 
            panel2.Controls.Add(tbTipoAnimal);
            panel2.Controls.Add(lblTipoAnimal);
            panel2.Location = new Point(440, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(431, 119);
            panel2.TabIndex = 3;
            // 
            // tbTipoAnimal
            // 
            tbTipoAnimal.AnimateReadOnly = false;
            tbTipoAnimal.AutoCompleteMode = AutoCompleteMode.None;
            tbTipoAnimal.AutoCompleteSource = AutoCompleteSource.None;
            tbTipoAnimal.BackgroundImageLayout = ImageLayout.None;
            tbTipoAnimal.CharacterCasing = CharacterCasing.Normal;
            tbTipoAnimal.Depth = 0;
            tbTipoAnimal.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbTipoAnimal.HideSelection = true;
            tbTipoAnimal.LeadingIcon = null;
            tbTipoAnimal.Location = new Point(13, 35);
            tbTipoAnimal.MaxLength = 32767;
            tbTipoAnimal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbTipoAnimal.Name = "tbTipoAnimal";
            tbTipoAnimal.PasswordChar = '\0';
            tbTipoAnimal.PrefixSuffixText = null;
            tbTipoAnimal.ReadOnly = false;
            tbTipoAnimal.RightToLeft = RightToLeft.No;
            tbTipoAnimal.SelectedText = "";
            tbTipoAnimal.SelectionLength = 0;
            tbTipoAnimal.SelectionStart = 0;
            tbTipoAnimal.ShortcutsEnabled = true;
            tbTipoAnimal.Size = new Size(404, 48);
            tbTipoAnimal.TabIndex = 0;
            tbTipoAnimal.TabStop = false;
            tbTipoAnimal.TextAlign = HorizontalAlignment.Left;
            tbTipoAnimal.TrailingIcon = null;
            tbTipoAnimal.UseSystemPasswordChar = false;
            // 
            // lblTipoAnimal
            // 
            lblTipoAnimal.AutoSize = true;
            lblTipoAnimal.Depth = 0;
            lblTipoAnimal.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTipoAnimal.Location = new Point(11, 13);
            lblTipoAnimal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblTipoAnimal.Name = "lblTipoAnimal";
            lblTipoAnimal.Size = new Size(112, 19);
            lblTipoAnimal.TabIndex = 1;
            lblTipoAnimal.Text = "Tipo de Animal ";
            // 
            // panel3
            // 
            panel3.Controls.Add(tbCodigo);
            panel3.Controls.Add(lblCodigo);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(431, 119);
            panel3.TabIndex = 2;
            // 
            // tbCodigo
            // 
            tbCodigo.AnimateReadOnly = false;
            tbCodigo.AutoCompleteMode = AutoCompleteMode.None;
            tbCodigo.AutoCompleteSource = AutoCompleteSource.None;
            tbCodigo.BackgroundImageLayout = ImageLayout.None;
            tbCodigo.CharacterCasing = CharacterCasing.Normal;
            tbCodigo.Depth = 0;
            tbCodigo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbCodigo.HideSelection = true;
            tbCodigo.LeadingIcon = null;
            tbCodigo.Location = new Point(11, 35);
            tbCodigo.MaxLength = 32767;
            tbCodigo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbCodigo.Name = "tbCodigo";
            tbCodigo.PasswordChar = '\0';
            tbCodigo.PrefixSuffixText = null;
            tbCodigo.ReadOnly = false;
            tbCodigo.RightToLeft = RightToLeft.No;
            tbCodigo.SelectedText = "";
            tbCodigo.SelectionLength = 0;
            tbCodigo.SelectionStart = 0;
            tbCodigo.ShortcutsEnabled = true;
            tbCodigo.Size = new Size(407, 48);
            tbCodigo.TabIndex = 0;
            tbCodigo.TabStop = false;
            tbCodigo.TextAlign = HorizontalAlignment.Left;
            tbCodigo.TrailingIcon = null;
            tbCodigo.UseSystemPasswordChar = false;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Depth = 0;
            lblCodigo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblCodigo.Location = new Point(11, 13);
            lblCodigo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(51, 19);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblAnimal);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1317, 128);
            panel1.TabIndex = 0;
            // 
            // lblAnimal
            // 
            lblAnimal.AutoSize = true;
            lblAnimal.Depth = 0;
            lblAnimal.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblAnimal.Location = new Point(27, 54);
            lblAnimal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblAnimal.Name = "lblAnimal";
            lblAnimal.Size = new Size(51, 19);
            lblAnimal.TabIndex = 0;
            lblAnimal.Text = "Animal";
            // 
            // UCUAnimalAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialCard1);
            Name = "UCUAnimalAdd";
            Size = new Size(1317, 805);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private Panel panel1;
        private GroupBox groupBox1;
        private ReaLTaiizor.Controls.MaterialLabel lblAnimal;
        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbCodigo;
        private ReaLTaiizor.Controls.MaterialLabel lblCodigo;
        private Panel panel3;
        private Panel panel4;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbFechaNacieminto_Ingreso;
        private ReaLTaiizor.Controls.MaterialLabel lblFechaNacimiento_Ingres;
        private Panel panel2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbTipoAnimal;
        private ReaLTaiizor.Controls.MaterialLabel lblTipoAnimal;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel6;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbEntornoProductivo;
        private ReaLTaiizor.Controls.MaterialLabel lblEntornoProductivo;
        private Panel panel7;
        private ReaLTaiizor.Controls.MaterialLabel lblSexo;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel8;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbObservacion;
        private ReaLTaiizor.Controls.MaterialLabel lblObservacion;
        private ReaLTaiizor.Controls.MaterialComboBox cbSexo;
        private ReaLTaiizor.Controls.MaterialButton btnGuardarAnimal;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel9;
    }
}
