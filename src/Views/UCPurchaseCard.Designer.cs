namespace GestionAgraria.Views
{
    partial class UCPurchaseCard
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            lblUserUsername = new ReaLTaiizor.Controls.MaterialLabel();
            lblUserName = new ReaLTaiizor.Controls.MaterialLabel();
            lblRecordDatetime = new ReaLTaiizor.Controls.MaterialLabel();
            lblTotal = new ReaLTaiizor.Controls.MaterialLabel();
            materialCheckBox1 = new ReaLTaiizor.Controls.MaterialCheckBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(lblRecordDatetime, 3, 0);
            tableLayoutPanel1.Controls.Add(lblTotal, 2, 0);
            tableLayoutPanel1.Controls.Add(materialCheckBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(624, 68);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblUserUsername);
            panel1.Controls.Add(lblUserName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(44, 9);
            panel1.Margin = new Padding(9);
            panel1.Name = "panel1";
            panel1.Size = new Size(178, 50);
            panel1.TabIndex = 9;
            // 
            // lblUserUsername
            // 
            lblUserUsername.AutoSize = true;
            lblUserUsername.Depth = 0;
            lblUserUsername.Dock = DockStyle.Fill;
            lblUserUsername.Font = new Font("Roboto", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            lblUserUsername.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.SubtleEmphasis;
            lblUserUsername.Location = new Point(0, 19);
            lblUserUsername.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblUserUsername.Name = "lblUserUsername";
            lblUserUsername.Size = new Size(100, 14);
            lblUserUsername.TabIndex = 8;
            lblUserUsername.Text = "Nombre de usuario";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Depth = 0;
            lblUserName.Dock = DockStyle.Top;
            lblUserName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblUserName.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle1;
            lblUserName.Location = new Point(0, 0);
            lblUserName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(92, 19);
            lblUserName.TabIndex = 7;
            lblUserName.Text = "Responsable";
            // 
            // lblRecordDatetime
            // 
            lblRecordDatetime.AutoSize = true;
            lblRecordDatetime.Depth = 0;
            lblRecordDatetime.Dock = DockStyle.Fill;
            lblRecordDatetime.Font = new Font("Roboto", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            lblRecordDatetime.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.SubtleEmphasis;
            lblRecordDatetime.Location = new Point(430, 0);
            lblRecordDatetime.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblRecordDatetime.Name = "lblRecordDatetime";
            lblRecordDatetime.Size = new Size(191, 68);
            lblRecordDatetime.TabIndex = 8;
            lblRecordDatetime.Text = "Fecha de registro";
            lblRecordDatetime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Depth = 0;
            lblTotal.Dock = DockStyle.Fill;
            lblTotal.Font = new Font("Roboto", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            lblTotal.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.SubtleEmphasis;
            lblTotal.Location = new Point(234, 0);
            lblTotal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(190, 68);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialCheckBox1
            // 
            materialCheckBox1.AutoSize = true;
            materialCheckBox1.Depth = 0;
            materialCheckBox1.Dock = DockStyle.Fill;
            materialCheckBox1.Location = new Point(0, 0);
            materialCheckBox1.Margin = new Padding(0);
            materialCheckBox1.MouseLocation = new Point(-1, -1);
            materialCheckBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox1.Name = "materialCheckBox1";
            materialCheckBox1.ReadOnly = false;
            materialCheckBox1.Ripple = true;
            materialCheckBox1.Size = new Size(35, 68);
            materialCheckBox1.TabIndex = 10;
            materialCheckBox1.TextAlign = ContentAlignment.MiddleCenter;
            materialCheckBox1.UseAccentColor = false;
            materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // UCPurchaseCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UCPurchaseCard";
            Size = new Size(624, 68);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        public ReaLTaiizor.Controls.MaterialLabel lblUserUsername;
        public ReaLTaiizor.Controls.MaterialLabel lblUserName;
        public ReaLTaiizor.Controls.MaterialLabel lblRecordDatetime;
        public ReaLTaiizor.Controls.MaterialLabel lblTotal;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox1;
    }
}
