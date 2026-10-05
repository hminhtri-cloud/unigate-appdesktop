using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace UniGate.Student.UserControls
{
    partial class UcDashboard
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();

            // Layout 3 Thẻ
            this.layoutCards = new System.Windows.Forms.TableLayoutPanel();

            // Thẻ 1: Điểm
            this.cardScore = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblScoreTitle = new System.Windows.Forms.Label();
            this.lblScoreVal = new System.Windows.Forms.Label();

            // Thẻ 2: Nguyện vọng
            this.cardWishlist = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblWishlistTitle = new System.Windows.Forms.Label();
            this.lblWishlistVal = new System.Windows.Forms.Label();

            // Thẻ 3: Holland
            this.cardHolland = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblHollandTitle = new System.Windows.Forms.Label();
            this.lblHollandVal = new System.Windows.Forms.Label();

            // Phần thân dưới
            this.layoutBody = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCountdownWrapper = new System.Windows.Forms.Panel();
            this.pnlCountdown = new Guna.UI2.WinForms.Guna2Panel();
            this.circleProgress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.lblDaysLeft = new System.Windows.Forms.Label();
            this.lblCountdownTitle = new System.Windows.Forms.Label();

            this.pnlQuoteWrapper = new System.Windows.Forms.Panel();
            this.pnlQuote = new Guna.UI2.WinForms.Guna2Panel();
            this.lblQuote = new System.Windows.Forms.Label();

            this.layoutMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.layoutCards.SuspendLayout();
            this.cardScore.SuspendLayout();
            this.cardWishlist.SuspendLayout();
            this.cardHolland.SuspendLayout();
            this.layoutBody.SuspendLayout();
            this.pnlCountdownWrapper.SuspendLayout();
            this.pnlCountdown.SuspendLayout();
            this.circleProgress.SuspendLayout();
            this.pnlQuoteWrapper.SuspendLayout();
            this.pnlQuote.SuspendLayout();
            this.SuspendLayout();

            // 
            // layoutMain
            // 
            this.layoutMain.ColumnCount = 1;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.Controls.Add(this.pnlHeader, 0, 0);
            this.layoutMain.Controls.Add(this.layoutCards, 0, 1);
            this.layoutMain.Controls.Add(this.layoutBody, 0, 2);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 0);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.Padding = new System.Windows.Forms.Padding(30);
            this.layoutMain.RowCount = 3;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F)); // Header
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F)); // Cards
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F)); // Body
            this.layoutMain.Size = new System.Drawing.Size(1200, 800);
            this.layoutMain.TabIndex = 0;

            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblDate);
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(33, 33);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1134, 94);
            this.pnlHeader.TabIndex = 0;

            // lblWelcome
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblWelcome.Location = new System.Drawing.Point(0, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(287, 37);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Chào mừng quay lại!";

            // lblDate
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDate.ForeColor = System.Drawing.Color.Gray;
            this.lblDate.Location = new System.Drawing.Point(5, 45);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(220, 20);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Hôm nay là Thứ Ba, 23/12/2025";

            // 
            // layoutCards
            // 
            this.layoutCards.ColumnCount = 3;
            this.layoutCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.layoutCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.layoutCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.layoutCards.Controls.Add(this.cardScore, 0, 0);
            this.layoutCards.Controls.Add(this.cardWishlist, 1, 0);
            this.layoutCards.Controls.Add(this.cardHolland, 2, 0);
            this.layoutCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutCards.Location = new System.Drawing.Point(33, 133);
            this.layoutCards.Name = "layoutCards";
            this.layoutCards.RowCount = 1;
            this.layoutCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutCards.Size = new System.Drawing.Size(1134, 174);
            this.layoutCards.TabIndex = 1;

            // 
            // CARD 1: SCORE
            // 
            this.cardScore.BorderRadius = 15;
            this.cardScore.Controls.Add(this.lblScoreVal);
            this.cardScore.Controls.Add(this.lblScoreTitle);
            this.cardScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardScore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.cardScore.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(140)))), ((int)(((byte)(248)))));
            this.cardScore.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.cardScore.Location = new System.Drawing.Point(0, 0);
            this.cardScore.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.cardScore.Name = "cardScore";
            this.cardScore.Size = new System.Drawing.Size(368, 174);
            this.cardScore.TabIndex = 0;

            this.lblScoreTitle.AutoSize = true;
            this.lblScoreTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblScoreTitle.ForeColor = System.Drawing.Color.White;
            this.lblScoreTitle.Location = new System.Drawing.Point(20, 20);
            this.lblScoreTitle.Name = "lblScoreTitle";
            this.lblScoreTitle.Text = "Điểm tổ hợp cao nhất";

            this.lblScoreVal.AutoSize = true;
            this.lblScoreVal.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreVal.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblScoreVal.ForeColor = System.Drawing.Color.White;
            this.lblScoreVal.Location = new System.Drawing.Point(20, 50);
            this.lblScoreVal.Name = "lblScoreVal";
            this.lblScoreVal.Text = "0.00";

            // 
            // CARD 2: WISHLIST
            // 
            this.cardWishlist.BorderRadius = 15;
            this.cardWishlist.Controls.Add(this.lblWishlistVal);
            this.cardWishlist.Controls.Add(this.lblWishlistTitle);
            this.cardWishlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardWishlist.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.cardWishlist.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.cardWishlist.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.cardWishlist.Location = new System.Drawing.Point(388, 0);
            this.cardWishlist.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cardWishlist.Name = "cardWishlist";
            this.cardWishlist.Size = new System.Drawing.Size(358, 174);
            this.cardWishlist.TabIndex = 1;

            this.lblWishlistTitle.AutoSize = true;
            this.lblWishlistTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblWishlistTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblWishlistTitle.ForeColor = System.Drawing.Color.White;
            this.lblWishlistTitle.Location = new System.Drawing.Point(20, 20);
            this.lblWishlistTitle.Name = "lblWishlistTitle";
            this.lblWishlistTitle.Text = "Đã lưu nguyện vọng";

            this.lblWishlistVal.AutoSize = true;
            this.lblWishlistVal.BackColor = System.Drawing.Color.Transparent;
            this.lblWishlistVal.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblWishlistVal.ForeColor = System.Drawing.Color.White;
            this.lblWishlistVal.Location = new System.Drawing.Point(20, 50);
            this.lblWishlistVal.Name = "lblWishlistVal";
            this.lblWishlistVal.Text = "0";

            // 
            // CARD 3: HOLLAND
            // 
            this.cardHolland.BorderRadius = 15;
            this.cardHolland.Controls.Add(this.lblHollandVal);
            this.cardHolland.Controls.Add(this.lblHollandTitle);
            this.cardHolland.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardHolland.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.cardHolland.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(36)))));
            this.cardHolland.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.cardHolland.Location = new System.Drawing.Point(766, 0);
            this.cardHolland.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cardHolland.Name = "cardHolland";
            this.cardHolland.Size = new System.Drawing.Size(368, 174);
            this.cardHolland.TabIndex = 2;

            this.lblHollandTitle.AutoSize = true;
            this.lblHollandTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblHollandTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHollandTitle.ForeColor = System.Drawing.Color.White;
            this.lblHollandTitle.Location = new System.Drawing.Point(20, 20);
            this.lblHollandTitle.Name = "lblHollandTitle";
            this.lblHollandTitle.Text = "Nhóm tính cách";

            this.lblHollandVal.AutoSize = true;
            this.lblHollandVal.BackColor = System.Drawing.Color.Transparent;
            this.lblHollandVal.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblHollandVal.ForeColor = System.Drawing.Color.White;
            this.lblHollandVal.Location = new System.Drawing.Point(20, 50);
            this.lblHollandVal.Name = "lblHollandVal";
            this.lblHollandVal.Text = "---";

            // 
            // layoutBody (Chia 2 cột: Đếm ngược - Quote)
            // 
            this.layoutBody.ColumnCount = 2;
            this.layoutBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.layoutBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.layoutBody.Controls.Add(this.pnlCountdownWrapper, 0, 0);
            this.layoutBody.Controls.Add(this.pnlQuoteWrapper, 1, 0);
            this.layoutBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutBody.Location = new System.Drawing.Point(33, 310);
            this.layoutBody.Name = "layoutBody";
            this.layoutBody.RowCount = 1;
            this.layoutBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutBody.Size = new System.Drawing.Size(1134, 457);
            this.layoutBody.TabIndex = 2;

            // pnlCountdownWrapper
            this.pnlCountdownWrapper.Controls.Add(this.pnlCountdown);
            this.pnlCountdownWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCountdownWrapper.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.pnlCountdownWrapper.Location = new System.Drawing.Point(3, 3);
            this.pnlCountdownWrapper.Name = "pnlCountdownWrapper";
            this.pnlCountdownWrapper.Size = new System.Drawing.Size(447, 451);
            this.pnlCountdownWrapper.TabIndex = 0;

            // pnlCountdown (Đếm ngược)
            this.pnlCountdown.BorderRadius = 20;
            this.pnlCountdown.Controls.Add(this.circleProgress);
            this.pnlCountdown.Controls.Add(this.lblCountdownTitle);
            this.pnlCountdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCountdown.FillColor = System.Drawing.Color.White;
            this.pnlCountdown.Location = new System.Drawing.Point(0, 0);
            this.pnlCountdown.Name = "pnlCountdown";
            this.pnlCountdown.ShadowDecoration.Enabled = true;
            this.pnlCountdown.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.pnlCountdown.Size = new System.Drawing.Size(432, 451);
            this.pnlCountdown.TabIndex = 0;

            this.lblCountdownTitle.AutoSize = true;
            this.lblCountdownTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCountdownTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCountdownTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblCountdownTitle.Location = new System.Drawing.Point(20, 20);
            this.lblCountdownTitle.Name = "lblCountdownTitle";
            this.lblCountdownTitle.Text = "Đếm ngược THPT QG 2026";

            // Vòng tròn Progress
            this.circleProgress.Controls.Add(this.lblDaysLeft);
            this.circleProgress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.circleProgress.FillThickness = 15;
            this.circleProgress.Location = new System.Drawing.Point(100, 80);
            this.circleProgress.Name = "circleProgress";
            this.circleProgress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.circleProgress.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.circleProgress.ProgressThickness = 15;
            this.circleProgress.Size = new System.Drawing.Size(220, 220);
            this.circleProgress.TabIndex = 1;
            this.circleProgress.Value = 65;

            this.lblDaysLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblDaysLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDaysLeft.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblDaysLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.lblDaysLeft.Location = new System.Drawing.Point(0, 0);
            this.lblDaysLeft.Name = "lblDaysLeft";
            this.lblDaysLeft.Size = new System.Drawing.Size(220, 220);
            this.lblDaysLeft.TabIndex = 0;
            this.lblDaysLeft.Text = "---";
            this.lblDaysLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlQuoteWrapper
            this.pnlQuoteWrapper.Controls.Add(this.pnlQuote);
            this.pnlQuoteWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuoteWrapper.Location = new System.Drawing.Point(456, 3);
            this.pnlQuoteWrapper.Name = "pnlQuoteWrapper";
            this.pnlQuoteWrapper.Size = new System.Drawing.Size(675, 451);
            this.pnlQuoteWrapper.TabIndex = 1;

            // pnlQuote (Trích dẫn)
            this.pnlQuote.BorderRadius = 20;
            this.pnlQuote.Controls.Add(this.lblQuote);
            this.pnlQuote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuote.FillColor = System.Drawing.Color.White;
            this.pnlQuote.Location = new System.Drawing.Point(0, 0);
            this.pnlQuote.Name = "pnlQuote";
            this.pnlQuote.ShadowDecoration.Enabled = true;
            this.pnlQuote.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.pnlQuote.Size = new System.Drawing.Size(675, 451);
            this.pnlQuote.TabIndex = 0;

            this.lblQuote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuote.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic);
            this.lblQuote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(45)))), ((int)(((byte)(18)))));
            this.lblQuote.Location = new System.Drawing.Point(0, 0);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Text = "\"Đừng để ngày hôm nay trôi qua lãng phí. Tương lai được mua bằng hiện tại!\"";
            this.lblQuote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // UcDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.layoutMain);
            this.Name = "UcDashboard";
            this.Size = new System.Drawing.Size(1200, 800);
            this.layoutMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.layoutCards.ResumeLayout(false);
            this.cardScore.ResumeLayout(false);
            this.cardScore.PerformLayout();
            this.cardWishlist.ResumeLayout(false);
            this.cardWishlist.PerformLayout();
            this.cardHolland.ResumeLayout(false);
            this.cardHolland.PerformLayout();
            this.layoutBody.ResumeLayout(false);
            this.pnlCountdownWrapper.ResumeLayout(false);
            this.pnlCountdown.ResumeLayout(false);
            this.pnlCountdown.PerformLayout();
            this.circleProgress.ResumeLayout(false);
            this.pnlQuoteWrapper.ResumeLayout(false);
            this.pnlQuote.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // Khai báo biến thành viên (Member Variables)
        private System.Windows.Forms.TableLayoutPanel layoutMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblDate;

        private System.Windows.Forms.TableLayoutPanel layoutCards;
        private Guna.UI2.WinForms.Guna2GradientPanel cardScore;
        private System.Windows.Forms.Label lblScoreVal;
        private System.Windows.Forms.Label lblScoreTitle;

        private Guna.UI2.WinForms.Guna2GradientPanel cardWishlist;
        private System.Windows.Forms.Label lblWishlistVal;
        private System.Windows.Forms.Label lblWishlistTitle;

        private Guna.UI2.WinForms.Guna2GradientPanel cardHolland;
        private System.Windows.Forms.Label lblHollandVal;
        private System.Windows.Forms.Label lblHollandTitle;

        private System.Windows.Forms.TableLayoutPanel layoutBody;
        private System.Windows.Forms.Panel pnlCountdownWrapper;
        private Guna.UI2.WinForms.Guna2Panel pnlCountdown;
        private Guna.UI2.WinForms.Guna2CircleProgressBar circleProgress;
        private System.Windows.Forms.Label lblDaysLeft;
        private System.Windows.Forms.Label lblCountdownTitle;

        private System.Windows.Forms.Panel pnlQuoteWrapper;
        private Guna.UI2.WinForms.Guna2Panel pnlQuote;
        private System.Windows.Forms.Label lblQuote;
    }
}