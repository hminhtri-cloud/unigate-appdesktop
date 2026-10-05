using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Drawing;

namespace UniGate.Admin
{
    partial class FormLogin
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlBackground = new Guna2Panel();
            pnlLoginCard = new Guna2Panel();
            picLogo = new Guna2PictureBox();
            lblTitle = new Label();
            lblSubtitle = new Label();
            txtEmail = new Guna2TextBox();
            txtPassword = new Guna2TextBox();
            btnLogin = new Guna2Button();
            lblMessage = new Label();
            controlBoxClose = new Guna2ControlBox();
            controlBoxMinimize = new Guna2ControlBox();
            dragControl = new Guna2DragControl(components);
            shadowForm = new Guna2ShadowForm(components);
            pnlBackground.SuspendLayout();
            pnlLoginCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlBackground
            // 
            pnlBackground.BackColor = Color.FromArgb(240, 242, 245);
            pnlBackground.Controls.Add(pnlLoginCard);
            pnlBackground.Controls.Add(controlBoxClose);
            pnlBackground.Controls.Add(controlBoxMinimize);
            pnlBackground.CustomizableEdges = customizableEdges15;
            pnlBackground.Dock = DockStyle.Fill;
            pnlBackground.Location = new Point(0, 0);
            pnlBackground.Margin = new Padding(6, 7, 6, 7);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.ShadowDecoration.CustomizableEdges = customizableEdges16;
            pnlBackground.Size = new Size(1733, 1231);
            pnlBackground.TabIndex = 0;
            // 
            // pnlLoginCard
            // 
            pnlLoginCard.BackColor = Color.Transparent;
            pnlLoginCard.BorderRadius = 15;
            pnlLoginCard.Controls.Add(picLogo);
            pnlLoginCard.Controls.Add(lblTitle);
            pnlLoginCard.Controls.Add(lblSubtitle);
            pnlLoginCard.Controls.Add(txtEmail);
            pnlLoginCard.Controls.Add(txtPassword);
            pnlLoginCard.Controls.Add(btnLogin);
            pnlLoginCard.Controls.Add(lblMessage);
            pnlLoginCard.CustomizableEdges = customizableEdges9;
            pnlLoginCard.FillColor = Color.White;
            pnlLoginCard.Location = new Point(433, 123);
            pnlLoginCard.Margin = new Padding(6, 7, 6, 7);
            pnlLoginCard.Name = "pnlLoginCard";
            pnlLoginCard.ShadowDecoration.Color = Color.LightGray;
            pnlLoginCard.ShadowDecoration.CustomizableEdges = customizableEdges10;
            pnlLoginCard.ShadowDecoration.Depth = 20;
            pnlLoginCard.ShadowDecoration.Enabled = true;
            pnlLoginCard.Size = new Size(867, 985);
            pnlLoginCard.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.CustomizableEdges = customizableEdges1;
            picLogo.FillColor = Color.Transparent;
            picLogo.ImageRotate = 0F;
            picLogo.Location = new Point(368, 74);
            picLogo.Margin = new Padding(6, 7, 6, 7);
            picLogo.Name = "picLogo";
            picLogo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            picLogo.Size = new Size(130, 148);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(14, 165, 233);
            lblTitle.Location = new Point(195, 234);
            lblTitle.Margin = new Padding(6, 0, 6, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(375, 65);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "UniGate Admin";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(184, 320);
            lblSubtitle.Margin = new Padding(6, 0, 6, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(411, 37);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Đăng nhập vào hệ thống quản trị";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            txtEmail.BorderRadius = 8;
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.CustomizableEdges = customizableEdges3;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.FocusedState.BorderColor = Color.FromArgb(14, 165, 233);
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.HoverState.BorderColor = Color.FromArgb(14, 165, 233);
            txtEmail.Location = new Point(87, 418);
            txtEmail.Margin = new Padding(13, 15, 13, 15);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email quản trị viên";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtEmail.Size = new Size(693, 98);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BorderRadius = 8;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.CustomizableEdges = customizableEdges5;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(14, 165, 233);
            txtPassword.Font = new Font("Segoe UI", 9F);
            txtPassword.HoverState.BorderColor = Color.FromArgb(14, 165, 233);
            txtPassword.Location = new Point(87, 554);
            txtPassword.Margin = new Padding(13, 15, 13, 15);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.PlaceholderText = "Mật khẩu";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtPassword.Size = new Size(693, 98);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BorderRadius = 8;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.CustomizableEdges = customizableEdges7;
            btnLogin.FillColor = Color.FromArgb(14, 165, 233);
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.HoverState.FillColor = Color.FromArgb(2, 132, 199);
            btnLogin.Location = new Point(87, 714);
            btnLogin.Margin = new Padding(6, 7, 6, 7);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnLogin.Size = new Size(693, 111);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "ĐĂNG NHẬP";
            btnLogin.Click += btnLogin_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 9F);
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(87, 862);
            lblMessage.Margin = new Padding(6, 0, 6, 0);
            lblMessage.MaximumSize = new Size(693, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 32);
            lblMessage.TabIndex = 5;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // controlBoxClose
            // 
            controlBoxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            controlBoxClose.CustomizableEdges = customizableEdges11;
            controlBoxClose.FillColor = Color.Transparent;
            controlBoxClose.IconColor = Color.Gray;
            controlBoxClose.Location = new Point(1625, 12);
            controlBoxClose.Margin = new Padding(6, 7, 6, 7);
            controlBoxClose.Name = "controlBoxClose";
            controlBoxClose.ShadowDecoration.CustomizableEdges = customizableEdges12;
            controlBoxClose.Size = new Size(98, 71);
            controlBoxClose.TabIndex = 1;
            // 
            // controlBoxMinimize
            // 
            controlBoxMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            controlBoxMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            controlBoxMinimize.CustomizableEdges = customizableEdges13;
            controlBoxMinimize.FillColor = Color.Transparent;
            controlBoxMinimize.IconColor = Color.Gray;
            controlBoxMinimize.Location = new Point(1517, 12);
            controlBoxMinimize.Margin = new Padding(6, 7, 6, 7);
            controlBoxMinimize.Name = "controlBoxMinimize";
            controlBoxMinimize.ShadowDecoration.CustomizableEdges = customizableEdges14;
            controlBoxMinimize.Size = new Size(98, 71);
            controlBoxMinimize.TabIndex = 2;
            // 
            // dragControl
            // 
            dragControl.DockIndicatorTransparencyValue = 0.6D;
            dragControl.TargetControl = pnlBackground;
            dragControl.UseTransparentDrag = true;
            // 
            // shadowForm
            // 
            shadowForm.BorderRadius = 20;
            shadowForm.TargetForm = this;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1733, 1231);
            Controls.Add(pnlBackground);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 7, 6, 7);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Login";
            pnlBackground.ResumeLayout(false);
            pnlLoginCard.ResumeLayout(false);
            pnlLoginCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlBackground;
        private Guna.UI2.WinForms.Guna2Panel pnlLoginCard;
        private Guna.UI2.WinForms.Guna2PictureBox picLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.Label lblMessage;
        private Guna.UI2.WinForms.Guna2ControlBox controlBoxClose;
        private Guna.UI2.WinForms.Guna2ControlBox controlBoxMinimize;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
        private Guna.UI2.WinForms.Guna2ShadowForm shadowForm;
    }
}