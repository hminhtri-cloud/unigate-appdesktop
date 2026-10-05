using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Drawing;

namespace UniGate.Student.UserControls
{
    partial class UcCompare
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

            this.layoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();

            // Selection Area
            this.pnlSelectionWrapper = new Guna.UI2.WinForms.Guna2Panel();
            this.layoutSelection = new System.Windows.Forms.TableLayoutPanel();
            this.cbMajor1 = CreateComboBox("Chọn ngành 1...");
            this.cbMajor2 = CreateComboBox("Chọn ngành 2...");
            this.cbMajor3 = CreateComboBox("Chọn ngành 3...");
            this.btnCompare = new Guna.UI2.WinForms.Guna2Button();

            // Grid
            this.dgvCompare = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colCriteria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colM1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colM2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colM3 = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.layoutMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlSelectionWrapper.SuspendLayout();
            this.layoutSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompare)).BeginInit();
            this.SuspendLayout();

            // 
            // layoutMain (Root)
            // 
            this.layoutMain.ColumnCount = 1;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            // Rows: Header(70px) -> Selection(80px) -> Grid(Fill)
            this.layoutMain.Controls.Add(this.pnlHeader, 0, 0);
            this.layoutMain.Controls.Add(this.pnlSelectionWrapper, 0, 1);
            this.layoutMain.Controls.Add(this.dgvCompare, 0, 2);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 0);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.RowCount = 3;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.Size = new System.Drawing.Size(1000, 600);
            this.layoutMain.TabIndex = 0;

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.pnlHeader.ShadowDecoration.Depth = 5;
            this.pnlHeader.ShadowDecoration.Enabled = true;
            this.pnlHeader.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pnlHeader.Size = new System.Drawing.Size(1000, 70);
            this.pnlHeader.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(269, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "So sánh Ngành & Trường";

            // 
            // pnlSelectionWrapper
            // 
            this.pnlSelectionWrapper.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSelectionWrapper.Controls.Add(this.layoutSelection);
            this.pnlSelectionWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSelectionWrapper.Location = new System.Drawing.Point(0, 70);
            this.pnlSelectionWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSelectionWrapper.Name = "pnlSelectionWrapper";
            this.pnlSelectionWrapper.Size = new System.Drawing.Size(1000, 80);
            this.pnlSelectionWrapper.TabIndex = 1;

            // 
            // layoutSelection (Grid for Combo Boxes)
            // 
            this.layoutSelection.ColumnCount = 4;
            // 3 Combos take 28% each, Button takes rest (auto)
            this.layoutSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.layoutSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.layoutSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.layoutSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.layoutSelection.Controls.Add(this.cbMajor1, 0, 0);
            this.layoutSelection.Controls.Add(this.cbMajor2, 1, 0);
            this.layoutSelection.Controls.Add(this.cbMajor3, 2, 0);
            this.layoutSelection.Controls.Add(this.btnCompare, 3, 0);
            this.layoutSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutSelection.Location = new System.Drawing.Point(0, 0);
            this.layoutSelection.Name = "layoutSelection";
            this.layoutSelection.Padding = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.layoutSelection.RowCount = 1;
            this.layoutSelection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutSelection.Size = new System.Drawing.Size(1000, 80);
            this.layoutSelection.TabIndex = 0;

            // 
            // cbMajor1
            // 
            this.cbMajor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbMajor1.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            // 
            // cbMajor2
            // 
            this.cbMajor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbMajor2.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            // 
            // cbMajor3
            // 
            this.cbMajor3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbMajor3.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);

            // 
            // btnCompare
            // 
            this.btnCompare.BorderRadius = 8;
            this.btnCompare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompare.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompare.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.btnCompare.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCompare.ForeColor = System.Drawing.Color.White;
            this.btnCompare.Location = new System.Drawing.Point(825, 0);
            this.btnCompare.Margin = new System.Windows.Forms.Padding(0);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(155, 36);
            this.btnCompare.TabIndex = 3;
            this.btnCompare.Text = "SO SÁNH";

            // 
            // dgvCompare
            // 
            this.dgvCompare.AllowUserToAddRows = false;
            this.dgvCompare.AllowUserToDeleteRows = false;
            this.dgvCompare.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.dgvCompare.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;

            // Critical for Wrapping Text
            this.dgvCompare.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCompare.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvCompare.BackgroundColor = System.Drawing.Color.White;
            this.dgvCompare.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCompare.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCompare.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompare.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCompare.ColumnHeadersHeight = 50;

            this.dgvCompare.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCriteria,
            this.colM1,
            this.colM2,
            this.colM3});

            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft; // Top Align for multiline
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True; // Enable Wrap
            this.dgvCompare.DefaultCellStyle = dataGridViewCellStyle3;

            this.dgvCompare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompare.EnableHeadersVisualStyles = false;
            this.dgvCompare.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.dgvCompare.Location = new System.Drawing.Point(0, 150);
            this.dgvCompare.Name = "dgvCompare";
            this.dgvCompare.ReadOnly = true;
            this.dgvCompare.RowHeadersVisible = false;
            this.dgvCompare.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompare.Size = new System.Drawing.Size(1000, 450);
            this.dgvCompare.TabIndex = 2;

            // Explicit Theme Styling
            this.dgvCompare.ThemeStyle.AlternatingRowsStyle.BackColor = dataGridViewCellStyle1.BackColor;
            this.dgvCompare.ThemeStyle.AlternatingRowsStyle.Font = dataGridViewCellStyle1.Font;
            this.dgvCompare.ThemeStyle.AlternatingRowsStyle.ForeColor = dataGridViewCellStyle1.ForeColor;
            this.dgvCompare.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = dataGridViewCellStyle1.SelectionBackColor;
            this.dgvCompare.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = dataGridViewCellStyle1.SelectionForeColor;
            this.dgvCompare.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCompare.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.dgvCompare.ThemeStyle.HeaderStyle.BackColor = dataGridViewCellStyle2.BackColor;
            this.dgvCompare.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCompare.ThemeStyle.HeaderStyle.Font = dataGridViewCellStyle2.Font;
            this.dgvCompare.ThemeStyle.HeaderStyle.ForeColor = dataGridViewCellStyle2.ForeColor;
            this.dgvCompare.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCompare.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvCompare.ThemeStyle.ReadOnly = true;
            this.dgvCompare.ThemeStyle.RowsStyle.BackColor = dataGridViewCellStyle3.BackColor;
            this.dgvCompare.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCompare.ThemeStyle.RowsStyle.Font = dataGridViewCellStyle3.Font;
            this.dgvCompare.ThemeStyle.RowsStyle.ForeColor = dataGridViewCellStyle3.ForeColor;
            this.dgvCompare.ThemeStyle.RowsStyle.Height = 22; // AutoSize handles actual height
            this.dgvCompare.ThemeStyle.RowsStyle.SelectionBackColor = dataGridViewCellStyle3.SelectionBackColor;
            this.dgvCompare.ThemeStyle.RowsStyle.SelectionForeColor = dataGridViewCellStyle3.SelectionForeColor;

            // 
            // colCriteria
            // 
            this.colCriteria.FillWeight = 15F;
            this.colCriteria.HeaderText = "Tiêu chí";
            this.colCriteria.Name = "colCriteria";
            this.colCriteria.ReadOnly = true;

            // 
            // colM1
            // 
            this.colM1.FillWeight = 28.33F;
            this.colM1.HeaderText = "Ngành 1";
            this.colM1.Name = "colM1";
            this.colM1.ReadOnly = true;

            // 
            // colM2
            // 
            this.colM2.FillWeight = 28.33F;
            this.colM2.HeaderText = "Ngành 2";
            this.colM2.Name = "colM2";
            this.colM2.ReadOnly = true;

            // 
            // colM3
            // 
            this.colM3.FillWeight = 28.33F;
            this.colM3.HeaderText = "Ngành 3";
            this.colM3.Name = "colM3";
            this.colM3.ReadOnly = true;

            // 
            // UcCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.layoutMain);
            this.Name = "UcCompare";
            this.Size = new System.Drawing.Size(1000, 600);
            this.layoutMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSelectionWrapper.ResumeLayout(false);
            this.layoutSelection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompare)).EndInit();
            this.ResumeLayout(false);
        }

        // Helper Method
        private Guna.UI2.WinForms.Guna2ComboBox CreateComboBox(string placeholder)
        {
            var cb = new Guna.UI2.WinForms.Guna2ComboBox();
            cb.BorderRadius = 5;
            cb.Font = new System.Drawing.Font("Segoe UI", 9F);
            cb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            // Removed PlaceholderText prop as it can be buggy in some Guna builds
            // Instead, handle initial selection logic in backend
            return cb;
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutMain;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlSelectionWrapper;
        private System.Windows.Forms.TableLayoutPanel layoutSelection;
        private Guna.UI2.WinForms.Guna2Button btnCompare;

        private Guna.UI2.WinForms.Guna2ComboBox cbMajor1;
        private Guna.UI2.WinForms.Guna2ComboBox cbMajor2;
        private Guna.UI2.WinForms.Guna2ComboBox cbMajor3;

        private Guna.UI2.WinForms.Guna2DataGridView dgvCompare;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCriteria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colM1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colM2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colM3;
    }
}