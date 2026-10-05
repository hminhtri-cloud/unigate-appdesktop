using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Drawing;

namespace UniGate.Student.UserControls
{
    partial class UcSettings
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
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.layoutContent = new System.Windows.Forms.TableLayoutPanel();

            // --- Group Info (Cột trái) ---
            this.grpInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.layoutInfoInternal = new System.Windows.Forms.FlowLayoutPanel();
            this.picAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();

            // Khai báo Label và TextBox thông tin
            this.lblInfoName = CreateHeaderLabel("HỌ VÀ TÊN:");
            this.txtFullName = CreateTextBox("Họ tên sinh viên", true);
            this.lblInfoEmail = CreateHeaderLabel("EMAIL ĐĂNG NHẬP:");
            this.txtEmail = CreateTextBox("Email tài khoản", true);

            // --- Cột phải (Chứa nút Đăng xuất) ---
            this.pnlRightColumn = new System.Windows.Forms.Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();

            // Suspend Layout
            this.layoutMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.layoutContent.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.layoutInfoInternal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.pnlRightColumn.SuspendLayout();
            this.SuspendLayout();

            // layoutMain (Root)
            this.layoutMain.ColumnCount = 1;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.Controls.Add(this.pnlHeader, 0, 0);
            this.layoutMain.Controls.Add(this.layoutContent, 0, 1);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 0);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.RowCount = 2;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.Size = new System.Drawing.Size(1000, 700);

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1000, 70);

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblTitle.Location = new System.Drawing.Point(30, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(190, 30);
            this.lblTitle.Text = "Cài đặt Tài khoản";

            // layoutContent
            this.layoutContent.ColumnCount = 2;
            this.layoutContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.layoutContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.layoutContent.Controls.Add(this.grpInfo, 0, 0);
            this.layoutContent.Controls.Add(this.pnlRightColumn, 1, 0);
            this.layoutContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutContent.Location = new System.Drawing.Point(0, 70);
            this.layoutContent.Name = "layoutContent";
            this.layoutContent.Padding = new System.Windows.Forms.Padding(25);
            this.layoutContent.RowCount = 1;
            this.layoutContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutContent.Size = new System.Drawing.Size(1000, 630);

            // grpInfo
            this.grpInfo.BorderRadius = 10;
            this.grpInfo.Controls.Add(this.layoutInfoInternal);
            this.grpInfo.CustomBorderColor = System.Drawing.Color.FromArgb(14, 165, 233);
            this.grpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpInfo.ForeColor = System.Drawing.Color.White;
            this.grpInfo.Location = new System.Drawing.Point(28, 28);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(402, 574);
            this.grpInfo.Text = "Thông tin cá nhân";

            // layoutInfoInternal
            this.layoutInfoInternal.BackColor = System.Drawing.Color.White;
            this.layoutInfoInternal.Controls.Add(this.picAvatar);
            this.layoutInfoInternal.Controls.Add(this.lblInfoName);
            this.layoutInfoInternal.Controls.Add(this.txtFullName);
            this.layoutInfoInternal.Controls.Add(this.lblInfoEmail);
            this.layoutInfoInternal.Controls.Add(this.txtEmail);
            this.layoutInfoInternal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutInfoInternal.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.layoutInfoInternal.Location = new System.Drawing.Point(0, 40);
            this.layoutInfoInternal.Name = "layoutInfoInternal";
            this.layoutInfoInternal.Padding = new System.Windows.Forms.Padding(25, 20, 25, 20);
            this.layoutInfoInternal.Size = new System.Drawing.Size(402, 534);

            // picAvatar
            this.picAvatar.FillColor = System.Drawing.Color.Gainsboro;
            this.picAvatar.Location = new System.Drawing.Point(141, 23);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(115, 0, 0, 25);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picAvatar.Size = new System.Drawing.Size(120, 120);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            // pnlRightColumn
            this.pnlRightColumn.Controls.Add(this.btnLogout);
            this.pnlRightColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightColumn.Location = new System.Drawing.Point(455, 28);
            this.pnlRightColumn.Name = "pnlRightColumn";
            this.pnlRightColumn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.pnlRightColumn.Size = new System.Drawing.Size(517, 574);

            // btnLogout
            this.btnLogout.BorderRadius = 8;
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(254, 226, 226);
            this.btnLogout.Location = new System.Drawing.Point(15, 514);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(502, 60);
            this.btnLogout.Text = "ĐĂNG XUẤT TÀI KHOẢN";

            // Control finalized
            this.Controls.Add(this.layoutMain);
            this.Size = new System.Drawing.Size(1000, 700);
            this.layoutMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.layoutContent.ResumeLayout(false);
            this.grpInfo.ResumeLayout(false);
            this.layoutInfoInternal.ResumeLayout(false);
            this.layoutInfoInternal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnlRightColumn.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        // --- HELPERS ---
        private Guna.UI2.WinForms.Guna2TextBox CreateTextBox(string placeholder, bool isReadOnly)
        {
            var txt = new Guna.UI2.WinForms.Guna2TextBox();
            txt.ReadOnly = isReadOnly;
            txt.Height = 45;
            txt.Width = 340;
            txt.BorderRadius = 6;
            txt.Font = new System.Drawing.Font("Segoe UI", 10F);
            txt.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            return txt;
        }

        private System.Windows.Forms.Label CreateHeaderLabel(string text)
        {
            var lbl = new System.Windows.Forms.Label();
            lbl.Text = text;
            lbl.AutoSize = true;
            lbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lbl.ForeColor = System.Drawing.Color.Gray;
            lbl.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            return lbl;
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutMain;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel layoutContent;
        private Guna.UI2.WinForms.Guna2GroupBox grpInfo;
        private System.Windows.Forms.FlowLayoutPanel layoutInfoInternal;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picAvatar;
        private System.Windows.Forms.Panel pnlRightColumn;
        private Guna.UI2.WinForms.Guna2Button btnLogout;

        // Chỉ khai báo 1 lần duy nhất ở đây
        private System.Windows.Forms.Label lblInfoName;
        private System.Windows.Forms.Label lblInfoEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
    }
}