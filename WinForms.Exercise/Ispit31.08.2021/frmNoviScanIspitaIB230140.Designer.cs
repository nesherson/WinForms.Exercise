namespace WinForms.Exercise.Ispit31._08._2021
{
    partial class frmNoviScanIspitaIB230140
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
            cmbPredmet = new ComboBox();
            label1 = new Label();
            txtNapomena = new TextBox();
            pbSlika = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            cbVaranje = new CheckBox();
            btnSpasi = new Button();
            errorProvider = new ErrorProvider(components);
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // cmbPredmet
            // 
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(12, 27);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(195, 23);
            cmbPredmet.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 1;
            label1.Text = "Predmet:";
            // 
            // txtNapomena
            // 
            txtNapomena.Location = new Point(12, 71);
            txtNapomena.Multiline = true;
            txtNapomena.Name = "txtNapomena";
            txtNapomena.Size = new Size(195, 203);
            txtNapomena.TabIndex = 2;
            // 
            // pbSlika
            // 
            pbSlika.BorderStyle = BorderStyle.FixedSingle;
            pbSlika.Location = new Point(226, 27);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(235, 247);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 3;
            pbSlika.TabStop = false;
            pbSlika.Click += pbSlika_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 4;
            label2.Text = "Napomena:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(226, 9);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 5;
            label3.Text = "Slika:";
            // 
            // cbVaranje
            // 
            cbVaranje.AutoSize = true;
            cbVaranje.Location = new Point(12, 280);
            cbVaranje.Name = "cbVaranje";
            cbVaranje.Size = new Size(112, 19);
            cbVaranje.TabIndex = 6;
            cbVaranje.Text = "Varanje na ispitu";
            cbVaranje.UseVisualStyleBackColor = true;
            // 
            // btnSpasi
            // 
            btnSpasi.Location = new Point(386, 280);
            btnSpasi.Name = "btnSpasi";
            btnSpasi.Size = new Size(75, 23);
            btnSpasi.TabIndex = 7;
            btnSpasi.Text = "Spasi";
            btnSpasi.UseVisualStyleBackColor = true;
            btnSpasi.Click += btnSpasi_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // frmNoviScanIspitaIB230140
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 308);
            Controls.Add(btnSpasi);
            Controls.Add(cbVaranje);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pbSlika);
            Controls.Add(txtNapomena);
            Controls.Add(label1);
            Controls.Add(cmbPredmet);
            Name = "frmNoviScanIspitaIB230140";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Scan ispita";
            Load += frmNoviScanIspitaIB230140_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbPredmet;
        private Label label1;
        private TextBox txtNapomena;
        private PictureBox pbSlika;
        private Label label2;
        private Label label3;
        private CheckBox cbVaranje;
        private Button btnSpasi;
        private ErrorProvider errorProvider;
        private OpenFileDialog openFileDialog;
    }
}