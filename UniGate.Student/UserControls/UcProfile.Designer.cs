using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Drawing;

namespace UniGate.Student.UserControls
{
    partial class UcProfile
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
            this.layoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLeftColumn = new System.Windows.Forms.Panel();
            this.pnlRightColumn = new System.Windows.Forms.Panel();

            // --- Groups ---
            this.grpPriority = new Guna.UI2.WinForms.Guna2GroupBox();
            this.layoutPriority = new System.Windows.Forms.TableLayoutPanel();

            this.grpThpt = new Guna.UI2.WinForms.Guna2GroupBox();
            this.layoutThpt = new System.Windows.Forms.TableLayoutPanel();

            this.grpHocBa = new Guna.UI2.WinForms.Guna2GroupBox();
            this.layoutHocBa = new System.Windows.Forms.TableLayoutPanel();

            // --- Controls ---
            this.cbKhuVuc = CreateComboBox("Khu vực");
            this.cbDoiTuong = CreateComboBox("Đối tượng ưu tiên");
            this.txtDgnl = CreateTextBox("Điểm ĐGNL (Nếu có)");

            this.txtKhuVuc = CreateTextBox("Khu vực");
            this.txtDoiTuong = CreateTextBox("Đối tượng ưu tiên");
            this.txtDgnl = CreateTextBox("Điểm ĐGNL (Nếu có)");

            this.txtThptToan = CreateTextBox("Toán");
            this.txtThptVan = CreateTextBox("Ngữ Văn");
            this.cbMon1 = CreateComboBox("Môn TC 1");
            this.txtDiem1 = CreateTextBox("Điểm");
            this.cbMon2 = CreateComboBox("Môn TC 2");
            this.txtDiem2 = CreateTextBox("Điểm");

            this.txtHB_Toan = CreateTextBox("Toán");
            this.txtHB_Van = CreateTextBox("Ngữ Văn");
            this.txtHB_Anh = CreateTextBox("Tiếng Anh");
            this.txtHB_Ly = CreateTextBox("Vật Lý");
            this.txtHB_Hoa = CreateTextBox("Hóa Học");
            this.txtHB_Sinh = CreateTextBox("Sinh Học");
            this.txtHB_Su = CreateTextBox("Lịch Sử");
            this.txtHB_Dia = CreateTextBox("Địa Lý");
            this.txtHB_GDKTPL = CreateTextBox("GD KT&PL");
            this.txtHB_TinHoc = CreateTextBox("Tin Học");

            this.btnSave = new Guna.UI2.WinForms.Guna2Button();

            // Suspend Layouts
            this.SuspendLayout();
            this.layoutMain.SuspendLayout();
            this.pnlLeftColumn.SuspendLayout();
            this.grpPriority.SuspendLayout();
            this.layoutPriority.SuspendLayout();
            this.grpThpt.SuspendLayout();
            this.layoutThpt.SuspendLayout();
            this.pnlRightColumn.SuspendLayout();
            this.grpHocBa.SuspendLayout();
            this.layoutHocBa.SuspendLayout();

