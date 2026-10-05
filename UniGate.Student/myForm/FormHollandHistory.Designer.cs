namespace UniGate.Student.myForm
{
    partial class FormHollandHistory
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
            dgvHistory = new DataGridView();
            btnDetail = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();

            // =========================
            // dgvHistory
            // =========================
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new Point(50, 50);          // Cách mép trái & trên
            dgvHistory.Name = "dgvHistory";
            dgvHistory.RowHeadersWidth = 82;
            dgvHistory.Size = new Size(700, 300);            // Rộng hơn, cao hơn
            dgvHistory.TabIndex = 0;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Cột tự co giãn

            // =========================
            // btnDetail
            // =========================
            btnDetail.Location = new Point(300, 370);        // Căn giữa dưới dgv
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(200, 40);             // Vừa tay, cân đối
            btnDetail.TabIndex = 1;
            btnDetail.Text = "Xem chi tiết";                // Text chuyên nghiệp
            btnDetail.UseVisualStyleBackColor = true;

            // =========================
            // FormHollandHistory
            // =========================
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvHistory);
            Controls.Add(btnDetail);
            Name = "FormHollandHistory";
            Text = "Lịch sử Holland";                        // Đổi tên form thân thiện

            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
        }




        #endregion

        private DataGridView dgvHistory;
        private Button btnDetail;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn Results;
    }
}