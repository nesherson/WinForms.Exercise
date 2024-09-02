namespace WinForms.Exercise.Ispit22._02._2024
{
    partial class frmNastavaIB230003
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
            lblImeProstorije = new Label();
            cmbPredmet = new ComboBox();
            dgvNastava = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            cmbDan = new ComboBox();
            label4 = new Label();
            cmbVrijeme = new ComboBox();
            btnDodaj = new Button();
            errorProvider1 = new ErrorProvider(components);
            Predmet = new DataGridViewTextBoxColumn();
            DanOdrzavanja = new DataGridViewTextBoxColumn();
            Vrijeme = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvNastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblImeProstorije
            // 
            lblImeProstorije.AutoSize = true;
            lblImeProstorije.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblImeProstorije.Location = new Point(12, 9);
            lblImeProstorije.Name = "lblImeProstorije";
            lblImeProstorije.Size = new Size(284, 47);
            lblImeProstorije.TabIndex = 0;
            lblImeProstorije.Text = "lblImeProstorije";
            // 
            // cmbPredmet
            // 
            cmbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(12, 88);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(257, 23);
            cmbPredmet.TabIndex = 1;
            // 
            // dgvNastava
            // 
            dgvNastava.AllowUserToAddRows = false;
            dgvNastava.AllowUserToDeleteRows = false;
            dgvNastava.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNastava.Columns.AddRange(new DataGridViewColumn[] { Predmet, DanOdrzavanja, Vrijeme });
            dgvNastava.Location = new Point(12, 117);
            dgvNastava.Name = "dgvNastava";
            dgvNastava.ReadOnly = true;
            dgvNastava.RowTemplate.Height = 25;
            dgvNastava.Size = new Size(607, 248);
            dgvNastava.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 3;
            label2.Text = "Predmet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 70);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 5;
            label3.Text = "Dan:";
            // 
            // cmbDan
            // 
            cmbDan.FormattingEnabled = true;
            cmbDan.Items.AddRange(new object[] { "Ponedjeljak", "Utorak", "Srijeda", "Četvrtak", "Petak", "Subota", "Nedjelja" });
            cmbDan.Location = new Point(275, 88);
            cmbDan.Name = "cmbDan";
            cmbDan.Size = new Size(140, 23);
            cmbDan.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(421, 70);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 7;
            label4.Text = "Vrijeme:";
            // 
            // cmbVrijeme
            // 
            cmbVrijeme.FormattingEnabled = true;
            cmbVrijeme.Items.AddRange(new object[] { "08 - 10", "10 - 12", "12 - 14", "14 - 16" });
            cmbVrijeme.Location = new Point(421, 88);
            cmbVrijeme.Name = "cmbVrijeme";
            cmbVrijeme.Size = new Size(117, 23);
            cmbVrijeme.TabIndex = 6;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(544, 88);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 8;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            // 
            // DanOdrzavanja
            // 
            DanOdrzavanja.DataPropertyName = "DanOdrzavanja";
            DanOdrzavanja.HeaderText = "Dan";
            DanOdrzavanja.Name = "DanOdrzavanja";
            DanOdrzavanja.ReadOnly = true;
            // 
            // Vrijeme
            // 
            Vrijeme.DataPropertyName = "Vrijeme";
            Vrijeme.HeaderText = "Vrijeme";
            Vrijeme.Name = "Vrijeme";
            Vrijeme.ReadOnly = true;
            // 
            // frmNastavaIB230003
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 374);
            Controls.Add(btnDodaj);
            Controls.Add(label4);
            Controls.Add(cmbVrijeme);
            Controls.Add(label3);
            Controls.Add(cmbDan);
            Controls.Add(label2);
            Controls.Add(dgvNastava);
            Controls.Add(cmbPredmet);
            Controls.Add(lblImeProstorije);
            Name = "frmNastavaIB230003";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nastava";
            Load += frmNastavaIB230003_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblImeProstorije;
        private ComboBox cmbPredmet;
        private DataGridView dgvNastava;
        private Label label2;
        private Label label3;
        private ComboBox cmbDan;
        private Label label4;
        private ComboBox cmbVrijeme;
        private Button btnDodaj;
        private ErrorProvider errorProvider1;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn DanOdrzavanja;
        private DataGridViewTextBoxColumn Vrijeme;
    }
}