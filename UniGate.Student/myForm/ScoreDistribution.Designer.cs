namespace UniGate.Student.myForm
{
    partial class ScoreDistribution
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
            lblBestGroup = new Label();
            lblBestPercentile = new Label();
            lblAdvice = new Label();
            dgvStats = new DataGridView();
            btnManageTargets = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvStats).BeginInit();
            SuspendLayout();

            // =========================
            // lblBestGroup
            // =========================
            lblBestGroup.AutoSize = true;
            lblBestGroup.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblBestGroup.Location = new Point(50, 30);
            lblBestGroup.Name = "lblBestGroup";
            lblBestGroup.Size = new Size(200, 32);
            lblBestGroup.TabIndex = 0;
            lblBestGroup.Text = "Nhóm phù hợp nhất";

            // =========================
            // lblBestPercentile
            // =========================
            lblBestPercentile.AutoSize = true;
            lblBestPercentile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBestPercentile.Location = new Point(50, 80);
            lblBestPercentile.Name = "lblBestPercentile";
            lblBestPercentile.Size = new Size(250, 32);
            lblBestPercentile.TabIndex = 1;
            lblBestPercentile.Text = "Bạn đang ở top 85%";

            // =========================
            // lblAdvice
            // =========================
            lblAdvice.AutoSize = true;
            lblAdvice.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblAdvice.Location = new Point(50, 130);
            lblAdvice.Name = "lblAdvice";
            lblAdvice.Size = new Size(500, 32);
            lblAdvice.TabIndex = 2;
            lblAdvice.Text = "Bạn đang vượt qua 85% thí sinh, quá xuất sắc!";

            // =========================
            // dgvStats
            // =========================
            dgvStats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStats.Location = new Point(50, 200);
            dgvStats.Name = "dgvStats";
            dgvStats.RowHeadersWidth = 82;
            dgvStats.Size = new Size(800, 400);
            dgvStats.TabIndex = 3;

            // =========================
            // btnManageTargets
            // =========================
            btnManageTargets.Location = new Point(870, 200);
            btnManageTargets.Size = new Size(150, 50);
            btnManageTargets.TabIndex = 4;
            btnManageTargets.Text = "Quản lý mục tiêu";
            btnManageTargets.UseVisualStyleBackColor = true;

            // =========================
            // Form ScoreDistribution
            // =========================
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 650);
            Controls.Add(lblBestGroup);
            Controls.Add(lblBestPercentile);
            Controls.Add(lblAdvice);
            Controls.Add(dgvStats);
            Controls.Add(btnManageTargets);
            Name = "ScoreDistribution";
            Text = "Phân phối điểm";

            ((System.ComponentModel.ISupportInitialize)dgvStats).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label lblBestGroup;
        private Label lblBestPercentile;
        private Label lblAdvice;
        private DataGridView dgvStats;
        private Button btnManageTargets;
    }
}