namespace UniGate.Student.myForm
{
    partial class FormRecommendation
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            // Controls
            tabControl1 = new TabControl();
            tpScore = new TabPage();
            tpTargets = new TabPage();
            tpHolland = new TabPage();
            tpBestFit = new TabPage();

            // TabScore controls
            lblStatus = new Label();
            label1 = new Label();
            numMargin = new NumericUpDown();
            btnFilter = new Button();
            dgvScore = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();

            // TabTargets controls
            dgvTargets = new DataGridView();
            dgvTargets_Col1 = new DataGridViewTextBoxColumn();
            dgvTargets_Col2 = new DataGridViewTextBoxColumn();
            dgvTargets_Col3 = new DataGridViewTextBoxColumn();
            dgvTargets_Col4 = new DataGridViewTextBoxColumn();
            dgvTargets_Col5 = new DataGridViewTextBoxColumn();
            dgvTargets_Col6 = new DataGridViewTextBoxColumn();

            // TabHolland controls
            dgvHolland = new DataGridView();
            dgvHolland_Col1 = new DataGridViewTextBoxColumn();
            dgvHolland_Col2 = new DataGridViewTextBoxColumn();
            dgvHolland_Col3 = new DataGridViewTextBoxColumn();
            dgvHolland_Col4 = new DataGridViewTextBoxColumn();
            dgvHolland_Col5 = new DataGridViewTextBoxColumn();
            dgvHolland_Col6 = new DataGridViewTextBoxColumn();

            // TabBestFit controls
            dgvBestFit = new DataGridView();
            dgvBestFit_Col1 = new DataGridViewTextBoxColumn();
            dgvBestFit_Col2 = new DataGridViewTextBoxColumn();
            dgvBestFit_Col3 = new DataGridViewTextBoxColumn();
            dgvBestFit_Col4 = new DataGridViewTextBoxColumn();
            dgvBestFit_Col5 = new DataGridViewTextBoxColumn();
            dgvBestFit_Col6 = new DataGridViewTextBoxColumn();

            // Context menu
            ctxMenuFavorite = new ContextMenuStrip(components);

