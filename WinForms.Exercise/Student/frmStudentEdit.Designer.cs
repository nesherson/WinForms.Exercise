namespace WinForms.Exercise
{
    partial class frmStudentEdit
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
            txtFirstName = new TextBox();
            dtpDateOfBirth = new DateTimePicker();
            pbStudentImage = new PictureBox();
            lblAddEditStudent = new Label();
            groupBox1 = new GroupBox();
            cmbGenders = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            groupBox2 = new GroupBox();
            cbActive = new CheckBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            txtIndexNumber = new TextBox();
            groupBox3 = new GroupBox();
            dgvUserRoles = new DataGridView();
            RoleName = new DataGridViewTextBoxColumn();
            button1 = new Button();
            cmbRoles = new ComboBox();
            btnAddImage = new Button();
            btnSave = new Button();
            ofdUserImage = new OpenFileDialog();
            statusStrip1 = new StatusStrip();
            tslImagePath = new ToolStripStatusLabel();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbStudentImage).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserRoles).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 35);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "First name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(132, 27);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(177, 23);
            txtFirstName.TabIndex = 1;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(132, 146);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(177, 23);
            dtpDateOfBirth.TabIndex = 2;
            // 
            // pbStudentImage
            // 
            pbStudentImage.BackColor = SystemColors.Control;
            pbStudentImage.BorderStyle = BorderStyle.FixedSingle;
            pbStudentImage.Location = new Point(12, 71);
            pbStudentImage.Name = "pbStudentImage";
            pbStudentImage.Size = new Size(212, 226);
            pbStudentImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbStudentImage.TabIndex = 3;
            pbStudentImage.TabStop = false;
            // 
            // lblAddEditStudent
            // 
            lblAddEditStudent.AutoSize = true;
            lblAddEditStudent.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddEditStudent.Location = new Point(359, 21);
            lblAddEditStudent.Name = "lblAddEditStudent";
            lblAddEditStudent.Size = new Size(175, 37);
            lblAddEditStudent.TabIndex = 4;
            lblAddEditStudent.Text = "Add student";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbGenders);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(dtpDateOfBirth);
            groupBox1.Controls.Add(lblLastName);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Location = new Point(248, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(334, 226);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal data";
            // 
            // cmbGenders
            // 
            cmbGenders.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenders.FormattingEnabled = true;
            cmbGenders.Location = new Point(132, 190);
            cmbGenders.Name = "cmbGenders";
            cmbGenders.Size = new Size(177, 23);
            cmbGenders.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 190);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 7;
            label5.Text = "Gender:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 152);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 6;
            label4.Text = "Date of birth:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 113);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(132, 105);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(177, 23);
            txtEmail.TabIndex = 5;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(24, 74);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(64, 15);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(132, 66);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(177, 23);
            txtLastName.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbActive);
            groupBox2.Controls.Add(lblPassword);
            groupBox2.Controls.Add(txtPassword);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtIndexNumber);
            groupBox2.Location = new Point(248, 313);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(334, 128);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "User data";
            // 
            // cbActive
            // 
            cbActive.AutoSize = true;
            cbActive.Location = new Point(250, 100);
            cbActive.Name = "cbActive";
            cbActive.Size = new Size(59, 19);
            cbActive.TabIndex = 14;
            cbActive.Text = "Active";
            cbActive.UseVisualStyleBackColor = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(24, 63);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 11;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(132, 60);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(177, 23);
            txtPassword.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 30);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 9;
            label2.Text = "Index number:";
            // 
            // txtIndexNumber
            // 
            txtIndexNumber.Location = new Point(132, 22);
            txtIndexNumber.Name = "txtIndexNumber";
            txtIndexNumber.Size = new Size(177, 23);
            txtIndexNumber.TabIndex = 10;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvUserRoles);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(cmbRoles);
            groupBox3.Location = new Point(602, 71);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(342, 227);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Roles";
            // 
            // dgvUserRoles
            // 
            dgvUserRoles.AllowUserToAddRows = false;
            dgvUserRoles.AllowUserToDeleteRows = false;
            dgvUserRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserRoles.Columns.AddRange(new DataGridViewColumn[] { RoleName });
            dgvUserRoles.Location = new Point(6, 63);
            dgvUserRoles.Name = "dgvUserRoles";
            dgvUserRoles.ReadOnly = true;
            dgvUserRoles.RowTemplate.Height = 25;
            dgvUserRoles.Size = new Size(329, 150);
            dgvUserRoles.TabIndex = 11;
            // 
            // RoleName
            // 
            RoleName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RoleName.DataPropertyName = "Name";
            RoleName.HeaderText = "Name";
            RoleName.Name = "RoleName";
            RoleName.ReadOnly = true;
            // 
            // button1
            // 
            button1.Location = new Point(238, 26);
            button1.Name = "button1";
            button1.Size = new Size(98, 23);
            button1.TabIndex = 10;
            button1.Text = "Add role";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cmbRoles
            // 
            cmbRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(6, 26);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(141, 23);
            cmbRoles.TabIndex = 9;
            // 
            // btnAddImage
            // 
            btnAddImage.Location = new Point(12, 313);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(212, 23);
            btnAddImage.TabIndex = 8;
            btnAddImage.Text = "Add image";
            btnAddImage.UseVisualStyleBackColor = true;
            btnAddImage.Click += btnAddImage_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(853, 486);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(91, 23);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // ofdUserImage
            // 
            ofdUserImage.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tslImagePath });
            statusStrip1.Location = new Point(0, 518);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(949, 22);
            statusStrip1.TabIndex = 10;
            statusStrip1.Text = "statusStrip1";
            // 
            // tslImagePath
            // 
            tslImagePath.Name = "tslImagePath";
            tslImagePath.Size = new Size(0, 17);
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // frmStudentEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 540);
            Controls.Add(statusStrip1);
            Controls.Add(btnSave);
            Controls.Add(btnAddImage);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblAddEditStudent);
            Controls.Add(pbStudentImage);
            Name = "frmStudentEdit";
            Text = "frmStudentEdit";
            Load += frmStudentEdit_Load;
            ((System.ComponentModel.ISupportInitialize)pbStudentImage).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUserRoles).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirstName;
        private DateTimePicker dtpDateOfBirth;
        private PictureBox pbStudentImage;
        private Label lblAddEditStudent;
        private GroupBox groupBox1;
        private ComboBox cmbGenders;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtEmail;
        private Label lblLastName;
        private TextBox txtLastName;
        private GroupBox groupBox2;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtIndexNumber;
        private CheckBox cbActive;
        private GroupBox groupBox3;
        private Button button1;
        private ComboBox cmbRoles;
        private Button btnAddImage;
        private Button btnSave;
        private OpenFileDialog ofdUserImage;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tslImagePath;
        private ErrorProvider errorProvider;
        private DataGridView dgvUserRoles;
        private DataGridViewTextBoxColumn RoleName;
    }
}