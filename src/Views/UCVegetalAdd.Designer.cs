namespace GestionAgraria.Views
{
    partial class UCVegetalAdd
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
            this.btnGuardarVegetal = new ReaLTaiizor.Controls.MaterialButton();
            groupBox1 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel9 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel8 = new Panel();
            this.tb_Observacion = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.lbl_Observacion = new ReaLTaiizor.Controls.MaterialLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            tbTipoAnimal = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.lblCantidad = new ReaLTaiizor.Controls.MaterialLabel();
            panel3 = new Panel();
            tbCodigo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.lblTipoPlanta = new ReaLTaiizor.Controls.MaterialLabel();
            panel1 = new Panel();
            lblVegetal = new ReaLTaiizor.Controls.MaterialLabel();
            materialCard1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel8.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(this.btnGuardarVegetal);
            materialCard1.Controls.Add(groupBox1);
            materialCard1.Controls.Add(panel1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(0, 5);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(1317, 795);
            materialCard1.TabIndex = 1;
            // 
            // btnGuardarVegetal
            // 
            this.btnGuardarVegetal.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.btnGuardarVegetal.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardarVegetal.Depth = 0;
            this.btnGuardarVegetal.Dock = DockStyle.Bottom;
            this.btnGuardarVegetal.HighEmphasis = true;
            this.btnGuardarVegetal.Icon = null;
            this.btnGuardarVegetal.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnGuardarVegetal.Location = new Point(14, 745);
            this.btnGuardarVegetal.Margin = new Padding(4, 6, 4, 6);
            this.btnGuardarVegetal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnGuardarVegetal.Name = "btnGuardarVegetal";
            this.btnGuardarVegetal.NoAccentTextColor = Color.Empty;
            this.btnGuardarVegetal.Size = new Size(1289, 36);
            this.btnGuardarVegetal.TabIndex = 2;
            this.btnGuardarVegetal.Text = "GUARDAR";
            this.btnGuardarVegetal.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardarVegetal.UseAccentColor = false;
            this.btnGuardarVegetal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel4);
            groupBox1.Controls.Add(tableLayoutPanel3);
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(3, 134);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1311, 608);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Vegetales";
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
            tableLayoutPanel3.Location = new Point(0, 157);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1311, 427);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Controls.Add(this.tb_Observacion);
            panel8.Controls.Add(this.lbl_Observacion);
            panel8.Location = new Point(3, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(1305, 421);
            panel8.TabIndex = 2;
            // 
            // tb_Observacion
            // 
            this.tb_Observacion.AnimateReadOnly = false;
            this.tb_Observacion.AutoCompleteMode = AutoCompleteMode.None;
            this.tb_Observacion.AutoCompleteSource = AutoCompleteSource.None;
            this.tb_Observacion.BackgroundImageLayout = ImageLayout.None;
            this.tb_Observacion.CharacterCasing = CharacterCasing.Normal;
            this.tb_Observacion.Depth = 0;
            this.tb_Observacion.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.tb_Observacion.HideSelection = true;
            this.tb_Observacion.LeadingIcon = null;
            this.tb_Observacion.Location = new Point(11, 44);
            this.tb_Observacion.MaxLength = 32767;
            this.tb_Observacion.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_Observacion.Name = "tb_Observacion";
            this.tb_Observacion.PasswordChar = '\0';
            this.tb_Observacion.PrefixSuffixText = null;
            this.tb_Observacion.ReadOnly = false;
            this.tb_Observacion.RightToLeft = RightToLeft.No;
            this.tb_Observacion.SelectedText = "";
            this.tb_Observacion.SelectionLength = 0;
            this.tb_Observacion.SelectionStart = 0;
            this.tb_Observacion.ShortcutsEnabled = true;
            this.tb_Observacion.Size = new Size(1283, 48);
            this.tb_Observacion.TabIndex = 0;
            this.tb_Observacion.TabStop = false;
            this.tb_Observacion.TextAlign = HorizontalAlignment.Left;
            this.tb_Observacion.TrailingIcon = null;
            this.tb_Observacion.UseSystemPasswordChar = false;
            // 
            // lbl_Observacion
            // 
            this.lbl_Observacion.AutoSize = true;
            this.lbl_Observacion.Depth = 0;
            this.lbl_Observacion.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.lbl_Observacion.Location = new Point(11, 17);
            this.lbl_Observacion.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.lbl_Observacion.Name = "lbl_Observacion";
            this.lbl_Observacion.Size = new Size(105, 19);
            this.lbl_Observacion.TabIndex = 1;
            this.lbl_Observacion.Text = "Observaciones";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 26);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1311, 125);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(tbTipoAnimal);
            panel2.Controls.Add(this.lblCantidad);
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
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Depth = 0;
            this.lblCantidad.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.lblCantidad.Location = new Point(11, 13);
            this.lblCantidad.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new Size(65, 19);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad";
            // 
            // panel3
            // 
            panel3.Controls.Add(tbCodigo);
            panel3.Controls.Add(this.lblTipoPlanta);
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
            // lblTipoPlanta
            // 
            this.lblTipoPlanta.AutoSize = true;
            this.lblTipoPlanta.Depth = 0;
            this.lblTipoPlanta.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.lblTipoPlanta.Location = new Point(11, 13);
            this.lblTipoPlanta.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.lblTipoPlanta.Name = "lblTipoPlanta";
            this.lblTipoPlanta.Size = new Size(104, 19);
            this.lblTipoPlanta.TabIndex = 1;
            this.lblTipoPlanta.Text = "Tipo de Planta";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblVegetal);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1317, 128);
            panel1.TabIndex = 0;
            // 
            // lblVegetal
            // 
            lblVegetal.AutoSize = true;
            lblVegetal.Depth = 0;
            lblVegetal.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblVegetal.Location = new Point(27, 54);
            lblVegetal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblVegetal.Name = "lblVegetal";
            lblVegetal.Size = new Size(54, 19);
            lblVegetal.TabIndex = 0;
            lblVegetal.Text = "Vegetal";
            // 
            // UCVegetalAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialCard1);
            Name = "UCVegetalAdd";
            Size = new Size(1317, 805);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
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
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel9;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel8;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbObservacion;
        private ReaLTaiizor.Controls.MaterialLabel lblObservacion;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel6;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbEntornoProductivo;
        private ReaLTaiizor.Controls.MaterialLabel lblEntornoProductivo;
        private Panel panel7;
        private ReaLTaiizor.Controls.MaterialComboBox cbSexo;
        private ReaLTaiizor.Controls.MaterialLabel lblSexo;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel4;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbFechaNacieminto_Ingreso;
        private ReaLTaiizor.Controls.MaterialLabel lblFechaNacimiento_Ingres;
        private Panel panel2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbTipoAnimal;
        private ReaLTaiizor.Controls.MaterialLabel lblTipoAnimal;
        private Panel panel3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbCodigo;
        private ReaLTaiizor.Controls.MaterialLabel lblCodigo;
        private Panel panel1;
        private ReaLTaiizor.Controls.MaterialLabel lblVegetal;
    }
}
