namespace UniGate.Student.myForm
{
    partial class FormHollandResult
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
            lblTitle = new Label();
            lblCode = new Label();
            rtbDescription = new RichTextBox();
            lblSuggestions = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(620, 66);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(378, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "KẾT QUẢ TRẮC NGHIỆM CỦA BẠN";
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new Point(675, 176);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(260, 32);
            lblCode.TabIndex = 1;
            lblCode.Text = "Hiển thị mã (ví dụ: RIA)";
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(647, 250);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(511, 336);
            rtbDescription.TabIndex = 2;
            rtbDescription.Text = "";
            // 
            // lblSuggestions
            // 
            lblSuggestions.AutoSize = true;
            lblSuggestions.Location = new Point(1242, 382);
            lblSuggestions.Name = "lblSuggestions";
            lblSuggestions.Size = new Size(311, 32);
            lblSuggestions.TabIndex = 3;
            lblSuggestions.Text = "Gợi ý nghề nghiệp phù hợp";
            // 
            // FormHollandResult
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1574, 655);
            Controls.Add(lblSuggestions);
            Controls.Add(rtbDescription);
            Controls.Add(lblCode);
            Controls.Add(lblTitle);
            Name = "FormHollandResult";
            Text = "FormHollandResult";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblCode;
        private RichTextBox rtbDescription;
        private Label lblSuggestions;
    }
}