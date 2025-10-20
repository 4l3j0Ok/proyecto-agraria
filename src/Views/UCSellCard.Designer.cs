namespace GestionAgraria.Views
{
    partial class UCSellCard
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
            tableLayoutPanel2 = new TableLayoutPanel();
            lblRecordDatetime = new ReaLTaiizor.Controls.MaterialLabel();
            lblUserUsername = new ReaLTaiizor.Controls.MaterialLabel();
            lblTotal = new ReaLTaiizor.Controls.MaterialLabel();
            lblQuatityProduc = new ReaLTaiizor.Controls.MaterialLabel();
            lblUserName = new ReaLTaiizor.Controls.MaterialLabel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
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
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(lblUserName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(9, 8);
            panel1.Margin = new Padding(9, 8, 9, 8);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(4);
            panel1.Size = new Size(606, 52);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(lblRecordDatetime, 3, 0);
            tableLayoutPanel2.Controls.Add(lblUserUsername, 0, 0);
            tableLayoutPanel2.Controls.Add(lblTotal, 2, 0);
            tableLayoutPanel2.Controls.Add(lblQuatityProduc, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(4, 23);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(598, 14);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // lblRecordDatetime
            // 
            lblRecordDatetime.AutoSize = true;
            lblRecordDatetime.Depth = 0;
            lblRecordDatetime.Dock = DockStyle.Fill;
            lblRecordDatetime.Font = new Font("Roboto", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            lblRecordDatetime.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.SubtleEmphasis;
            lblRecordDatetime.Location = new Point(450, 0);
            lblRecordDatetime.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblRecordDatetime.Name = "lblRecordDatetime";
            lblRecordDatetime.Size = new Size(145, 14);
            lblRecordDatetime.TabIndex = 7;
            lblRecordDatetime.Text = "fecha de registro";
            lblRecordDatetime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUserUsername
            // 
            lblUserUsername.AutoSize = true;
            lblUserUsername.Depth = 0;
            lblUserUsername.Dock = DockStyle.Fill;
            lblUserUsername.Font = new Font("Roboto", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            lblUserUsername.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.SubtleEmphasis;
            lblUserUsername.Location = new Point(3, 0);
            lblUserUsername.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblUserUsername.Name = "lblUserUsername";
            lblUserUsername.Size = new Size(143, 14);
            lblUserUsername.TabIndex = 6;
            lblUserUsername.Text = "Nombre de usuario";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Depth = 0;
            lblTotal.Dock = DockStyle.Fill;
            lblTotal.Font = new Font("Roboto", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            lblTotal.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.SubtleEmphasis;
            lblTotal.Location = new Point(301, 0);
            lblTotal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(143, 14);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblQuatityProduc
            // 
            lblQuatityProduc.AutoSize = true;
            lblQuatityProduc.Depth = 0;
            lblQuatityProduc.Dock = DockStyle.Fill;
            lblQuatityProduc.Font = new Font("Roboto", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            lblQuatityProduc.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.SubtleEmphasis;
            lblQuatityProduc.Location = new Point(152, 0);
            lblQuatityProduc.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblQuatityProduc.Name = "lblQuatityProduc";
            lblQuatityProduc.Size = new Size(143, 14);
            lblQuatityProduc.TabIndex = 5;
            lblQuatityProduc.Text = "Cantidad";
            lblQuatityProduc.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Depth = 0;
            lblUserName.Dock = DockStyle.Top;
            lblUserName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblUserName.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle1;
            lblUserName.Location = new Point(4, 4);
            lblUserName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(92, 19);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Responsable";
            // 
            // UCSellCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UCSellCard";
            Size = new Size(624, 68);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        public ReaLTaiizor.Controls.MaterialLabel lblUserUsername;
        public ReaLTaiizor.Controls.MaterialLabel lblTotal;
        public ReaLTaiizor.Controls.MaterialLabel lblQuatityProduc;
        public ReaLTaiizor.Controls.MaterialLabel lblUserName;
        public ReaLTaiizor.Controls.MaterialLabel lblRecordDatetime;
    }
}
