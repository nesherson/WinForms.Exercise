namespace WinForms.Exercise.IspitIB230123
{
    partial class frmPretragaIB230123
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
            cmbSpol = new ComboBox();
            dtpRodjenDo = new DateTimePicker();
            label3 = new Label();
            dtpRodjenOd = new DateTimePicker();
            label4 = new Label();
            dgvStudentiPretraga = new DataGridView();
            ImePrezime = new DataGridViewTextBoxColumn();
            BrojIndeksa = new DataGridViewTextBoxColumn();
            Prosjek = new DataGridViewTextBoxColumn();
            DatumRodjenja = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Uvjerenja = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudentiPretraga).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "Spol";
            // 
            // cmbSpol
            // 
            cmbSpol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpol.FormattingEnabled = true;
            cmbSpol.Location = new Point(48, 6);
            cmbSpol.Name = "cmbSpol";
            cmbSpol.Size = new Size(83, 23);
            cmbSpol.TabIndex = 1;
            cmbSpol.SelectedIndexChanged += cmbSpol_SelectedIndexChanged;
            // 
            // dtpRodjenDo
            // 
            dtpRodjenDo.Location = new Point(488, 6);
            dtpRodjenDo.Name = "dtpRodjenDo";
            dtpRodjenDo.Size = new Size(200, 23);
            dtpRodjenDo.TabIndex = 2;
            dtpRodjenDo.ValueChanged += dtpRodjenDo_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(137, 9);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 4;
            label3.Text = "rodjen u periodu od";
            // 
            // dtpRodjenOd
            // 
            dtpRodjenOd.Location = new Point(255, 6);
            dtpRodjenOd.Name = "dtpRodjenOd";
            dtpRodjenOd.Size = new Size(200, 23);
            dtpRodjenOd.TabIndex = 5;
            dtpRodjenOd.ValueChanged += dtpRodjenOd_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(461, 12);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 6;
            label4.Text = "do";
            // 
            // dgvStudentiPretraga
            // 
            dgvStudentiPretraga.AllowUserToAddRows = false;
            dgvStudentiPretraga.AllowUserToDeleteRows = false;
            dgvStudentiPretraga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentiPretraga.Columns.AddRange(new DataGridViewColumn[] { ImePrezime, BrojIndeksa, Prosjek, DatumRodjenja, Aktivan, Uvjerenja });
            dgvStudentiPretraga.Location = new Point(12, 35);
            dgvStudentiPretraga.Name = "dgvStudentiPretraga";
            dgvStudentiPretraga.ReadOnly = true;
            dgvStudentiPretraga.RowTemplate.Height = 25;
            dgvStudentiPretraga.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudentiPretraga.Size = new Size(776, 360);
            dgvStudentiPretraga.TabIndex = 7;
            dgvStudentiPretraga.CellContentClick += dgvStudentiPretraga_CellContentClick;
            // 
            // ImePrezime
            // 
            ImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImePrezime.DataPropertyName = "ImePrezime";
            ImePrezime.HeaderText = "Ime i prezime";
            ImePrezime.Name = "ImePrezime";
            ImePrezime.ReadOnly = true;
            // 
            // BrojIndeksa
            // 
            BrojIndeksa.DataPropertyName = "BrojIndeksa";
            BrojIndeksa.HeaderText = "Broj indeksa";
            BrojIndeksa.Name = "BrojIndeksa";
            BrojIndeksa.ReadOnly = true;
            // 
            // Prosjek
            // 
            Prosjek.DataPropertyName = "Prosjek";
            Prosjek.HeaderText = "Prosjek";
            Prosjek.Name = "Prosjek";
            Prosjek.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            DatumRodjenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumRodjenja.DataPropertyName = "DatumRodjenja";
            DatumRodjenja.HeaderText = "Datum rodjenja";
            DatumRodjenja.Name = "DatumRodjenja";
            DatumRodjenja.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            Aktivan.Resizable = DataGridViewTriState.True;
            Aktivan.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Uvjerenja
            // 
            Uvjerenja.HeaderText = "";
            Uvjerenja.Name = "Uvjerenja";
            Uvjerenja.ReadOnly = true;
            Uvjerenja.Text = "Uvjerenja";
            Uvjerenja.UseColumnTextForButtonValue = true;
            // 
            // frmPretragaIB230123
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 406);
            Controls.Add(dgvStudentiPretraga);
            Controls.Add(label4);
            Controls.Add(dtpRodjenOd);
            Controls.Add(label3);
            Controls.Add(dtpRodjenDo);
            Controls.Add(cmbSpol);
            Controls.Add(label1);
            Name = "frmPretragaIB230123";
            Text = "frmPretragaIB230123";
            Load += frmPretragaIB230123_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudentiPretraga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbSpol;
        private DateTimePicker dtpRodjenDo;
        private Label label3;
        private DateTimePicker dtpRodjenOd;
        private Label label4;
        private DataGridView dgvStudentiPretraga;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn BrojIndeksa;
        private DataGridViewTextBoxColumn Prosjek;
        private DataGridViewTextBoxColumn DatumRodjenja;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Uvjerenja;
    }
}