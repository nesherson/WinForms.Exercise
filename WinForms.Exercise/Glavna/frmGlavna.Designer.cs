namespace WinForms.Exercise.Glavna
{
    partial class frmGlavna
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
            menuStrip1 = new MenuStrip();
            fajlToolStripMenuItem = new ToolStripMenuItem();
            noviKorisnikToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            odjavaToolStripMenuItem = new ToolStripMenuItem();
            krajRadaToolStripMenuItem = new ToolStripMenuItem();
            vjezbaToolStripMenuItem = new ToolStripMenuItem();
            studentiToolStripMenuItem = new ToolStripMenuItem();
            pretragaToolStripMenuItem = new ToolStripMenuItem();
            noviToolStripMenuItem = new ToolStripMenuItem();
            pingToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fajlToolStripMenuItem, vjezbaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fajlToolStripMenuItem
            // 
            fajlToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { noviKorisnikToolStripMenuItem, toolStripSeparator1, odjavaToolStripMenuItem, krajRadaToolStripMenuItem });
            fajlToolStripMenuItem.Name = "fajlToolStripMenuItem";
            fajlToolStripMenuItem.Size = new Size(37, 20);
            fajlToolStripMenuItem.Text = "Fajl";
            // 
            // noviKorisnikToolStripMenuItem
            // 
            noviKorisnikToolStripMenuItem.Name = "noviKorisnikToolStripMenuItem";
            noviKorisnikToolStripMenuItem.Size = new Size(143, 22);
            noviKorisnikToolStripMenuItem.Text = "Novi korisnik";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(140, 6);
            // 
            // odjavaToolStripMenuItem
            // 
            odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            odjavaToolStripMenuItem.Size = new Size(143, 22);
            odjavaToolStripMenuItem.Text = "Odjava";
            odjavaToolStripMenuItem.Click += odjavaToolStripMenuItem_Click;
            // 
            // krajRadaToolStripMenuItem
            // 
            krajRadaToolStripMenuItem.Name = "krajRadaToolStripMenuItem";
            krajRadaToolStripMenuItem.Size = new Size(143, 22);
            krajRadaToolStripMenuItem.Text = "Kraj rada";
            krajRadaToolStripMenuItem.Click += krajRadaToolStripMenuItem_Click;
            // 
            // vjezbaToolStripMenuItem
            // 
            vjezbaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { studentiToolStripMenuItem, pingToolStripMenuItem });
            vjezbaToolStripMenuItem.Name = "vjezbaToolStripMenuItem";
            vjezbaToolStripMenuItem.Size = new Size(53, 20);
            vjezbaToolStripMenuItem.Text = "Vjezba";
            // 
            // studentiToolStripMenuItem
            // 
            studentiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pretragaToolStripMenuItem, noviToolStripMenuItem });
            studentiToolStripMenuItem.Name = "studentiToolStripMenuItem";
            studentiToolStripMenuItem.Size = new Size(180, 22);
            studentiToolStripMenuItem.Text = "Studenti";
            // 
            // pretragaToolStripMenuItem
            // 
            pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            pretragaToolStripMenuItem.Size = new Size(142, 22);
            pretragaToolStripMenuItem.Text = "Pretraga";
            pretragaToolStripMenuItem.Click += pretragaToolStripMenuItem_Click;
            // 
            // noviToolStripMenuItem
            // 
            noviToolStripMenuItem.Name = "noviToolStripMenuItem";
            noviToolStripMenuItem.Size = new Size(142, 22);
            noviToolStripMenuItem.Text = "Novi student";
            noviToolStripMenuItem.Click += noviToolStripMenuItem_Click;
            // 
            // pingToolStripMenuItem
            // 
            pingToolStripMenuItem.Name = "pingToolStripMenuItem";
            pingToolStripMenuItem.Size = new Size(180, 22);
            pingToolStripMenuItem.Text = "Ping";
            pingToolStripMenuItem.Click += pingToolStripMenuItem_Click;
            // 
            // frmGlavna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "frmGlavna";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGlavna";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fajlToolStripMenuItem;
        private ToolStripMenuItem noviKorisnikToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem odjavaToolStripMenuItem;
        private ToolStripMenuItem krajRadaToolStripMenuItem;
        private ToolStripMenuItem vjezbaToolStripMenuItem;
        private ToolStripMenuItem studentiToolStripMenuItem;
        private ToolStripMenuItem pretragaToolStripMenuItem;
        private ToolStripMenuItem noviToolStripMenuItem;
        private ToolStripMenuItem pingToolStripMenuItem;
    }
}