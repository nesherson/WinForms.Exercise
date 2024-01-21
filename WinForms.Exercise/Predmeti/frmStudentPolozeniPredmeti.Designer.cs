namespace WinForms.Exercise.Predmeti
{
    partial class frmStudentPolozeniPredmeti
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
            dgvPolozeniPredmeti = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Ocjena = new DataGridViewTextBoxColumn();
            DatumPolaganja = new DataGridViewTextBoxColumn();
            label1 = new Label();
            cmbPredmet = new ComboBox();
            cmbOcjena = new ComboBox();
            dtpDatumPolaganja = new DateTimePicker();
            btnDodaj = new Button();
            label2 = new Label();
            label3 = new Label();
            lblImePrezime = new Label();
            lblBrojIndeksa = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPolozeniPredmeti).BeginInit();
            SuspendLayout();
            // 
            // dgvPolozeniPredmeti
            // 
            dgvPolozeniPredmeti.AllowUserToAddRows = false;
            dgvPolozeniPredmeti.AllowUserToDeleteRows = false;
            dgvPolozeniPredmeti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPolozeniPredmeti.Columns.AddRange(new DataGridViewColumn[] { Predmet, Ocjena, DatumPolaganja });
            dgvPolozeniPredmeti.Location = new Point(13, 141);
            dgvPolozeniPredmeti.Name = "dgvPolozeniPredmeti";
            dgvPolozeniPredmeti.ReadOnly = true;
            dgvPolozeniPredmeti.RowTemplate.Height = 25;
            dgvPolozeniPredmeti.Size = new Size(524, 256);
            dgvPolozeniPredmeti.TabIndex = 0;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            // 
            // Ocjena
            // 
            Ocjena.DataPropertyName = "Ocjena";
            Ocjena.HeaderText = "Ocjena";
            Ocjena.Name = "Ocjena";
            Ocjena.ReadOnly = true;
            // 
            // DatumPolaganja
            // 
            DatumPolaganja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumPolaganja.DataPropertyName = "DatumPolaganja";
            DatumPolaganja.HeaderText = "DatumPolaganja";
            DatumPolaganja.Name = "DatumPolaganja";
            DatumPolaganja.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 94);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 1;
            label1.Text = "Predmet:";
            // 
            // cmbPredmet
            // 
            cmbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(13, 112);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(158, 23);
            cmbPredmet.TabIndex = 2;
            // 
            // cmbOcjena
            // 
            cmbOcjena.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOcjena.FormattingEnabled = true;
            cmbOcjena.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
            cmbOcjena.Location = new Point(177, 112);
            cmbOcjena.Name = "cmbOcjena";
            cmbOcjena.Size = new Size(53, 23);
            cmbOcjena.TabIndex = 3;
            // 
            // dtpDatumPolaganja
            // 
            dtpDatumPolaganja.Location = new Point(236, 112);
            dtpDatumPolaganja.Name = "dtpDatumPolaganja";
            dtpDatumPolaganja.Size = new Size(215, 23);
            dtpDatumPolaganja.TabIndex = 4;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(457, 112);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(80, 23);
            btnDodaj.TabIndex = 5;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 94);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 6;
            label2.Text = "Ocjena:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(236, 94);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 7;
            label3.Text = "Datum polaganja:";
            // 
            // lblImePrezime
            // 
            lblImePrezime.AutoSize = true;
            lblImePrezime.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblImePrezime.Location = new Point(12, 18);
            lblImePrezime.Name = "lblImePrezime";
            lblImePrezime.Size = new Size(101, 21);
            lblImePrezime.TabIndex = 8;
            lblImePrezime.Text = "ImePrezime";
            // 
            // lblBrojIndeksa
            // 
            lblBrojIndeksa.AutoSize = true;
            lblBrojIndeksa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBrojIndeksa.Location = new Point(13, 51);
            lblBrojIndeksa.Name = "lblBrojIndeksa";
            lblBrojIndeksa.Size = new Size(100, 21);
            lblBrojIndeksa.TabIndex = 9;
            lblBrojIndeksa.Text = "BrojIndeksa";
            // 
            // frmStudentPolozeniPredmeti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 412);
            Controls.Add(lblBrojIndeksa);
            Controls.Add(lblImePrezime);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnDodaj);
            Controls.Add(dtpDatumPolaganja);
            Controls.Add(cmbOcjena);
            Controls.Add(cmbPredmet);
            Controls.Add(label1);
            Controls.Add(dgvPolozeniPredmeti);
            Name = "frmStudentPolozeniPredmeti";
            Text = "frmStudentPolozeniPredmeti";
            Load += frmStudentPolozeniPredmeti_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPolozeniPredmeti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPolozeniPredmeti;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Ocjena;
        private DataGridViewTextBoxColumn DatumPolaganja;
        private Label label1;
        private ComboBox cmbPredmet;
        private ComboBox cmbOcjena;
        private DateTimePicker dtpDatumPolaganja;
        private Button btnDodaj;
        private Label label2;
        private Label label3;
        private Label lblImePrezime;
        private Label lblBrojIndeksa;
    }
}