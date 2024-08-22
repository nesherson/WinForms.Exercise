namespace WinForms.Exercise.Ispit31._08._2021
{
    partial class frmScanIspitaIB230124
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
            label1 = new Label();
            btnDodajScanIspita = new Button();
            dgvStudentiIspitiScan = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Napomena = new DataGridViewTextBoxColumn();
            Varanje = new DataGridViewCheckBoxColumn();
            SkeniranIspit = new DataGridViewImageColumn();
            lblStudent = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudentiIspitiScan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 21);
            label1.TabIndex = 0;
            label1.Text = "Pregled ispita za studenta:";
            // 
            // btnDodajScanIspita
            // 
            btnDodajScanIspita.Location = new Point(680, 12);
            btnDodajScanIspita.Name = "btnDodajScanIspita";
            btnDodajScanIspita.Size = new Size(108, 23);
            btnDodajScanIspita.TabIndex = 1;
            btnDodajScanIspita.Text = "Dodaj scan ispita";
            btnDodajScanIspita.UseVisualStyleBackColor = true;
            btnDodajScanIspita.Click += btnDodajScanIspita_Click;
            // 
            // dgvStudentiIspitiScan
            // 
            dgvStudentiIspitiScan.AllowUserToAddRows = false;
            dgvStudentiIspitiScan.AllowUserToDeleteRows = false;
            dgvStudentiIspitiScan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentiIspitiScan.Columns.AddRange(new DataGridViewColumn[] { Predmet, Napomena, Varanje, SkeniranIspit });
            dgvStudentiIspitiScan.Location = new Point(12, 41);
            dgvStudentiIspitiScan.Name = "dgvStudentiIspitiScan";
            dgvStudentiIspitiScan.ReadOnly = true;
            dgvStudentiIspitiScan.RowTemplate.Height = 25;
            dgvStudentiIspitiScan.Size = new Size(776, 338);
            dgvStudentiIspitiScan.TabIndex = 2;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            // 
            // Napomena
            // 
            Napomena.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Napomena.DataPropertyName = "Napomena";
            Napomena.HeaderText = "Napomena";
            Napomena.Name = "Napomena";
            Napomena.ReadOnly = true;
            // 
            // Varanje
            // 
            Varanje.DataPropertyName = "Varanje";
            Varanje.HeaderText = "Varanje";
            Varanje.Name = "Varanje";
            Varanje.ReadOnly = true;
            // 
            // SkeniranIspit
            // 
            SkeniranIspit.DataPropertyName = "SkeniranIspit";
            SkeniranIspit.HeaderText = "Scan ispita";
            SkeniranIspit.Name = "SkeniranIspit";
            SkeniranIspit.ReadOnly = true;
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblStudent.Location = new Point(198, 9);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(110, 21);
            lblStudent.TabIndex = 3;
            lblStudent.Text = "tempStudent";
            // 
            // frmScanIspitaIB230124
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 391);
            Controls.Add(lblStudent);
            Controls.Add(dgvStudentiIspitiScan);
            Controls.Add(btnDodajScanIspita);
            Controls.Add(label1);
            Name = "frmScanIspitaIB230124";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmScanIspitaIB230124";
            Load += frmScanIspitaIB230124_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudentiIspitiScan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnDodajScanIspita;
        private DataGridView dgvStudentiIspitiScan;
        private Label lblStudent;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Napomena;
        private DataGridViewCheckBoxColumn Varanje;
        private DataGridViewImageColumn SkeniranIspit;
    }
}