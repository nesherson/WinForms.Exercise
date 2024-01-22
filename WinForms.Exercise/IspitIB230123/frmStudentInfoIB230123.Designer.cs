namespace WinForms.Exercise.IspitIB230123
{
    partial class frmStudentInfoIB230123
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
            pbSlika = new PictureBox();
            lblImePrezime = new Label();
            label2 = new Label();
            lblProsjek = new Label();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(12, 12);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(279, 219);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            // 
            // lblImePrezime
            // 
            lblImePrezime.AutoSize = true;
            lblImePrezime.Font = new Font("Segoe UI", 14F);
            lblImePrezime.Location = new Point(92, 251);
            lblImePrezime.Name = "lblImePrezime";
            lblImePrezime.Size = new Size(111, 25);
            lblImePrezime.TabIndex = 1;
            lblImePrezime.Text = "imePrezime";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(103, 285);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 2;
            label2.Text = "Prosjek: ";
            // 
            // lblProsjek
            // 
            lblProsjek.AutoSize = true;
            lblProsjek.Font = new Font("Segoe UI", 11F);
            lblProsjek.Location = new Point(157, 285);
            lblProsjek.Name = "lblProsjek";
            lblProsjek.Size = new Size(57, 20);
            lblProsjek.TabIndex = 3;
            lblProsjek.Text = "prosjek";
            // 
            // frmStudentInfoIB230123
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 325);
            Controls.Add(lblProsjek);
            Controls.Add(label2);
            Controls.Add(lblImePrezime);
            Controls.Add(pbSlika);
            Name = "frmStudentInfoIB230123";
            Text = "frmStudentInfoIB230123";
            Load += frmStudentInfoIB230123_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private Label lblImePrezime;
        private Label label2;
        private Label lblProsjek;
    }
}