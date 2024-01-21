namespace WinForms.Exercise.Auth
{
    partial class frmRegistracija
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
            txtIme = new TextBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            txtPrezime = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label6 = new Label();
            txtLozinka = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtKorisnickoIme = new TextBox();
            txtEmail = new TextBox();
            btnRegistracija = new Button();
            errorProvider = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // txtIme
            // 
            txtIme.Location = new Point(6, 37);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(212, 23);
            txtIme.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPrezime);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtIme);
            groupBox1.Location = new Point(23, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(232, 131);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Licni podaci";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 63);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 4;
            label3.Text = "Prezime";
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(6, 81);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(212, 23);
            txtPrezime.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 2;
            label1.Text = "Ime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(38, 9);
            label2.Name = "label2";
            label2.Size = new Size(133, 30);
            label2.TabIndex = 3;
            label2.Text = "Registracija";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtLozinka);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtKorisnickoIme);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Location = new Point(303, 55);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(232, 170);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Korisnicki podaci";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 107);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 10;
            label6.Text = "Lozinka:";
            // 
            // txtLozinka
            // 
            txtLozinka.Location = new Point(6, 125);
            txtLozinka.Name = "txtLozinka";
            txtLozinka.PasswordChar = '*';
            txtLozinka.Size = new Size(212, 23);
            txtLozinka.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 63);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 8;
            label4.Text = "Korisnicko ime:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 6;
            label5.Text = "Email:";
            // 
            // txtKorisnickoIme
            // 
            txtKorisnickoIme.Location = new Point(6, 81);
            txtKorisnickoIme.Name = "txtKorisnickoIme";
            txtKorisnickoIme.Size = new Size(212, 23);
            txtKorisnickoIme.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(6, 37);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(212, 23);
            txtEmail.TabIndex = 5;
            // 
            // btnRegistracija
            // 
            btnRegistracija.Location = new Point(460, 246);
            btnRegistracija.Name = "btnRegistracija";
            btnRegistracija.Size = new Size(75, 23);
            btnRegistracija.TabIndex = 4;
            btnRegistracija.Text = "Registracija";
            btnRegistracija.UseVisualStyleBackColor = true;
            btnRegistracija.Click += btnRegistracija_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // frmRegistracija
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 287);
            Controls.Add(btnRegistracija);
            Controls.Add(groupBox2);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Name = "frmRegistracija";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DLWMS :: Registracija";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtIme;
        private GroupBox groupBox1;
        private Label label2;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox txtPrezime;
        private Label label1;
        private Label label6;
        private TextBox txtLozinka;
        private Label label4;
        private Label label5;
        private TextBox txtKorisnickoIme;
        private TextBox txtEmail;
        private Button btnRegistracija;
        private ErrorProvider errorProvider;
    }
}