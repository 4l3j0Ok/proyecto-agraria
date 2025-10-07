namespace GestionAgraria.Views
{
    partial class UCFormativeEnvironmentDataAdd
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
            tlYearData = new TableLayoutPanel();
            panel1 = new Panel();
            tbFormativeEnvironmentDataGroup = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            panel9 = new Panel();
            tbFormativeEnvironmentDataCourse = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            panel5 = new Panel();
            cbFormativeEnvironmentDataYear = new ReaLTaiizor.Controls.MaterialComboBox();
            materialLabel5 = new ReaLTaiizor.Controls.MaterialLabel();
            btnDelete = new ReaLTaiizor.Controls.MaterialButton();
            tlYearData.SuspendLayout();
            panel1.SuspendLayout();
            panel9.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // tlYearData
            // 
            tlYearData.AutoScroll = true;
            tlYearData.AutoSize = true;
            tlYearData.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlYearData.ColumnCount = 4;
            tlYearData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlYearData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tlYearData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tlYearData.ColumnStyles.Add(new ColumnStyle());
            tlYearData.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlYearData.Controls.Add(panel1, 2, 0);
            tlYearData.Controls.Add(panel9, 1, 0);
            tlYearData.Controls.Add(panel5, 0, 0);
            tlYearData.Controls.Add(btnDelete, 4, 0);
            tlYearData.Dock = DockStyle.Fill;
            tlYearData.Location = new Point(0, 0);
            tlYearData.Name = "tlYearData";
            tlYearData.RowCount = 1;
            tlYearData.RowStyles.Add(new RowStyle());
            tlYearData.Size = new Size(1119, 99);
            tlYearData.TabIndex = 31;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(tbFormativeEnvironmentDataGroup);
            panel1.Controls.Add(materialLabel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(672, 10);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 0, 20, 0);
            panel1.Size = new Size(311, 79);
            panel1.TabIndex = 32;
            // 
            // tbFormativeEnvironmentDataGroup
            // 
            tbFormativeEnvironmentDataGroup.AnimateReadOnly = false;
            tbFormativeEnvironmentDataGroup.AutoCompleteMode = AutoCompleteMode.None;
            tbFormativeEnvironmentDataGroup.AutoCompleteSource = AutoCompleteSource.None;
            tbFormativeEnvironmentDataGroup.BackgroundImageLayout = ImageLayout.None;
            tbFormativeEnvironmentDataGroup.CharacterCasing = CharacterCasing.Normal;
            tbFormativeEnvironmentDataGroup.Depth = 0;
            tbFormativeEnvironmentDataGroup.Dock = DockStyle.Fill;
            tbFormativeEnvironmentDataGroup.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbFormativeEnvironmentDataGroup.HideSelection = true;
            tbFormativeEnvironmentDataGroup.LeadingIcon = null;
            tbFormativeEnvironmentDataGroup.Location = new Point(20, 19);
            tbFormativeEnvironmentDataGroup.Margin = new Padding(3, 3, 26, 3);
            tbFormativeEnvironmentDataGroup.MaxLength = 1;
            tbFormativeEnvironmentDataGroup.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbFormativeEnvironmentDataGroup.Name = "tbFormativeEnvironmentDataGroup";
            tbFormativeEnvironmentDataGroup.Padding = new Padding(9, 8, 9, 8);
            tbFormativeEnvironmentDataGroup.PasswordChar = '\0';
            tbFormativeEnvironmentDataGroup.PrefixSuffixText = null;
            tbFormativeEnvironmentDataGroup.ReadOnly = false;
            tbFormativeEnvironmentDataGroup.RightToLeft = RightToLeft.No;
            tbFormativeEnvironmentDataGroup.SelectedText = "";
            tbFormativeEnvironmentDataGroup.SelectionLength = 0;
            tbFormativeEnvironmentDataGroup.SelectionStart = 0;
            tbFormativeEnvironmentDataGroup.ShortcutsEnabled = true;
            tbFormativeEnvironmentDataGroup.Size = new Size(271, 48);
            tbFormativeEnvironmentDataGroup.TabIndex = 0;
            tbFormativeEnvironmentDataGroup.TabStop = false;
            tbFormativeEnvironmentDataGroup.TextAlign = HorizontalAlignment.Left;
            tbFormativeEnvironmentDataGroup.TrailingIcon = null;
            tbFormativeEnvironmentDataGroup.UseSystemPasswordChar = false;
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
            materialLabel1.Size = new Size(44, 19);
            materialLabel1.TabIndex = 4;
            materialLabel1.Text = "Grupo";
            // 
            // panel9
            // 
            panel9.AutoSize = true;
            panel9.Controls.Add(tbFormativeEnvironmentDataCourse);
            panel9.Controls.Add(materialLabel4);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(341, 10);
            panel9.Margin = new Padding(10);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(20, 0, 20, 0);
            panel9.Size = new Size(311, 79);
            panel9.TabIndex = 31;
            // 
            // tbFormativeEnvironmentDataCourse
            // 
            tbFormativeEnvironmentDataCourse.AnimateReadOnly = false;
            tbFormativeEnvironmentDataCourse.AutoCompleteMode = AutoCompleteMode.None;
            tbFormativeEnvironmentDataCourse.AutoCompleteSource = AutoCompleteSource.None;
            tbFormativeEnvironmentDataCourse.BackgroundImageLayout = ImageLayout.None;
            tbFormativeEnvironmentDataCourse.CharacterCasing = CharacterCasing.Normal;
            tbFormativeEnvironmentDataCourse.Depth = 0;
            tbFormativeEnvironmentDataCourse.Dock = DockStyle.Fill;
            tbFormativeEnvironmentDataCourse.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbFormativeEnvironmentDataCourse.HideSelection = true;
            tbFormativeEnvironmentDataCourse.LeadingIcon = null;
            tbFormativeEnvironmentDataCourse.Location = new Point(20, 19);
            tbFormativeEnvironmentDataCourse.Margin = new Padding(3, 3, 26, 3);
            tbFormativeEnvironmentDataCourse.MaxLength = 1;
            tbFormativeEnvironmentDataCourse.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbFormativeEnvironmentDataCourse.Name = "tbFormativeEnvironmentDataCourse";
            tbFormativeEnvironmentDataCourse.Padding = new Padding(9, 8, 9, 8);
            tbFormativeEnvironmentDataCourse.PasswordChar = '\0';
            tbFormativeEnvironmentDataCourse.PrefixSuffixText = null;
            tbFormativeEnvironmentDataCourse.ReadOnly = false;
            tbFormativeEnvironmentDataCourse.RightToLeft = RightToLeft.No;
            tbFormativeEnvironmentDataCourse.SelectedText = "";
            tbFormativeEnvironmentDataCourse.SelectionLength = 0;
            tbFormativeEnvironmentDataCourse.SelectionStart = 0;
            tbFormativeEnvironmentDataCourse.ShortcutsEnabled = true;
            tbFormativeEnvironmentDataCourse.Size = new Size(271, 48);
            tbFormativeEnvironmentDataCourse.TabIndex = 0;
            tbFormativeEnvironmentDataCourse.TabStop = false;
            tbFormativeEnvironmentDataCourse.TextAlign = HorizontalAlignment.Left;
            tbFormativeEnvironmentDataCourse.TrailingIcon = null;
            tbFormativeEnvironmentDataCourse.UseSystemPasswordChar = false;
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
            materialLabel4.Size = new Size(42, 19);
            materialLabel4.TabIndex = 4;
            materialLabel4.Text = "Curso";
            // 
            // panel5
            // 
            panel5.AutoSize = true;
            panel5.Controls.Add(cbFormativeEnvironmentDataYear);
            panel5.Controls.Add(materialLabel5);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(10, 10);
            panel5.Margin = new Padding(10);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(20, 0, 20, 0);
            panel5.Size = new Size(311, 79);
            panel5.TabIndex = 30;
            // 
            // cbFormativeEnvironmentDataYear
            // 
            cbFormativeEnvironmentDataYear.AutoResize = false;
            cbFormativeEnvironmentDataYear.BackColor = Color.FromArgb(255, 255, 255);
            cbFormativeEnvironmentDataYear.Depth = 0;
            cbFormativeEnvironmentDataYear.Dock = DockStyle.Top;
            cbFormativeEnvironmentDataYear.DrawMode = DrawMode.OwnerDrawVariable;
            cbFormativeEnvironmentDataYear.DropDownHeight = 174;
            cbFormativeEnvironmentDataYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFormativeEnvironmentDataYear.DropDownWidth = 121;
            cbFormativeEnvironmentDataYear.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbFormativeEnvironmentDataYear.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbFormativeEnvironmentDataYear.FormattingEnabled = true;
            cbFormativeEnvironmentDataYear.IntegralHeight = false;
            cbFormativeEnvironmentDataYear.ItemHeight = 43;
            cbFormativeEnvironmentDataYear.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7" });
            cbFormativeEnvironmentDataYear.Location = new Point(20, 19);
            cbFormativeEnvironmentDataYear.MaxDropDownItems = 4;
            cbFormativeEnvironmentDataYear.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbFormativeEnvironmentDataYear.Name = "cbFormativeEnvironmentDataYear";
            cbFormativeEnvironmentDataYear.Size = new Size(271, 49);
            cbFormativeEnvironmentDataYear.StartIndex = 0;
            cbFormativeEnvironmentDataYear.TabIndex = 5;
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
            materialLabel5.Size = new Size(29, 19);
            materialLabel5.TabIndex = 4;
            materialLabel5.Text = "Año";
            // 
            // btnDelete
            // 
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelete.Depth = 0;
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.HighEmphasis = true;
            btnDelete.Icon = Properties.Resources.trash;
            btnDelete.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnDelete.Location = new Point(997, 30);
            btnDelete.Margin = new Padding(4, 30, 4, 30);
            btnDelete.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(118, 39);
            btnDelete.TabIndex = 34;
            btnDelete.Text = "Eliminar";
            btnDelete.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDelete.UseAccentColor = true;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // UCFormativeEnvironmentDataAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlYearData);
            Name = "UCFormativeEnvironmentDataAdd";
            Size = new Size(1119, 99);
            tlYearData.ResumeLayout(false);
            tlYearData.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tlYearData;
        private Panel panel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbFormativeEnvironmentDataGroup;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private Panel panel9;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbFormativeEnvironmentDataCourse;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private Panel panel5;
        private ReaLTaiizor.Controls.MaterialComboBox cbFormativeEnvironmentDataYear;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel5;
        private ReaLTaiizor.Controls.MaterialButton btnDelete;
    }
}