            tabControl1.SuspendLayout();
            tpScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMargin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvScore).BeginInit();
            tpTargets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTargets).BeginInit();
            tpHolland.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHolland).BeginInit();
            tpBestFit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBestFit).BeginInit();
            SuspendLayout();

            // --- tabControl1 ---
            tabControl1.Controls.Add(tpScore);
            tabControl1.Controls.Add(tpTargets);
            tabControl1.Controls.Add(tpHolland);
            tabControl1.Controls.Add(tpBestFit);
            tabControl1.Location = new Point(20, 20);
            tabControl1.Size = new Size(1580, 850);
            tabControl1.SelectedIndex = 0;

            // --- tpScore ---
            tpScore.Text = "Theo Điểm";
            tpScore.Controls.Add(lblStatus);
            tpScore.Controls.Add(label1);
            tpScore.Controls.Add(numMargin);
            tpScore.Controls.Add(btnFilter);
            tpScore.Controls.Add(dgvScore);

            // lblStatus
            lblStatus.Text = "Đang hiển thị các ngành quanh mức 20 điểm. Hãy nhập điểm của bạn để xem gợi ý chính xác!";
            lblStatus.Location = new Point(50, 20);
            lblStatus.Size = new Size(1200, 32);

            // label1
            label1.Text = "Margin:";
            label1.Location = new Point(50, 60);
            label1.Size = new Size(100, 32);

            // numMargin
            numMargin.Location = new Point(160, 60);
            numMargin.Minimum = 0;
            numMargin.Maximum = 50;
            numMargin.Value = 5;
            numMargin.Size = new Size(120, 39);

            // btnFilter
            btnFilter.Text = "Lọc kết quả";
            btnFilter.Location = new Point(300, 60);
            btnFilter.Size = new Size(150, 40);

            // dgvScore
            dgvScore.Location = new Point(50, 120);
            dgvScore.Size = new Size(1200, 600);
            dgvScore.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvScore.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvScore.ContextMenuStrip = ctxMenuFavorite;

            // dgvScore Columns
            Column1.HeaderText = "Trường"; Column1.Name = "dgvScore_ColSchool";
            Column2.HeaderText = "Ngành"; Column2.Name = "dgvScore_ColMajor";
            Column3.HeaderText = "Tổ hợp"; Column3.Name = "dgvScore_ColCombination";
            Column4.HeaderText = "Điểm chuẩn"; Column4.Name = "dgvScore_ColBenchmark";
            Column5.HeaderText = "Điểm của m"; Column5.Name = "dgvScore_ColMyScore";
            Column6.HeaderText = "Trạng thái"; Column6.Name = "dgvScore_ColStatus";

            // --- tpTargets ---
            tpTargets.Text = "Theo Tổ Hợp";
            tpTargets.Controls.Add(dgvTargets);
            dgvTargets.Location = new Point(50, 50);
            dgvTargets.Size = new Size(1200, 600);
            dgvTargets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTargets.Columns.AddRange(new DataGridViewColumn[] { dgvTargets_Col1, dgvTargets_Col2, dgvTargets_Col3, dgvTargets_Col4, dgvTargets_Col5, dgvTargets_Col6 });
            dgvTargets.ContextMenuStrip = ctxMenuFavorite;

            dgvTargets_Col1.HeaderText = "Trường"; dgvTargets_Col1.Name = "dgvTargets_ColSchool";
            dgvTargets_Col2.HeaderText = "Ngành"; dgvTargets_Col2.Name = "dgvTargets_ColMajor";
            dgvTargets_Col3.HeaderText = "Tổ hợp"; dgvTargets_Col3.Name = "dgvTargets_ColCombination";
            dgvTargets_Col4.HeaderText = "Điểm chuẩn"; dgvTargets_Col4.Name = "dgvTargets_ColBenchmark";
            dgvTargets_Col5.HeaderText = "Điểm của m"; dgvTargets_Col5.Name = "dgvTargets_ColMyScore";
            dgvTargets_Col6.HeaderText = "Trạng thái"; dgvTargets_Col6.Name = "dgvTargets_ColStatus";

            // --- tpHolland ---
            tpHolland.Text = "Theo Tính Cách";
            tpHolland.Controls.Add(dgvHolland);
            dgvHolland.Location = new Point(50, 50);
            dgvHolland.Size = new Size(1200, 600);
            dgvHolland.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHolland.Columns.AddRange(new DataGridViewColumn[] { dgvHolland_Col1, dgvHolland_Col2, dgvHolland_Col3, dgvHolland_Col4, dgvHolland_Col5, dgvHolland_Col6 });
            dgvHolland.ContextMenuStrip = ctxMenuFavorite;

            dgvHolland_Col1.HeaderText = "Trường"; dgvHolland_Col1.Name = "dgvHolland_ColSchool";
            dgvHolland_Col2.HeaderText = "Ngành"; dgvHolland_Col2.Name = "dgvHolland_ColMajor";
            dgvHolland_Col3.HeaderText = "Tổ hợp"; dgvHolland_Col3.Name = "dgvHolland_ColCombination";
            dgvHolland_Col4.HeaderText = "Điểm chuẩn"; dgvHolland_Col4.Name = "dgvHolland_ColBenchmark";
            dgvHolland_Col5.HeaderText = "Điểm của m"; dgvHolland_Col5.Name = "dgvHolland_ColMyScore";
            dgvHolland_Col6.HeaderText = "Trạng thái"; dgvHolland_Col6.Name = "dgvHolland_ColStatus";

            // --- tpBestFit ---
            tpBestFit.Text = "Phù Hợp Nhất";
            tpBestFit.Controls.Add(dgvBestFit);
            dgvBestFit.Location = new Point(50, 50);
            dgvBestFit.Size = new Size(1200, 600);
            dgvBestFit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBestFit.Columns.AddRange(new DataGridViewColumn[] { dgvBestFit_Col1, dgvBestFit_Col2, dgvBestFit_Col3, dgvBestFit_Col4, dgvBestFit_Col5, dgvBestFit_Col6 });
            dgvBestFit.ContextMenuStrip = ctxMenuFavorite;

            dgvBestFit_Col1.HeaderText = "Trường"; dgvBestFit_Col1.Name = "dgvBestFit_ColSchool";
            dgvBestFit_Col2.HeaderText = "Ngành"; dgvBestFit_Col2.Name = "dgvBestFit_ColMajor";
            dgvBestFit_Col3.HeaderText = "Tổ hợp"; dgvBestFit_Col3.Name = "dgvBestFit_ColCombination";
            dgvBestFit_Col4.HeaderText = "Điểm chuẩn"; dgvBestFit_Col4.Name = "dgvBestFit_ColBenchmark";
            dgvBestFit_Col5.HeaderText = "Điểm của m"; dgvBestFit_Col5.Name = "dgvBestFit_ColMyScore";
            dgvBestFit_Col6.HeaderText = "Trạng thái"; dgvBestFit_Col6.Name = "dgvBestFit_ColStatus";

            // --- ctxMenuFavorite ---
            ctxMenuFavorite.Items.Add("Thêm yêu thích", null, OnAddFavoriteClick);
            ctxMenuFavorite.Items.Add("Xóa yêu thích", null, OnRemoveFavoriteClick);

            // --- FormRecommendation ---
            ClientSize = new Size(1620, 900);
            Controls.Add(tabControl1);
            Text = "FormRecommendation";

            tabControl1.ResumeLayout(false);
            tpScore.ResumeLayout(false);
            tpScore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMargin).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvScore).EndInit();
            tpTargets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTargets).EndInit();
            tpHolland.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHolland).EndInit();
            tpBestFit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBestFit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        // Controls declaration
        private TabControl tabControl1;
        private TabPage tpScore, tpTargets, tpHolland, tpBestFit;
        private DataGridView dgvScore, dgvTargets, dgvHolland, dgvBestFit;
        private DataGridViewTextBoxColumn Column1, Column2, Column3, Column4, Column5, Column6;
        private DataGridViewTextBoxColumn dgvTargets_Col1, dgvTargets_Col2, dgvTargets_Col3, dgvTargets_Col4, dgvTargets_Col5, dgvTargets_Col6;
        private DataGridViewTextBoxColumn dgvHolland_Col1, dgvHolland_Col2, dgvHolland_Col3, dgvHolland_Col4, dgvHolland_Col5, dgvHolland_Col6;
        private DataGridViewTextBoxColumn dgvBestFit_Col1, dgvBestFit_Col2, dgvBestFit_Col3, dgvBestFit_Col4, dgvBestFit_Col5, dgvBestFit_Col6;

        private Label lblStatus, label1;
        private NumericUpDown numMargin;
        private Button btnFilter;
        private ContextMenuStrip ctxMenuFavorite;

        // Event handlers
        private void OnAddFavoriteClick(object sender, EventArgs e) { /* xử lý */ }
        private void OnRemoveFavoriteClick(object sender, EventArgs e) { /* xử lý */ }
    }
}
