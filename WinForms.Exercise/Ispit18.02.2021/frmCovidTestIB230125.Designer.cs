namespace WinForms.Exercise.Ispit18._02._2021
{
    partial class frmCovidTestIB230125
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
            cmbStudent = new ComboBox();
            cmbRezultatTesta = new ComboBox();
            dtpDatumTestiranja = new DateTimePicker();
            label1 = new Label();
            btnDodaj = new Button();
            cbNalazDostavljen = new CheckBox();
            dgvStudentCovidTest = new DataGridView();
            Student = new DataGridViewTextBoxColumn();
            Datum = new DataGridViewTextBoxColumn();
            Rezultat = new DataGridViewTextBoxColumn();
            NalazDostavljen = new DataGridViewCheckBoxColumn();
            label2 = new Label();
            label3 = new Label();
            errorProvider = new ErrorProvider(components);
            label4 = new Label();
            lblBrojTestova = new Label();
            groupBox1 = new GroupBox();
            btnGenerisi = new Button();
            txtBrojTestova = new TextBox();
            label5 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            btnPrintaj = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudentCovidTest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // cmbStudent
            // 
            cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(12, 27);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(180, 23);
            cmbStudent.TabIndex = 0;
            // 
            // cmbRezultatTesta
            // 
            cmbRezultatTesta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRezultatTesta.FormattingEnabled = true;
            cmbRezultatTesta.Items.AddRange(new object[] { "Negativan", "Pozitivan" });
            cmbRezultatTesta.Location = new Point(421, 26);
            cmbRezultatTesta.Name = "cmbRezultatTesta";
            cmbRezultatTesta.Size = new Size(139, 23);
            cmbRezultatTesta.TabIndex = 1;
            // 
            // dtpDatumTestiranja
            // 
            dtpDatumTestiranja.Location = new Point(198, 27);
            dtpDatumTestiranja.Name = "dtpDatumTestiranja";
            dtpDatumTestiranja.Size = new Size(217, 23);
            dtpDatumTestiranja.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Student:";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(713, 27);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // cbNalazDostavljen
            // 
            cbNalazDostavljen.AutoSize = true;
            cbNalazDostavljen.Location = new Point(566, 30);
            cbNalazDostavljen.Name = "cbNalazDostavljen";
            cbNalazDostavljen.Size = new Size(112, 19);
            cbNalazDostavljen.TabIndex = 5;
            cbNalazDostavljen.Text = "Nalaz dostavljen";
            cbNalazDostavljen.UseVisualStyleBackColor = true;
            // 
            // dgvStudentCovidTest
            // 
            dgvStudentCovidTest.AllowUserToAddRows = false;
            dgvStudentCovidTest.AllowUserToDeleteRows = false;
            dgvStudentCovidTest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentCovidTest.Columns.AddRange(new DataGridViewColumn[] { Student, Datum, Rezultat, NalazDostavljen });
            dgvStudentCovidTest.Location = new Point(12, 55);
            dgvStudentCovidTest.Name = "dgvStudentCovidTest";
            dgvStudentCovidTest.ReadOnly = true;
            dgvStudentCovidTest.RowTemplate.Height = 25;
            dgvStudentCovidTest.Size = new Size(776, 295);
            dgvStudentCovidTest.TabIndex = 6;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "Student";
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // Datum
            // 
            Datum.DataPropertyName = "Datum";
            Datum.HeaderText = "Datum";
            Datum.Name = "Datum";
            Datum.ReadOnly = true;
            // 
            // Rezultat
            // 
            Rezultat.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Rezultat.DataPropertyName = "Rezultat";
            Rezultat.HeaderText = "Rezultat";
            Rezultat.Name = "Rezultat";
            Rezultat.ReadOnly = true;
            // 
            // NalazDostavljen
            // 
            NalazDostavljen.DataPropertyName = "NalazDostavljen";
            NalazDostavljen.HeaderText = "Nalaz dostavljen";
            NalazDostavljen.Name = "NalazDostavljen";
            NalazDostavljen.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 9);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 7;
            label2.Text = "Datum testiranja:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(421, 9);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 8;
            label3.Text = "Rezultat testa:";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 353);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 9;
            label4.Text = "Broj testova: ";
            // 
            // lblBrojTestova
            // 
            lblBrojTestova.AutoSize = true;
            lblBrojTestova.Location = new Point(83, 353);
            lblBrojTestova.Name = "lblBrojTestova";
            lblBrojTestova.Size = new Size(12, 15);
            lblBrojTestova.TabIndex = 10;
            lblBrojTestova.Text = "-";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Controls.Add(txtBrojTestova);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(130, 356);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 54);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generisanje testova";
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(184, 16);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(75, 23);
            btnGenerisi.TabIndex = 12;
            btnGenerisi.Text = "Generisi";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // txtBrojTestova
            // 
            txtBrojTestova.Location = new Point(78, 16);
            txtBrojTestova.Name = "txtBrojTestova";
            txtBrojTestova.Size = new Size(100, 23);
            txtBrojTestova.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 12;
            label5.Text = "Broj testova: ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(402, 356);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(139, 54);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Brisanje testova";
            // 
            // button1
            // 
            button1.Location = new Point(6, 19);
            button1.Name = "button1";
            button1.Size = new Size(124, 23);
            button1.TabIndex = 12;
            button1.Text = "OBRISI TESTOVE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(701, 387);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(87, 23);
            btnPrintaj.TabIndex = 13;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += btnPrintaj_Click;
            // 
            // frmCovidTestIB230125
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 419);
            Controls.Add(btnPrintaj);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblBrojTestova);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvStudentCovidTest);
            Controls.Add(cbNalazDostavljen);
            Controls.Add(btnDodaj);
            Controls.Add(label1);
            Controls.Add(dtpDatumTestiranja);
            Controls.Add(cmbRezultatTesta);
            Controls.Add(cmbStudent);
            Name = "frmCovidTestIB230125";
            Text = "Rezultati COVID testiranja";
            Load += frmCovidTestIB230125_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudentCovidTest).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbStudent;
        private ComboBox cmbRezultatTesta;
        private DateTimePicker dtpDatumTestiranja;
        private Label label1;
        private Button btnDodaj;
        private CheckBox cbNalazDostavljen;
        private DataGridView dgvStudentCovidTest;
        private Label label2;
        private Label label3;
        private ErrorProvider errorProvider;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewTextBoxColumn Rezultat;
        private DataGridViewCheckBoxColumn NalazDostavljen;
        private Label lblBrojTestova;
        private Label label4;
        private Button btnPrintaj;
        private GroupBox groupBox2;
        private Button button1;
        private GroupBox groupBox1;
        private Button btnGenerisi;
        private TextBox txtBrojTestova;
        private Label label5;
    }
}