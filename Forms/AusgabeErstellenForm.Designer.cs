namespace Komponenten.Forms
{
    partial class AusgabeErstellenForm
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
            lblAusgabeName = new Label();
            tbNamenEingeben = new TextBox();
            tbBetragEingeben = new TextBox();
            lblAusgabeBetrag = new Label();
            cbPrivatAusgabe = new CheckBox();
            lblDetails = new Label();
            listView1 = new ListView();
            ColAusgabenName = new ColumnHeader();
            Col_AusgabeBetrag = new ColumnHeader();
            btnSpeichern = new Button();
            btnZurück = new Button();
            cbBeschreibungHinzu = new CheckBox();
            tb_Beschreibung = new TextBox();
            CBDatum = new CheckBox();
            SuspendLayout();
            // 
            // lblAusgabeName
            // 
            lblAusgabeName.AutoSize = true;
            lblAusgabeName.Location = new Point(31, 24);
            lblAusgabeName.Name = "lblAusgabeName";
            lblAusgabeName.Size = new Size(88, 15);
            lblAusgabeName.TabIndex = 0;
            lblAusgabeName.Text = "Ausgabe Name";
            // 
            // tbNamenEingeben
            // 
            tbNamenEingeben.Location = new Point(31, 42);
            tbNamenEingeben.Name = "tbNamenEingeben";
            tbNamenEingeben.Size = new Size(129, 23);
            tbNamenEingeben.TabIndex = 1;
            // 
            // tbBetragEingeben
            // 
            tbBetragEingeben.Location = new Point(31, 103);
            tbBetragEingeben.Name = "tbBetragEingeben";
            tbBetragEingeben.Size = new Size(122, 23);
            tbBetragEingeben.TabIndex = 2;
            tbBetragEingeben.KeyPress += tbKontrolle_Betrag;
            // 
            // lblAusgabeBetrag
            // 
            lblAusgabeBetrag.AutoSize = true;
            lblAusgabeBetrag.Location = new Point(31, 85);
            lblAusgabeBetrag.Name = "lblAusgabeBetrag";
            lblAusgabeBetrag.Size = new Size(93, 15);
            lblAusgabeBetrag.TabIndex = 3;
            lblAusgabeBetrag.Text = "Ausgabe Betrag:";
            // 
            // cbPrivatAusgabe
            // 
            cbPrivatAusgabe.AutoSize = true;
            cbPrivatAusgabe.Location = new Point(31, 132);
            cbPrivatAusgabe.Name = "cbPrivatAusgabe";
            cbPrivatAusgabe.Size = new Size(110, 19);
            cbPrivatAusgabe.TabIndex = 4;
            cbPrivatAusgabe.Text = "Privat Ausgabe?";
            cbPrivatAusgabe.UseVisualStyleBackColor = true;
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Location = new Point(229, 24);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(91, 15);
            lblDetails.TabIndex = 6;
            lblDetails.Text = "Ausgabe Details";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ColAusgabenName, Col_AusgabeBetrag });
            listView1.GridLines = true;
            listView1.Location = new Point(198, 49);
            listView1.Name = "listView1";
            listView1.Size = new Size(157, 145);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ColAusgabenName
            // 
            ColAusgabenName.Text = "Name";
            ColAusgabenName.Width = 90;
            // 
            // Col_AusgabeBetrag
            // 
            Col_AusgabeBetrag.Text = "Betrag";
            // 
            // btnSpeichern
            // 
            btnSpeichern.Location = new Point(31, 259);
            btnSpeichern.Name = "btnSpeichern";
            btnSpeichern.Size = new Size(75, 23);
            btnSpeichern.TabIndex = 8;
            btnSpeichern.Text = "Speichern";
            btnSpeichern.UseVisualStyleBackColor = true;
            btnSpeichern.Click += btnSpeichern_Click;
            // 
            // btnZurück
            // 
            btnZurück.Location = new Point(245, 259);
            btnZurück.Name = "btnZurück";
            btnZurück.Size = new Size(75, 23);
            btnZurück.TabIndex = 9;
            btnZurück.Text = "Zurück";
            btnZurück.UseVisualStyleBackColor = true;
            btnZurück.Click += btnZurück_Click;
            // 
            // cbBeschreibungHinzu
            // 
            cbBeschreibungHinzu.AutoSize = true;
            cbBeschreibungHinzu.Location = new Point(31, 182);
            cbBeschreibungHinzu.Name = "cbBeschreibungHinzu";
            cbBeschreibungHinzu.Size = new Size(166, 19);
            cbBeschreibungHinzu.TabIndex = 10;
            cbBeschreibungHinzu.Text = "Beschreibung hinzufügen?";
            cbBeschreibungHinzu.UseVisualStyleBackColor = true;
            cbBeschreibungHinzu.CheckedChanged += Cb_Beschreibung_Checked;
            // 
            // tb_Beschreibung
            // 
            tb_Beschreibung.Location = new Point(31, 207);
            tb_Beschreibung.Multiline = true;
            tb_Beschreibung.Name = "tb_Beschreibung";
            tb_Beschreibung.PlaceholderText = "Beschreibung....";
            tb_Beschreibung.Size = new Size(306, 46);
            tb_Beschreibung.TabIndex = 11;
            // 
            // CBDatum
            // 
            CBDatum.AutoSize = true;
            CBDatum.Location = new Point(31, 157);
            CBDatum.Name = "CBDatum";
            CBDatum.Size = new Size(125, 19);
            CBDatum.TabIndex = 12;
            CBDatum.Text = "Datum von Heute?";
            CBDatum.UseVisualStyleBackColor = true;
            // 
            // AusgabeErstellenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 294);
            Controls.Add(CBDatum);
            Controls.Add(tb_Beschreibung);
            Controls.Add(cbBeschreibungHinzu);
            Controls.Add(btnZurück);
            Controls.Add(btnSpeichern);
            Controls.Add(listView1);
            Controls.Add(lblDetails);
            Controls.Add(cbPrivatAusgabe);
            Controls.Add(lblAusgabeBetrag);
            Controls.Add(tbBetragEingeben);
            Controls.Add(tbNamenEingeben);
            Controls.Add(lblAusgabeName);
            Name = "AusgabeErstellenForm";
            Text = "AusgabeErstellenForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAusgabeName;
        private TextBox tbNamenEingeben;
        private TextBox tbBetragEingeben;
        private Label lblAusgabeBetrag;
        private CheckBox cbPrivatAusgabe;
        private Label lblDetails;
        private ListView listView1;
        private Button btnSpeichern;
        private Button btnZurück;
        private CheckBox cbBeschreibungHinzu;
        private TextBox tb_Beschreibung;
        private ColumnHeader ColAusgabenName;
        private ColumnHeader Col_AusgabeBetrag;
        private CheckBox CBDatum;
    }
}