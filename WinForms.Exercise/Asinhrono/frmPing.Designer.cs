namespace WinForms.Exercise.Asinhrono
{
    partial class frmPing
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
            btnPing = new Button();
            txtSadrzaj = new TextBox();
            SuspendLayout();
            // 
            // btnPing
            // 
            btnPing.Location = new Point(373, 12);
            btnPing.Name = "btnPing";
            btnPing.Size = new Size(75, 23);
            btnPing.TabIndex = 0;
            btnPing.Text = "Ping";
            btnPing.UseVisualStyleBackColor = true;
            btnPing.Click += btnPing_Click;
            // 
            // txtSadrzaj
            // 
            txtSadrzaj.Location = new Point(12, 39);
            txtSadrzaj.Multiline = true;
            txtSadrzaj.Name = "txtSadrzaj";
            txtSadrzaj.Size = new Size(436, 290);
            txtSadrzaj.TabIndex = 1;
            // 
            // frmPing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 341);
            Controls.Add(txtSadrzaj);
            Controls.Add(btnPing);
            Name = "frmPing";
            Text = "frmPing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPing;
        private TextBox txtSadrzaj;
    }
}