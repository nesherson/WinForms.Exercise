namespace WinForms.Exercise.Ispit31._08._2021
{
    partial class frmPretragaIB230004
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
            dgvStudenti = new DataGridView();
            ImePrezime = new DataGridViewTextBoxColumn();
            PolozeniPredmeti = new DataGridViewTextBoxColumn();
            BrojPolozenih = new DataGridViewTextBoxColumn();
            Prosjek = new DataGridViewTextBoxColumn();
            btnIspiti = new DataGridViewButtonColumn();
            lblProsjekOcjena = new Label();
            lblNajveciProsjek = new Label();
            groupBox1 = new GroupBox();
            lblBrojZnakova = new Label();
            lblBrojSuglasnika = new Label();
            lblBrojSamoglasnika = new Label();
            label3 = new Label();
            btnGenerisiInfo = new Button();
            txtSadrzaj = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Ime ili prezime:";
            // 
            // txtImePrezime
            // 
            txtImePrezime.Location = new Point(142, 9);
            txtImePrezime.Name = "txtImePrezime";
            txtImePrezime.Size = new Size(770, 27);
            txtImePrezime.TabIndex = 1;
            txtImePrezime.TextChanged += txtImePrezime_TextChanged;
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { ImePrezime, PolozeniPredmeti, BrojPolozenih, Prosjek, btnIspiti });
            dgvStudenti.Location = new Point(12, 42);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowHeadersWidth = 51;
            dgvStudenti.RowTemplate.Height = 29;
            dgvStudenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudenti.Size = new Size(900, 311);
            dgvStudenti.TabIndex = 2;
            dgvStudenti.CellContentClick += dgvStudenti_CellContentClick;
            // 
            // ImePrezime
            // 
            ImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImePrezime.DataPropertyName = "ImePrezime";
            ImePrezime.HeaderText = "Ime i prezime";
            ImePrezime.MinimumWidth = 6;
            ImePrezime.Name = "ImePrezime";
            ImePrezime.ReadOnly = true;
            // 
            // PolozeniPredmeti
            // 
            PolozeniPredmeti.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PolozeniPredmeti.DataPropertyName = "PolozeniPredmeti";
            PolozeniPredmeti.HeaderText = "Položeni predmeti";
            PolozeniPredmeti.MinimumWidth = 6;
            PolozeniPredmeti.Name = "PolozeniPredmeti";
            PolozeniPredmeti.ReadOnly = true;
            // 
            // BrojPolozenih
            // 
            BrojPolozenih.DataPropertyName = "BrojPolozenih";
            BrojPolozenih.HeaderText = "Broj položenih";
            BrojPolozenih.MinimumWidth = 6;
            BrojPolozenih.Name = "BrojPolozenih";
            BrojPolozenih.ReadOnly = true;
            BrojPolozenih.Width = 125;
            // 
            // Prosjek
            // 
            Prosjek.DataPropertyName = "Prosjek";
            Prosjek.HeaderText = "Prosjek";
            Prosjek.MinimumWidth = 6;
            Prosjek.Name = "Prosjek";
            Prosjek.ReadOnly = true;
            Prosjek.Width = 125;
            // 
            // btnIspiti
            // 
            btnIspiti.HeaderText = "";
            btnIspiti.MinimumWidth = 6;
            btnIspiti.Name = "btnIspiti";
            btnIspiti.ReadOnly = true;
            btnIspiti.Resizable = DataGridViewTriState.True;
            btnIspiti.SortMode = DataGridViewColumnSortMode.Automatic;
            btnIspiti.Text = "Ispiti";
            btnIspiti.UseColumnTextForButtonValue = true;
            btnIspiti.Width = 125;
            // 
            // lblProsjekOcjena
            // 
            lblProsjekOcjena.AutoSize = true;
            lblProsjekOcjena.Location = new Point(12, 356);
            lblProsjekOcjena.Name = "lblProsjekOcjena";
            lblProsjekOcjena.Size = new Size(179, 20);
            lblProsjekOcjena.TabIndex = 3;
            lblProsjekOcjena.Text = "Prosjek prikazanih ocjena:";
            // 
            // lblNajveciProsjek
            // 
            lblNajveciProsjek.AutoSize = true;
            lblNajveciProsjek.Location = new Point(663, 356);
            lblNajveciProsjek.Name = "lblNajveciProsjek";
            lblNajveciProsjek.Size = new Size(165, 20);
            lblNajveciProsjek.TabIndex = 4;
            lblNajveciProsjek.Text = "Najveći prosjek osvario:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblBrojZnakova);
            groupBox1.Controls.Add(lblBrojSuglasnika);
            groupBox1.Controls.Add(lblBrojSamoglasnika);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnGenerisiInfo);
            groupBox1.Controls.Add(txtSadrzaj);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 389);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(900, 281);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Threading";
            // 
            // lblBrojZnakova
            // 
            lblBrojZnakova.AutoSize = true;
            lblBrojZnakova.Location = new Point(103, 232);
            lblBrojZnakova.Name = "lblBrojZnakova";
            lblBrojZnakova.Size = new Size(127, 20);
            lblBrojZnakova.TabIndex = 11;
            lblBrojZnakova.Text = "Znakova(!,?,<,>,*):";
            // 
            // lblBrojSuglasnika
            // 
            lblBrojSuglasnika.AutoSize = true;
            lblBrojSuglasnika.Location = new Point(103, 212);
            lblBrojSuglasnika.Name = "lblBrojSuglasnika";
            lblBrojSuglasnika.Size = new Size(82, 20);
            lblBrojSuglasnika.TabIndex = 10;
            lblBrojSuglasnika.Text = "Suglasnika:";
            // 
            // lblBrojSamoglasnika
            // 
            lblBrojSamoglasnika.AutoSize = true;
            lblBrojSamoglasnika.Location = new Point(103, 192);
            lblBrojSamoglasnika.Name = "lblBrojSamoglasnika";
            lblBrojSamoglasnika.Size = new Size(104, 20);
            lblBrojSamoglasnika.TabIndex = 9;
            lblBrojSamoglasnika.Text = "Samoglasnika:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 192);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 8;
            label3.Text = "Sadržaj info:";
            // 
            // btnGenerisiInfo
            // 
            btnGenerisiInfo.Location = new Point(772, 192);
            btnGenerisiInfo.Name = "btnGenerisiInfo";
            btnGenerisiInfo.Size = new Size(122, 29);
            btnGenerisiInfo.TabIndex = 7;
            btnGenerisiInfo.Text = "Generiši info";
            btnGenerisiInfo.UseVisualStyleBackColor = true;
            btnGenerisiInfo.Click += btnGenerisiInfo_Click;
            // 
            // txtSadrzaj
            // 
            txtSadrzaj.Location = new Point(6, 46);
            txtSadrzaj.Multiline = true;
            txtSadrzaj.Name = "txtSadrzaj";
            txtSadrzaj.Size = new Size(888, 140);
            txtSadrzaj.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 23);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 6;
            label2.Text = "Unesite sadržaj:";
            // 
            // frmPretragaIB230004
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 682);
            Controls.Add(groupBox1);
            Controls.Add(lblNajveciProsjek);
            Controls.Add(lblProsjekOcjena);
            Controls.Add(dgvStudenti);
            Controls.Add(txtImePrezime);
            Controls.Add(label1);
            Name = "frmPretragaIB230004";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pretraga";
            Load += frmPretragaIB230004_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtImePrezime;
        private DataGridView dgvStudenti;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn PolozeniPredmeti;
        private DataGridViewTextBoxColumn BrojPolozenih;
        private DataGridViewTextBoxColumn Prosjek;
        private DataGridViewButtonColumn btnIspiti;
        private Label lblProsjekOcjena;
        private Label lblNajveciProsjek;
        private GroupBox groupBox1;
        private Label label3;
        private Button btnGenerisiInfo;
        private TextBox txtSadrzaj;
        private Label label2;
        private Label lblBrojZnakova;
        private Label lblBrojSuglasnika;
        private Label lblBrojSamoglasnika;
    }
}