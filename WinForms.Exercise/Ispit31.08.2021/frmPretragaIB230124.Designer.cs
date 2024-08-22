namespace WinForms.Exercise.Ispit31._08._2021
{
    partial class frmPretragaIB230124
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
            label1 = new Label();
            txtImePrezime = new TextBox();
            dgvPretraga = new DataGridView();
            ImePrezime = new DataGridViewTextBoxColumn();
            PolozeniPredmeti = new DataGridViewTextBoxColumn();
            BrojPolozenih = new DataGridViewTextBoxColumn();
            Prosjek = new DataGridViewTextBoxColumn();
            Ispiti = new DataGridViewButtonColumn();
            label2 = new Label();
            lblProsjekPrikazanihOcjena = new Label();
            label3 = new Label();
            lblNajveciProsjek = new Label();
            groupBox1 = new GroupBox();
            lblZnakovi = new Label();
            lblSuglasnici = new Label();
            lblSamoglasnici = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnGenerisiInfo = new Button();
            label4 = new Label();
            txtSadrzaj = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Ime ili prezime:";
            // 
            // txtImePrezime
            // 
            txtImePrezime.Location = new Point(105, 6);
            txtImePrezime.Name = "txtImePrezime";
            txtImePrezime.Size = new Size(409, 23);
            txtImePrezime.TabIndex = 1;
            txtImePrezime.TextChanged += txtImePrezime_TextChanged;
            // 
            // dgvPretraga
            // 
            dgvPretraga.AllowUserToAddRows = false;
            dgvPretraga.AllowUserToDeleteRows = false;
            dgvPretraga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPretraga.Columns.AddRange(new DataGridViewColumn[] { ImePrezime, PolozeniPredmeti, BrojPolozenih, Prosjek, Ispiti });
            dgvPretraga.Location = new Point(12, 35);
            dgvPretraga.Name = "dgvPretraga";
            dgvPretraga.ReadOnly = true;
            dgvPretraga.RowTemplate.Height = 25;
            dgvPretraga.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPretraga.Size = new Size(909, 307);
            dgvPretraga.TabIndex = 2;
            dgvPretraga.CellContentClick += dgvPretraga_CellContentClick;
            // 
            // ImePrezime
            // 
            ImePrezime.DataPropertyName = "ImePrezime";
            ImePrezime.HeaderText = "Ime i prezime";
            ImePrezime.Name = "ImePrezime";
            ImePrezime.ReadOnly = true;
            ImePrezime.Width = 150;
            // 
            // PolozeniPredmeti
            // 
            PolozeniPredmeti.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PolozeniPredmeti.DataPropertyName = "PolozeniPredmeti";
            PolozeniPredmeti.HeaderText = "Polozeni predmeti";
            PolozeniPredmeti.Name = "PolozeniPredmeti";
            PolozeniPredmeti.ReadOnly = true;
            // 
            // BrojPolozenih
            // 
            BrojPolozenih.DataPropertyName = "BrojPolozenih";
            BrojPolozenih.HeaderText = "Broj polozenih";
            BrojPolozenih.Name = "BrojPolozenih";
            BrojPolozenih.ReadOnly = true;
            // 
            // Prosjek
            // 
            Prosjek.DataPropertyName = "Prosjek";
            Prosjek.HeaderText = "Prosjek";
            Prosjek.Name = "Prosjek";
            Prosjek.ReadOnly = true;
            // 
            // Ispiti
            // 
            Ispiti.HeaderText = "";
            Ispiti.Name = "Ispiti";
            Ispiti.ReadOnly = true;
            Ispiti.Text = "Ispiti";
            Ispiti.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 345);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 3;
            label2.Text = "Prosjek prikazanih ocjena: ";
            // 
            // lblProsjekPrikazanihOcjena
            // 
            lblProsjekPrikazanihOcjena.AutoSize = true;
            lblProsjekPrikazanihOcjena.Location = new Point(153, 345);
            lblProsjekPrikazanihOcjena.Name = "lblProsjekPrikazanihOcjena";
            lblProsjekPrikazanihOcjena.Size = new Size(73, 15);
            lblProsjekPrikazanihOcjena.TabIndex = 4;
            lblProsjekPrikazanihOcjena.Text = "tempProsjek";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(677, 345);
            label3.Name = "label3";
            label3.Size = new Size(135, 15);
            label3.TabIndex = 5;
            label3.Text = "Najveci prosjek ostvario:";
            // 
            // lblNajveciProsjek
            // 
            lblNajveciProsjek.AutoSize = true;
            lblNajveciProsjek.Location = new Point(809, 345);
            lblNajveciProsjek.Name = "lblNajveciProsjek";
            lblNajveciProsjek.Size = new Size(112, 15);
            lblNajveciProsjek.TabIndex = 6;
            lblNajveciProsjek.Text = "tempNajveciProsjek";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblZnakovi);
            groupBox1.Controls.Add(lblSuglasnici);
            groupBox1.Controls.Add(lblSamoglasnici);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnGenerisiInfo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSadrzaj);
            groupBox1.Location = new Point(12, 380);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(909, 266);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Threading";
            // 
            // lblZnakovi
            // 
            lblZnakovi.AutoSize = true;
            lblZnakovi.Location = new Point(141, 236);
            lblZnakovi.Name = "lblZnakovi";
            lblZnakovi.Size = new Size(12, 15);
            lblZnakovi.TabIndex = 9;
            lblZnakovi.Text = "-";
            // 
            // lblSuglasnici
            // 
            lblSuglasnici.AutoSize = true;
            lblSuglasnici.Location = new Point(156, 221);
            lblSuglasnici.Name = "lblSuglasnici";
            lblSuglasnici.Size = new Size(12, 15);
            lblSuglasnici.TabIndex = 8;
            lblSuglasnici.Text = "-";
            // 
            // lblSamoglasnici
            // 
            lblSamoglasnici.AutoSize = true;
            lblSamoglasnici.Location = new Point(166, 204);
            lblSamoglasnici.Name = "lblSamoglasnici";
            lblSamoglasnici.Size = new Size(12, 15);
            lblSamoglasnici.TabIndex = 7;
            lblSamoglasnici.Text = "-";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(84, 236);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 6;
            label8.Text = "Znakova:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(84, 221);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 5;
            label7.Text = "Suglasnika:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(84, 204);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 4;
            label6.Text = "Samoglasnika: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 204);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 3;
            label5.Text = "Sadrzaj info:";
            // 
            // btnGenerisiInfo
            // 
            btnGenerisiInfo.Location = new Point(797, 204);
            btnGenerisiInfo.Name = "btnGenerisiInfo";
            btnGenerisiInfo.Size = new Size(106, 23);
            btnGenerisiInfo.TabIndex = 2;
            btnGenerisiInfo.Text = "Generisi info";
            btnGenerisiInfo.UseVisualStyleBackColor = true;
            btnGenerisiInfo.Click += btnGenerisiInfo_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 18);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 1;
            label4.Text = "Unesite sadrzaj:";
            // 
            // txtSadrzaj
            // 
            txtSadrzaj.Location = new Point(6, 36);
            txtSadrzaj.Multiline = true;
            txtSadrzaj.Name = "txtSadrzaj";
            txtSadrzaj.ScrollBars = ScrollBars.Vertical;
            txtSadrzaj.Size = new Size(897, 162);
            txtSadrzaj.TabIndex = 0;
            // 
            // frmPretragaIB230124
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 650);
            Controls.Add(groupBox1);
            Controls.Add(lblNajveciProsjek);
            Controls.Add(label3);
            Controls.Add(lblProsjekPrikazanihOcjena);
            Controls.Add(label2);
            Controls.Add(dgvPretraga);
            Controls.Add(txtImePrezime);
            Controls.Add(label1);
            Name = "frmPretragaIB230124";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pretraga";
            Load += frmPretragaIB230124_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtImePrezime;
        private DataGridView dgvPretraga;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn PolozeniPredmeti;
        private DataGridViewTextBoxColumn BrojPolozenih;
        private DataGridViewTextBoxColumn Prosjek;
        private DataGridViewButtonColumn Ispiti;
        private Label label2;
        private Label lblProsjekPrikazanihOcjena;
        private Label label3;
        private Label lblNajveciProsjek;
        private GroupBox groupBox1;
        private Label lblZnakovi;
        private Label lblSuglasnici;
        private Label lblSamoglasnici;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btnGenerisiInfo;
        private Label label4;
        private TextBox txtSadrzaj;
    }
}