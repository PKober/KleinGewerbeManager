namespace KleinGewerbeManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            erstellenToolStripMenuItem = new ToolStripMenuItem();
            kundeToolStripMenuItem = new ToolStripMenuItem();
            ausgabeToolStripMenuItem = new ToolStripMenuItem();
            einnahmeToolStripMenuItem = new ToolStripMenuItem();
            übersichtToolStripMenuItem = new ToolStripMenuItem();
            kundenToolStripMenuItem = new ToolStripMenuItem();
            aufträgeToolStripMenuItem = new ToolStripMenuItem();
            ausgabenToolStripMenuItem = new ToolStripMenuItem();
            einnahmenToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { erstellenToolStripMenuItem, übersichtToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(438, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // erstellenToolStripMenuItem
            // 
            erstellenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kundeToolStripMenuItem, ausgabeToolStripMenuItem, einnahmeToolStripMenuItem });
            erstellenToolStripMenuItem.Name = "erstellenToolStripMenuItem";
            erstellenToolStripMenuItem.Size = new Size(63, 20);
            erstellenToolStripMenuItem.Text = "Erstellen";
            // 
            // kundeToolStripMenuItem
            // 
            kundeToolStripMenuItem.Name = "kundeToolStripMenuItem";
            kundeToolStripMenuItem.Size = new Size(127, 22);
            kundeToolStripMenuItem.Text = "Kunde";
            kundeToolStripMenuItem.Click += kundeToolStripMenuItem_Click;
            // 
            // ausgabeToolStripMenuItem
            // 
            ausgabeToolStripMenuItem.Name = "ausgabeToolStripMenuItem";
            ausgabeToolStripMenuItem.Size = new Size(127, 22);
            ausgabeToolStripMenuItem.Text = "Ausgabe";
            ausgabeToolStripMenuItem.Click += ausgabeToolStripMenuItem_Click;
            // 
            // einnahmeToolStripMenuItem
            // 
            einnahmeToolStripMenuItem.Name = "einnahmeToolStripMenuItem";
            einnahmeToolStripMenuItem.Size = new Size(127, 22);
            einnahmeToolStripMenuItem.Text = "Einnahme";
            // 
            // übersichtToolStripMenuItem
            // 
            übersichtToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kundenToolStripMenuItem, aufträgeToolStripMenuItem, ausgabenToolStripMenuItem, einnahmenToolStripMenuItem });
            übersichtToolStripMenuItem.Name = "übersichtToolStripMenuItem";
            übersichtToolStripMenuItem.Size = new Size(69, 20);
            übersichtToolStripMenuItem.Text = "Übersicht";
            // 
            // kundenToolStripMenuItem
            // 
            kundenToolStripMenuItem.Name = "kundenToolStripMenuItem";
            kundenToolStripMenuItem.Size = new Size(180, 22);
            kundenToolStripMenuItem.Text = "Kunden";
            // 
            // aufträgeToolStripMenuItem
            // 
            aufträgeToolStripMenuItem.Name = "aufträgeToolStripMenuItem";
            aufträgeToolStripMenuItem.Size = new Size(180, 22);
            aufträgeToolStripMenuItem.Text = "Aufträge";
            // 
            // ausgabenToolStripMenuItem
            // 
            ausgabenToolStripMenuItem.Name = "ausgabenToolStripMenuItem";
            ausgabenToolStripMenuItem.Size = new Size(180, 22);
            ausgabenToolStripMenuItem.Text = "Ausgaben";
            ausgabenToolStripMenuItem.Click += ausgabenToolStripMenuItem_Click;
            // 
            // einnahmenToolStripMenuItem
            // 
            einnahmenToolStripMenuItem.Name = "einnahmenToolStripMenuItem";
            einnahmenToolStripMenuItem.Size = new Size(180, 22);
            einnahmenToolStripMenuItem.Text = "Einnahmen";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem erstellenToolStripMenuItem;
        private ToolStripMenuItem kundeToolStripMenuItem;
        private ToolStripMenuItem ausgabeToolStripMenuItem;
        private ToolStripMenuItem übersichtToolStripMenuItem;
        private ToolStripMenuItem kundenToolStripMenuItem;
        private ToolStripMenuItem aufträgeToolStripMenuItem;
        private ToolStripMenuItem ausgabenToolStripMenuItem;
        private ToolStripMenuItem einnahmenToolStripMenuItem;
        private ToolStripMenuItem einnahmeToolStripMenuItem;
    }
}
