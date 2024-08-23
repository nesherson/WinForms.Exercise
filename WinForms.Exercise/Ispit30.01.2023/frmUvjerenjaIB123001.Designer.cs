namespace WinForms.Exercise.Ispit30._01._2023
{
	partial class frmUvjerenjaIB123001
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
			dgvUvjerenja = new DataGridView();
			VrijemeKreiranja = new DataGridViewTextBoxColumn();
			VrstaUvjerenja = new DataGridViewTextBoxColumn();
			SvrhaUvjerenja = new DataGridViewTextBoxColumn();
			Uplatnica = new DataGridViewImageColumn();
			Printano = new DataGridViewCheckBoxColumn();
			Brisi = new DataGridViewButtonColumn();
			Printaj = new DataGridViewButtonColumn();
			btnNoviZahtjev = new Button();
			groupBox1 = new GroupBox();
			label4 = new Label();
			txtSadrzaj = new TextBox();
			btnDodaj = new Button();
			label3 = new Label();
			txtBrojZahtjeva = new TextBox();
			label2 = new Label();
			txtSvrhaIzdavanja = new TextBox();
			label1 = new Label();
			cmbVrstaUvjerenja = new ComboBox();
			((System.ComponentModel.ISupportInitialize)dgvUvjerenja).BeginInit();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// dgvUvjerenja
			// 
			dgvUvjerenja.AllowUserToAddRows = false;
			dgvUvjerenja.AllowUserToDeleteRows = false;
			dgvUvjerenja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvUvjerenja.Columns.AddRange(new DataGridViewColumn[] { VrijemeKreiranja, VrstaUvjerenja, SvrhaUvjerenja, Uplatnica, Printano, Brisi, Printaj });
			dgvUvjerenja.Location = new Point(12, 41);
			dgvUvjerenja.Name = "dgvUvjerenja";
			dgvUvjerenja.ReadOnly = true;
			dgvUvjerenja.RowTemplate.Height = 25;
			dgvUvjerenja.ScrollBars = ScrollBars.Vertical;
			dgvUvjerenja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvUvjerenja.Size = new Size(748, 270);
			dgvUvjerenja.TabIndex = 0;
			dgvUvjerenja.CellContentClick += dgvUvjerenja_CellContentClick;
			// 
			// VrijemeKreiranja
			// 
			VrijemeKreiranja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			VrijemeKreiranja.DataPropertyName = "VrijemeKreiranja";
			VrijemeKreiranja.HeaderText = "Datum";
			VrijemeKreiranja.Name = "VrijemeKreiranja";
			VrijemeKreiranja.ReadOnly = true;
			// 
			// VrstaUvjerenja
			// 
			VrstaUvjerenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			VrstaUvjerenja.DataPropertyName = "VrstaUvjerenja";
			VrstaUvjerenja.HeaderText = "Vrsta";
			VrstaUvjerenja.Name = "VrstaUvjerenja";
			VrstaUvjerenja.ReadOnly = true;
			// 
			// SvrhaUvjerenja
			// 
			SvrhaUvjerenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			SvrhaUvjerenja.DataPropertyName = "SvrhaUvjerenja";
			SvrhaUvjerenja.HeaderText = "Svrha";
			SvrhaUvjerenja.Name = "SvrhaUvjerenja";
			SvrhaUvjerenja.ReadOnly = true;
			// 
			// Uplatnica
			// 
			Uplatnica.DataPropertyName = "Uplatnica";
			Uplatnica.HeaderText = "Uplatnica";
			Uplatnica.Name = "Uplatnica";
			Uplatnica.ReadOnly = true;
			Uplatnica.Resizable = DataGridViewTriState.True;
			Uplatnica.SortMode = DataGridViewColumnSortMode.Automatic;
			// 
			// Printano
			// 
			Printano.DataPropertyName = "Printano";
			Printano.HeaderText = "Printano";
			Printano.Name = "Printano";
			Printano.ReadOnly = true;
			// 
			// Brisi
			// 
			Brisi.HeaderText = "";
			Brisi.Name = "Brisi";
			Brisi.ReadOnly = true;
			Brisi.Text = "Briši";
			Brisi.UseColumnTextForButtonValue = true;
			// 
			// Printaj
			// 
			Printaj.HeaderText = "";
			Printaj.Name = "Printaj";
			Printaj.ReadOnly = true;
			Printaj.Text = "Printaj";
			Printaj.UseColumnTextForButtonValue = true;
			// 
			// btnNoviZahtjev
			// 
			btnNoviZahtjev.Location = new Point(650, 12);
			btnNoviZahtjev.Name = "btnNoviZahtjev";
			btnNoviZahtjev.Size = new Size(110, 23);
			btnNoviZahtjev.TabIndex = 1;
			btnNoviZahtjev.Text = "Novi zahtjev";
			btnNoviZahtjev.UseVisualStyleBackColor = true;
			btnNoviZahtjev.Click += btnNoviZahtjev_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(txtSadrzaj);
			groupBox1.Controls.Add(btnDodaj);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(txtBrojZahtjeva);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(txtSvrhaIzdavanja);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(cmbVrstaUvjerenja);
			groupBox1.Location = new Point(12, 327);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(747, 275);
			groupBox1.TabIndex = 2;
			groupBox1.TabStop = false;
			groupBox1.Text = "Dodavanje zahtjeva za izdavanje uvjerenja";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(6, 63);
			label4.Name = "label4";
			label4.Size = new Size(31, 15);
			label4.TabIndex = 8;
			label4.Text = "Info:";
			// 
			// txtSadrzaj
			// 
			txtSadrzaj.Location = new Point(6, 81);
			txtSadrzaj.Multiline = true;
			txtSadrzaj.Name = "txtSadrzaj";
			txtSadrzaj.ReadOnly = true;
			txtSadrzaj.ScrollBars = ScrollBars.Vertical;
			txtSadrzaj.Size = new Size(735, 188);
			txtSadrzaj.TabIndex = 7;
			// 
			// btnDodaj
			// 
			btnDodaj.Location = new Point(638, 37);
			btnDodaj.Name = "btnDodaj";
			btnDodaj.Size = new Size(103, 23);
			btnDodaj.TabIndex = 6;
			btnDodaj.Text = "Dodaj =>";
			btnDodaj.UseVisualStyleBackColor = true;
			btnDodaj.Click += btnDodaj_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(502, 19);
			label3.Name = "label3";
			label3.Size = new Size(77, 15);
			label3.TabIndex = 5;
			label3.Text = "Broj zahtjeva:";
			// 
			// txtBrojZahtjeva
			// 
			txtBrojZahtjeva.Location = new Point(503, 37);
			txtBrojZahtjeva.Name = "txtBrojZahtjeva";
			txtBrojZahtjeva.Size = new Size(90, 23);
			txtBrojZahtjeva.TabIndex = 4;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(239, 19);
			label2.Name = "label2";
			label2.Size = new Size(91, 15);
			label2.TabIndex = 3;
			label2.Text = "Svrha izdavanja:";
			// 
			// txtSvrhaIzdavanja
			// 
			txtSvrhaIzdavanja.Location = new Point(239, 37);
			txtSvrhaIzdavanja.Name = "txtSvrhaIzdavanja";
			txtSvrhaIzdavanja.Size = new Size(258, 23);
			txtSvrhaIzdavanja.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(6, 19);
			label1.Name = "label1";
			label1.Size = new Size(87, 15);
			label1.TabIndex = 1;
			label1.Text = "Vrsta uvjerenja:";
			// 
			// cmbVrstaUvjerenja
			// 
			cmbVrstaUvjerenja.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbVrstaUvjerenja.FormattingEnabled = true;
			cmbVrstaUvjerenja.Items.AddRange(new object[] { "Regulisanje stipendije", "Test 123", "Test test", "Test 123 test 123", "Uvjerenje o polozenim ispitima" });
			cmbVrstaUvjerenja.Location = new Point(6, 37);
			cmbVrstaUvjerenja.Name = "cmbVrstaUvjerenja";
			cmbVrstaUvjerenja.Size = new Size(227, 23);
			cmbVrstaUvjerenja.TabIndex = 0;
			// 
			// frmUvjerenjaIB123001
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(771, 614);
			Controls.Add(groupBox1);
			Controls.Add(btnNoviZahtjev);
			Controls.Add(dgvUvjerenja);
			Name = "frmUvjerenjaIB123001";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "brojUvjerenja";
			Load += frmUvjerenjaIB123001_Load;
			((System.ComponentModel.ISupportInitialize)dgvUvjerenja).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvUvjerenja;
		private Button btnNoviZahtjev;
		private DataGridViewTextBoxColumn VrijemeKreiranja;
		private DataGridViewTextBoxColumn VrstaUvjerenja;
		private DataGridViewTextBoxColumn SvrhaUvjerenja;
		private DataGridViewImageColumn Uplatnica;
		private DataGridViewCheckBoxColumn Printano;
		private DataGridViewButtonColumn Brisi;
		private DataGridViewButtonColumn Printaj;
		private GroupBox groupBox1;
		private TextBox txtSadrzaj;
		private Button btnDodaj;
		private Label label3;
		private TextBox txtBrojZahtjeva;
		private Label label2;
		private TextBox txtSvrhaIzdavanja;
		private Label label1;
		private ComboBox cmbVrstaUvjerenja;
		private Label label4;
	}
}