            // 
            // layoutMain (Root)
            // 
            this.layoutMain.ColumnCount = 2;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutMain.Controls.Add(this.pnlLeftColumn, 0, 0);
            this.layoutMain.Controls.Add(this.pnlRightColumn, 1, 0);
            this.layoutMain.Controls.Add(this.btnSave, 0, 1);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 0);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.RowCount = 2;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F)); // Footer for Button
            this.layoutMain.Size = new System.Drawing.Size(1000, 600);
            this.layoutMain.TabIndex = 0;
            this.layoutMain.Padding = new System.Windows.Forms.Padding(20);

            // 
            // pnlLeftColumn (Holds Priority + THPT)
            // 
            this.pnlLeftColumn.Controls.Add(this.grpThpt);
            this.pnlLeftColumn.Controls.Add(this.grpPriority);
            this.pnlLeftColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftColumn.Location = new System.Drawing.Point(23, 23);
            this.pnlLeftColumn.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.pnlLeftColumn.Name = "pnlLeftColumn";
            this.pnlLeftColumn.Size = new System.Drawing.Size(467, 484);
            this.pnlLeftColumn.TabIndex = 0;

            // 
            // grpPriority
            // 
            this.grpPriority.Controls.Add(this.layoutPriority);
            this.grpPriority.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.grpPriority.CustomBorderThickness = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.grpPriority.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPriority.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpPriority.ForeColor = System.Drawing.Color.White;
            this.grpPriority.Location = new System.Drawing.Point(0, 0);
            this.grpPriority.Name = "grpPriority";
            this.grpPriority.Padding = new System.Windows.Forms.Padding(10, 45, 10, 10);
            this.grpPriority.Size = new System.Drawing.Size(467, 180);
            this.grpPriority.TabIndex = 0;
            this.grpPriority.Text = "Thông tin ưu tiên & ĐGNL";
            this.grpPriority.TextOffset = new System.Drawing.Point(10, -5);

            // 
            // layoutPriority
            // 
            this.layoutPriority.BackColor = System.Drawing.Color.White;
            this.layoutPriority.ColumnCount = 2;
            this.layoutPriority.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPriority.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPriority.Controls.Add(this.cbKhuVuc, 0, 0);
            this.layoutPriority.Controls.Add(this.cbDoiTuong, 1, 0);
            this.layoutPriority.Controls.Add(this.txtDgnl, 0, 1);
            this.layoutPriority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPriority.Location = new System.Drawing.Point(10, 45);
            this.layoutPriority.Name = "layoutPriority";
            this.layoutPriority.RowCount = 2;
            this.layoutPriority.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPriority.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPriority.Size = new System.Drawing.Size(447, 125);
            this.layoutPriority.TabIndex = 0;

            // 
            // grpThpt
            // 
            this.grpThpt.Controls.Add(this.layoutThpt);
            this.grpThpt.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.grpThpt.CustomBorderThickness = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.grpThpt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpThpt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThpt.ForeColor = System.Drawing.Color.White;
            this.grpThpt.Location = new System.Drawing.Point(0, 190); // Spacing from Top
            this.grpThpt.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.grpThpt.Name = "grpThpt";
            this.grpThpt.Padding = new System.Windows.Forms.Padding(10, 45, 10, 10);
            this.grpThpt.Size = new System.Drawing.Size(467, 294);
            this.grpThpt.TabIndex = 1;
            this.grpThpt.Text = "Điểm thi tốt nghiệp THPT";
            this.grpThpt.TextOffset = new System.Drawing.Point(10, -5);

            this.txtDoiTuong = CreateTextBox("Đối tượng ưu tiên");

            this.txtKhuVuc = CreateTextBox("Khu vực");


            // 
            // layoutThpt
            // 
            this.layoutThpt.BackColor = System.Drawing.Color.White;
            this.layoutThpt.ColumnCount = 2;
            this.layoutThpt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutThpt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutThpt.Controls.Add(this.txtThptToan, 0, 0);
            this.layoutThpt.Controls.Add(this.txtThptVan, 1, 0);
            this.layoutThpt.Controls.Add(this.cbMon1, 0, 1);
            this.layoutThpt.Controls.Add(this.txtDiem1, 1, 1);
            this.layoutThpt.Controls.Add(this.cbMon2, 0, 2);
            this.layoutThpt.Controls.Add(this.txtDiem2, 1, 2);
            this.layoutThpt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutThpt.Location = new System.Drawing.Point(10, 45);
            this.layoutThpt.Name = "layoutThpt";
            this.layoutThpt.RowCount = 3;
            this.layoutThpt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.layoutThpt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.layoutThpt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.layoutThpt.Size = new System.Drawing.Size(447, 239);
            this.layoutThpt.TabIndex = 0;

            // 
            // pnlRightColumn (Holds HocBa)
            // 
            this.pnlRightColumn.Controls.Add(this.grpHocBa);
            this.pnlRightColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightColumn.Location = new System.Drawing.Point(503, 23);
            this.pnlRightColumn.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.pnlRightColumn.Name = "pnlRightColumn";
            this.pnlRightColumn.Size = new System.Drawing.Size(474, 484);
            this.pnlRightColumn.TabIndex = 1;

            // 
            // grpHocBa
            // 
            this.grpHocBa.Controls.Add(this.layoutHocBa);
            this.grpHocBa.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.grpHocBa.CustomBorderThickness = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.grpHocBa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpHocBa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpHocBa.ForeColor = System.Drawing.Color.White;
            this.grpHocBa.Location = new System.Drawing.Point(0, 0);
            this.grpHocBa.Name = "grpHocBa";
            this.grpHocBa.Padding = new System.Windows.Forms.Padding(10, 45, 10, 10);
            this.grpHocBa.Size = new System.Drawing.Size(474, 484);
            this.grpHocBa.TabIndex = 0;
            this.grpHocBa.Text = "Điểm tổng kết Học bạ (Lớp 12)";
            this.grpHocBa.TextOffset = new System.Drawing.Point(10, -5);

            // 
            // layoutHocBa
            // 
            this.layoutHocBa.BackColor = System.Drawing.Color.White;
            this.layoutHocBa.ColumnCount = 2;
            this.layoutHocBa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutHocBa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutHocBa.Controls.Add(this.txtHB_Toan, 0, 0); this.layoutHocBa.Controls.Add(this.txtHB_Van, 1, 0);
            this.layoutHocBa.Controls.Add(this.txtHB_Anh, 0, 1); this.layoutHocBa.Controls.Add(this.txtHB_Ly, 1, 1);
            this.layoutHocBa.Controls.Add(this.txtHB_Hoa, 0, 2); this.layoutHocBa.Controls.Add(this.txtHB_Sinh, 1, 2);
            this.layoutHocBa.Controls.Add(this.txtHB_Su, 0, 3); this.layoutHocBa.Controls.Add(this.txtHB_Dia, 1, 3);
            this.layoutHocBa.Controls.Add(this.txtHB_GDKTPL, 0, 4); this.layoutHocBa.Controls.Add(this.txtHB_TinHoc, 1, 4);
            this.layoutHocBa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutHocBa.Location = new System.Drawing.Point(10, 45);
            this.layoutHocBa.Name = "layoutHocBa";
            this.layoutHocBa.RowCount = 5;
            this.layoutHocBa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutHocBa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutHocBa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutHocBa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutHocBa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutHocBa.Size = new System.Drawing.Size(454, 429);
            this.layoutHocBa.TabIndex = 0;

            // 
            // btnSave (Docked at Bottom)
            // 
            this.layoutMain.SetColumnSpan(this.btnSave, 2);
            this.btnSave.BorderRadius = 10;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(23, 513);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(954, 64);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "LƯU HỒ SƠ ĐIỂM SỐ";

            // 
            // UcProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.layoutMain);
            this.Name = "UcProfile";
            this.Size = new System.Drawing.Size(1000, 600);
            this.layoutMain.ResumeLayout(false);
            this.pnlLeftColumn.ResumeLayout(false);
            this.grpPriority.ResumeLayout(false);
            this.layoutPriority.ResumeLayout(false);
            this.grpThpt.ResumeLayout(false);
            this.layoutThpt.ResumeLayout(false);
            this.pnlRightColumn.ResumeLayout(false);
            this.grpHocBa.ResumeLayout(false);
            this.layoutHocBa.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        // Helper: Create TextBox with standard style
        private Guna.UI2.WinForms.Guna2TextBox CreateTextBox(string placeholder)
        {
            var txt = new Guna.UI2.WinForms.Guna2TextBox();
            txt.PlaceholderText = placeholder;
            txt.BorderRadius = 5;
            txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            txt.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txt.Margin = new System.Windows.Forms.Padding(5);
            txt.Size = new System.Drawing.Size(200, 40); // Base size, will stretch
            return txt;
        }

        // Helper: Create ComboBox (Without PlaceholderText property to avoid crash)
        private Guna.UI2.WinForms.Guna2ComboBox CreateComboBox(string tooltip)
        {
            var cb = new Guna.UI2.WinForms.Guna2ComboBox();
            // cb.PlaceholderText = ...; // Not supported in all versions
            cb.BorderRadius = 5;
            cb.Font = new System.Drawing.Font("Segoe UI", 9F);
            cb.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cb.Margin = new System.Windows.Forms.Padding(5);
            cb.Size = new System.Drawing.Size(200, 40);
            return cb;
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutMain;
        private System.Windows.Forms.Panel pnlLeftColumn;
        private System.Windows.Forms.Panel pnlRightColumn;

        private Guna.UI2.WinForms.Guna2GroupBox grpPriority;
        private System.Windows.Forms.TableLayoutPanel layoutPriority;
        private Guna.UI2.WinForms.Guna2ComboBox cbKhuVuc;
        private Guna.UI2.WinForms.Guna2ComboBox cbDoiTuong;
        private Guna.UI2.WinForms.Guna2TextBox txtDgnl;

        private Guna.UI2.WinForms.Guna2TextBox txtKhuVuc;
        private Guna.UI2.WinForms.Guna2TextBox txtDoiTuong;

        private Guna.UI2.WinForms.Guna2GroupBox grpThpt;
        private System.Windows.Forms.TableLayoutPanel layoutThpt;
        private Guna.UI2.WinForms.Guna2TextBox txtThptToan;
        private Guna.UI2.WinForms.Guna2TextBox txtThptVan;
        private Guna.UI2.WinForms.Guna2ComboBox cbMon1;
        private Guna.UI2.WinForms.Guna2TextBox txtDiem1;
        private Guna.UI2.WinForms.Guna2ComboBox cbMon2;
        private Guna.UI2.WinForms.Guna2TextBox txtDiem2;

        private Guna.UI2.WinForms.Guna2GroupBox grpHocBa;
        private System.Windows.Forms.TableLayoutPanel layoutHocBa;
        private Guna.UI2.WinForms.Guna2TextBox txtHB_Toan, txtHB_Van, txtHB_Anh, txtHB_Ly, txtHB_Hoa;
        private Guna.UI2.WinForms.Guna2TextBox txtHB_Sinh, txtHB_Su, txtHB_Dia, txtHB_GDKTPL, txtHB_TinHoc;

        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}