namespace WinForms.Exercise.Ispit31._08._2021
{
    partial class frmScanIspitaIB230004
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
            lblStudent = new Label();
            dgvIspitiScan = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Napomena = new DataGridViewTextBoxColumn();
            Varanje = new DataGridViewCheckBoxColumn();
            SkeniranIspit = new DataGridViewImageColumn();
            btnBrisi = new DataGridViewButtonColumn();
            btnDodajScan = new Button();
            btnPrintaj = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvIspitiScan).BeginInit();
            SuspendLayout();
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Location = new Point(12, 9);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(183, 20);
            lblStudent.TabIndex = 0;
            lblStudent.Text = "Pregled ispita za studenta:";
            // 
            // dgvIspitiScan
            // 
            dgvIspitiScan.AllowUserToAddRows = false;
            dgvIspitiScan.AllowUserToDeleteRows = false;
            dgvIspitiScan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIspitiScan.Columns.AddRange(new DataGridViewColumn[] { Predmet, Napomena, Varanje, SkeniranIspit, btnBrisi });
            dgvIspitiScan.Location = new Point(12, 42);
            dgvIspitiScan.Name = "dgvIspitiScan";
            dgvIspitiScan.ReadOnly = true;
            dgvIspitiScan.RowHeadersWidth = 51;
            dgvIspitiScan.RowTemplate.Height = 29;
            dgvIspitiScan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIspitiScan.Size = new Size(776, 396);
            dgvIspitiScan.TabIndex = 2;
            dgvIspitiScan.CellContentClick += dgvIspitiScan_CellContentClick;
            dgvIspitiScan.CellContentDoubleClick += dgvIspitiScan_CellContentDoubleClick;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.MinimumWidth = 6;
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            // 
            // Napomena
            // 
            Napomena.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Napomena.DataPropertyName = "Napomena";
            Napomena.HeaderText = "Napomena";
            Napomena.MinimumWidth = 6;
            Napomena.Name = "Napomena";
            Napomena.ReadOnly = true;
            // 
            // Varanje
            // 
            Varanje.DataPropertyName = "Varanje";
            Varanje.HeaderText = "Varanje";
            Varanje.MinimumWidth = 6;
            Varanje.Name = "Varanje";
            Varanje.ReadOnly = true;
            Varanje.Width = 125;
            // 
            // SkeniranIspit
            // 
            SkeniranIspit.DataPropertyName = "SkeniranIspit";
            SkeniranIspit.HeaderText = "Scan ispita";
            SkeniranIspit.MinimumWidth = 6;
            SkeniranIspit.Name = "SkeniranIspit";
            SkeniranIspit.ReadOnly = true;
            SkeniranIspit.Width = 125;
            // 
            // btnBrisi
            // 
            btnBrisi.HeaderText = "";
            btnBrisi.MinimumWidth = 6;
            btnBrisi.Name = "btnBrisi";
            btnBrisi.ReadOnly = true;
            btnBrisi.Text = "Briši";
            btnBrisi.UseColumnTextForButtonValue = true;
            btnBrisi.Width = 125;
            // 
            // btnDodajScan
            // 
            btnDodajScan.Location = new Point(656, 9);
            btnDodajScan.Name = "btnDodajScan";
            btnDodajScan.Size = new Size(132, 29);
            btnDodajScan.TabIndex = 3;
            btnDodajScan.Text = "Dodaj scan ispita";
            btnDodajScan.UseVisualStyleBackColor = true;
            btnDodajScan.Click += btnDodajScan_Click;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(656, 444);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(132, 29);
            btnPrintaj.TabIndex = 4;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += btnPrintaj_Click;
            // 
            // frmScanIspitaIB230004
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 482);
            Controls.Add(btnPrintaj);
            Controls.Add(btnDodajScan);
            Controls.Add(dgvIspitiScan);
            Controls.Add(lblStudent);
            Name = "frmScanIspitaIB230004";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Scan ispita";
            Load += frmScanIspitaIB230004_Load;
            ((System.ComponentModel.ISupportInitialize)dgvIspitiScan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudent;
        private DataGridView dgvIspitiScan;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Napomena;
        private DataGridViewCheckBoxColumn Varanje;
        private DataGridViewImageColumn SkeniranIspit;
        private DataGridViewButtonColumn btnBrisi;
        private Button btnDodajScan;
        private Button btnPrintaj;
    }
}