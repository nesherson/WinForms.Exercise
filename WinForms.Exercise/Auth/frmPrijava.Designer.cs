namespace WinForms.Exercise.Auth
{
    partial class frmPrijava
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtKorisnickoIme = new TextBox();
            btnPrijava = new Button();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            txtLozinka = new TextBox();
            label3 = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fit_znak_osnovni;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 240);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(321, 62);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "Korisnicko ime:";
            // 
            // txtKorisnickoIme
            // 
            txtKorisnickoIme.Location = new Point(321, 80);
            txtKorisnickoIme.Name = "txtKorisnickoIme";
            txtKorisnickoIme.Size = new Size(241, 23);
            txtKorisnickoIme.TabIndex = 2;
            // 
            // btnPrijava
            // 
            btnPrijava.Location = new Point(487, 229);
            btnPrijava.Name = "btnPrijava";
            btnPrijava.Size = new Size(75, 23);
            btnPrijava.TabIndex = 3;
            btnPrijava.Text = "Prijava";
            btnPrijava.UseVisualStyleBackColor = true;
            btnPrijava.Click += btnPrijava_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(321, 162);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(104, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Niste registrovani?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(388, 9);
            label2.Name = "label2";
            label2.Size = new Size(84, 30);
            label2.TabIndex = 5;
            label2.Text = "Prijava";
            // 
            // txtLozinka
            // 
            txtLozinka.Location = new Point(321, 136);
            txtLozinka.Name = "txtLozinka";
            txtLozinka.PasswordChar = '*';
            txtLozinka.Size = new Size(241, 23);
            txtLozinka.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(321, 118);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 6;
            label3.Text = "Lozinka:";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // frmPrijava
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 269);
            Controls.Add(txtLozinka);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(btnPrijava);
            Controls.Add(txtKorisnickoIme);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "frmPrijava";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DLWMS :: Prijava";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtKorisnickoIme;
        private Button btnPrijava;
        private LinkLabel linkLabel1;
        private Label label2;
        private TextBox txtLozinka;
        private Label label3;
        private ErrorProvider errorProvider;
    }
}