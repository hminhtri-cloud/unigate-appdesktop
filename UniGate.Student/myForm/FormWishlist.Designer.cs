namespace UniGate.Student.myForm
{
    partial class FormWishlist
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
            dgvFavorites = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvFavorites).BeginInit();
            SuspendLayout();
            // 
            // dgvFavorites
            // 
            dgvFavorites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFavorites.Location = new Point(142, 76);
            dgvFavorites.Name = "dgvFavorites";
            dgvFavorites.RowHeadersWidth = 82;
            dgvFavorites.Size = new Size(521, 291);
            dgvFavorites.TabIndex = 0;
            // 
            // FormWishlist
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvFavorites);
            Name = "FormWishlist";
            Text = "FormWishlist";
            ((System.ComponentModel.ISupportInitialize)dgvFavorites).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvFavorites;
    }
}