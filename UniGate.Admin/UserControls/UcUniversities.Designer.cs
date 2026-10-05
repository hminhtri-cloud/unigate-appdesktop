using System.Windows.Forms;
using System.Drawing;

namespace UniGate.Admin.UserControls
{
    partial class UcUniversities
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
            this.dgvUni = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.txtLogo = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUni)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUni
            // 
            this.dgvUni.AllowUserToAddRows = false;
            this.dgvUni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUni.BackgroundColor = System.Drawing.Color.White;
            this.dgvUni.ColumnHeadersHeight = 46;
            this.dgvUni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colCode,
            this.colName,
            this.colRegion});
            this.dgvUni.Location = new System.Drawing.Point(10, 10);
            this.dgvUni.Name = "dgvUni";
            this.dgvUni.ReadOnly = true;
            this.dgvUni.RowHeadersWidth = 82;
            this.dgvUni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUni.Size = new System.Drawing.Size(918, 702);
            this.dgvUni.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 10;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colCode
            // 
            this.colCode.DataPropertyName = "Code";
            this.colCode.HeaderText = "Mã";
            this.colCode.MinimumWidth = 10;
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Tên Trường";
            this.colName.MinimumWidth = 10;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colRegion
            // 
            this.colRegion.DataPropertyName = "Region";
            this.colRegion.HeaderText = "Khu vực";
            this.colRegion.MinimumWidth = 10;
            this.colRegion.Name = "colRegion";
            this.colRegion.ReadOnly = true;
            // 
            // pnlDetail
            // 
            this.pnlDetail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlDetail.Controls.Add(this.lblTitle);
            this.pnlDetail.Controls.Add(CreateLabel("Mã trường:", 60));
            this.pnlDetail.Controls.Add(this.txtCode);
            this.pnlDetail.Controls.Add(CreateLabel("Tên trường:", 110));
            this.pnlDetail.Controls.Add(this.txtName);
            this.pnlDetail.Controls.Add(CreateLabel("Khu vực:", 160));
            this.pnlDetail.Controls.Add(this.cbRegion);
            this.pnlDetail.Controls.Add(CreateLabel("Địa chỉ:", 210));
            this.pnlDetail.Controls.Add(this.txtAddress);
            this.pnlDetail.Controls.Add(CreateLabel("Website:", 260));
            this.pnlDetail.Controls.Add(this.txtWebsite);
            this.pnlDetail.Controls.Add(CreateLabel("Logo URL:", 310));
            this.pnlDetail.Controls.Add(this.txtLogo);
            this.pnlDetail.Controls.Add(CreateLabel("Mô tả:", 360));
            this.pnlDetail.Controls.Add(this.txtDesc);
            this.pnlDetail.Controls.Add(this.btnAdd);
            this.pnlDetail.Controls.Add(this.btnUpdate);
            this.pnlDetail.Controls.Add(this.btnDelete);
            this.pnlDetail.Controls.Add(this.btnClear);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDetail.Location = new System.Drawing.Point(938, 0);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(330, 722);
            this.pnlDetail.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(212, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ TRƯỜNG ĐH";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(20, 80);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(20, 130);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(290, 20);
            this.txtName.TabIndex = 2;
            // 
            // cbRegion
            // 
            this.cbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Items.AddRange(new object[] {
            "Miền Bắc",
            "Miền Trung",
            "Miền Nam"});
            this.cbRegion.Location = new System.Drawing.Point(20, 180);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(290, 21);
            this.cbRegion.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(20, 230);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(290, 20);
            this.txtAddress.TabIndex = 4;
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(20, 280);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(290, 20);
            this.txtWebsite.TabIndex = 5;
            // 
            // txtLogo
            // 
            this.txtLogo.Location = new System.Drawing.Point(20, 330);
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.Size = new System.Drawing.Size(290, 20);
            this.txtLogo.TabIndex = 6;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(20, 380);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(290, 60);
            this.txtDesc.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(20, 460);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 35);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(110, 460);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 35);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(200, 460);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 35);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(20, 510);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(260, 30);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Làm mới";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // UcUniversities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvUni);
            this.Controls.Add(this.pnlDetail);
            this.Name = "UcUniversities";
            this.Size = new System.Drawing.Size(1268, 722);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUni)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label CreateLabel(string text, int y)
        {
            var l = new System.Windows.Forms.Label();
            l.Text = text;
            l.Location = new System.Drawing.Point(20, y );
            l.AutoSize = true;
            return l;
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUni;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtCode, txtName, txtAddress, txtWebsite, txtLogo, txtDesc;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.Button btnAdd, btnUpdate, btnDelete, btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId, colCode, colName, colRegion;
    }
}