namespace WinForms.Exercise.Ispit31._08._2021
{
    partial class frmNoviScanIspitaIB230004
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
            label1 = new Label();
            txtNapomena = new TextBox();
            cmbPredmeti = new ComboBox();
            pbSlika = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            btnSpasi = new Button();
            cbVaranje = new CheckBox();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Predmet:";
            // 
            // txtNapomena
            // 
            txtNapomena.Location = new Point(12, 86);
            txtNapomena.Multiline = true;
            txtNapomena.Name = "txtNapomena";
            txtNapomena.Size = new Size(254, 288);
            txtNapomena.TabIndex = 1;
            // 
            // cmbPredmeti
            // 
            cmbPredmeti.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPredmeti.FormattingEnabled = true;
            cmbPredmeti.Location = new Point(12, 32);
            cmbPredmeti.Name = "cmbPredmeti";
            cmbPredmeti.Size = new Size(254, 28);
            cmbPredmeti.TabIndex = 2;
            // 
            // pbSlika
            // 
            pbSlika.BorderStyle = BorderStyle.FixedSingle;
            pbSlika.Location = new Point(292, 32);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(305, 342);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 3;
            pbSlika.TabStop = false;
            pbSlika.MouseDoubleClick += pbSlika_MouseDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 4;
            label2.Text = "Napomena:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(292, 9);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 5;
            label3.Text = "Slika:";
            // 
            // btnSpasi
            // 
            btnSpasi.Location = new Point(501, 395);
            btnSpasi.Name = "btnSpasi";
            btnSpasi.Size = new Size(94, 29);
            btnSpasi.TabIndex = 6;
            btnSpasi.Text = "Spasi";
            btnSpasi.UseVisualStyleBackColor = true;
            btnSpasi.Click += btnSpasi_Click;
            // 
            // cbVaranje
            // 
            cbVaranje.AutoSize = true;
            cbVaranje.Location = new Point(16, 390);
            cbVaranje.Name = "cbVaranje";
            cbVaranje.Size = new Size(140, 24);
            cbVaranje.TabIndex = 7;
            cbVaranje.Text = "Varanje na ispitu";
            cbVaranje.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNoviScanIspitaIB230004
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 450);
            Controls.Add(cbVaranje);
            Controls.Add(btnSpasi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pbSlika);
            Controls.Add(cmbPredmeti);
            Controls.Add(txtNapomena);
            Controls.Add(label1);
            Name = "frmNoviScanIspitaIB230004";
            Text = "Scan ispita";
            Load += frmNoviScanIspitaIB230004_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNapomena;
        private ComboBox cmbPredmeti;
        private PictureBox pbSlika;
        private Label label2;
        private Label label3;
        private Button btnSpasi;
        private CheckBox cbVaranje;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
    }
}