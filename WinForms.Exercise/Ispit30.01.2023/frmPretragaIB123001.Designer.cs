namespace WinForms.Exercise.Ispit30._01._2023
{
	partial class frmPretragaIB123001
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
			dgvStudenti = new DataGridView();
			BrojIndeksa = new DataGridViewTextBoxColumn();
			ImePrezime = new DataGridViewTextBoxColumn();
			Prosjek = new DataGridViewTextBoxColumn();
			DatumRodjenja = new DataGridViewTextBoxColumn();
			Aktivan = new DataGridViewCheckBoxColumn();
			Uvjerenja = new DataGridViewButtonColumn();
			cmbSpolovi = new ComboBox();
			label1 = new Label();
			dtpRodjenOd = new DateTimePicker();
			label2 = new Label();
			label3 = new Label();
			dtpRodjenDo = new DateTimePicker();
			openFileDialog1 = new OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
			SuspendLayout();
			// 
			// dgvStudenti
			// 
			dgvStudenti.AllowUserToAddRows = false;
			dgvStudenti.AllowUserToDeleteRows = false;
			dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { BrojIndeksa, ImePrezime, Prosjek, DatumRodjenja, Aktivan, Uvjerenja });
			dgvStudenti.Location = new Point(12, 35);
			dgvStudenti.Name = "dgvStudenti";
			dgvStudenti.ReadOnly = true;
			dgvStudenti.RowTemplate.Height = 25;
			dgvStudenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvStudenti.Size = new Size(690, 317);
			dgvStudenti.TabIndex = 0;
			dgvStudenti.CellContentClick += dgvStudenti_CellContentClick;
			// 
			// BrojIndeksa
			// 
			BrojIndeksa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			BrojIndeksa.DataPropertyName = "BrojIndeksa";
			BrojIndeksa.HeaderText = "Broj indeksa";
			BrojIndeksa.Name = "BrojIndeksa";
			BrojIndeksa.ReadOnly = true;
			// 
			// ImePrezime
			// 
			ImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			ImePrezime.DataPropertyName = "ImePrezime";
			ImePrezime.HeaderText = "Ime i prezime";
			ImePrezime.Name = "ImePrezime";
			ImePrezime.ReadOnly = true;
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
			// 
			// Uvjerenja
			// 
			Uvjerenja.HeaderText = "";
			Uvjerenja.Name = "Uvjerenja";
			Uvjerenja.ReadOnly = true;
			Uvjerenja.Text = "Uvjerenja";
			Uvjerenja.UseColumnTextForButtonValue = true;
			// 
			// cmbSpolovi
			// 
			cmbSpolovi.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbSpolovi.FormattingEnabled = true;
			cmbSpolovi.Location = new Point(48, 6);
			cmbSpolovi.Name = "cmbSpolovi";
			cmbSpolovi.Size = new Size(94, 23);
			cmbSpolovi.TabIndex = 1;
			cmbSpolovi.SelectedIndexChanged += cmbSpolovi_SelectedIndexChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(30, 15);
			label1.TabIndex = 2;
			label1.Text = "Spol";
			// 
			// dtpRodjenOd
			// 
			dtpRodjenOd.Location = new Point(269, 6);
			dtpRodjenOd.Name = "dtpRodjenOd";
			dtpRodjenOd.Size = new Size(200, 23);
			dtpRodjenOd.TabIndex = 3;
			dtpRodjenOd.ValueChanged += dtpRodjenOd_ValueChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(148, 9);
			label2.Name = "label2";
			label2.Size = new Size(112, 15);
			label2.TabIndex = 4;
			label2.Text = "rođen u periodu od ";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(475, 9);
			label3.Name = "label3";
			label3.Size = new Size(21, 15);
			label3.TabIndex = 5;
			label3.Text = "do";
			// 
			// dtpRodjenDo
			// 
			dtpRodjenDo.Location = new Point(502, 6);
			dtpRodjenDo.Name = "dtpRodjenDo";
			dtpRodjenDo.Size = new Size(200, 23);
			dtpRodjenDo.TabIndex = 6;
			dtpRodjenDo.ValueChanged += dtpRodjenDo_ValueChanged;
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			// 
			// frmPretragaIB123001
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(711, 361);
			Controls.Add(dtpRodjenDo);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(dtpRodjenOd);
			Controls.Add(label1);
			Controls.Add(cmbSpolovi);
			Controls.Add(dgvStudenti);
			Name = "frmPretragaIB123001";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Pretraga studenata";
			Load += frmPretragaIB123001_Load;
			((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvStudenti;
		private ComboBox cmbSpolovi;
		private Label label1;
		private DateTimePicker dtpRodjenOd;
		private Label label2;
		private Label label3;
		private DateTimePicker dtpRodjenDo;
		private DataGridViewTextBoxColumn BrojIndeksa;
		private DataGridViewTextBoxColumn ImePrezime;
		private DataGridViewTextBoxColumn Prosjek;
		private DataGridViewTextBoxColumn DatumRodjenja;
		private DataGridViewCheckBoxColumn Aktivan;
		private DataGridViewButtonColumn Uvjerenja;
		private OpenFileDialog openFileDialog1;
	}
}