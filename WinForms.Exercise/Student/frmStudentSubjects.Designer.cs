namespace WinForms.Exercise
{
    partial class frmStudentSubjects
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
            dgvStudentSubjects = new DataGridView();
            Subject = new DataGridViewTextBoxColumn();
            Grade = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            cmbSubjects = new ComboBox();
            cmbGrades = new ComboBox();
            label1 = new Label();
            dtpDate = new DateTimePicker();
            btnAddStudentSubject = new Button();
            errorProvider = new ErrorProvider(components);
            cmbStudents = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvStudentSubjects).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // dgvStudentSubjects
            // 
            dgvStudentSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentSubjects.Columns.AddRange(new DataGridViewColumn[] { Subject, Grade, Date });
            dgvStudentSubjects.Location = new Point(12, 123);
            dgvStudentSubjects.Name = "dgvStudentSubjects";
            dgvStudentSubjects.RowTemplate.Height = 25;
            dgvStudentSubjects.Size = new Size(614, 312);
            dgvStudentSubjects.TabIndex = 0;
            // 
            // Subject
            // 
            Subject.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Subject.DataPropertyName = "Subject";
            Subject.HeaderText = "Subject";
            Subject.Name = "Subject";
            // 
            // Grade
            // 
            Grade.DataPropertyName = "Grade";
            Grade.HeaderText = "Grade";
            Grade.Name = "Grade";
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Date.DataPropertyName = "Date";
            Date.HeaderText = "Date";
            Date.Name = "Date";
            // 
            // cmbSubjects
            // 
            cmbSubjects.FormattingEnabled = true;
            cmbSubjects.Location = new Point(12, 94);
            cmbSubjects.Name = "cmbSubjects";
            cmbSubjects.Size = new Size(240, 23);
            cmbSubjects.TabIndex = 1;
            // 
            // cmbGrades
            // 
            cmbGrades.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrades.FormattingEnabled = true;
            cmbGrades.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
            cmbGrades.Location = new Point(258, 94);
            cmbGrades.Name = "cmbGrades";
            cmbGrades.Size = new Size(58, 23);
            cmbGrades.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(228, 37);
            label1.TabIndex = 3;
            label1.Text = "Student subjects";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(322, 94);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 4;
            // 
            // btnAddStudentSubject
            // 
            btnAddStudentSubject.Location = new Point(551, 93);
            btnAddStudentSubject.Name = "btnAddStudentSubject";
            btnAddStudentSubject.Size = new Size(75, 24);
            btnAddStudentSubject.TabIndex = 5;
            btnAddStudentSubject.Text = "Add";
            btnAddStudentSubject.UseVisualStyleBackColor = true;
            btnAddStudentSubject.Click += btnAddStudentSubject_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // cmbStudents
            // 
            cmbStudents.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudents.FormattingEnabled = true;
            cmbStudents.Location = new Point(411, 12);
            cmbStudents.Name = "cmbStudents";
            cmbStudents.Size = new Size(219, 23);
            cmbStudents.TabIndex = 6;
            cmbStudents.SelectedIndexChanged += cmbStudents_SelectedIndexChanged;
            // 
            // frmStudentSubjects
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 447);
            Controls.Add(cmbStudents);
            Controls.Add(btnAddStudentSubject);
            Controls.Add(dtpDate);
            Controls.Add(label1);
            Controls.Add(cmbGrades);
            Controls.Add(cmbSubjects);
            Controls.Add(dgvStudentSubjects);
            Name = "frmStudentSubjects";
            Text = "Student subjects";
            Load += frmStudentSubjects_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudentSubjects).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudentSubjects;
        private ComboBox cmbSubjects;
        private ComboBox cmbGrades;
        private Label label1;
        private DateTimePicker dtpDate;
        private Button btnAddStudentSubject;
        private ErrorProvider errorProvider;
        private DataGridViewTextBoxColumn Subject;
        private DataGridViewTextBoxColumn Grade;
        private DataGridViewTextBoxColumn Date;
        private ComboBox cmbStudents;
    }
}