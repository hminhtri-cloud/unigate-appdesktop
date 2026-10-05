namespace UniGate.Student.myForm
{
    partial class FormKetQuaToHop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvCombinations = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            colSelect = new DataGridViewCheckBoxColumn();
            lblStatus = new Label();
            btnRefresh = new Button();
            btnSaveTargets = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCombinations).BeginInit();
            SuspendLayout();
            // 
            // dgvCombinations
            // 
            dgvCombinations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCombinations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCombinations.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, colSelect });
            dgvCombinations.Location = new Point(550, 102);
            dgvCombinations.Name = "dgvCombinations";
            dgvCombinations.RowHeadersWidth = 82;
            dgvCombinations.Size = new Size(418, 286);
            dgvCombinations.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tổ hợp (A01, D01...)";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Các môn thi";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Tổng điểm (Đã cộng ưu tiên)";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            // 
            // colSelect
            // 
            colSelect.HeaderText = "Chọn";
            colSelect.MinimumWidth = 10;
            colSelect.Name = "colSelect";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(626, 443);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(104, 32);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "lblStatus";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(917, 363);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(274, 140);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "btnRefresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnSaveTargets
            // 
            btnSaveTargets.Location = new Point(856, 547);
            btnSaveTargets.Name = "btnSaveTargets";
            btnSaveTargets.Size = new Size(241, 82);
            btnSaveTargets.TabIndex = 3;
            btnSaveTargets.Text = "btnSaveTargets";
            btnSaveTargets.UseVisualStyleBackColor = true;
            btnSaveTargets.Click += btnSaveTargets_Click;
            // 
            // FormKetQuaToHop
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 702);
            Controls.Add(btnSaveTargets);
            Controls.Add(btnRefresh);
            Controls.Add(lblStatus);
            Controls.Add(dgvCombinations);
            Name = "FormKetQuaToHop";
            Text = "FormKetQuaToHop";
            ((System.ComponentModel.ISupportInitialize)dgvCombinations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCombinations;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label lblStatus;
        private Button btnRefresh;
        private DataGridViewCheckBoxColumn colSelect;
        private Button btnSaveTargets;
    }
}