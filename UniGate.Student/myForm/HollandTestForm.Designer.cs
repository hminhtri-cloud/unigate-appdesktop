namespace UniGate.Student.myForm;

partial class HollandTestForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }


    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        pnlContainer = new Panel();
        lblQuestionNumber = new Label();
        pbProgress = new ProgressBar();
        lblContent = new Label();
        btn1 = new Button();
        btn2 = new Button();
        btn3 = new Button();
        btn4 = new Button();
        btn5 = new Button();
        btnPrev = new Button();
        pnlContainer.SuspendLayout();
        SuspendLayout();
        // 
        // pnlContainer
        // 
        pnlContainer.Dock = DockStyle.Fill;
        pnlContainer.Controls.Add(btnPrev);
        pnlContainer.Controls.Add(btn5);
        pnlContainer.Controls.Add(btn4);
        pnlContainer.Controls.Add(btn3);
        pnlContainer.Controls.Add(btn2);
        pnlContainer.Controls.Add(btn1);
        pnlContainer.Controls.Add(lblContent);
        pnlContainer.Controls.Add(pbProgress);
        pnlContainer.Controls.Add(lblQuestionNumber);
        pnlContainer.Location = new Point(0, 0);
        pnlContainer.Name = "pnlContainer";
        pnlContainer.Size = new Size(900, 500);
        // 
        // lblQuestionNumber
        // 
        lblQuestionNumber.AutoSize = true;
        lblQuestionNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblQuestionNumber.Location = new Point(40, 30);
        lblQuestionNumber.Text = "Câu 1 / 60";
        // 
        // pbProgress
        // 
        pbProgress.Location = new Point(40, 65);
        pbProgress.Maximum = 60;
        pbProgress.Size = new Size(820, 15);
        pbProgress.Value = 1;
        // 
        // lblContent
        // 
        lblContent.Font = new Font("Segoe UI", 12F);
        lblContent.Location = new Point(40, 120);
        lblContent.Size = new Size(820, 100);
        lblContent.TextAlign = ContentAlignment.MiddleCenter;
        lblContent.Text = "Nội dung câu hỏi sẽ hiện ở đây";
        // 
        // btn1
        // 
        btn1.Location = new Point(100, 270);
        btn1.Size = new Size(120, 50);
        btn1.Text = "1\nRất không đúng";
        // 
        // btn2
        // 
        btn2.Location = new Point(240, 270);
        btn2.Size = new Size(120, 50);
        btn2.Text = "2\nKhông đúng";
        // 
        // btn3
        // 
        btn3.Location = new Point(380, 270);
        btn3.Size = new Size(120, 50);
        btn3.Text = "3\nBình thường";
        // 
        // btn4
        // 
        btn4.Location = new Point(520, 270);
        btn4.Size = new Size(120, 50);
        btn4.Text = "4\nĐúng";
        // 
        // btn5
        // 
        btn5.Location = new Point(660, 270);
        btn5.Size = new Size(120, 50);
        btn5.Text = "5\nRất đúng";
        // 
        // btnPrev
        // 
        btnPrev.Location = new Point(40, 400);
        btnPrev.Size = new Size(120, 40);
        btnPrev.Text = "← Quay lại";
        btnPrev.Enabled = false;
        // 
        // HollandTestForm
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(900, 500);
        Controls.Add(pnlContainer);
        Name = "HollandTestForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Trắc nghiệm Holland";
        pnlContainer.ResumeLayout(false);
        pnlContainer.PerformLayout();
        ResumeLayout(false);
    }


    #endregion

    private Panel pnlContainer;
    private Button btnPrev;
    private Button btn5;
    private Button btn4;
    private Button btn3;
    private Button btn2;
    private Button btn1;
    private ProgressBar pbProgress;
    private Label lblContent;
    private Label lblQuestionNumber;
}