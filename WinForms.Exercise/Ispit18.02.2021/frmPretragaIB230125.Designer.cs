namespace WinForms.Exercise.Ispit18._02._2021
{
    partial class frmPretragaIB230125
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
            dtpOd = new DateTimePicker();
            dtpDo = new DateTimePicker();
            cmbZnak = new ComboBox();
            cmbOcjena = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dgvPretraga = new DataGridView();
            BrojIndeksa = new DataGridViewTextBoxColumn();
            Ime = new DataGridViewTextBoxColumn();
            Prezime = new DataGridViewTextBoxColumn();
            Spol = new DataGridViewTextBoxColumn();
            GodinaStudija = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Polozeni = new DataGridViewButtonColumn();
            label4 = new Label();
            label5 = new Label();
            lblBrojStudenata = new Label();
            lblProsjecnaOcjena = new Label();
            errorProvider = new ErrorProvider(components);
            btnCovid = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // dtpOd
            // 
            dtpOd.Location = new Point(35, 10);
            dtpOd.Name = "dtpOd";
            dtpOd.Size = new Size(200, 23);
            dtpOd.TabIndex = 0;
            dtpOd.ValueChanged += dtpOd_ValueChanged;
            // 
            // dtpDo
            // 
            dtpDo.Location = new Point(283, 10);
            dtpDo.Name = "dtpDo";
            dtpDo.Size = new Size(200, 23);
            dtpDo.TabIndex = 1;
            dtpDo.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // cmbZnak
            // 
            cmbZnak.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbZnak.FormattingEnabled = true;
            cmbZnak.Items.AddRange(new object[] { "=", ">", ">=", "<", "<=" });
            cmbZnak.Location = new Point(612, 12);
            cmbZnak.Name = "cmbZnak";
            cmbZnak.Size = new Size(97, 23);
            cmbZnak.TabIndex = 2;
            cmbZnak.SelectedIndexChanged += cmbZnak_SelectedIndexChanged;
            // 
            // cmbOcjena
            // 
            cmbOcjena.FormattingEnabled = true;
            cmbOcjena.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
            cmbOcjena.Location = new Point(715, 13);
            cmbOcjena.Name = "cmbOcjena";
            cmbOcjena.Size = new Size(97, 23);
            cmbOcjena.TabIndex = 3;
            cmbOcjena.SelectedIndexChanged += cmbOcjena_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 4;
            label1.Text = "Od:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 16);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 5;
            label2.Text = "Do:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(559, 16);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 6;
            label3.Text = "Ocjena:";
            // 
            // dgvPretraga
            // 
            dgvPretraga.AllowUserToAddRows = false;
            dgvPretraga.AllowUserToDeleteRows = false;
            dgvPretraga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPretraga.Columns.AddRange(new DataGridViewColumn[] { BrojIndeksa, Ime, Prezime, Spol, GodinaStudija, Aktivan, Polozeni });
            dgvPretraga.Location = new Point(12, 48);
            dgvPretraga.Name = "dgvPretraga";
            dgvPretraga.ReadOnly = true;
            dgvPretraga.RowTemplate.Height = 25;
            dgvPretraga.Size = new Size(843, 267);
            dgvPretraga.TabIndex = 7;
            // 
            // BrojIndeksa
            // 
            BrojIndeksa.DataPropertyName = "Indeks";
            BrojIndeksa.HeaderText = "Indeks";
            BrojIndeksa.Name = "BrojIndeksa";
            BrojIndeksa.ReadOnly = true;
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
            // Spol
            // 
            Spol.DataPropertyName = "Spol";
            Spol.HeaderText = "Spol";
            Spol.Name = "Spol";
            Spol.ReadOnly = true;
            // 
            // GodinaStudija
            // 
            GodinaStudija.DataPropertyName = "GodinaStudija";
            GodinaStudija.HeaderText = "Godina studija";
            GodinaStudija.Name = "GodinaStudija";
            GodinaStudija.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            // 
            // Polozeni
            // 
            Polozeni.HeaderText = "Polozeni";
            Polozeni.Name = "Polozeni";
            Polozeni.ReadOnly = true;
            Polozeni.Resizable = DataGridViewTriState.True;
            Polozeni.SortMode = DataGridViewColumnSortMode.Automatic;
            Polozeni.Text = "Polozeni";
            Polozeni.UseColumnTextForButtonValue = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 318);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 8;
            label4.Text = "Broj studenata:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 333);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 9;
            label5.Text = "Prosjecna ocjena:";
            // 
            // lblBrojStudenata
            // 
            lblBrojStudenata.AutoSize = true;
            lblBrojStudenata.Location = new Point(104, 318);
            lblBrojStudenata.Name = "lblBrojStudenata";
            lblBrojStudenata.Size = new Size(12, 15);
            lblBrojStudenata.TabIndex = 10;
            lblBrojStudenata.Text = "-";
            // 
            // lblProsjecnaOcjena
            // 
            lblProsjecnaOcjena.AutoSize = true;
            lblProsjecnaOcjena.Location = new Point(117, 333);
            lblProsjecnaOcjena.Name = "lblProsjecnaOcjena";
            lblProsjecnaOcjena.Size = new Size(12, 15);
            lblProsjecnaOcjena.TabIndex = 11;
            lblProsjecnaOcjena.Text = "-";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // btnCovid
            // 
            btnCovid.Location = new Point(780, 325);
            btnCovid.Name = "btnCovid";
            btnCovid.Size = new Size(75, 23);
            btnCovid.TabIndex = 12;
            btnCovid.Text = "COVID";
            btnCovid.UseVisualStyleBackColor = true;
            btnCovid.Click += btnCovid_Click;
            // 
            // frmPretragaIB230125
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 363);
            Controls.Add(btnCovid);
            Controls.Add(lblProsjecnaOcjena);
            Controls.Add(lblBrojStudenata);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dgvPretraga);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbOcjena);
            Controls.Add(cmbZnak);
            Controls.Add(dtpDo);
            Controls.Add(dtpOd);
            Name = "frmPretragaIB230125";
            Text = "Studenti";
            Load += frmPretragaIB230125_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpOd;
        private DateTimePicker dtpDo;
        private ComboBox cmbZnak;
        private ComboBox cmbOcjena;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgvPretraga;
        private Label label4;
        private Label label5;
        private Label lblBrojStudenata;
        private Label lblProsjecnaOcjena;
        private DataGridViewTextBoxColumn BrojIndeksa;
        private DataGridViewTextBoxColumn Ime;
        private DataGridViewTextBoxColumn Prezime;
        private DataGridViewTextBoxColumn Spol;
        private DataGridViewTextBoxColumn GodinaStudija;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Polozeni;
        private ErrorProvider errorProvider;
        private Button btnCovid;
    }
}