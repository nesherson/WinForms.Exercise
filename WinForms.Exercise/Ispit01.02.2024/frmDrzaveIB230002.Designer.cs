namespace WinForms.Exercise.Ispit01._02._2024
{
    partial class frmDrzaveIB230002
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
            dgvDrzave = new DataGridView();
            Zastava = new DataGridViewImageColumn();
            Drzava = new DataGridViewTextBoxColumn();
            BrojGradova = new DataGridViewTextBoxColumn();
            Aktivna = new DataGridViewCheckBoxColumn();
            BtnGradovi = new DataGridViewButtonColumn();
            btnNovaDrzava = new Button();
            btnPrintaj = new Button();
            statusStrip1 = new StatusStrip();
            tslVrijeme = new ToolStripStatusLabel();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvDrzave).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDrzave
            // 
            dgvDrzave.AllowUserToAddRows = false;
            dgvDrzave.AllowUserToDeleteRows = false;
            dgvDrzave.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrzave.Columns.AddRange(new DataGridViewColumn[] { Zastava, Drzava, BrojGradova, Aktivna, BtnGradovi });
            dgvDrzave.Location = new Point(12, 58);
            dgvDrzave.Name = "dgvDrzave";
            dgvDrzave.ReadOnly = true;
            dgvDrzave.RowTemplate.Height = 25;
            dgvDrzave.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDrzave.Size = new Size(776, 336);
            dgvDrzave.TabIndex = 0;
            dgvDrzave.CellContentClick += dgvDrzave_CellContentClick;
            // 
            // Zastava
            // 
            Zastava.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Zastava.DataPropertyName = "Zastava";
            Zastava.HeaderText = "Zastava";
            Zastava.Name = "Zastava";
            Zastava.ReadOnly = true;
            Zastava.Width = 217;
            // 
            // Drzava
            // 
            Drzava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Drzava.DataPropertyName = "Drzava";
            Drzava.HeaderText = "Drzava";
            Drzava.Name = "Drzava";
            Drzava.ReadOnly = true;
            // 
            // BrojGradova
            // 
            BrojGradova.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BrojGradova.DataPropertyName = "BrojGradova";
            BrojGradova.HeaderText = "Broj gradova";
            BrojGradova.Name = "BrojGradova";
            BrojGradova.ReadOnly = true;
            // 
            // Aktivna
            // 
            Aktivna.DataPropertyName = "Aktivna";
            Aktivna.HeaderText = "Aktivna";
            Aktivna.Name = "Aktivna";
            Aktivna.ReadOnly = true;
            // 
            // BtnGradovi
            // 
            BtnGradovi.HeaderText = "";
            BtnGradovi.Name = "BtnGradovi";
            BtnGradovi.ReadOnly = true;
            BtnGradovi.Text = "Gradovi";
            BtnGradovi.UseColumnTextForButtonValue = true;
            // 
            // btnNovaDrzava
            // 
            btnNovaDrzava.Location = new Point(688, 29);
            btnNovaDrzava.Name = "btnNovaDrzava";
            btnNovaDrzava.Size = new Size(100, 23);
            btnNovaDrzava.TabIndex = 1;
            btnNovaDrzava.Text = "Nova država";
            btnNovaDrzava.UseVisualStyleBackColor = true;
            btnNovaDrzava.Click += btnNovaDrzava_Click;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(713, 400);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(75, 23);
            btnPrintaj.TabIndex = 2;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += btnPrintaj_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tslVrijeme });
            statusStrip1.Location = new Point(0, 442);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // tslVrijeme
            // 
            tslVrijeme.Name = "tslVrijeme";
            tslVrijeme.Size = new Size(59, 17);
            tslVrijeme.Text = "tslVrijeme";
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // frmDrzaveIB230002
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 464);
            Controls.Add(statusStrip1);
            Controls.Add(btnPrintaj);
            Controls.Add(btnNovaDrzava);
            Controls.Add(dgvDrzave);
            Name = "frmDrzaveIB230002";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Države";
            Load += frmDrzaveIB230002_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDrzave).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDrzave;
        private Button btnNovaDrzava;
        private Button btnPrintaj;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tslVrijeme;
        private System.Windows.Forms.Timer timer;
        private DataGridViewImageColumn Zastava;
        private DataGridViewTextBoxColumn Drzava;
        private DataGridViewTextBoxColumn BrojGradova;
        private DataGridViewCheckBoxColumn Aktivna;
        private DataGridViewButtonColumn BtnGradovi;
    }
}