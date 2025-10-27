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
            chbPurchase = new ReaLTaiizor.Controls.MaterialCheckBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(lblRecordDatetime, 3, 0);
            tableLayoutPanel1.Controls.Add(lblTotal, 2, 0);
            tableLayoutPanel1.Controls.Add(chbPurchase, 0, 0);
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
            panel1.AutoSize = true;
            panel1.Controls.Add(lblUserUsername);
            panel1.Controls.Add(lblUserName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(44, 9);
            panel1.Margin = new Padding(9);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 50);
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
            lblRecordDatetime.Location = new Point(306, 0);
            lblRecordDatetime.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblRecordDatetime.Name = "lblRecordDatetime";
            lblRecordDatetime.Size = new Size(315, 68);
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
            lblTotal.Location = new Point(156, 0);
            lblTotal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(144, 68);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chbPurchase
            // 
            chbPurchase.AutoSize = true;
            chbPurchase.Depth = 0;
            chbPurchase.Dock = DockStyle.Fill;
            chbPurchase.Location = new Point(0, 0);
            chbPurchase.Margin = new Padding(0);
            chbPurchase.MouseLocation = new Point(-1, -1);
            chbPurchase.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            chbPurchase.Name = "chbPurchase";
            chbPurchase.ReadOnly = false;
            chbPurchase.Ripple = true;
            chbPurchase.Size = new Size(35, 68);
            chbPurchase.TabIndex = 10;
            chbPurchase.TextAlign = ContentAlignment.MiddleCenter;
            chbPurchase.UseAccentColor = false;
            chbPurchase.UseVisualStyleBackColor = true;
            chbPurchase.CheckedChanged += chbPurchase_CheckedChanged;
            // 
            // UCPurchaseCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(0);
            Name = "UCPurchaseCard";
            Size = new Size(624, 68);
            Click += OnPurchasesCardClick;
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
        private ReaLTaiizor.Controls.MaterialCheckBox chbPurchase;
    }
}
