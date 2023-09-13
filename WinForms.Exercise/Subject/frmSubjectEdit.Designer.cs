namespace WinForms.Exercise
{
    partial class frmSubjectEdit
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
            txtSubjectName = new TextBox();
            btnAddSubject = new Button();
            dgvSubjects = new DataGridView();
            SubjectName = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).BeginInit();
            SuspendLayout();
            // 
            // txtSubjectName
            // 
            txtSubjectName.Location = new Point(12, 91);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(311, 23);
            txtSubjectName.TabIndex = 0;
            // 
            // btnAddSubject
            // 
            btnAddSubject.Location = new Point(343, 90);
            btnAddSubject.Name = "btnAddSubject";
            btnAddSubject.Size = new Size(94, 23);
            btnAddSubject.TabIndex = 1;
            btnAddSubject.Text = "Add subject";
            btnAddSubject.UseVisualStyleBackColor = true;
            btnAddSubject.Click += btnAddSubject_Click;
            // 
            // dgvSubjects
            // 
            dgvSubjects.AllowUserToAddRows = false;
            dgvSubjects.AllowUserToDeleteRows = false;
            dgvSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubjects.Columns.AddRange(new DataGridViewColumn[] { SubjectName });
            dgvSubjects.Location = new Point(12, 120);
            dgvSubjects.Name = "dgvSubjects";
            dgvSubjects.ReadOnly = true;
            dgvSubjects.RowTemplate.Height = 25;
            dgvSubjects.Size = new Size(425, 190);
            dgvSubjects.TabIndex = 2;
            // 
            // SubjectName
            // 
            SubjectName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SubjectName.DataPropertyName = "Name";
            SubjectName.HeaderText = "Name";
            SubjectName.Name = "SubjectName";
            SubjectName.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 73);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 3;
            label1.Text = "Subject name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(169, 37);
            label2.TabIndex = 4;
            label2.Text = "Add subject";
            // 
            // frmSubjectEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 321);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvSubjects);
            Controls.Add(btnAddSubject);
            Controls.Add(txtSubjectName);
            Name = "frmSubjectEdit";
            Text = "Add subject";
            Load += frmSubjectEdit_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSubjectName;
        private Button btnAddSubject;
        private DataGridView dgvSubjects;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn SubjectName;
    }
}