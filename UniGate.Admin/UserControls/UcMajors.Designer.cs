using System.Windows.Forms;
using System.Drawing;

namespace UniGate.Admin.UserControls
{
    partial class UcMajors
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
            dgvMajors = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colUni = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colScore = new DataGridViewTextBoxColumn();
            pnlDetail = new Panel();
            lblTitle = new Label();
            lblUni = new Label();
            cbUniversity = new ComboBox();
            lblMajor = new Label();
            txtMajorName = new TextBox();
            txtCode = new TextBox();
            txtGroup = new TextBox();
            numScore = new NumericUpDown();
            numTuition = new NumericUpDown();
            txtHolland = new TextBox();
            txtDesc = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMajors).BeginInit();
            pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numScore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTuition).BeginInit();
            SuspendLayout();
            // 
            // dgvMajors
            // 
            dgvMajors.AllowUserToAddRows = false;
            dgvMajors.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMajors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMajors.BackgroundColor = Color.White;
            dgvMajors.ColumnHeadersHeight = 46;
            dgvMajors.Columns.AddRange(new DataGridViewColumn[] { colId, colUni, colName, colScore });
            dgvMajors.Location = new Point(22, 25);
            dgvMajors.Margin = new Padding(6, 7, 6, 7);
            dgvMajors.Name = "dgvMajors";
            dgvMajors.ReadOnly = true;
            dgvMajors.RowHeadersWidth = 82;
            dgvMajors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMajors.Size = new Size(1902, 1868);
            dgvMajors.TabIndex = 0;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.MinimumWidth = 10;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colUni
            // 
            colUni.DataPropertyName = "UniversityName";
            colUni.HeaderText = "Trường";
            colUni.MinimumWidth = 10;
            colUni.Name = "colUni";
            colUni.ReadOnly = true;
            // 
            // colName
            // 
            colName.DataPropertyName = "MajorName";
            colName.HeaderText = "Ngành";
            colName.MinimumWidth = 10;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colScore
            // 
            colScore.DataPropertyName = "CutoffScore";
            colScore.HeaderText = "Điểm";
            colScore.MinimumWidth = 10;
            colScore.Name = "colScore";
            colScore.ReadOnly = true;
            // 
            // pnlDetail
            // 
            pnlDetail.BackColor = Color.WhiteSmoke;
            pnlDetail.Controls.Add(lblTitle);
            pnlDetail.Controls.Add(lblUni);
            pnlDetail.Controls.Add(cbUniversity);
            pnlDetail.Controls.Add(lblMajor);
            pnlDetail.Controls.Add(txtMajorName);
            pnlDetail.Controls.Add(txtCode);
            pnlDetail.Controls.Add(txtGroup);
            pnlDetail.Controls.Add(numScore);
            pnlDetail.Controls.Add(numTuition);
            pnlDetail.Controls.Add(txtHolland);
            pnlDetail.Controls.Add(txtDesc);
            pnlDetail.Controls.Add(btnAdd);
            pnlDetail.Controls.Add(btnUpdate);
            pnlDetail.Controls.Add(btnDelete);
            pnlDetail.Controls.Add(btnClear);
            pnlDetail.Dock = DockStyle.Right;
            pnlDetail.Location = new Point(1946, 0);
            pnlDetail.Margin = new Padding(6, 7, 6, 7);
            pnlDetail.Name = "pnlDetail";
            pnlDetail.Size = new Size(715, 1918);
            pnlDetail.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(43, 49);
            lblTitle.Margin = new Padding(6, 0, 6, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(398, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "THÔNG TIN CHI TIẾT";
            // 
            // lblUni
            // 
            lblUni.Location = new Point(43, 148);
            lblUni.Margin = new Padding(6, 0, 6, 0);
            lblUni.Name = "lblUni";
            lblUni.Size = new Size(217, 57);
            lblUni.TabIndex = 1;
            lblUni.Text = "Trường ĐH:";
            // 
            // cbUniversity
            // 
            cbUniversity.Location = new Point(43, 197);
            cbUniversity.Margin = new Padding(6, 7, 6, 7);
            cbUniversity.Name = "cbUniversity";
            cbUniversity.Size = new Size(602, 40);
            cbUniversity.TabIndex = 2;
            // 
            // lblMajor
            // 
            lblMajor.Location = new Point(43, 271);
            lblMajor.Margin = new Padding(6, 0, 6, 0);
            lblMajor.Name = "lblMajor";
            lblMajor.Size = new Size(217, 57);
            lblMajor.TabIndex = 3;
            lblMajor.Text = "Tên ngành:";
            // 
            // txtMajorName
            // 
            txtMajorName.Location = new Point(43, 320);
            txtMajorName.Margin = new Padding(6, 7, 6, 7);
            txtMajorName.Name = "txtMajorName";
            txtMajorName.Size = new Size(602, 39);
            txtMajorName.TabIndex = 4;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(43, 443);
            txtCode.Margin = new Padding(6, 7, 6, 7);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(277, 39);
            txtCode.TabIndex = 5;
            // 
            // txtGroup
            // 
            txtGroup.Location = new Point(368, 443);
            txtGroup.Margin = new Padding(6, 7, 6, 7);
            txtGroup.Name = "txtGroup";
            txtGroup.Size = new Size(277, 39);
            txtGroup.TabIndex = 6;
            // 
            // numScore
            // 
            numScore.DecimalPlaces = 2;
            numScore.Location = new Point(43, 566);
            numScore.Margin = new Padding(6, 7, 6, 7);
            numScore.Name = "numScore";
            numScore.Size = new Size(607, 39);
            numScore.TabIndex = 7;
            // 
            // numTuition
            // 
            numTuition.Location = new Point(43, 689);
            numTuition.Margin = new Padding(6, 7, 6, 7);
            numTuition.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numTuition.Name = "numTuition";
            numTuition.Size = new Size(607, 39);
            numTuition.TabIndex = 8;
            // 
            // txtHolland
            // 
            txtHolland.Location = new Point(43, 812);
            txtHolland.Margin = new Padding(6, 7, 6, 7);
            txtHolland.Name = "txtHolland";
            txtHolland.Size = new Size(602, 39);
            txtHolland.TabIndex = 9;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(43, 935);
            txtDesc.Margin = new Padding(6, 7, 6, 7);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(602, 142);
            txtDesc.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(43, 1132);
            btnAdd.Margin = new Padding(6, 7, 6, 7);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(173, 86);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightBlue;
            btnUpdate.Enabled = false;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(238, 1132);
            btnUpdate.Margin = new Padding(6, 7, 6, 7);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(173, 86);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.Enabled = false;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(433, 1132);
            btnDelete.Margin = new Padding(6, 7, 6, 7);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(173, 86);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(43, 1255);
            btnClear.Margin = new Padding(6, 7, 6, 7);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(563, 74);
            btnClear.TabIndex = 14;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // UcMajors
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlDetail);
            Controls.Add(dgvMajors);
            Margin = new Padding(6, 7, 6, 7);
            Name = "UcMajors";
            Size = new Size(2661, 1918);
            ((System.ComponentModel.ISupportInitialize)dgvMajors).EndInit();
            pnlDetail.ResumeLayout(false);
            pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numScore).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTuition).EndInit();
            ResumeLayout(false);

        }

        private System.Windows.Forms.Label CreateLabel(string text, int y)
        {
            var l = new System.Windows.Forms.Label();
            l.Text = text;
            l.Location = new System.Drawing.Point(20, y - 20);
            l.AutoSize = true;
            return l;
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMajors;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUni;
        private System.Windows.Forms.ComboBox cbUniversity;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.TextBox txtMajorName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.NumericUpDown numScore;
        private System.Windows.Forms.NumericUpDown numTuition;
        private System.Windows.Forms.TextBox txtHolland;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
    }
}