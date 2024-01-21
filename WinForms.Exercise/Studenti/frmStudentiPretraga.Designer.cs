namespace WinForms.Exercise.Studenti
{
    partial class frmStudentiPretraga
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
            dgvStudentiPretraga = new DataGridView();
            Ime = new DataGridViewTextBoxColumn();
            Prezime = new DataGridViewTextBoxColumn();
            DatumRodjenja = new DataGridViewTextBoxColumn();
            Indeks = new DataGridViewTextBoxColumn();
            Semestar = new DataGridViewTextBoxColumn();
            Slika = new DataGridViewImageColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Predmeti = new DataGridViewButtonColumn();
            btnStudentNovi = new Button();
            txtPretraga = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvStudentiPretraga).BeginInit();
            SuspendLayout();
            // 
            // dgvStudentiPretraga
            // 
            dgvStudentiPretraga.AllowUserToAddRows = false;
            dgvStudentiPretraga.AllowUserToDeleteRows = false;
            dgvStudentiPretraga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentiPretraga.Columns.AddRange(new DataGridViewColumn[] { Ime, Prezime, DatumRodjenja, Indeks, Semestar, Slika, Aktivan, Predmeti });
            dgvStudentiPretraga.Location = new Point(12, 42);
            dgvStudentiPretraga.Name = "dgvStudentiPretraga";
            dgvStudentiPretraga.ReadOnly = true;
            dgvStudentiPretraga.RowTemplate.Height = 25;
            dgvStudentiPretraga.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudentiPretraga.Size = new Size(776, 339);
            dgvStudentiPretraga.TabIndex = 0;
            dgvStudentiPretraga.CellContentClick += dgvStudentiPretraga_CellContentClick;
            // 
            // Ime
            // 
            Ime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ime.DataPropertyName = "Ime";
            Ime.HeaderText = "Ime";
            Ime.Name = "Ime";
            Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            Prezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Prezime.DataPropertyName = "Prezime";
            Prezime.HeaderText = "Prezime";
            Prezime.Name = "Prezime";
            Prezime.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            DatumRodjenja.DataPropertyName = "DatumRodjenja";
            DatumRodjenja.HeaderText = "DatumRodjenja";
            DatumRodjenja.Name = "DatumRodjenja";
            DatumRodjenja.ReadOnly = true;
            // 
            // Indeks
            // 
            Indeks.DataPropertyName = "Indeks";
            Indeks.HeaderText = "Indeks";
            Indeks.Name = "Indeks";
            Indeks.ReadOnly = true;
            // 
            // Semestar
            // 
            Semestar.DataPropertyName = "Semestar";
            Semestar.HeaderText = "Semestar";
            Semestar.Name = "Semestar";
            Semestar.ReadOnly = true;
            // 
            // Slika
            // 
            Slika.DataPropertyName = "Slika";
            Slika.HeaderText = "Slika";
            Slika.Name = "Slika";
            Slika.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            Aktivan.Width = 50;
            // 
            // Predmeti
            // 
            Predmeti.HeaderText = "";
            Predmeti.Name = "Predmeti";
            Predmeti.ReadOnly = true;
            Predmeti.Text = "Predmeti";
            Predmeti.UseColumnTextForButtonValue = true;
            // 
            // btnStudentNovi
            // 
            btnStudentNovi.Location = new Point(692, 12);
            btnStudentNovi.Name = "btnStudentNovi";
            btnStudentNovi.Size = new Size(96, 23);
            btnStudentNovi.TabIndex = 1;
            btnStudentNovi.Text = "Novi student";
            btnStudentNovi.UseVisualStyleBackColor = true;
            btnStudentNovi.Click += btnStudentNovi_Click;
            // 
            // txtPretraga
            // 
            txtPretraga.Location = new Point(12, 13);
            txtPretraga.Name = "txtPretraga";
            txtPretraga.Size = new Size(503, 23);
            txtPretraga.TabIndex = 2;
            txtPretraga.TextChanged += txtPretraga_TextChanged;
            // 
            // frmStudentiPretraga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 389);
            Controls.Add(txtPretraga);
            Controls.Add(btnStudentNovi);
            Controls.Add(dgvStudentiPretraga);
            Name = "frmStudentiPretraga";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmStudentiPretraga";
            Load += frmStudentiPretraga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudentiPretraga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudentiPretraga;
        private Button btnStudentNovi;
        private TextBox txtPretraga;
        private DataGridViewTextBoxColumn Ime;
        private DataGridViewTextBoxColumn Prezime;
        private DataGridViewTextBoxColumn DatumRodjenja;
        private DataGridViewTextBoxColumn Indeks;
        private DataGridViewTextBoxColumn Semestar;
        private DataGridViewImageColumn Slika;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Predmeti;
    }
}