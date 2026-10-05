namespace UniGate.Student.myForm
{
    partial class FormCompareMajor
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            cbMajor1 = new ComboBox();
            cbMajor2 = new ComboBox();
            cbMajor3 = new ComboBox();
            btnCompare = new Button();
            dgvCompare = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCompare).BeginInit();
            SuspendLayout();
            // 
            // cbMajor1
            // 
            cbMajor1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMajor1.Location = new Point(50, 30);
            cbMajor1.Name = "cbMajor1";
            cbMajor1.Size = new Size(300, 39);
            cbMajor1.TabIndex = 0;
            // 
            // cbMajor2
            // 
            cbMajor2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMajor2.Location = new Point(400, 30);
            cbMajor2.Name = "cbMajor2";
            cbMajor2.Size = new Size(300, 39);
            cbMajor2.TabIndex = 1;
            // 
            // cbMajor3
            // 
            cbMajor3.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMajor3.Location = new Point(750, 30);
            cbMajor3.Name = "cbMajor3";
            cbMajor3.Size = new Size(300, 39);
            cbMajor3.TabIndex = 2;
            // 
            // btnCompare
            // 
            btnCompare.Location = new Point(1100, 30);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(150, 45);
            btnCompare.TabIndex = 3;
            btnCompare.Text = "So sánh";
            btnCompare.UseVisualStyleBackColor = true;
            btnCompare.Click += new EventHandler(btnCompare_Click);
            // 
            // dgvCompare
            // 
            dgvCompare.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCompare.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompare.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn() { HeaderText = "Trường" },
                new DataGridViewTextBoxColumn() { HeaderText = "Ngành" },
                new DataGridViewTextBoxColumn() { HeaderText = "Tổ hợp" },
                new DataGridViewTextBoxColumn() { HeaderText = "Điểm chuẩn" },
                new DataGridViewTextBoxColumn() { HeaderText = "Điểm của m" },
                new DataGridViewTextBoxColumn() { HeaderText = "Holland phù hợp" }
            });
            dgvCompare.Location = new Point(50, 100);
            dgvCompare.Name = "dgvCompare";
            dgvCompare.RowHeadersWidth = 82;
            dgvCompare.Size = new Size(1200, 500);
            dgvCompare.TabIndex = 4;
            // 
            // FormCompareMajor
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 650);
            Controls.Add(dgvCompare);
            Controls.Add(btnCompare);
            Controls.Add(cbMajor3);
            Controls.Add(cbMajor2);
            Controls.Add(cbMajor1);
            Name = "FormCompareMajor";
            Text = "So sánh ngành / trường";
            ((System.ComponentModel.ISupportInitialize)dgvCompare).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbMajor1;
        private ComboBox cbMajor2;
        private ComboBox cbMajor3;
        private Button btnCompare;
        private DataGridView dgvCompare;
    }
}
