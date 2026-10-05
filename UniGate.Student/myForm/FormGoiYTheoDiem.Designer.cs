namespace UniGate.Student.myForm
{
    partial class FormGoiYTheoDiem
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
            numMargin = new NumericUpDown();
            btnFilter = new Button();
            dgvResults = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numMargin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // numMargin
            // 
            numMargin.Location = new Point(50, 53);
            numMargin.Name = "numMargin";
            numMargin.Size = new Size(200, 39);
            numMargin.TabIndex = 0;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(270, 48);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(150, 45);
            btnFilter.TabIndex = 1;
            btnFilter.Text = "Lọc kết quả";
            btnFilter.UseVisualStyleBackColor = true;
            // 
            // dgvResults
            // 
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvResults.Location = new Point(50, 123);
            dgvResults.Name = "dgvResults";
            dgvResults.RowHeadersWidth = 82;
            dgvResults.Size = new Size(900, 500);
            dgvResults.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "Trường";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Ngành";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Tổ hợp";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Điểm chuẩn";
            Column4.MinimumWidth = 10;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Điểm của m";
            Column5.MinimumWidth = 10;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Trạng thái";
            Column6.MinimumWidth = 10;
            Column6.Name = "Column6";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 9);
            label1.Name = "label1";
            label1.Size = new Size(94, 32);
            label1.TabIndex = 3;
            label1.Text = "margin:";
            // 
            // FormGoiYTheoDiem
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 650);
            Controls.Add(label1);
            Controls.Add(numMargin);
            Controls.Add(btnFilter);
            Controls.Add(dgvResults);
            Name = "FormGoiYTheoDiem";
            Text = "Gợi ý theo điểm";
            ((System.ComponentModel.ISupportInitialize)numMargin).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private NumericUpDown numMargin;
        private Button btnFilter;
        private DataGridView dgvResults;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label label1;
    }
}