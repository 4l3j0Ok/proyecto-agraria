using ReaLTaiizor.Controls;
using System.ComponentModel;
using System.Windows.Forms;

namespace GestionAgraria.Controls
{
    partial class UCPaginator
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLast = new MaterialButton();
            btnNext = new MaterialButton();
            lblPageInfo = new MaterialLabel();
            btnPrevious = new MaterialButton();
            btnFirst = new MaterialButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLast
            // 
            btnLast.AutoSize = false;
            btnLast.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLast.Density = MaterialButton.MaterialButtonDensity.Default;
            btnLast.Depth = 0;
            btnLast.Dock = DockStyle.Fill;
            btnLast.HighEmphasis = true;
            btnLast.Icon = null;
            btnLast.IconType = MaterialButton.MaterialIconType.Rebase;
            btnLast.Location = new Point(493, 3);
            btnLast.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnLast.Name = "btnLast";
            btnLast.NoAccentTextColor = Color.Empty;
            btnLast.Size = new Size(44, 34);
            btnLast.TabIndex = 4;
            btnLast.Text = ">>";
            btnLast.Type = MaterialButton.MaterialButtonType.Contained;
            btnLast.UseAccentColor = false;
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += btnLast_Click;
            // 
            // btnNext
            // 
            btnNext.AutoSize = false;
            btnNext.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNext.Density = MaterialButton.MaterialButtonDensity.Default;
            btnNext.Depth = 0;
            btnNext.Dock = DockStyle.Fill;
            btnNext.HighEmphasis = true;
            btnNext.Icon = null;
            btnNext.IconType = MaterialButton.MaterialIconType.Rebase;
            btnNext.Location = new Point(443, 3);
            btnNext.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNext.Name = "btnNext";
            btnNext.NoAccentTextColor = Color.Empty;
            btnNext.Size = new Size(44, 34);
            btnNext.TabIndex = 3;
            btnNext.Text = ">";
            btnNext.Type = MaterialButton.MaterialButtonType.Contained;
            btnNext.UseAccentColor = false;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblPageInfo
            // 
            lblPageInfo.Depth = 0;
            lblPageInfo.Dock = DockStyle.Fill;
            lblPageInfo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblPageInfo.Location = new Point(103, 0);
            lblPageInfo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(334, 40);
            lblPageInfo.TabIndex = 2;
            lblPageInfo.Text = "Página 1 de 1";
            lblPageInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPrevious
            // 
            btnPrevious.AutoSize = false;
            btnPrevious.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPrevious.Density = MaterialButton.MaterialButtonDensity.Default;
            btnPrevious.Depth = 0;
            btnPrevious.Dock = DockStyle.Fill;
            btnPrevious.HighEmphasis = true;
            btnPrevious.Icon = null;
            btnPrevious.IconType = MaterialButton.MaterialIconType.Rebase;
            btnPrevious.Location = new Point(53, 3);
            btnPrevious.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnPrevious.Name = "btnPrevious";
            btnPrevious.NoAccentTextColor = Color.Empty;
            btnPrevious.Size = new Size(44, 34);
            btnPrevious.TabIndex = 1;
            btnPrevious.Text = "<";
            btnPrevious.Type = MaterialButton.MaterialButtonType.Contained;
            btnPrevious.UseAccentColor = false;
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnFirst
            // 
            btnFirst.AutoSize = false;
            btnFirst.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFirst.Density = MaterialButton.MaterialButtonDensity.Default;
            btnFirst.Depth = 0;
            btnFirst.Dock = DockStyle.Fill;
            btnFirst.HighEmphasis = true;
            btnFirst.Icon = null;
            btnFirst.IconType = MaterialButton.MaterialIconType.Rebase;
            btnFirst.Location = new Point(3, 3);
            btnFirst.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnFirst.Name = "btnFirst";
            btnFirst.NoAccentTextColor = Color.Empty;
            btnFirst.Size = new Size(44, 34);
            btnFirst.TabIndex = 0;
            btnFirst.Text = "<<";
            btnFirst.Type = MaterialButton.MaterialButtonType.Contained;
            btnFirst.UseAccentColor = false;
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += btnFirst_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Controls.Add(btnFirst, 0, 0);
            tableLayoutPanel1.Controls.Add(btnPrevious, 1, 0);
            tableLayoutPanel1.Controls.Add(lblPageInfo, 2, 0);
            tableLayoutPanel1.Controls.Add(btnNext, 3, 0);
            tableLayoutPanel1.Controls.Add(btnLast, 4, 0);
            tableLayoutPanel1.Location = new Point(130, 0);
            tableLayoutPanel1.MaximumSize = new Size(540, 40);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(540, 40);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // UCPaginator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UCPaginator";
            Size = new Size(800, 40);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialButton btnLast;
        private MaterialButton btnNext;
        private MaterialLabel lblPageInfo;
        private MaterialButton btnPrevious;
        private MaterialButton btnFirst;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
