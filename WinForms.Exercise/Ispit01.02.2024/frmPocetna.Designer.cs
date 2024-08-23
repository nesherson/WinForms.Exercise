namespace WinForms.Exercise.Ispit01._02._2024
{
	partial class frmPocetna
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
			btnDrzaveGradovi = new Button();
			btnPretraga = new Button();
			btnIzvjestaj = new Button();
			lblBrojStudenata = new Label();
			SuspendLayout();
			// 
			// btnDrzaveGradovi
			// 
			btnDrzaveGradovi.Location = new Point(26, 149);
			btnDrzaveGradovi.Name = "btnDrzaveGradovi";
			btnDrzaveGradovi.Size = new Size(159, 68);
			btnDrzaveGradovi.TabIndex = 0;
			btnDrzaveGradovi.Text = "Drzave i gradovi";
			btnDrzaveGradovi.UseVisualStyleBackColor = true;
			// 
			// btnPretraga
			// 
			btnPretraga.Location = new Point(191, 149);
			btnPretraga.Name = "btnPretraga";
			btnPretraga.Size = new Size(159, 68);
			btnPretraga.TabIndex = 1;
			btnPretraga.Text = "Pretraga";
			btnPretraga.UseVisualStyleBackColor = true;
			// 
			// btnIzvjestaj
			// 
			btnIzvjestaj.Location = new Point(138, 120);
			btnIzvjestaj.Name = "btnIzvjestaj";
			btnIzvjestaj.Size = new Size(108, 23);
			btnIzvjestaj.TabIndex = 2;
			btnIzvjestaj.Text = "Izvjestaj";
			btnIzvjestaj.UseVisualStyleBackColor = true;
			// 
			// lblBrojStudenata
			// 
			lblBrojStudenata.Font = new Font("Segoe UI", 14F);
			lblBrojStudenata.Location = new Point(55, 94);
			lblBrojStudenata.Name = "lblBrojStudenata";
			lblBrojStudenata.Size = new Size(269, 23);
			lblBrojStudenata.TabIndex = 3;
			lblBrojStudenata.Text = "lblBrojStudenata";
			// 
			// frmPocetna
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(380, 248);
			Controls.Add(lblBrojStudenata);
			Controls.Add(btnIzvjestaj);
			Controls.Add(btnPretraga);
			Controls.Add(btnDrzaveGradovi);
			Name = "frmPocetna";
			Text = "Template 2023/24";
			Load += frmPocetna_Load;
			ResumeLayout(false);
		}

		#endregion

		private Button btnDrzaveGradovi;
		private Button btnPretraga;
		private Button btnIzvjestaj;
		private Label lblBrojStudenata;
	}
}