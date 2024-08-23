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
			((System.ComponentModel.ISupportInitialize)dgvUvjerenja).BeginInit();
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
			dgvUvjerenja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvUvjerenja.Size = new Size(632, 270);
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
			btnNoviZahtjev.Location = new Point(534, 12);
			btnNoviZahtjev.Name = "btnNoviZahtjev";
			btnNoviZahtjev.Size = new Size(110, 23);
			btnNoviZahtjev.TabIndex = 1;
			btnNoviZahtjev.Text = "Novi zahtjev";
			btnNoviZahtjev.UseVisualStyleBackColor = true;
			btnNoviZahtjev.Click += btnNoviZahtjev_Click;
			// 
			// frmUvjerenjaIB123001
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(656, 452);
			Controls.Add(btnNoviZahtjev);
			Controls.Add(dgvUvjerenja);
			Name = "frmUvjerenjaIB123001";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "brojUvjerenja";
			Load += frmUvjerenjaIB123001_Load;
			((System.ComponentModel.ISupportInitialize)dgvUvjerenja).EndInit();
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
	}
}