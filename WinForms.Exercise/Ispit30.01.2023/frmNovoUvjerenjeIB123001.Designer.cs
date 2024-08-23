namespace WinForms.Exercise.Ispit30._01._2023
{
	partial class frmNovoUvjerenjeIB123001
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
			cmbVrstaUvjerenja = new ComboBox();
			txtSvrhaIzdavanja = new TextBox();
			pbUplatnica = new PictureBox();
			label1 = new Label();
			btnSacuvaj = new Button();
			label2 = new Label();
			label3 = new Label();
			err = new ErrorProvider(components);
			fileDialog = new OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)pbUplatnica).BeginInit();
			((System.ComponentModel.ISupportInitialize)err).BeginInit();
			SuspendLayout();
			// 
			// cmbVrstaUvjerenja
			// 
			cmbVrstaUvjerenja.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbVrstaUvjerenja.FormattingEnabled = true;
			cmbVrstaUvjerenja.Items.AddRange(new object[] { "Regulisanje stipendije", "Test 123", "Test test", "Test 123 test 123", "Uvjerenje o polozenim ispitima" });
			cmbVrstaUvjerenja.Location = new Point(12, 38);
			cmbVrstaUvjerenja.Name = "cmbVrstaUvjerenja";
			cmbVrstaUvjerenja.Size = new Size(248, 23);
			cmbVrstaUvjerenja.TabIndex = 0;
			// 
			// txtSvrhaIzdavanja
			// 
			txtSvrhaIzdavanja.Location = new Point(12, 82);
			txtSvrhaIzdavanja.Multiline = true;
			txtSvrhaIzdavanja.Name = "txtSvrhaIzdavanja";
			txtSvrhaIzdavanja.Size = new Size(248, 272);
			txtSvrhaIzdavanja.TabIndex = 1;
			// 
			// pbUplatnica
			// 
			pbUplatnica.BorderStyle = BorderStyle.FixedSingle;
			pbUplatnica.Location = new Point(282, 38);
			pbUplatnica.Name = "pbUplatnica";
			pbUplatnica.Size = new Size(475, 287);
			pbUplatnica.SizeMode = PictureBoxSizeMode.StretchImage;
			pbUplatnica.TabIndex = 2;
			pbUplatnica.TabStop = false;
			pbUplatnica.DoubleClick += pbUplatnica_DoubleClick;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 20);
			label1.Name = "label1";
			label1.Size = new Size(87, 15);
			label1.TabIndex = 3;
			label1.Text = "Vrsta uvjerenja:";
			// 
			// btnSacuvaj
			// 
			btnSacuvaj.Location = new Point(682, 331);
			btnSacuvaj.Name = "btnSacuvaj";
			btnSacuvaj.Size = new Size(75, 23);
			btnSacuvaj.TabIndex = 4;
			btnSacuvaj.Text = "Sačuvaj";
			btnSacuvaj.UseVisualStyleBackColor = true;
			btnSacuvaj.Click += btnSacuvaj_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 64);
			label2.Name = "label2";
			label2.Size = new Size(91, 15);
			label2.TabIndex = 5;
			label2.Text = "Svrha izdavanja:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(282, 20);
			label3.Name = "label3";
			label3.Size = new Size(113, 15);
			label3.TabIndex = 6;
			label3.Text = "Skenirana uplatnica:";
			// 
			// err
			// 
			err.ContainerControl = this;
			// 
			// fileDialog
			// 
			fileDialog.FileName = "openFileDialog1";
			// 
			// frmNovoUvjerenjeIB123001
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(774, 374);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(btnSacuvaj);
			Controls.Add(label1);
			Controls.Add(pbUplatnica);
			Controls.Add(txtSvrhaIzdavanja);
			Controls.Add(cmbVrstaUvjerenja);
			Name = "frmNovoUvjerenjeIB123001";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Novi zahtjev za izdavanjem uvjerenja";
			Load += frmNovoUvjerenjeIB123001_Load;
			((System.ComponentModel.ISupportInitialize)pbUplatnica).EndInit();
			((System.ComponentModel.ISupportInitialize)err).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cmbVrstaUvjerenja;
		private TextBox txtSvrhaIzdavanja;
		private PictureBox pbUplatnica;
		private Label label1;
		private Button btnSacuvaj;
		private Label label2;
		private Label label3;
		private ErrorProvider err;
		private OpenFileDialog fileDialog;
	}
}