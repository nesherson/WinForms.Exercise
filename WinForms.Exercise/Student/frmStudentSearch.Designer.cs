namespace WinForms.Exercise
{
    partial class frmStudentSearch
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
            dgvStudents = new DataGridView();
            btnAddStudent = new Button();
            txtSearch = new TextBox();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            IndexNumber = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            DateOfBirth = new DataGridViewTextBoxColumn();
            Active = new DataGridViewCheckBoxColumn();
            Predmeti = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { FirstName, LastName, IndexNumber, Gender, DateOfBirth, Active, Predmeti });
            dgvStudents.Location = new Point(12, 41);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowTemplate.Height = 25;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(887, 284);
            dgvStudents.TabIndex = 0;
            dgvStudents.CellContentClick += dgvStudents_CellContentClick;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(795, 12);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(104, 23);
            btnAddStudent.TabIndex = 1;
            btnAddStudent.Text = "Add student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(365, 23);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += textBox1_TextChanged;
            // 
            // FirstName
            // 
            FirstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "First name";
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            LastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "Last name";
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            // 
            // IndexNumber
            // 
            IndexNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IndexNumber.DataPropertyName = "IndexNumber";
            IndexNumber.HeaderText = "Index number";
            IndexNumber.Name = "IndexNumber";
            IndexNumber.ReadOnly = true;
            // 
            // Gender
            // 
            Gender.DataPropertyName = "Gender";
            Gender.HeaderText = "Gender";
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            // 
            // DateOfBirth
            // 
            DateOfBirth.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DateOfBirth.DataPropertyName = "DateOfBirth";
            DateOfBirth.HeaderText = "Date of birth";
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.ReadOnly = true;
            // 
            // Active
            // 
            Active.DataPropertyName = "Active";
            Active.HeaderText = "Active";
            Active.Name = "Active";
            Active.ReadOnly = true;
            // 
            // Predmeti
            // 
            Predmeti.HeaderText = "";
            Predmeti.Name = "Predmeti";
            Predmeti.ReadOnly = true;
            Predmeti.Text = "Predmeti";
            Predmeti.UseColumnTextForButtonValue = true;
            // 
            // frmStudentSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 339);
            Controls.Add(txtSearch);
            Controls.Add(btnAddStudent);
            Controls.Add(dgvStudents);
            Name = "frmStudentSearch";
            Text = "frmStudentSearch";
            Load += frmStudentSearch_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudents;
        private Button btnAddStudent;
        private TextBox txtSearch;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn IndexNumber;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn DateOfBirth;
        private DataGridViewCheckBoxColumn Active;
        private DataGridViewButtonColumn Predmeti;
    }
}