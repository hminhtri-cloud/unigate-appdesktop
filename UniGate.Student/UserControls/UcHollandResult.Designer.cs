using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Drawing;

namespace UniGate.Student.UserControls
{
    partial class UcHollandResult
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
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle rowStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle altRowStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.layoutMain = new System.Windows.Forms.TableLayoutPanel();

            // --- Header Section ---
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();

            // --- Result Summary Section (Top) ---
            this.pnlResultCard = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblCodeLabel = new System.Windows.Forms.Label();

            // --- Details Section (Bottom Split) ---
            this.layoutDetails = new System.Windows.Forms.TableLayoutPanel();

            // Description Box (Left)
            this.grpDescription = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();

            // Suggestions Box (Right)
            this.grpSuggestions = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvSuggestions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colMajorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatchRate = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // Action Button
            this.btnSaveResult = new Guna.UI2.WinForms.Guna2Button();

            // Suspend Layout
            this.SuspendLayout();
            this.layoutMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlResultCard.SuspendLayout();
            this.layoutDetails.SuspendLayout();
            this.grpDescription.SuspendLayout();
            this.grpSuggestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuggestions)).BeginInit();

            // 
            // layoutMain (Root)
            // 
            this.layoutMain.ColumnCount = 1;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.Controls.Add(this.pnlHeader, 0, 0);
            this.layoutMain.Controls.Add(this.pnlResultCard, 0, 1);
            this.layoutMain.Controls.Add(this.layoutDetails, 0, 2);
            this.layoutMain.Controls.Add(this.btnSaveResult, 0, 3);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 0);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.Padding = new System.Windows.Forms.Padding(20);
            this.layoutMain.RowCount = 4;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));  // Header
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F)); // Result Card
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));  // Details
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));  // Button
            this.layoutMain.Size = new System.Drawing.Size(1200, 800);
            this.layoutMain.TabIndex = 0;

            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(23, 23);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1154, 54);
            this.pnlHeader.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(14, 165, 233);
            this.lblTitle.Location = new System.Drawing.Point(0, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(292, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "KẾT QUẢ TRẮC NGHIỆM";

            // 
            // pnlResultCard (Gradient Background)
            // 
            this.pnlResultCard.BorderRadius = 15;
            this.pnlResultCard.Controls.Add(this.lblCode);
            this.pnlResultCard.Controls.Add(this.lblCodeLabel);
            this.pnlResultCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResultCard.FillColor = System.Drawing.Color.FromArgb(14, 165, 233);
            this.pnlResultCard.FillColor2 = System.Drawing.Color.FromArgb(56, 189, 248);
            this.pnlResultCard.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.pnlResultCard.Location = new System.Drawing.Point(23, 83);
            this.pnlResultCard.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20); // Spacing bottom
            this.pnlResultCard.Name = "pnlResultCard";
            this.pnlResultCard.ShadowDecoration.Depth = 10;
            this.pnlResultCard.ShadowDecoration.Enabled = true;
            this.pnlResultCard.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.pnlResultCard.Size = new System.Drawing.Size(1154, 127);
            this.pnlResultCard.TabIndex = 1;

            // 
            // lblCodeLabel
            // 
            this.lblCodeLabel.AutoSize = true;
            this.lblCodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblCodeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCodeLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCodeLabel.Location = new System.Drawing.Point(30, 25);
            this.lblCodeLabel.Name = "lblCodeLabel";
            this.lblCodeLabel.Size = new System.Drawing.Size(193, 21);
            this.lblCodeLabel.TabIndex = 0;
            this.lblCodeLabel.Text = "Nhóm tính cách của bạn:";

            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.BackColor = System.Drawing.Color.Transparent;
            this.lblCode.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblCode.ForeColor = System.Drawing.Color.White;
            this.lblCode.Location = new System.Drawing.Point(30, 50);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(176, 65);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = ""; // Placeholder

            // 
            // layoutDetails (Grid 2 columns)
            // 
            this.layoutDetails.ColumnCount = 2;
            this.layoutDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutDetails.Controls.Add(this.grpDescription, 0, 0);
            this.layoutDetails.Controls.Add(this.grpSuggestions, 1, 0);
            this.layoutDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutDetails.Location = new System.Drawing.Point(23, 233);
            this.layoutDetails.Name = "layoutDetails";
            this.layoutDetails.RowCount = 1;
            this.layoutDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutDetails.Size = new System.Drawing.Size(1154, 484);
            this.layoutDetails.TabIndex = 2;

            // 
            // grpDescription
            // 
            this.grpDescription.BorderColor = System.Drawing.Color.Gainsboro;
            this.grpDescription.BorderRadius = 10;
            this.grpDescription.Controls.Add(this.txtDescription);
            this.grpDescription.CustomBorderColor = System.Drawing.Color.White;
            this.grpDescription.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.grpDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpDescription.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.grpDescription.Location = new System.Drawing.Point(3, 3);
            this.grpDescription.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.grpDescription.Name = "grpDescription";
            this.grpDescription.Padding = new System.Windows.Forms.Padding(10, 40, 10, 10);
            this.grpDescription.Size = new System.Drawing.Size(564, 478);
            this.grpDescription.TabIndex = 0;
            this.grpDescription.Text = "Đặc điểm nổi bật";
            this.grpDescription.TextOffset = new System.Drawing.Point(10, 10);

            // 
            // txtDescription
            // 
            this.txtDescription.BorderThickness = 0;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.txtDescription.Location = new System.Drawing.Point(10, 40);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(544, 428);
            this.txtDescription.TabIndex = 0;
            // 
            // grpSuggestions
            // 
            this.grpSuggestions.BorderColor = System.Drawing.Color.Gainsboro;
            this.grpSuggestions.BorderRadius = 10;
            this.grpSuggestions.Controls.Add(this.dgvSuggestions);
            this.grpSuggestions.CustomBorderColor = System.Drawing.Color.White;
            this.grpSuggestions.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.grpSuggestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSuggestions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpSuggestions.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.grpSuggestions.Location = new System.Drawing.Point(587, 3);
            this.grpSuggestions.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.grpSuggestions.Name = "grpSuggestions";
            this.grpSuggestions.Padding = new System.Windows.Forms.Padding(10, 40, 10, 10);
            this.grpSuggestions.Size = new System.Drawing.Size(564, 478);
            this.grpSuggestions.TabIndex = 1;
            this.grpSuggestions.Text = "Ngành nghề phù hợp";
            this.grpSuggestions.TextOffset = new System.Drawing.Point(10, 10);

            // 
            // dgvSuggestions
            // 
            this.dgvSuggestions.AllowUserToAddRows = false;
            this.dgvSuggestions.AllowUserToDeleteRows = false;
            this.dgvSuggestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuggestions.BackgroundColor = System.Drawing.Color.White;
            this.dgvSuggestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSuggestions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSuggestions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            // Header
            headerStyle.BackColor = System.Drawing.Color.FromArgb(14, 165, 233);
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.SelectionBackColor = System.Drawing.Color.FromArgb(14, 165, 233);
            headerStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            headerStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuggestions.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvSuggestions.ColumnHeadersHeight = 40;

            // Rows
            rowStyle.BackColor = System.Drawing.Color.White;
            rowStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            rowStyle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            rowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(224, 242, 254);
            rowStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.dgvSuggestions.DefaultCellStyle = rowStyle;

            // Alt Rows
            altRowStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            altRowStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            altRowStyle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            altRowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(224, 242, 254);
            altRowStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.dgvSuggestions.AlternatingRowsDefaultCellStyle = altRowStyle;

            this.dgvSuggestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMajorName,
            this.colMatchRate});
            this.dgvSuggestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSuggestions.EnableHeadersVisualStyles = false;
            this.dgvSuggestions.GridColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.dgvSuggestions.Location = new System.Drawing.Point(10, 40);
            this.dgvSuggestions.Name = "dgvSuggestions";
            this.dgvSuggestions.ReadOnly = true;
            this.dgvSuggestions.RowHeadersVisible = false;
            this.dgvSuggestions.RowTemplate.Height = 35;
            this.dgvSuggestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuggestions.TabIndex = 0;
            this.dgvSuggestions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(14, 165, 233);

            // Columns
            this.colMajorName.HeaderText = "Tên ngành / Nhóm ngành";
            this.colMajorName.Name = "colMajorName";
            this.colMajorName.ReadOnly = true;
            this.colMajorName.FillWeight = 70F;

            this.colMatchRate.HeaderText = "Độ phù hợp";
            this.colMatchRate.Name = "colMatchRate";
            this.colMatchRate.ReadOnly = true;
            this.colMatchRate.FillWeight = 30F;

            // 
            // btnSaveResult
            // 
            this.btnSaveResult.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSaveResult.BorderRadius = 8;
            this.btnSaveResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveResult.FillColor = System.Drawing.Color.FromArgb(34, 197, 94); // Green
            this.btnSaveResult.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveResult.ForeColor = System.Drawing.Color.White;
            this.btnSaveResult.Location = new System.Drawing.Point(1037, 735);
            this.btnSaveResult.Name = "btnSaveResult";
            this.btnSaveResult.Size = new System.Drawing.Size(140, 45);
            this.btnSaveResult.TabIndex = 3;
            this.btnSaveResult.Text = "Lưu kết quả";

            // 
            // UcHollandResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.layoutMain);
            this.Name = "UcHollandResult";
            this.Size = new System.Drawing.Size(1200, 800);

            this.layoutMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlResultCard.ResumeLayout(false);
            this.pnlResultCard.PerformLayout();
            this.layoutDetails.ResumeLayout(false);
            this.grpDescription.ResumeLayout(false);
            this.grpSuggestions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuggestions)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutMain;

        // Header
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;

        // Result Card (Top)
        private Guna.UI2.WinForms.Guna2GradientPanel pnlResultCard;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblCodeLabel;

        // Detail Section (Bottom)
        private System.Windows.Forms.TableLayoutPanel layoutDetails;

        // Left: Description
        private Guna.UI2.WinForms.Guna2GroupBox grpDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription; // Replaced RichTextBox

        // Right: Suggestions List
        private Guna.UI2.WinForms.Guna2GroupBox grpSuggestions;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSuggestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMajorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatchRate;

        // Footer Action
        private Guna.UI2.WinForms.Guna2Button btnSaveResult;
    }
}