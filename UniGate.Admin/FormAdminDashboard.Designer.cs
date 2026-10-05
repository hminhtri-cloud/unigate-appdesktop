namespace UniGate.Admin
{
    partial class FormAdminDashboard
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();

            // Menu Buttons
            this.btnHolland = new System.Windows.Forms.Button();
            this.btnScoreParams = new System.Windows.Forms.Button();
            this.btnGroupParams = new System.Windows.Forms.Button();
            this.btnMajorParams = new System.Windows.Forms.Button();
            this.btnUniParams = new System.Windows.Forms.Button();
            this.btnUserParams = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();

            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();

            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();

            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelMenu (Sidebar bên trái - Màu trắng)
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            // Add Controls theo thứ tự ngược lại (Bottom -> Top) vì Dock=Top
            this.panelMenu.Controls.Add(this.btnLogout); // Dock Bottom
            this.panelMenu.Controls.Add(this.btnHolland);
            this.panelMenu.Controls.Add(this.btnScoreParams);
            this.panelMenu.Controls.Add(this.btnGroupParams);
            this.panelMenu.Controls.Add(this.btnMajorParams);
            this.panelMenu.Controls.Add(this.btnUniParams);
            this.panelMenu.Controls.Add(this.btnUserParams);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(260, 750); // Rộng hơn xíu cho đẹp
            this.panelMenu.TabIndex = 0;
            // Shadow border phải (giả lập bằng Padding hoặc Panel con nếu cần)

            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(260, 100);
            this.panelLogo.TabIndex = 0;

            // 
            // lblLogo
            // 
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255))))); // Sky Blue
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(260, 100);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "UniGate\r\nADMIN";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // --- MENU BUTTONS ---
            // Helper SetupButton (xem bên dưới file Designer) được gọi sau

            // btnDashboard
            this.SetupButton(this.btnDashboard, "Dashboard Thống kê");

            // btnUserParams
            this.SetupButton(this.btnUserParams, "Quản lý Người dùng");

            // btnUniParams
            this.SetupButton(this.btnUniParams, "Quản lý Trường ĐH");

            // btnMajorParams
            this.SetupButton(this.btnMajorParams, "Quản lý Ngành đào tạo");

            // btnGroupParams
            this.SetupButton(this.btnGroupParams, "Quản lý Khối thi");

            // btnScoreParams
            this.SetupButton(this.btnScoreParams, "Dữ liệu Phổ điểm");

            // btnHolland
            this.SetupButton(this.btnHolland, "Câu hỏi trắc nghiệm");

            // btnLogout
            this.SetupButton(this.btnLogout, "Đăng xuất");
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom; // Nằm dưới cùng
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68); // Red text
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(260, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(940, 70);
            this.panelTitleBar.TabIndex = 1;
            // Border Bottom giả lập (nếu cần)

            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255))))); // Sky Blue Title
            this.lblTitleChildForm.Location = new System.Drawing.Point(30, 20);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(125, 30);
            this.lblTitleChildForm.TabIndex = 0;
            this.lblTitleChildForm.Text = "Dashboard";

            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250))))); // Light Gray BG
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(260, 70);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(940, 680);
            this.panelDesktop.TabIndex = 2;

            // 
            // FormAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UniGate Admin System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);
        }

        // Hàm helper để code gọn hơn trong Designer
        private void SetupButton(System.Windows.Forms.Button btn, string text)
        {
            btn.Dock = System.Windows.Forms.DockStyle.Top;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            btn.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btn.Location = new System.Drawing.Point(0, 0);
            btn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0); // Indent text
            btn.Size = new System.Drawing.Size(260, 60);
            btn.TabIndex = 1;
            btn.Text = text;
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.UseVisualStyleBackColor = true;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnUserParams;
        private System.Windows.Forms.Button btnUniParams;
        private System.Windows.Forms.Button btnMajorParams;
        private System.Windows.Forms.Button btnScoreParams;
        private System.Windows.Forms.Button btnGroupParams;
        private System.Windows.Forms.Button btnHolland;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelDesktop;
    }
}