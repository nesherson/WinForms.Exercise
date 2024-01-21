namespace WinForms.Exercise.Studenti
{
    partial class frmStudentNovi
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
            cmbSemestar = new ComboBox();
            pbSlika = new PictureBox();
            btnUcitajSliku = new Button();
            btnSacuvaj = new Button();
            groupBox1 = new GroupBox();
            dtpDatumRodjenja = new DateTimePicker();
            label5 = new Label();
            txtPrezime = new TextBox();
            label4 = new Label();
            txtIme = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            txtBrojIndeksa = new TextBox();
            label10 = new Label();
            txtLozinka = new TextBox();
            label9 = new Label();
            label8 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtKorisnickoIme = new TextBox();
            label6 = new Label();
            lblNaslov = new Label();
            groupBox3 = new GroupBox();
            cmbUloge = new ComboBox();
            btnUlogaDodaj = new Button();
            dgvStudentUloge = new DataGridView();
            Naziv = new DataGridViewTextBoxColumn();
            openFileDialog = new OpenFileDialog();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudentUloge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // cmbSemestar
            // 
            cmbSemestar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSemestar.FormattingEnabled = true;
            cmbSemestar.Location = new Point(7, 230);
            cmbSemestar.Name = "cmbSemestar";
            cmbSemestar.Size = new Size(232, 23);
            cmbSemestar.TabIndex = 2;
            // 
            // pbSlika
            // 
            pbSlika.BorderStyle = BorderStyle.FixedSingle;
            pbSlika.Location = new Point(12, 47);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(236, 253);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 3;
            pbSlika.TabStop = false;
            // 
            // btnUcitajSliku
            // 
            btnUcitajSliku.Location = new Point(12, 312);
            btnUcitajSliku.Name = "btnUcitajSliku";
            btnUcitajSliku.Size = new Size(236, 23);
            btnUcitajSliku.TabIndex = 5;
            btnUcitajSliku.Text = "Ucitaj sliku";
            btnUcitajSliku.UseVisualStyleBackColor = true;
            btnUcitajSliku.Click += btnUcitajSliku_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(820, 461);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(75, 23);
            btnSacuvaj.TabIndex = 6;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpDatumRodjenja);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPrezime);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtIme);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(282, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 168);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Licni podaci";
            // 
            // dtpDatumRodjenja
            // 
            dtpDatumRodjenja.Location = new Point(6, 131);
            dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            dtpDatumRodjenja.Size = new Size(233, 23);
            dtpDatumRodjenja.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 107);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 11;
            label5.Text = "Datum rodjenja:";
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(6, 81);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(233, 23);
            txtPrezime.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 63);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 12;
            label4.Text = "Prezime:";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(6, 37);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(233, 23);
            txtIme.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 10;
            label3.Text = "Ime:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtBrojIndeksa);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtLozinka);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cmbSemestar);
            groupBox2.Controls.Add(txtKorisnickoIme);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(282, 219);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(245, 265);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Korisnicki podaci";
            // 
            // txtBrojIndeksa
            // 
            txtBrojIndeksa.Location = new Point(7, 186);
            txtBrojIndeksa.Name = "txtBrojIndeksa";
            txtBrojIndeksa.Size = new Size(232, 23);
            txtBrojIndeksa.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 212);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 10;
            label10.Text = "Semestar:";
            // 
            // txtLozinka
            // 
            txtLozinka.Location = new Point(6, 142);
            txtLozinka.Name = "txtLozinka";
            txtLozinka.Size = new Size(233, 23);
            txtLozinka.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 168);
            label9.Name = "label9";
            label9.Size = new Size(74, 15);
            label9.TabIndex = 10;
            label9.Text = "Broj indeksa:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 124);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 14;
            label8.Text = "Lozinka:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(6, 86);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(233, 23);
            txtEmail.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 68);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 12;
            label7.Text = "Email:";
            // 
            // txtKorisnickoIme
            // 
            txtKorisnickoIme.Location = new Point(6, 37);
            txtKorisnickoIme.Name = "txtKorisnickoIme";
            txtKorisnickoIme.Size = new Size(233, 23);
            txtKorisnickoIme.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 19);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 10;
            label6.Text = "Korisnicko ime:";
            // 
            // lblNaslov
            // 
            lblNaslov.AutoSize = true;
            lblNaslov.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblNaslov.Location = new Point(12, 9);
            lblNaslov.Name = "lblNaslov";
            lblNaslov.Size = new Size(147, 30);
            lblNaslov.TabIndex = 9;
            lblNaslov.Text = "Novi student";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cmbUloge);
            groupBox3.Controls.Add(btnUlogaDodaj);
            groupBox3.Controls.Add(dgvStudentUloge);
            groupBox3.Location = new Point(560, 45);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(335, 202);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Uloge";
            // 
            // cmbUloge
            // 
            cmbUloge.FormattingEnabled = true;
            cmbUloge.Location = new Point(6, 15);
            cmbUloge.Name = "cmbUloge";
            cmbUloge.Size = new Size(191, 23);
            cmbUloge.TabIndex = 12;
            // 
            // btnUlogaDodaj
            // 
            btnUlogaDodaj.Location = new Point(231, 15);
            btnUlogaDodaj.Name = "btnUlogaDodaj";
            btnUlogaDodaj.Size = new Size(97, 23);
            btnUlogaDodaj.TabIndex = 11;
            btnUlogaDodaj.Text = "Dodaj";
            btnUlogaDodaj.UseVisualStyleBackColor = true;
            btnUlogaDodaj.Click += btnUlogaDodaj_Click;
            // 
            // dgvStudentUloge
            // 
            dgvStudentUloge.AllowUserToAddRows = false;
            dgvStudentUloge.AllowUserToDeleteRows = false;
            dgvStudentUloge.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentUloge.Columns.AddRange(new DataGridViewColumn[] { Naziv });
            dgvStudentUloge.Location = new Point(6, 44);
            dgvStudentUloge.Name = "dgvStudentUloge";
            dgvStudentUloge.ReadOnly = true;
            dgvStudentUloge.RowTemplate.Height = 25;
            dgvStudentUloge.Size = new Size(322, 150);
            dgvStudentUloge.TabIndex = 0;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv";
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // frmStudentNovi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 493);
            Controls.Add(groupBox3);
            Controls.Add(lblNaslov);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnUcitajSliku);
            Controls.Add(pbSlika);
            Name = "frmStudentNovi";
            Text = "DLWMS :: Dodavanje studenta";
            Load += frmStudentNovi_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudentUloge).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private ComboBox cmbSemestar;
        private PictureBox pbSlika;
        private Button button1;
        private Button btnUcitajSliku;
        private Button btnSacuvaj;
        private GroupBox groupBox1;
        private DateTimePicker dtpDatumRodjenja;
        private Label label5;
        private TextBox txtPrezime;
        private Label label4;
        private TextBox txtIme;
        private Label label3;
        private GroupBox groupBox2;
        private Label lblNaslov;
        private TextBox txtLozinka;
        private Label label8;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtKorisnickoIme;
        private Label label6;
        private TextBox txtBrojIndeksa;
        private Label label10;
        private Label label9;
        private GroupBox groupBox3;
        private Button btnUlogaDodaj;
        private DataGridView dgvStudentUloge;
        private DataGridViewTextBoxColumn Naziv;
        private ComboBox cmbUloge;
        private OpenFileDialog openFileDialog;
        private ErrorProvider errorProvider;
    }
}