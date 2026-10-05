using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Drawing;

namespace UniGate.Student.UserControls
{
    partial class UcHolland
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
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.pbProgress = new Guna.UI2.WinForms.Guna2ProgressBar();

            this.lblContent = new System.Windows.Forms.Label();

            this.layoutOptions = new System.Windows.Forms.TableLayoutPanel();
            this.btn1 = CreateOptionButton("1\nRất không đúng");
            this.btn2 = CreateOptionButton("2\nKhông đúng");
            this.btn3 = CreateOptionButton("3\nBình thường");
            this.btn4 = CreateOptionButton("4\nĐúng");
            this.btn5 = CreateOptionButton("5\nRất đúng");

            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnPrev = new Guna.UI2.WinForms.Guna2Button();

            this.layoutMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.layoutOptions.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();

            // 
            // layoutMain (Root Container)
            // 
            this.layoutMain.ColumnCount = 1;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            // Row 0: Header (100px)
            // Row 1: Question Content (Fill 100%)
            // Row 2: Options (120px)
            // Row 3: Footer/Prev Button (80px)
            this.layoutMain.Controls.Add(this.pnlHeader, 0, 0);
            this.layoutMain.Controls.Add(this.lblContent, 0, 1);
            this.layoutMain.Controls.Add(this.layoutOptions, 0, 2);
            this.layoutMain.Controls.Add(this.pnlFooter, 0, 3);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 0);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.RowCount = 4;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.layoutMain.Size = new System.Drawing.Size(1000, 600);
            this.layoutMain.TabIndex = 0;

            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblQuestionNumber);
            this.pnlHeader.Controls.Add(this.pbProgress);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1000, 100);
            this.pnlHeader.TabIndex = 0;

            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblQuestionNumber.ForeColor = System.Drawing.Color.Gray;
            this.lblQuestionNumber.Location = new System.Drawing.Point(46, 25);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(117, 21);
            this.lblQuestionNumber.TabIndex = 0;
            this.lblQuestionNumber.Text = "Câu hỏi 1 / 60";

            // 
            // pbProgress
            // 
            this.pbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProgress.BorderRadius = 5;
            this.pbProgress.Location = new System.Drawing.Point(50, 60);
            this.pbProgress.Maximum = 60;
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.pbProgress.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.pbProgress.Size = new System.Drawing.Size(900, 10);
            this.pbProgress.TabIndex = 1;
            this.pbProgress.Text = "guna2ProgressBar1";
            this.pbProgress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.pbProgress.Value = 1;

            // 
            // lblContent
            // 
            this.lblContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblContent.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblContent.Location = new System.Drawing.Point(50, 100);
            this.lblContent.Margin = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(900, 280);
            this.lblContent.TabIndex = 1;
            this.lblContent.Text = "Đang tải câu hỏi...";
            this.lblContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // layoutOptions
            // 
            this.layoutOptions.ColumnCount = 5;
            this.layoutOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutOptions.Controls.Add(this.btn1, 0, 0);
            this.layoutOptions.Controls.Add(this.btn2, 1, 0);
            this.layoutOptions.Controls.Add(this.btn3, 2, 0);
            this.layoutOptions.Controls.Add(this.btn4, 3, 0);
            this.layoutOptions.Controls.Add(this.btn5, 4, 0);
            this.layoutOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutOptions.Location = new System.Drawing.Point(50, 380);
            this.layoutOptions.Margin = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.layoutOptions.Name = "layoutOptions";
            this.layoutOptions.RowCount = 1;
            this.layoutOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutOptions.Size = new System.Drawing.Size(900, 140);
            this.layoutOptions.TabIndex = 2;

            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnPrev);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooter.Location = new System.Drawing.Point(0, 520);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1000, 80);
            this.pnlFooter.TabIndex = 3;

            // 
            // btnPrev
            // 
            this.btnPrev.BorderColor = System.Drawing.Color.Silver;
            this.btnPrev.BorderRadius = 8;
            this.btnPrev.BorderThickness = 1;
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.Enabled = false;
            this.btnPrev.FillColor = System.Drawing.Color.White;
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPrev.ForeColor = System.Drawing.Color.Gray;
            this.btnPrev.Location = new System.Drawing.Point(50, 15);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(140, 45);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "← Quay lại";

            // 
            // UcHolland
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.layoutMain);
            this.Name = "UcHolland";
            this.Size = new System.Drawing.Size(1000, 600);
            this.layoutMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.layoutOptions.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        // Helper Method
        private Guna.UI2.WinForms.Guna2Button CreateOptionButton(string text)
        {
            var btn = new Guna.UI2.WinForms.Guna2Button();
            btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            btn.BorderRadius = 15;
            btn.BorderThickness = 2;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;

            // Layout Properties
            btn.Dock = System.Windows.Forms.DockStyle.Fill;
            btn.Margin = new System.Windows.Forms.Padding(10, 20, 10, 20); // Spacing between buttons

            btn.FillColor = System.Drawing.Color.White;
            btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            btn.Text = text;

            return btn;
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblQuestionNumber;
        private Guna.UI2.WinForms.Guna2ProgressBar pbProgress;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.TableLayoutPanel layoutOptions;
        private System.Windows.Forms.Panel pnlFooter;
        private Guna.UI2.WinForms.Guna2Button btnPrev;

        // Buttons
        private Guna.UI2.WinForms.Guna2Button btn1;
        private Guna.UI2.WinForms.Guna2Button btn2;
        private Guna.UI2.WinForms.Guna2Button btn3;
        private Guna.UI2.WinForms.Guna2Button btn4;
        private Guna.UI2.WinForms.Guna2Button btn5;
    }
}