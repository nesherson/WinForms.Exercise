namespace WinForms.Exercise.Ispit22._02._2024
{
    partial class frmNovaProstorijaIB230003
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
            components = new System.ComponentModel.Container();
            pbLogo = new PictureBox();
            label1 = new Label();
            txtNaziv = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtOznaka = new TextBox();
            label4 = new Label();
            txtKapacitet = new TextBox();
            btnSacuvaj = new Button();
            openFileDialog1 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.BorderStyle = BorderStyle.FixedSingle;
            pbLogo.Location = new Point(12, 27);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(163, 143);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            pbLogo.MouseDoubleClick += pbLogo_MouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 1;
            label1.Text = "Logo:";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(187, 27);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(265, 23);
            txtNaziv.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 9);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Naziv:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(187, 53);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 5;
            label3.Text = "Oznaka:";
            // 
            // txtOznaka
            // 
            txtOznaka.Location = new Point(187, 71);
            txtOznaka.Name = "txtOznaka";
            txtOznaka.Size = new Size(149, 23);
            txtOznaka.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(349, 53);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 7;
            label4.Text = "Kapacitet:";
            // 
            // txtKapacitet
            // 
            txtKapacitet.Location = new Point(349, 71);
            txtKapacitet.Name = "txtKapacitet";
            txtKapacitet.Size = new Size(103, 23);
            txtKapacitet.TabIndex = 6;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(377, 147);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(75, 23);
            btnSacuvaj.TabIndex = 8;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmNovaProstorijaIB230003
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 198);
            Controls.Add(btnSacuvaj);
            Controls.Add(label4);
            Controls.Add(txtKapacitet);
            Controls.Add(label3);
            Controls.Add(txtOznaka);
            Controls.Add(label2);
            Controls.Add(txtNaziv);
            Controls.Add(label1);
            Controls.Add(pbLogo);
            Name = "frmNovaProstorijaIB230003";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Podaci o prostoriji";
            Load += frmNovaProstorijaIB230003_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Label label1;
        private TextBox txtNaziv;
        private Label label2;
        private Label label3;
        private TextBox txtOznaka;
        private Label label4;
        private TextBox txtKapacitet;
        private Button btnSacuvaj;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider errorProvider1;
    }
}