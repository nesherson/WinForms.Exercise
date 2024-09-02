namespace WinForms.Exercise.Ispit22._02._2024
{
    partial class frmPrisustvaIB230003
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
            label2 = new Label();
            cmbNastava = new ComboBox();
            dgvPrisustva = new DataGridView();
            Nastava = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            label1 = new Label();
            cmbStudent = new ComboBox();
            btnDodaj = new Button();
            lblBrojPrisustva = new Label();
            errorProvider1 = new ErrorProvider(components);
            groupBox1 = new GroupBox();
            label4 = new Label();
            txtSadrzaj = new TextBox();
            btnGenerisi = new Button();
            txtBrojZapisa = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPrisustva).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblImeProstorije
            // 
            lblImeProstorije.AutoSize = true;
            lblImeProstorije.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblImeProstorije.Location = new Point(12, 9);
            lblImeProstorije.Name = "lblImeProstorije";
            lblImeProstorije.Size = new Size(284, 47);
            lblImeProstorije.TabIndex = 1;
            lblImeProstorije.Text = "lblImeProstorije";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 5;
            label2.Text = "Nastava:";
            // 
            // cmbNastava
            // 
            cmbNastava.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNastava.FormattingEnabled = true;
            cmbNastava.Location = new Point(12, 74);
            cmbNastava.Name = "cmbNastava";
            cmbNastava.Size = new Size(257, 23);
            cmbNastava.TabIndex = 4;
            // 
            // dgvPrisustva
            // 
            dgvPrisustva.AllowUserToAddRows = false;
            dgvPrisustva.AllowUserToDeleteRows = false;
            dgvPrisustva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrisustva.Columns.AddRange(new DataGridViewColumn[] { Nastava, Student });
            dgvPrisustva.Location = new Point(12, 103);
            dgvPrisustva.Name = "dgvPrisustva";
            dgvPrisustva.ReadOnly = true;
            dgvPrisustva.RowTemplate.Height = 25;
            dgvPrisustva.Size = new Size(607, 202);
            dgvPrisustva.TabIndex = 6;
            // 
            // Nastava
            // 
            Nastava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nastava.DataPropertyName = "Nastava";
            Nastava.HeaderText = "Predmet, prostorija, vrijeme";
            Nastava.Name = "Nastava";
            Nastava.ReadOnly = true;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "Student";
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 56);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 8;
            label1.Text = "Student";
            // 
            // cmbStudent
            // 
            cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(281, 74);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(257, 23);
            cmbStudent.TabIndex = 7;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(544, 73);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 9;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // lblBrojPrisustva
            // 
            lblBrojPrisustva.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblBrojPrisustva.Location = new Point(516, 9);
            lblBrojPrisustva.Name = "lblBrojPrisustva";
            lblBrojPrisustva.Size = new Size(99, 47);
            lblBrojPrisustva.TabIndex = 10;
            lblBrojPrisustva.Text = "lblBrojPrisustva";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSadrzaj);
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Controls.Add(txtBrojZapisa);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 311);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(607, 226);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 52);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 4;
            label4.Text = "Info:";
            // 
            // txtSadrzaj
            // 
            txtSadrzaj.Location = new Point(6, 70);
            txtSadrzaj.Multiline = true;
            txtSadrzaj.Name = "txtSadrzaj";
            txtSadrzaj.Size = new Size(595, 149);
            txtSadrzaj.TabIndex = 3;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(212, 25);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(75, 23);
            btnGenerisi.TabIndex = 2;
            btnGenerisi.Text = "Generisi";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // txtBrojZapisa
            // 
            txtBrojZapisa.Location = new Point(106, 25);
            txtBrojZapisa.Name = "txtBrojZapisa";
            txtBrojZapisa.Size = new Size(100, 23);
            txtBrojZapisa.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 28);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 0;
            label3.Text = "Broj zapisa:";
            // 
            // frmPrisustvaIB230003
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 542);
            Controls.Add(groupBox1);
            Controls.Add(lblBrojPrisustva);
            Controls.Add(btnDodaj);
            Controls.Add(label1);
            Controls.Add(cmbStudent);
            Controls.Add(dgvPrisustva);
            Controls.Add(label2);
            Controls.Add(cmbNastava);
            Controls.Add(lblImeProstorije);
            Name = "frmPrisustvaIB230003";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Evidencija nastave";
            Load += frmPrisustvaIB230003_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrisustva).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblImeProstorije;
        private Label label2;
        private ComboBox cmbNastava;
        private DataGridView dgvPrisustva;
        private Label label1;
        private ComboBox cmbStudent;
        private Button btnDodaj;
        private Label lblBrojPrisustva;
        private DataGridViewTextBoxColumn Nastava;
        private DataGridViewTextBoxColumn Student;
        private ErrorProvider errorProvider1;
        private GroupBox groupBox1;
        private TextBox txtSadrzaj;
        private Button btnGenerisi;
        private TextBox txtBrojZapisa;
        private Label label3;
        private Label label4;
    }
}