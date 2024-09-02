namespace WinForms.Exercise.Ispit22._02._2024
{
    partial class frmPocetnaIB230003
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
            button1 = new Button();
            button2 = new Button();
            lblBrojStudenata = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(101, 225);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(138, 31);
            button1.TabIndex = 0;
            button1.Text = "Ispit 22.02.2024";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(101, 187);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(138, 31);
            button2.TabIndex = 1;
            button2.Text = "Izvjestaj";
            button2.UseVisualStyleBackColor = true;
            // 
            // lblBrojStudenata
            // 
            lblBrojStudenata.AutoSize = true;
            lblBrojStudenata.Font = new Font("Segoe UI", 16F);
            lblBrojStudenata.Location = new Point(48, 120);
            lblBrojStudenata.Name = "lblBrojStudenata";
            lblBrojStudenata.Size = new Size(302, 37);
            lblBrojStudenata.TabIndex = 2;
            lblBrojStudenata.Text = "Broj studenata u bazi ->";
            lblBrojStudenata.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmPocetnaIB230003
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 341);
            Controls.Add(lblBrojStudenata);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPocetnaIB230003";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Template 2023/24";
            Load += frmPocetnaIB230003_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label lblBrojStudenata;
    }
}