namespace WinForms.Exercise.IspitIB230123
{
    partial class frmNovoUvjerenjeIB230123
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
            cmbVrstaUvjerenja = new ComboBox();
            txtSvrhaIzdavanja = new TextBox();
            pbUplatnica = new PictureBox();
            btnSacuvaj = new Button();
            label2 = new Label();
            label3 = new Label();
            openFileDialog = new OpenFileDialog();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Vrsta uvjerenja:";
            // 
            // cmbVrstaUvjerenja
            // 
            cmbVrstaUvjerenja.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVrstaUvjerenja.FormattingEnabled = true;
            cmbVrstaUvjerenja.Items.AddRange(new object[] { "Uvjerenje o polozenim ispitima", "Test uvjerenje" });
            cmbVrstaUvjerenja.Location = new Point(12, 27);
            cmbVrstaUvjerenja.Name = "cmbVrstaUvjerenja";
            cmbVrstaUvjerenja.Size = new Size(196, 23);
            cmbVrstaUvjerenja.TabIndex = 1;
            // 
            // txtSvrhaIzdavanja
            // 
            txtSvrhaIzdavanja.Location = new Point(12, 71);
            txtSvrhaIzdavanja.Multiline = true;
            txtSvrhaIzdavanja.Name = "txtSvrhaIzdavanja";
            txtSvrhaIzdavanja.Size = new Size(196, 213);
            txtSvrhaIzdavanja.TabIndex = 2;
            // 
            // pbUplatnica
            // 
            pbUplatnica.BorderStyle = BorderStyle.FixedSingle;
            pbUplatnica.Location = new Point(227, 27);
            pbUplatnica.Name = "pbUplatnica";
            pbUplatnica.Size = new Size(493, 228);
            pbUplatnica.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUplatnica.TabIndex = 3;
            pbUplatnica.TabStop = false;
            pbUplatnica.Click += pbUplatnica_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(645, 261);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(75, 23);
            btnSacuvaj.TabIndex = 4;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 5;
            label2.Text = "Svrha izdavanja:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(227, 9);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 6;
            label3.Text = "Skenirana uplatnica:";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // frmNovoUvjerenjeIB230123
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 302);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSacuvaj);
            Controls.Add(pbUplatnica);
            Controls.Add(txtSvrhaIzdavanja);
            Controls.Add(cmbVrstaUvjerenja);
            Controls.Add(label1);
            Name = "frmNovoUvjerenjeIB230123";
            Text = "Novi zahtjev za izdavanjem uvjerenja";
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbVrstaUvjerenja;
        private TextBox txtSvrhaIzdavanja;
        private PictureBox pbUplatnica;
        private Button btnSacuvaj;
        private Label label2;
        private Label label3;
        private OpenFileDialog openFileDialog;
        private ErrorProvider errorProvider;
    }
}