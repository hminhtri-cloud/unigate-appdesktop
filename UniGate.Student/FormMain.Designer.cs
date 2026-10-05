using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Drawing;

namespace UniGate.Student
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // Layout Containers
            this.tableLayoutRoot = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSidebarWrapper = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlRightWrapper = new System.Windows.Forms.Panel();
            this.pnlContainer = new Guna.UI2.WinForms.Guna2Panel();

            // Sidebar Components
            this.pnlSidebarHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.picAppLogo = new Guna.UI2.WinForms.Guna2PictureBox(); // <--- Đã khai báo ở đây
            this.pnlUserInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.picAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.flowMenu = new System.Windows.Forms.FlowLayoutPanel();

            // Buttons
            this.btnDashboard = CreateNavButton("Tổng quan");
            this.btnProfile = CreateNavButton("Hồ sơ & Điểm số");
            this.btnSubjectGroup = CreateNavButton("Tổ hợp Môn học");
            this.btnSearch = CreateNavButton("Tra cứu & Gợi ý");
            this.btnWishlist = CreateNavButton("Danh sách Nguyện vọng");
            this.btnHolland = CreateNavButton("Trắc nghiệm Holland");
            this.btnHollandResults = CreateNavButton("Kết quả Holland");
            this.btnTools = CreateNavButton("Phân tích Phổ điểm");
            this.btnCompare = CreateNavButton("So sánh Ngành");
            this.btnSettings = CreateNavButton("Cài đặt Tài khoản");

            // Top Bar Components
            this.pnlTopBar = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCurrentPage = new System.Windows.Forms.Label();
            this.controlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.controlBoxMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);

            // Suspend Layout
            this.SuspendLayout();
            this.tableLayoutRoot.SuspendLayout();
            this.pnlSidebarWrapper.SuspendLayout();
            this.pnlSidebarHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAppLogo)).BeginInit();
            this.pnlUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.flowMenu.SuspendLayout();
            this.pnlRightWrapper.SuspendLayout();
            this.pnlTopBar.SuspendLayout();

            // 
            // FormMain Config
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.tableLayoutRoot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UniGate Student Portal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            // 
            // tableLayoutRoot
            // 
            this.tableLayoutRoot.ColumnCount = 2;
            this.tableLayoutRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 380F));
            this.tableLayoutRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutRoot.Controls.Add(this.pnlSidebarWrapper, 0, 0);
            this.tableLayoutRoot.Controls.Add(this.pnlRightWrapper, 1, 0);
            this.tableLayoutRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutRoot.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutRoot.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutRoot.Name = "tableLayoutRoot";
            this.tableLayoutRoot.RowCount = 1;
            this.tableLayoutRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutRoot.Size = new System.Drawing.Size(1600, 900);
            this.tableLayoutRoot.TabIndex = 0;

            // 
            // pnlSidebarWrapper
            // 
            this.pnlSidebarWrapper.BackColor = System.Drawing.Color.White;
            this.pnlSidebarWrapper.Controls.Add(this.flowMenu);
            this.pnlSidebarWrapper.Controls.Add(this.pnlUserInfo);
            this.pnlSidebarWrapper.Controls.Add(this.pnlSidebarHeader);
            this.pnlSidebarWrapper.Controls.Add(this.btnSettings);
            this.pnlSidebarWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSidebarWrapper.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebarWrapper.Name = "pnlSidebarWrapper";
            this.pnlSidebarWrapper.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.pnlSidebarWrapper.ShadowDecoration.Depth = 10;
            this.pnlSidebarWrapper.ShadowDecoration.Enabled = true;
            this.pnlSidebarWrapper.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pnlSidebarWrapper.Size = new System.Drawing.Size(380, 900);
            this.pnlSidebarWrapper.TabIndex = 0;

            // 
            // pnlSidebarHeader (Chứa picAppLogo)
            // 
            this.pnlSidebarHeader.Controls.Add(this.picAppLogo);
            this.pnlSidebarHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSidebarHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebarHeader.Name = "pnlSidebarHeader";
            this.pnlSidebarHeader.Size = new System.Drawing.Size(380, 120);
            this.pnlSidebarHeader.TabIndex = 0;

            // 
            // picAppLogo
            // 
            this.picAppLogo.BackColor = System.Drawing.Color.Transparent;
            this.picAppLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picAppLogo.FillColor = System.Drawing.Color.Transparent;
            this.picAppLogo.ImageRotate = 0F;
            this.picAppLogo.Location = new System.Drawing.Point(0, 0);
            this.picAppLogo.Name = "picAppLogo";
            this.picAppLogo.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.picAppLogo.Size = new System.Drawing.Size(380, 120);
            this.picAppLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAppLogo.TabIndex = 0;
            this.picAppLogo.TabStop = false;
            // Lưu ý: Image sẽ được set trong FormMain.cs (Load event) để tránh lỗi Resource tại designer

            // 
            // pnlUserInfo
            // 
            this.pnlUserInfo.Controls.Add(this.lblUserName);
            this.pnlUserInfo.Controls.Add(this.picAvatar);
            this.pnlUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserInfo.Location = new System.Drawing.Point(0, 120);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(380, 100);
            this.pnlUserInfo.TabIndex = 1;

            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.Transparent;
            this.picAvatar.FillColor = System.Drawing.Color.Gainsboro;
            this.picAvatar.Location = new System.Drawing.Point(30, 15);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picAvatar.Size = new System.Drawing.Size(70, 70);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;

            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUserName.ForeColor = System.Drawing.Color.DimGray;
            this.lblUserName.Location = new System.Drawing.Point(115, 15);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(240, 70);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Xin chào...";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // flowMenu
            // 
            this.flowMenu.Controls.Add(this.btnDashboard);

            this.flowMenu.Controls.Add(this.btnHolland);
            this.flowMenu.Controls.Add(this.btnHollandResults);

            this.flowMenu.Controls.Add(this.btnProfile);
            this.flowMenu.Controls.Add(this.btnSubjectGroup);
            this.flowMenu.Controls.Add(this.btnTools);

            this.flowMenu.Controls.Add(this.btnSearch);
            this.flowMenu.Controls.Add(this.btnWishlist);
            this.flowMenu.Controls.Add(this.btnCompare);

            this.flowMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowMenu.Location = new System.Drawing.Point(0, 220);
            this.flowMenu.Name = "flowMenu";
            this.flowMenu.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.flowMenu.Size = new System.Drawing.Size(380, 610);
            this.flowMenu.TabIndex = 2;
            this.flowMenu.WrapContents = false;

            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FillColor = System.Drawing.Color.White;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSettings.ForeColor = System.Drawing.Color.DimGray;
            this.btnSettings.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.btnSettings.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.btnSettings.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSettings.Location = new System.Drawing.Point(0, 830);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(380, 70);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Cài đặt Tài khoản";
            this.btnSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettings.TextOffset = new System.Drawing.Point(45, 0);

            // 
            // pnlRightWrapper
            // 
            this.pnlRightWrapper.Controls.Add(this.pnlContainer);
            this.pnlRightWrapper.Controls.Add(this.pnlTopBar);
            this.pnlRightWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightWrapper.Location = new System.Drawing.Point(380, 0);
            this.pnlRightWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRightWrapper.Name = "pnlRightWrapper";
            this.pnlRightWrapper.Size = new System.Drawing.Size(1220, 900);
            this.pnlRightWrapper.TabIndex = 1;

            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.White;
            this.pnlTopBar.Controls.Add(this.controlBoxMinimize);
            this.pnlTopBar.Controls.Add(this.controlBoxClose);
            this.pnlTopBar.Controls.Add(this.lblCurrentPage);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1220, 70);
            this.pnlTopBar.TabIndex = 0;

            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.AutoSize = true;
            this.lblCurrentPage.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentPage.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCurrentPage.ForeColor = System.Drawing.Color.SlateGray;
            this.lblCurrentPage.Location = new System.Drawing.Point(30, 18);
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(139, 32);
            this.lblCurrentPage.TabIndex = 0;
            this.lblCurrentPage.Text = "Tổng quan";

            // 
            // controlBoxClose
            // 
            this.controlBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlBoxClose.FillColor = System.Drawing.Color.Transparent;
            this.controlBoxClose.IconColor = System.Drawing.Color.Gray;
            this.controlBoxClose.Location = new System.Drawing.Point(1170, 0);
            this.controlBoxClose.Name = "controlBoxClose";
            this.controlBoxClose.Size = new System.Drawing.Size(50, 50);
            this.controlBoxClose.TabIndex = 1;

            // 
            // controlBoxMinimize
            // 
            this.controlBoxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlBoxMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.controlBoxMinimize.FillColor = System.Drawing.Color.Transparent;
            this.controlBoxMinimize.IconColor = System.Drawing.Color.Gray;
            this.controlBoxMinimize.Location = new System.Drawing.Point(1120, 0);
            this.controlBoxMinimize.Name = "controlBoxMinimize";
            this.controlBoxMinimize.Size = new System.Drawing.Size(50, 50);
            this.controlBoxMinimize.TabIndex = 2;

            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlContainer.Location = new System.Drawing.Point(0, 70);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(30);
            this.pnlContainer.Size = new System.Drawing.Size(1220, 830);
            this.pnlContainer.TabIndex = 1;

            // 
            // dragControl
            // 
            this.dragControl.TargetControl = this.pnlTopBar;

            // 
            // Finish Layout
            // 
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlRightWrapper.ResumeLayout(false);
            this.flowMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnlUserInfo.ResumeLayout(false);
            this.pnlSidebarHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAppLogo)).EndInit(); // <--- Đã có dòng này
            this.pnlSidebarWrapper.ResumeLayout(false);
            this.tableLayoutRoot.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // Helper Method
        private Guna.UI2.WinForms.Guna2Button CreateNavButton(string text)
        {
            var btn = new Guna.UI2.WinForms.Guna2Button();
            btn.Size = new System.Drawing.Size(340, 55);
            btn.BorderRadius = 10;
            btn.FillColor = System.Drawing.Color.White;
            btn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btn.ForeColor = System.Drawing.Color.DimGray;
            btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            btn.TextOffset = new System.Drawing.Point(25, 0);
            btn.Text = text;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);

            btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));

            btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            btn.CheckedState.ForeColor = System.Drawing.Color.White;

            return btn;
        }

        // --- Controls Declaration ---
        private System.Windows.Forms.TableLayoutPanel tableLayoutRoot;
        private Guna.UI2.WinForms.Guna2Panel pnlSidebarWrapper;

        private Guna.UI2.WinForms.Guna2Panel pnlSidebarHeader;
        private Guna.UI2.WinForms.Guna2PictureBox picAppLogo; // <--- Biến này đã được khai báo

        private Guna.UI2.WinForms.Guna2Panel pnlUserInfo;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picAvatar;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.FlowLayoutPanel flowMenu;
        private System.Windows.Forms.Panel pnlRightWrapper;
        private Guna.UI2.WinForms.Guna2Panel pnlTopBar;
        private Guna.UI2.WinForms.Guna2Panel pnlContainer;
        private System.Windows.Forms.Label lblCurrentPage;
        private Guna.UI2.WinForms.Guna2ControlBox controlBoxClose;
        private Guna.UI2.WinForms.Guna2ControlBox controlBoxMinimize;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;

        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnProfile;
        private Guna.UI2.WinForms.Guna2Button btnSubjectGroup;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnWishlist;
        private Guna.UI2.WinForms.Guna2Button btnHolland;
        private Guna.UI2.WinForms.Guna2Button btnHollandResults;
        private Guna.UI2.WinForms.Guna2Button btnTools;
        private Guna.UI2.WinForms.Guna2Button btnCompare;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
    }
}