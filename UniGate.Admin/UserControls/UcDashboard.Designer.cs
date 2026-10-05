using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Shapes;

namespace UniGate.Admin.UserControls
{
    partial class UcDashboard
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            layoutMain = new TableLayoutPanel();
            layoutStats = new TableLayoutPanel();
            pnlChartWrapper = new Guna2Panel();
            pnlChartContainer = new Panel();
            lblChartTitle = new Label();
            layoutMain.SuspendLayout();
            pnlChartWrapper.SuspendLayout();
            SuspendLayout();
            // 
            // layoutMain
            // 
            layoutMain.ColumnCount = 1;
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutMain.Controls.Add(layoutStats, 0, 0);
            layoutMain.Controls.Add(pnlChartWrapper, 0, 1);
            layoutMain.Dock = DockStyle.Fill;
            layoutMain.Location = new Point(0, 0);
            layoutMain.Name = "layoutMain";
            layoutMain.Padding = new Padding(20);
            layoutMain.RowCount = 2;
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 180F));
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutMain.Size = new Size(1200, 700);
            layoutMain.TabIndex = 0;
            // 
            // layoutStats
            // 
            layoutStats.ColumnCount = 3;
            layoutStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            layoutStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            layoutStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            layoutStats.Dock = DockStyle.Fill;
            layoutStats.Location = new Point(23, 23);
            layoutStats.Name = "layoutStats";
            layoutStats.RowCount = 1;
            layoutStats.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutStats.Size = new Size(1154, 174);
            layoutStats.TabIndex = 0;
            // 
            // pnlChartWrapper
            // 
            pnlChartWrapper.BackColor = Color.Transparent;
            pnlChartWrapper.BorderRadius = 15;
            pnlChartWrapper.Controls.Add(pnlChartContainer);
            pnlChartWrapper.Controls.Add(lblChartTitle);
            pnlChartWrapper.CustomizableEdges = customizableEdges1;
            pnlChartWrapper.Dock = DockStyle.Fill;
            pnlChartWrapper.FillColor = Color.White;
            pnlChartWrapper.Location = new Point(23, 220);
            pnlChartWrapper.Margin = new Padding(3, 20, 3, 3);
            pnlChartWrapper.Name = "pnlChartWrapper";
            pnlChartWrapper.ShadowDecoration.Color = Color.LightGray;
            pnlChartWrapper.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnlChartWrapper.ShadowDecoration.Depth = 5;
            pnlChartWrapper.ShadowDecoration.Enabled = true;
            pnlChartWrapper.ShadowDecoration.Shadow = new Padding(0, 0, 5, 5);
            pnlChartWrapper.Size = new Size(1154, 457);
            pnlChartWrapper.TabIndex = 1;
            // 
            // pnlChartContainer
            // 
            pnlChartContainer.Dock = DockStyle.Fill;
            pnlChartContainer.Location = new Point(0, 65);
            pnlChartContainer.Name = "pnlChartContainer";
            pnlChartContainer.Padding = new Padding(20);
            pnlChartContainer.Size = new Size(1154, 392);
            pnlChartContainer.TabIndex = 1;
            // 
            // lblChartTitle
            // 
            lblChartTitle.AutoSize = true;
            lblChartTitle.Dock = DockStyle.Top;
            lblChartTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblChartTitle.ForeColor = Color.Gray;
            lblChartTitle.Location = new Point(0, 0);
            lblChartTitle.Name = "lblChartTitle";
            lblChartTitle.Padding = new Padding(20, 20, 0, 0);
            lblChartTitle.Size = new Size(520, 65);
            lblChartTitle.TabIndex = 0;
            lblChartTitle.Text = "Thống kê Tăng trưởng hệ thống";
            // 
            // UcDashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            Controls.Add(layoutMain);
            Name = "UcDashboard";
            Size = new Size(1200, 700);
            layoutMain.ResumeLayout(false);
            pnlChartWrapper.ResumeLayout(false);
            pnlChartWrapper.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // Helper: Tạo Card thống kê
        private Guna.UI2.WinForms.Guna2GradientPanel CreateStatCard(string title, string value, Color color, out Label lblValueRef)
        {
            var pnl = new Guna.UI2.WinForms.Guna2GradientPanel();
            pnl.BorderRadius = 15;
            pnl.FillColor = color;
            pnl.FillColor2 = ControlPaint.Light(color, 0.2f); // Gradient nhẹ
            pnl.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl.Margin = new System.Windows.Forms.Padding(10); // Khoảng cách giữa các card

            // Bóng đổ
            pnl.ShadowDecoration.Color = color;
            pnl.ShadowDecoration.Depth = 10;
            pnl.ShadowDecoration.Enabled = true;
            pnl.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 5, 0, 5);

            // Label Title
            var lblTitle = new Label();
            lblTitle.Text = title;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitle.ForeColor = Color.WhiteSmoke;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(20, 20);

            // Label Value
            var lblVal = new Label();
            lblVal.Text = value;
            lblVal.Font = new System.Drawing.Font("Segoe UI", 24F, FontStyle.Bold);
            lblVal.ForeColor = Color.White;
            lblVal.BackColor = Color.Transparent;
            lblVal.AutoSize = true;
            lblVal.Location = new Point(20, 50);

            pnl.Controls.Add(lblTitle);
            pnl.Controls.Add(lblVal);

            lblValueRef = lblVal; // Output reference để gán giá trị sau này
            return pnl;
        }

        private System.Windows.Forms.TableLayoutPanel layoutMain;
        private System.Windows.Forms.TableLayoutPanel layoutStats;

        // Cards
        private Guna.UI2.WinForms.Guna2GradientPanel pnlCardStudent;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlCardUni;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlCardMajor;

        // Labels (Public/Private field to access)
        private System.Windows.Forms.Label lblTotalStudents;
        private System.Windows.Forms.Label lblTotalUnis;
        private System.Windows.Forms.Label lblTotalMajors;

        // Chart Area
        private Guna.UI2.WinForms.Guna2Panel pnlChartWrapper;
        private System.Windows.Forms.Label lblChartTitle;
        private System.Windows.Forms.Panel pnlChartContainer;
    }
}