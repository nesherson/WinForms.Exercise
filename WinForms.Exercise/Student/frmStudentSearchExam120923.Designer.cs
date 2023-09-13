namespace WinForms.Exercise
{
    partial class frmStudentSearchExam120923
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
            dtpDateTo = new DateTimePicker();
            cmbGradeTo = new ComboBox();
            label3 = new Label();
            cmbGradeFrom = new ComboBox();
            label4 = new Label();
            dtpDateFrom = new DateTimePicker();
            label6 = new Label();
            cbActive = new CheckBox();
            dgvStudents = new DataGridView();
            FirstLastName = new DataGridViewTextBoxColumn();
            IndexNumber = new DataGridViewTextBoxColumn();
            Subject = new DataGridViewTextBoxColumn();
            Grade = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Active = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Grade from";
            // 
            // dtpDateTo
            // 
            dtpDateTo.Location = new Point(552, 6);
            dtpDateTo.Name = "dtpDateTo";
            dtpDateTo.Size = new Size(200, 23);
            dtpDateTo.TabIndex = 1;
            dtpDateTo.ValueChanged += dtpDateTo_ValueChanged;
            // 
            // cmbGradeTo
            // 
            cmbGradeTo.FormattingEnabled = true;
            cmbGradeTo.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
            cmbGradeTo.Location = new Point(157, 6);
            cmbGradeTo.Name = "cmbGradeTo";
            cmbGradeTo.Size = new Size(42, 23);
            cmbGradeTo.TabIndex = 2;
            cmbGradeTo.SelectedIndexChanged += cmbGradeTo_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(133, 9);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 4;
            label3.Text = "to";
            // 
            // cmbGradeFrom
            // 
            cmbGradeFrom.FormattingEnabled = true;
            cmbGradeFrom.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
            cmbGradeFrom.Location = new Point(85, 6);
            cmbGradeFrom.Name = "cmbGradeFrom";
            cmbGradeFrom.Size = new Size(42, 23);
            cmbGradeFrom.TabIndex = 5;
            cmbGradeFrom.SelectedIndexChanged += cmbGradeFrom_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(205, 9);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 6;
            label4.Text = "born in period from";
            // 
            // dtpDateFrom
            // 
            dtpDateFrom.Location = new Point(322, 6);
            dtpDateFrom.Name = "dtpDateFrom";
            dtpDateFrom.Size = new Size(200, 23);
            dtpDateFrom.TabIndex = 8;
            dtpDateFrom.ValueChanged += dtpDateFrom_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(528, 12);
            label6.Name = "label6";
            label6.Size = new Size(18, 15);
            label6.TabIndex = 9;
            label6.Text = "to";
            // 
            // cbActive
            // 
            cbActive.AutoSize = true;
            cbActive.Location = new Point(774, 11);
            cbActive.Name = "cbActive";
            cbActive.Size = new Size(59, 19);
            cbActive.TabIndex = 10;
            cbActive.Text = "Active";
            cbActive.UseVisualStyleBackColor = true;
            cbActive.CheckedChanged += cbActive_CheckedChanged;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { FirstLastName, IndexNumber, Subject, Grade, Date, Active });
            dgvStudents.Location = new Point(12, 46);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowTemplate.Height = 25;
            dgvStudents.Size = new Size(881, 343);
            dgvStudents.TabIndex = 11;
            // 
            // FirstLastName
            // 
            FirstLastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FirstLastName.DataPropertyName = "FirstLastName";
            FirstLastName.HeaderText = "First and last name";
            FirstLastName.Name = "FirstLastName";
            FirstLastName.ReadOnly = true;
            // 
            // IndexNumber
            // 
            IndexNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IndexNumber.DataPropertyName = "IndexNumber";
            IndexNumber.HeaderText = "Index number";
            IndexNumber.Name = "IndexNumber";
            IndexNumber.ReadOnly = true;
            // 
            // Subject
            // 
            Subject.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Subject.DataPropertyName = "SubjectName";
            Subject.HeaderText = "Subject";
            Subject.Name = "Subject";
            Subject.ReadOnly = true;
            // 
            // Grade
            // 
            Grade.DataPropertyName = "Grade";
            Grade.HeaderText = "Grade";
            Grade.Name = "Grade";
            Grade.ReadOnly = true;
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Date.DataPropertyName = "Date";
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // Active
            // 
            Active.DataPropertyName = "Active";
            Active.HeaderText = "Active";
            Active.Name = "Active";
            Active.ReadOnly = true;
            Active.Resizable = DataGridViewTriState.True;
            Active.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // frmStudentSearchExam120923
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 397);
            Controls.Add(dgvStudents);
            Controls.Add(cbActive);
            Controls.Add(label6);
            Controls.Add(dtpDateFrom);
            Controls.Add(label4);
            Controls.Add(cmbGradeFrom);
            Controls.Add(label3);
            Controls.Add(cmbGradeTo);
            Controls.Add(dtpDateTo);
            Controls.Add(label1);
            Name = "frmStudentSearchExam120923";
            Text = "frmStudentSearchExam120923";
            Load += frmStudentSearchExam120923_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDateTo;
        private ComboBox cmbGradeTo;
        private Label label3;
        private ComboBox cmbGradeFrom;
        private Label label4;
        private DateTimePicker dtpDateFrom;
        private Label label6;
        private CheckBox cbActive;
        private DataGridView dgvStudents;
        private DataGridViewTextBoxColumn FirstLastName;
        private DataGridViewTextBoxColumn IndexNumber;
        private DataGridViewTextBoxColumn Subject;
        private DataGridViewTextBoxColumn Grade;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewCheckBoxColumn Active;
    }
}