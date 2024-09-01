namespace WinForms.Exercise.Ispit01._02._2024
{
    partial class frmGradoviIB230002
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
            pbSlikaDrzave = new PictureBox();
            lblImeDrzave = new Label();
            label1 = new Label();
            txtImeGrada = new TextBox();
            btnDodajGrad = new Button();
            dgvGradovi = new DataGridView();
            Naziv = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            btnPromijeniStatus = new DataGridViewButtonColumn();
            err = new ErrorProvider(components);
            groupBox1 = new GroupBox();
            txtSadrzaj = new TextBox();
            label3 = new Label();
            btnGenerisi = new Button();
            cbAktivniGradovi = new CheckBox();
            txtBrojGradova = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbSlikaDrzave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pbSlikaDrzave
            // 
            pbSlikaDrzave.Location = new Point(12, 12);
            pbSlikaDrzave.Name = "pbSlikaDrzave";
            pbSlikaDrzave.Size = new Size(192, 106);
            pbSlikaDrzave.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlikaDrzave.TabIndex = 0;
            pbSlikaDrzave.TabStop = false;
            // 
            // lblImeDrzave
            // 
            lblImeDrzave.AutoSize = true;
            lblImeDrzave.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblImeDrzave.Location = new Point(223, 25);
            lblImeDrzave.Name = "lblImeDrzave";
            lblImeDrzave.Size = new Size(239, 47);
            lblImeDrzave.TabIndex = 1;
            lblImeDrzave.Text = "lblImeDrzave";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 152);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 2;
            label1.Text = "Unesite naziv novog grada:";
            // 
            // txtImeGrada
            // 
            txtImeGrada.Location = new Point(167, 149);
            txtImeGrada.Name = "txtImeGrada";
            txtImeGrada.Size = new Size(287, 23);
            txtImeGrada.TabIndex = 3;
            // 
            // btnDodajGrad
            // 
            btnDodajGrad.Location = new Point(460, 152);
            btnDodajGrad.Name = "btnDodajGrad";
            btnDodajGrad.Size = new Size(75, 23);
            btnDodajGrad.TabIndex = 4;
            btnDodajGrad.Text = "Dodaj";
            btnDodajGrad.UseVisualStyleBackColor = true;
            btnDodajGrad.Click += btnDodajGrad_Click;
            // 
            // dgvGradovi
            // 
            dgvGradovi.AllowUserToAddRows = false;
            dgvGradovi.AllowUserToDeleteRows = false;
            dgvGradovi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGradovi.Columns.AddRange(new DataGridViewColumn[] { Naziv, Aktivan, btnPromijeniStatus });
            dgvGradovi.Location = new Point(12, 181);
            dgvGradovi.Name = "dgvGradovi";
            dgvGradovi.ReadOnly = true;
            dgvGradovi.RowTemplate.Height = 25;
            dgvGradovi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGradovi.Size = new Size(523, 150);
            dgvGradovi.TabIndex = 5;
            dgvGradovi.CellContentClick += dgvGradovi_CellContentClick;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv grada";
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.DataPropertyName = "Status";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            // 
            // btnPromijeniStatus
            // 
            btnPromijeniStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            btnPromijeniStatus.HeaderText = "";
            btnPromijeniStatus.Name = "btnPromijeniStatus";
            btnPromijeniStatus.ReadOnly = true;
            btnPromijeniStatus.Text = "Promijeni status";
            btnPromijeniStatus.UseColumnTextForButtonValue = true;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSadrzaj);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Controls.Add(cbAktivniGradovi);
            groupBox1.Controls.Add(txtBrojGradova);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 346);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(523, 206);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator";
            // 
            // txtSadrzaj
            // 
            txtSadrzaj.Location = new Point(6, 64);
            txtSadrzaj.Multiline = true;
            txtSadrzaj.Name = "txtSadrzaj";
            txtSadrzaj.Size = new Size(511, 136);
            txtSadrzaj.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 46);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 10;
            label3.Text = "Info:";
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(250, 17);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(75, 23);
            btnGenerisi.TabIndex = 7;
            btnGenerisi.Text = "Generisi";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // cbAktivniGradovi
            // 
            cbAktivniGradovi.AutoSize = true;
            cbAktivniGradovi.Location = new Point(169, 20);
            cbAktivniGradovi.Name = "cbAktivniGradovi";
            cbAktivniGradovi.Size = new Size(63, 19);
            cbAktivniGradovi.TabIndex = 9;
            cbAktivniGradovi.Text = "Aktivni";
            cbAktivniGradovi.UseVisualStyleBackColor = true;
            // 
            // txtBrojGradova
            // 
            txtBrojGradova.Location = new Point(89, 16);
            txtBrojGradova.Name = "txtBrojGradova";
            txtBrojGradova.Size = new Size(74, 23);
            txtBrojGradova.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 7;
            label2.Text = "Broj gradova:";
            // 
            // frmGradoviIB230002
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 564);
            Controls.Add(groupBox1);
            Controls.Add(dgvGradovi);
            Controls.Add(btnDodajGrad);
            Controls.Add(txtImeGrada);
            Controls.Add(label1);
            Controls.Add(lblImeDrzave);
            Controls.Add(pbSlikaDrzave);
            Name = "frmGradoviIB230002";
            Text = "Podaci o gradovima";
            Load += frmGradoviIB230002_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlikaDrzave).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlikaDrzave;
        private Label lblImeDrzave;
        private Label label1;
        private TextBox txtImeGrada;
        private Button btnDodajGrad;
        private DataGridView dgvGradovi;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn btnPromijeniStatus;
        private ErrorProvider err;
        private GroupBox groupBox1;
        private CheckBox cbAktivniGradovi;
        private TextBox txtBrojGradova;
        private Label label2;
        private TextBox txtSadrzaj;
        private Label label3;
        private Button btnGenerisi;
    }
}