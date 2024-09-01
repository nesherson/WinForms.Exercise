namespace WinForms.Exercise.Ispit01._02._2024
{
    partial class frmNovaDrzavaIB230002
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
            pbZastava = new PictureBox();
            txtNaziv = new TextBox();
            cbAktivna = new CheckBox();
            label2 = new Label();
            btnSacuvaj = new Button();
            err = new ErrorProvider(components);
            fileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Zastava:";
            // 
            // pbZastava
            // 
            pbZastava.BorderStyle = BorderStyle.FixedSingle;
            pbZastava.Location = new Point(12, 27);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(310, 176);
            pbZastava.SizeMode = PictureBoxSizeMode.StretchImage;
            pbZastava.TabIndex = 1;
            pbZastava.TabStop = false;
            pbZastava.DoubleClick += pbZastava_DoubleClick;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(12, 224);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(310, 23);
            txtNaziv.TabIndex = 2;
            // 
            // cbAktivna
            // 
            cbAktivna.AutoSize = true;
            cbAktivna.Location = new Point(12, 253);
            cbAktivna.Name = "cbAktivna";
            cbAktivna.Size = new Size(66, 19);
            cbAktivna.TabIndex = 3;
            cbAktivna.Text = "Aktivna";
            cbAktivna.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 206);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 4;
            label2.Text = "Zastava:";
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(247, 279);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(75, 23);
            btnSacuvaj.TabIndex = 5;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // fileDialog
            // 
            fileDialog.FileName = "openFileDialog1";
            // 
            // frmNovaDrzavaIB230002
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 321);
            Controls.Add(btnSacuvaj);
            Controls.Add(label2);
            Controls.Add(cbAktivna);
            Controls.Add(txtNaziv);
            Controls.Add(pbZastava);
            Controls.Add(label1);
            Name = "frmNovaDrzavaIB230002";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Podaci o državi";
            Load += frmNovaDrzavaIB230002_Load;
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pbZastava;
        private TextBox txtNaziv;
        private CheckBox cbAktivna;
        private Label label2;
        private Button btnSacuvaj;
        private ErrorProvider err;
        private OpenFileDialog fileDialog;
    }
}