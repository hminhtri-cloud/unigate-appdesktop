namespace UniGate.Student.UserControls
{
    partial class UcSubjectGroups
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            layoutMain = new TableLayoutPanel();
            pnlHeader = new Panel();
            lblTitle = new Label();
            dgvSubjectGroups = new DataGridView();
            colGroupCode = new DataGridViewTextBoxColumn();
            colSubjects = new DataGridViewTextBoxColumn();
            colMyScore = new DataGridViewTextBoxColumn();
            colAction = new DataGridViewButtonColumn();
            layoutMain.SuspendLayout();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubjectGroups).BeginInit();
            SuspendLayout();
            // 
            // layoutMain
            // 
            layoutMain.ColumnCount = 1;
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutMain.Controls.Add(pnlHeader, 0, 0);
            layoutMain.Controls.Add(dgvSubjectGroups, 0, 1);
            layoutMain.Dock = DockStyle.Fill;
            layoutMain.Location = new Point(0, 0);
            layoutMain.Margin = new Padding(6, 7, 6, 7);
            layoutMain.Name = "layoutMain";
            layoutMain.RowCount = 2;
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 148F));
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutMain.Size = new Size(1950, 1477);
            layoutMain.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1950, 148);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 122, 204);
            lblTitle.Location = new Point(43, 37);
            lblTitle.Margin = new Padding(6, 0, 6, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(488, 59);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CHỌN KHỐI MỤC TIÊU";
            // 
            // dgvSubjectGroups
            // 
            dgvSubjectGroups.AllowUserToAddRows = false;
            dgvSubjectGroups.AllowUserToDeleteRows = false;
            dgvSubjectGroups.AllowUserToResizeRows = false;
            dgvSubjectGroups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSubjectGroups.BackgroundColor = Color.WhiteSmoke;
            dgvSubjectGroups.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dgvSubjectGroups.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSubjectGroups.ColumnHeadersHeight = 50;
            dgvSubjectGroups.Columns.AddRange(new DataGridViewColumn[] { colGroupCode, colSubjects, colMyScore, colAction });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(230, 240, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvSubjectGroups.DefaultCellStyle = dataGridViewCellStyle3;
            dgvSubjectGroups.Dock = DockStyle.Fill;
            dgvSubjectGroups.EnableHeadersVisualStyles = false;
            dgvSubjectGroups.Location = new Point(43, 197);
            dgvSubjectGroups.Margin = new Padding(43, 49, 43, 49);
            dgvSubjectGroups.Name = "dgvSubjectGroups";
            dgvSubjectGroups.ReadOnly = true;
            dgvSubjectGroups.RowHeadersVisible = false;
            dgvSubjectGroups.RowHeadersWidth = 82;
            dgvSubjectGroups.RowTemplate.Height = 45;
            dgvSubjectGroups.Size = new Size(1864, 1231);
            dgvSubjectGroups.TabIndex = 1;
            // 
            // colGroupCode
            // 
            colGroupCode.FillWeight = 20F;
            colGroupCode.HeaderText = "Mã Khối";
            colGroupCode.MinimumWidth = 10;
            colGroupCode.Name = "colGroupCode";
            colGroupCode.ReadOnly = true;
            // 
            // colSubjects
            // 
            colSubjects.FillWeight = 45F;
            colSubjects.HeaderText = "Môn Thi";
            colSubjects.MinimumWidth = 10;
            colSubjects.Name = "colSubjects";
            colSubjects.ReadOnly = true;
            // 
            // colMyScore
            // 
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.Red;
            colMyScore.DefaultCellStyle = dataGridViewCellStyle2;
            colMyScore.FillWeight = 20F;
            colMyScore.HeaderText = "Điểm Của Bạn";
            colMyScore.MinimumWidth = 10;
            colMyScore.Name = "colMyScore";
            colMyScore.ReadOnly = true;
            // 
            // colAction
            // 
            colAction.FillWeight = 15F;
            colAction.FlatStyle = FlatStyle.Flat;
            colAction.HeaderText = "Trạng Thái";
            colAction.MinimumWidth = 10;
            colAction.Name = "colAction";
            colAction.ReadOnly = true;
            // 
            // UcSubjectGroups
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(layoutMain);
            Margin = new Padding(6, 7, 6, 7);
            Name = "UcSubjectGroups";
            Size = new Size(1950, 1477);
            layoutMain.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubjectGroups).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvSubjectGroups;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMyScore;
        private System.Windows.Forms.DataGridViewButtonColumn colAction;
    }
}