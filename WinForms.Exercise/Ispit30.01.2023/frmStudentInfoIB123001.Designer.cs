namespace WinForms.Exercise.Ispit30._01._2023
{
	partial class frmStudentInfoIB123001
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
			pbSlikaStudenta = new PictureBox();
			lblImePrezime = new Label();
			lblProsjek = new Label();
			lblProsjekVrijednost = new Label();
			((System.ComponentModel.ISupportInitialize)pbSlikaStudenta).BeginInit();
			SuspendLayout();
			// 
			// pbSlikaStudenta
			// 
			pbSlikaStudenta.BorderStyle = BorderStyle.FixedSingle;
			pbSlikaStudenta.Location = new Point(12, 12);
			pbSlikaStudenta.Name = "pbSlikaStudenta";
			pbSlikaStudenta.Size = new Size(282, 224);
			pbSlikaStudenta.SizeMode = PictureBoxSizeMode.StretchImage;
			pbSlikaStudenta.TabIndex = 0;
			pbSlikaStudenta.TabStop = false;
			// 
			// lblImePrezime
			// 
			lblImePrezime.AutoSize = true;
			lblImePrezime.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
			lblImePrezime.Location = new Point(77, 269);
			lblImePrezime.Name = "lblImePrezime";
			lblImePrezime.Size = new Size(162, 30);
			lblImePrezime.TabIndex = 1;
			lblImePrezime.Text = "lblImePrezime";
			// 
			// lblProsjek
			// 
			lblProsjek.AutoSize = true;
			lblProsjek.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			lblProsjek.Location = new Point(91, 319);
			lblProsjek.Name = "lblProsjek";
			lblProsjek.Size = new Size(71, 21);
			lblProsjek.TabIndex = 2;
			lblProsjek.Text = "Prosjek:";
			// 
			// lblProsjekVrijednost
			// 
			lblProsjekVrijednost.AutoSize = true;
			lblProsjekVrijednost.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			lblProsjekVrijednost.Location = new Point(168, 319);
			lblProsjekVrijednost.Name = "lblProsjekVrijednost";
			lblProsjekVrijednost.Size = new Size(164, 21);
			lblProsjekVrijednost.TabIndex = 3;
			lblProsjekVrijednost.Text = "lblProsjekVrijednost";
			// 
			// frmStudentInfoIB123001
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(306, 450);
			Controls.Add(lblProsjekVrijednost);
			Controls.Add(lblProsjek);
			Controls.Add(lblImePrezime);
			Controls.Add(pbSlikaStudenta);
			Name = "frmStudentInfoIB123001";
			Text = "frmStudentInfoIB123001";
			Load += frmStudentInfoIB123001_Load;
			((System.ComponentModel.ISupportInitialize)pbSlikaStudenta).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pbSlikaStudenta;
		private Label lblImePrezime;
		private Label lblProsjek;
		private Label lblProsjekVrijednost;
	}
}