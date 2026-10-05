 using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Drawing;

namespace UniGate.Student.UserControls
{
    partial class UcSearch
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
            
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            tabControl = new Guna2TabControl();
            tpScore = new TabPage();
            dgvScore = new Guna2DataGridView();
            pnlFilterWrapper = new Guna2Panel();
            flowFilter = new FlowLayoutPanel();
            lblMargin = new Label();
            numMargin = new Guna2NumericUpDown();
            btnFilter = new Guna2Button();
            lblStatus = new Label();
            tpTargets = new TabPage();
            dgvTargets = new Guna2DataGridView();
            tpHolland = new TabPage();
            dgvHolland = new Guna2DataGridView();
            tpBestFit = new TabPage();
            dgvBestFit = new Guna2DataGridView();
            // --- THÊM ĐOẠN NÀY ---
            tpDgnl = new TabPage();
            dgvDgnl = new Guna2DataGridView();
            tabControl.SuspendLayout();
            tpScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvScore).BeginInit();
            pnlFilterWrapper.SuspendLayout();
            flowFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMargin).BeginInit();
            tpTargets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTargets).BeginInit();
            tpHolland.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHolland).BeginInit();
            tpBestFit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBestFit).BeginInit();
            SuspendLayout();// ...
            

            
            

            tabControl.SuspendLayout();
            // ...
            // Nhớ thêm dòng này vào chỗ BeginInit các dgv khác
            ((System.ComponentModel.ISupportInitialize)dgvDgnl).BeginInit();
            tpDgnl.SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Alignment = TabAlignment.Left;
            tabControl.Controls.Add(tpScore);
            tabControl.Controls.Add(tpTargets);
            tabControl.Controls.Add(tpHolland);
            tabControl.Controls.Add(tpDgnl);
            tabControl.Controls.Add(tpBestFit);
            tabControl.Dock = DockStyle.Fill;
            tabControl.ItemSize = new Size(400, 100);
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(6, 7, 6, 7);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(2383, 1723);
            tabControl.TabButtonHoverState.BorderColor = Color.Empty;
            tabControl.TabButtonHoverState.FillColor = Color.FromArgb(224, 242, 254);
            tabControl.TabButtonHoverState.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            tabControl.TabButtonHoverState.ForeColor = Color.FromArgb(14, 165, 233);
            tabControl.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            tabControl.TabButtonIdleState.BorderColor = Color.Empty;
            tabControl.TabButtonIdleState.FillColor = Color.White;
            tabControl.TabButtonIdleState.Font = new Font("Segoe UI", 11F);
            tabControl.TabButtonIdleState.ForeColor = Color.DimGray;
            tabControl.TabButtonIdleState.InnerColor = Color.FromArgb(33, 42, 57);
            tabControl.TabButtonSelectedState.BorderColor = Color.Empty;
            tabControl.TabButtonSelectedState.FillColor = Color.FromArgb(240, 249, 255);
            tabControl.TabButtonSelectedState.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tabControl.TabButtonSelectedState.ForeColor = Color.FromArgb(14, 165, 233);
            tabControl.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            tabControl.TabButtonSize = new Size(400, 100);
            tabControl.TabIndex = 0;
            tabControl.TabMenuBackColor = Color.White;
            // 
            // tpScore
            // 
            tpScore.BackColor = Color.WhiteSmoke;
            tpScore.Controls.Add(dgvScore);
            tpScore.Controls.Add(pnlFilterWrapper);
            tpScore.Location = new Point(404, 4);
            tpScore.Margin = new Padding(6, 7, 6, 7);
            tpScore.Name = "tpScore";
            tpScore.Padding = new Padding(11, 12, 11, 12);
            tpScore.Size = new Size(1975, 1715);
            tpScore.TabIndex = 0;
            tpScore.Text = "Gợi ý theo Điểm";
            // 
            // dgvScore
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvScore.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvScore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvScore.ColumnHeadersHeight = 46;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvScore.DefaultCellStyle = dataGridViewCellStyle3;
            dgvScore.Dock = DockStyle.Fill;
            dgvScore.GridColor = Color.FromArgb(231, 229, 255);
            dgvScore.Location = new Point(11, 234);
            dgvScore.Margin = new Padding(6, 7, 6, 7);
            dgvScore.Name = "dgvScore";
            dgvScore.RowHeadersVisible = false;
            dgvScore.RowHeadersWidth = 82;
            dgvScore.Size = new Size(1953, 1469);
            dgvScore.TabIndex = 1;
            dgvScore.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvScore.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvScore.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvScore.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvScore.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvScore.ThemeStyle.BackColor = Color.White;
            dgvScore.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvScore.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvScore.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvScore.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvScore.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvScore.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvScore.ThemeStyle.HeaderStyle.Height = 46;
            dgvScore.ThemeStyle.ReadOnly = false;
            dgvScore.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvScore.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvScore.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvScore.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvScore.ThemeStyle.RowsStyle.Height = 41;
            dgvScore.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvScore.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // tpDgnl
            // 
            tpDgnl.BackColor = Color.WhiteSmoke;
            tpDgnl.Controls.Add(dgvDgnl);
            tpDgnl.Location = new Point(404, 4);
            tpDgnl.Margin = new Padding(6, 7, 6, 7);
            tpDgnl.Name = "tpDgnl";
            tpDgnl.Padding = new Padding(11, 12, 11, 12);
            tpDgnl.Size = new Size(1975, 1715);
            tpDgnl.TabIndex = 4; // Tăng lên 1 đơn vị so với tab trước
            tpDgnl.Text = "Đánh giá năng lực";

            // 
            // dgvDgnl
            // 
            // M copy y chang style của mấy cái dgv kia bỏ vào đây cho đồng bộ
            dgvDgnl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1; // Hoặc style tương ứng
            dgvDgnl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDgnl.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDgnl.Dock = DockStyle.Fill;
            dgvDgnl.GridColor = Color.FromArgb(231, 229, 255);
            dgvDgnl.Location = new Point(11, 12);
            dgvDgnl.Margin = new Padding(6, 7, 6, 7);
            dgvDgnl.Name = "dgvDgnl";
            dgvDgnl.RowHeadersVisible = false;
            dgvDgnl.Size = new Size(1953, 1691);
            dgvDgnl.TabIndex = 0;
            dgvDgnl.ThemeStyle.BackColor = Color.White;
            dgvDgnl.ThemeStyle.BackColor = Color.White;
            dgvDgnl.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvDgnl.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvDgnl.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDgnl.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvDgnl.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvDgnl.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDgnl.ThemeStyle.HeaderStyle.Height = 46;
            dgvDgnl.ThemeStyle.ReadOnly = false;
            dgvDgnl.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvDgnl.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDgnl.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvDgnl.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvDgnl.ThemeStyle.RowsStyle.Height = 41;
            dgvDgnl.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvScore.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);

            // 
            // pnlFilterWrapper
            // 
            pnlFilterWrapper.BackColor = Color.White;
            pnlFilterWrapper.Controls.Add(flowFilter);
            pnlFilterWrapper.CustomizableEdges = customizableEdges5;
            pnlFilterWrapper.Dock = DockStyle.Top;
            pnlFilterWrapper.Location = new Point(11, 12);
            pnlFilterWrapper.Margin = new Padding(6, 7, 6, 7);
            pnlFilterWrapper.Name = "pnlFilterWrapper";
            pnlFilterWrapper.ShadowDecoration.Color = Color.Silver;
            pnlFilterWrapper.ShadowDecoration.CustomizableEdges = customizableEdges6;
            pnlFilterWrapper.ShadowDecoration.Depth = 5;
            pnlFilterWrapper.ShadowDecoration.Enabled = true;
            pnlFilterWrapper.ShadowDecoration.Shadow = new Padding(0, 0, 0, 3);
            pnlFilterWrapper.Size = new Size(1953, 222);
            pnlFilterWrapper.TabIndex = 0;
            // 
            // flowFilter
            // 
            flowFilter.Controls.Add(lblMargin);
            flowFilter.Controls.Add(numMargin);
            flowFilter.Controls.Add(btnFilter);
            flowFilter.Controls.Add(lblStatus);
            flowFilter.Dock = DockStyle.Fill;
            flowFilter.Location = new Point(0, 0);
            flowFilter.Margin = new Padding(6, 7, 6, 7);
            flowFilter.Name = "flowFilter";
            flowFilter.Padding = new Padding(65, 49, 0, 0);
            flowFilter.Size = new Size(1953, 222);
            flowFilter.TabIndex = 0;
            // 
            // lblMargin
            // 
            lblMargin.AutoSize = true;
            lblMargin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMargin.ForeColor = Color.FromArgb(64, 64, 64);
            lblMargin.Location = new Point(71, 74);
            lblMargin.Margin = new Padding(6, 25, 22, 0);
            lblMargin.Name = "lblMargin";
            lblMargin.Size = new Size(227, 45);
            lblMargin.TabIndex = 0;
            lblMargin.Text = "Biên độ (+/-):";

            // 
            // numMargin
            // 
            numMargin.BackColor = Color.Transparent;
            numMargin.BorderColor = Color.Silver;
            numMargin.BorderRadius = 8;
            numMargin.Cursor = Cursors.IBeam;
            numMargin.CustomizableEdges = customizableEdges1;
            numMargin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            numMargin.Location = new Point(326, 100);
            numMargin.Margin = new Padding(6, 7, 43, 7);
            numMargin.Name = "numMargin";
            numMargin.ShadowDecoration.CustomizableEdges = customizableEdges2;
            numMargin.Size = new Size(200, 75);
            numMargin.TabIndex = 1;
            numMargin.UpDownButtonFillColor = Color.FromArgb(240, 240, 240);
            numMargin.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // Chỉnh biên độ nhảy 0.25 mỗi lần bấm nút tăng/giảm
            numMargin.Increment = 0.25m;
            numMargin.DecimalPlaces = 2; // Hiển thị 2 chữ số thập phân cho đẹp (0.25, 0.50...)
            // 
            // btnFilter
            // 
            btnFilter.BorderRadius = 8;
            btnFilter.Cursor = Cursors.Hand;
            btnFilter.CustomizableEdges = customizableEdges3;
            btnFilter.FillColor = Color.FromArgb(14, 165, 233);
            btnFilter.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(808, 56);
            btnFilter.Margin = new Padding(6, 7, 43, 7);
            btnFilter.Name = "btnFilter";
            btnFilter.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnFilter.Size = new Size(347, 111);
            btnFilter.TabIndex = 2;
            btnFilter.Text = "LỌC KẾT QUẢ";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            lblStatus.ForeColor = Color.Gray;
            lblStatus.Location = new Point(1204, 81);
            lblStatus.Margin = new Padding(6, 32, 6, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(525, 41);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Hệ thống sẽ tìm trường trong khoảng...";
            // 
            // tpTargets
            // 
            tpTargets.BackColor = Color.WhiteSmoke;
            tpTargets.Controls.Add(dgvTargets);
            tpTargets.Location = new Point(404, 4);
            tpTargets.Margin = new Padding(6, 7, 6, 7);
            tpTargets.Name = "tpTargets";
            tpTargets.Padding = new Padding(11, 12, 11, 12);
            tpTargets.Size = new Size(1975, 1715);
            tpTargets.TabIndex = 1;
            tpTargets.Text = "Theo Khối/Tổ hợp";
            // 
            // dgvTargets
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvTargets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvTargets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvTargets.ColumnHeadersHeight = 46;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvTargets.DefaultCellStyle = dataGridViewCellStyle6;
            dgvTargets.Dock = DockStyle.Fill;
            dgvTargets.GridColor = Color.FromArgb(231, 229, 255);
            dgvTargets.Location = new Point(11, 12);
            dgvTargets.Margin = new Padding(6, 7, 6, 7);
            dgvTargets.Name = "dgvTargets";
            dgvTargets.RowHeadersVisible = false;
            dgvTargets.RowHeadersWidth = 82;
            dgvTargets.Size = new Size(1953, 1691);
            dgvTargets.TabIndex = 0;
            dgvTargets.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvTargets.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvTargets.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvTargets.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvTargets.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvTargets.ThemeStyle.BackColor = Color.White;
            dgvTargets.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvTargets.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvTargets.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTargets.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvTargets.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvTargets.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTargets.ThemeStyle.HeaderStyle.Height = 46;
            dgvTargets.ThemeStyle.ReadOnly = false;
            dgvTargets.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvTargets.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTargets.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvTargets.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvTargets.ThemeStyle.RowsStyle.Height = 41;
            dgvTargets.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvTargets.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // tpHolland
            // 
            tpHolland.BackColor = Color.WhiteSmoke;
            tpHolland.Controls.Add(dgvHolland);
            tpHolland.Location = new Point(404, 4);
            tpHolland.Margin = new Padding(6, 7, 6, 7);
            tpHolland.Name = "tpHolland";
            tpHolland.Padding = new Padding(11, 12, 11, 12);
            tpHolland.Size = new Size(1975, 1715);
            tpHolland.TabIndex = 2;
            tpHolland.Text = "Theo Tính cách";
            // 
            // dgvHolland
            // 
            dataGridViewCellStyle7.BackColor = Color.White;
            dgvHolland.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvHolland.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvHolland.ColumnHeadersHeight = 46;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvHolland.DefaultCellStyle = dataGridViewCellStyle9;
            dgvHolland.Dock = DockStyle.Fill;
            dgvHolland.GridColor = Color.FromArgb(231, 229, 255);
            dgvHolland.Location = new Point(11, 12);
            dgvHolland.Margin = new Padding(6, 7, 6, 7);
            dgvHolland.Name = "dgvHolland";
            dgvHolland.RowHeadersVisible = false;
            dgvHolland.RowHeadersWidth = 82;
            dgvHolland.Size = new Size(1953, 1691);
            dgvHolland.TabIndex = 0;
            dgvHolland.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvHolland.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvHolland.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvHolland.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvHolland.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvHolland.ThemeStyle.BackColor = Color.White;
            dgvHolland.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvHolland.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvHolland.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvHolland.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvHolland.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvHolland.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHolland.ThemeStyle.HeaderStyle.Height = 46;
            dgvHolland.ThemeStyle.ReadOnly = false;
            dgvHolland.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvHolland.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHolland.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvHolland.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvHolland.ThemeStyle.RowsStyle.Height = 41;
            dgvHolland.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvHolland.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // tpBestFit
            // 
            tpBestFit.BackColor = Color.WhiteSmoke;
            tpBestFit.Controls.Add(dgvBestFit);
            tpBestFit.Location = new Point(404, 4);
            tpBestFit.Margin = new Padding(6, 7, 6, 7);
            tpBestFit.Name = "tpBestFit";
            tpBestFit.Padding = new Padding(11, 12, 11, 12);
            tpBestFit.Size = new Size(1975, 1715);
            tpBestFit.TabIndex = 3;
            tpBestFit.Text = "Gợi ý Tốt nhất (AI)";
            // 
            // dgvBestFit
            // 
            dataGridViewCellStyle10.BackColor = Color.White;
            dgvBestFit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvBestFit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvBestFit.ColumnHeadersHeight = 46;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgvBestFit.DefaultCellStyle = dataGridViewCellStyle12;
            dgvBestFit.Dock = DockStyle.Fill;
            dgvBestFit.GridColor = Color.FromArgb(231, 229, 255);
            dgvBestFit.Location = new Point(11, 12);
            dgvBestFit.Margin = new Padding(6, 7, 6, 7);
            dgvBestFit.Name = "dgvBestFit";
            dgvBestFit.RowHeadersVisible = false;
            dgvBestFit.RowHeadersWidth = 82;
            dgvBestFit.Size = new Size(1953, 1691);
            dgvBestFit.TabIndex = 0;
            dgvBestFit.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvBestFit.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvBestFit.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvBestFit.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvBestFit.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvBestFit.ThemeStyle.BackColor = Color.White;
            dgvBestFit.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvBestFit.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvBestFit.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvBestFit.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvBestFit.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvBestFit.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBestFit.ThemeStyle.HeaderStyle.Height = 46;
            dgvBestFit.ThemeStyle.ReadOnly = false;
            dgvBestFit.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvBestFit.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBestFit.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvBestFit.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvBestFit.ThemeStyle.RowsStyle.Height = 41;
            dgvBestFit.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvBestFit.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // UcSearch
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControl);
            Margin = new Padding(6, 7, 6, 7);
            Name = "UcSearch";
            Size = new Size(2383, 1723);
            tabControl.ResumeLayout(false);
            tpScore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvScore).EndInit();
            pnlFilterWrapper.ResumeLayout(false);
            flowFilter.ResumeLayout(false);
            flowFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMargin).EndInit();
            tpTargets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTargets).EndInit();
            tpHolland.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHolland).EndInit();
            tpBestFit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBestFit).EndInit();
            ResumeLayout(false);
            tpDgnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDgnl).EndInit();

        }

        #endregion

        // Helper to apply consistent styling to all grids
        private void ApplyGridStyle(Guna.UI2.WinForms.Guna2DataGridView grid)
        {
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;
            grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            grid.BackgroundColor = System.Drawing.Color.White;
            grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            grid.ColumnHeadersHeight = 50;
            grid.EnableHeadersVisualStyles = false;
            grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            grid.ReadOnly = true;
            grid.RowHeadersVisible = false;
            grid.RowTemplate.Height = 45;
            grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // Header Style
            grid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            grid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            grid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;

            // Row Style
            grid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            grid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            grid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            grid.ThemeStyle.RowsStyle.Height = 45;
            grid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            grid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));

            // Alt Rows
            grid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));

            // Columns Construction
            grid.Columns.Clear();
            var colId = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "MajorId", HeaderText = "ID", Visible = false };
            var colUni = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "UniversityName", HeaderText = "Trường ĐH" };
            var colMajor = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "MajorName", HeaderText = "Ngành học" };

            // Logic riêng cho ĐGNL
            if (grid.Name == "dgvDgnl")
            {
                var colExamType = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "ExamType", HeaderText = "Kỳ thi (HCM/HN)" };
                var colBench = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "Benchmark", HeaderText = "Điểm chuẩn" };
                var colMyScore = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "MyScore", HeaderText = "Điểm của bạn" };
                var colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "Status", HeaderText = "Đánh giá" };

                // Nút lưu
                var colFav = new System.Windows.Forms.DataGridViewButtonColumn
                {
                    Name = "colFavorite",
                    HeaderText = "Lưu",
                    Text = "❤",
                    UseColumnTextForButtonValue = true,
                    FillWeight = 40
                };

                grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {colId, colUni, colMajor, colExamType, colBench, colMyScore, colStatus, colFav});
            }
            else // Các tab bình thường (THPT)
            {
                var colGroup = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "GroupCode", HeaderText = "Tổ hợp" };
                var colBench = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "Benchmark", HeaderText = "Điểm chuẩn" };
                var colMyScore = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "MyScore", HeaderText = "Điểm của bạn" };
                var colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "Status", HeaderText = "Đánh giá" };

                var colFav = new System.Windows.Forms.DataGridViewButtonColumn
                {
                    Name = "colFavorite",
                    HeaderText = "Lưu",
                    Text = "❤",
                    UseColumnTextForButtonValue = true,
                    FillWeight = 40
                };

                grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {colId, colUni, colMajor, colGroup, colBench, colMyScore, colStatus, colFav});
            }
        }
        
        

        private Guna.UI2.WinForms.Guna2TabControl tabControl;
        private System.Windows.Forms.TabPage tpScore, tpTargets, tpHolland, tpBestFit;
        private System.Windows.Forms.TabPage tpDgnl;
        private Guna.UI2.WinForms.Guna2Panel pnlFilterWrapper;
        private System.Windows.Forms.FlowLayoutPanel flowFilter;
        private System.Windows.Forms.Label lblMargin, lblStatus;
        private Guna.UI2.WinForms.Guna2NumericUpDown numMargin;
        private Guna.UI2.WinForms.Guna2Button btnFilter;
        private Guna.UI2.WinForms.Guna2DataGridView dgvScore, dgvTargets, dgvHolland, dgvDgnl, dgvBestFit;
    }
}