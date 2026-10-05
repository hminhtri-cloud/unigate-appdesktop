using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Drawing;

namespace UniGate.Student.UserControls
{
    partial class UcTools
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

            // GroupBox & Internal Layouts
            this.grpBest = new Guna.UI2.WinForms.Guna2GroupBox();
            this.layoutSummary = new System.Windows.Forms.TableLayoutPanel();
            this.flowTextInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBestGroup = new System.Windows.Forms.Label();
            this.lblBestPercentile = new System.Windows.Forms.Label();
            this.lblAdvice = new System.Windows.Forms.Label();
            this.btnManageTargets = new Guna.UI2.WinForms.Guna2Button();

            // DataGridView
            this.dgvStats = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPercentile = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.layoutMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.grpBest.SuspendLayout();
            this.layoutSummary.SuspendLayout();
            this.flowTextInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).BeginInit();
            this.SuspendLayout();

            // 
            // layoutMain (Root Container)
            // 
            this.layoutMain.ColumnCount = 1;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            // Rows: Header(80px) -> Summary(200px) -> Grid(Remaining)
            this.layoutMain.Controls.Add(this.pnlHeader, 0, 0);
            this.layoutMain.Controls.Add(this.grpBest, 0, 1);
            this.layoutMain.Controls.Add(this.dgvStats, 0, 2);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 0);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.RowCount = 3;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F)); // Height for GroupBox
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
            this.pnlHeader.Size = new System.Drawing.Size(1000, 80);
            this.pnlHeader.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(325, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Phân tích & So sánh Phổ điểm";

            // 
            // grpBest
            // 
            this.grpBest.BorderColor = System.Drawing.Color.Gainsboro;
            this.grpBest.BorderRadius = 10;
            this.grpBest.Controls.Add(this.layoutSummary);
            this.grpBest.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.grpBest.CustomBorderThickness = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.grpBest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBest.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpBest.ForeColor = System.Drawing.Color.White;
            this.grpBest.Location = new System.Drawing.Point(20, 100);
            this.grpBest.Margin = new System.Windows.Forms.Padding(20);
            this.grpBest.Name = "grpBest";
            this.grpBest.Padding = new System.Windows.Forms.Padding(10, 45, 10, 10); // Top padding to clear header
            this.grpBest.Size = new System.Drawing.Size(960, 180);
            this.grpBest.TabIndex = 1;
            this.grpBest.Text = "Đánh giá Tổng quan";
            this.grpBest.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.grpBest.TextOffset = new System.Drawing.Point(10, -5);

            // 
            // layoutSummary (Inside GroupBox)
            // 
            this.layoutSummary.BackColor = System.Drawing.Color.White;
            this.layoutSummary.ColumnCount = 2;
            this.layoutSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.layoutSummary.Controls.Add(this.flowTextInfo, 0, 0);
            this.layoutSummary.Controls.Add(this.btnManageTargets, 1, 0);
            this.layoutSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutSummary.Location = new System.Drawing.Point(10, 45);
            this.layoutSummary.Name = "layoutSummary";
            this.layoutSummary.RowCount = 1;
            this.layoutSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutSummary.Size = new System.Drawing.Size(940, 125);
            this.layoutSummary.TabIndex = 0;

            // 
            // flowTextInfo
            // 
            this.flowTextInfo.Controls.Add(this.lblBestGroup);
            this.flowTextInfo.Controls.Add(this.lblBestPercentile);
            this.flowTextInfo.Controls.Add(this.lblAdvice);
            this.flowTextInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowTextInfo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowTextInfo.Location = new System.Drawing.Point(3, 3);
            this.flowTextInfo.Name = "flowTextInfo";
            this.flowTextInfo.Size = new System.Drawing.Size(767, 119);
            this.flowTextInfo.TabIndex = 0;
            this.flowTextInfo.WrapContents = false;

            // 
            // lblBestGroup
            // 
            this.lblBestGroup.AutoSize = true;
            this.lblBestGroup.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblBestGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.lblBestGroup.Location = new System.Drawing.Point(3, 0);
            this.lblBestGroup.Name = "lblBestGroup";
            this.lblBestGroup.Size = new System.Drawing.Size(62, 45);
            this.lblBestGroup.TabIndex = 0;
            this.lblBestGroup.Text = "---";

            // 
            // lblBestPercentile
            // 
            this.lblBestPercentile.AutoSize = true;
            this.lblBestPercentile.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBestPercentile.ForeColor = System.Drawing.Color.DimGray;
            this.lblBestPercentile.Location = new System.Drawing.Point(3, 45);
            this.lblBestPercentile.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblBestPercentile.Name = "lblBestPercentile";
            this.lblBestPercentile.Size = new System.Drawing.Size(193, 30);
            this.lblBestPercentile.TabIndex = 1;
            this.lblBestPercentile.Text = "Đang tải dữ liệu...";

            // 
            // lblAdvice
            // 
            this.lblAdvice.AutoSize = true;
            this.lblAdvice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.lblAdvice.ForeColor = System.Drawing.Color.Gray;
            this.lblAdvice.Location = new System.Drawing.Point(3, 80);
            this.lblAdvice.Name = "lblAdvice";
            this.lblAdvice.Size = new System.Drawing.Size(309, 20);
            this.lblAdvice.TabIndex = 2;
            this.lblAdvice.Text = "Hệ thống đang phân tích dữ liệu điểm của bạn...";

            // 
            // btnManageTargets
            // 
            this.btnManageTargets.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnManageTargets.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.btnManageTargets.BorderRadius = 8;
            this.btnManageTargets.BorderThickness = 1;
            this.btnManageTargets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageTargets.FillColor = System.Drawing.Color.White;
            this.btnManageTargets.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnManageTargets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.btnManageTargets.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.btnManageTargets.Location = new System.Drawing.Point(776, 40);
            this.btnManageTargets.Name = "btnManageTargets";
            this.btnManageTargets.Size = new System.Drawing.Size(161, 45);
            this.btnManageTargets.TabIndex = 1;
            this.btnManageTargets.Text = "Cập nhật Điểm";

            // 
            // dgvStats
            // 
            this.dgvStats.AllowUserToAddRows = false;
            this.dgvStats.AllowUserToDeleteRows = false;
            this.dgvStats.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.dgvStats.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStats.BackgroundColor = System.Drawing.Color.White;
            this.dgvStats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStats.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStats.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStats.ColumnHeadersHeight = 45;
            this.dgvStats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGroup,
            this.colScore,
            this.colPercentile});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStats.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStats.EnableHeadersVisualStyles = false;
            this.dgvStats.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.dgvStats.Location = new System.Drawing.Point(20, 300);
            this.dgvStats.Margin = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.dgvStats.Name = "dgvStats";
            this.dgvStats.ReadOnly = true;
            this.dgvStats.RowHeadersVisible = false;
            this.dgvStats.RowTemplate.Height = 40;
            this.dgvStats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStats.Size = new System.Drawing.Size(960, 280);
            this.dgvStats.TabIndex = 2;
            this.dgvStats.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvStats.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvStats.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.dgvStats.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.dgvStats.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.dgvStats.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvStats.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.dgvStats.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.dgvStats.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStats.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.dgvStats.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStats.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvStats.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvStats.ThemeStyle.ReadOnly = true;
            this.dgvStats.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStats.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStats.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvStats.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.dgvStats.ThemeStyle.RowsStyle.Height = 40;
            this.dgvStats.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.dgvStats.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));

            // 
            // colGroup
            // 
            this.colGroup.DataPropertyName = "SubjectGroup";
            this.colGroup.HeaderText = "Khối Thi";
            this.colGroup.Name = "colGroup";
            this.colGroup.ReadOnly = true;

            // 
            // colScore
            // 
            this.colScore.DataPropertyName = "UserScore";
            this.colScore.HeaderText = "Điểm của bạn";
            this.colScore.Name = "colScore";
            this.colScore.ReadOnly = true;

            // 
            // colPercentile
            // 
            this.colPercentile.DataPropertyName = "Percentile";
            this.colPercentile.HeaderText = "Phân Vị (Vượt qua % thí sinh)";
            this.colPercentile.Name = "colPercentile";
            this.colPercentile.ReadOnly = true;

            // 
            // UcTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.layoutMain);
            this.Name = "UcTools";
            this.Size = new System.Drawing.Size(1000, 600);
            this.layoutMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpBest.ResumeLayout(false);
            this.layoutSummary.ResumeLayout(false);
            this.flowTextInfo.ResumeLayout(false);
            this.flowTextInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutMain;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2GroupBox grpBest;
        private System.Windows.Forms.TableLayoutPanel layoutSummary;
        private System.Windows.Forms.FlowLayoutPanel flowTextInfo;
        private System.Windows.Forms.Label lblBestGroup;
        private System.Windows.Forms.Label lblBestPercentile;
        private System.Windows.Forms.Label lblAdvice;
        private Guna.UI2.WinForms.Guna2Button btnManageTargets;
        private Guna.UI2.WinForms.Guna2DataGridView dgvStats;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPercentile;
    }
}