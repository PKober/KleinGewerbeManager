namespace Komponenten
{
    partial class KundenErstellenForm
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
            TbNamenEingabe = new TextBox();
            lblNamenKunde = new Label();
            tbAdresseKunden = new TextBox();
            lblAdresseKunde = new Label();
            btnSpeichern = new Button();
            btnZurück = new Button();
            SuspendLayout();
            // 
            // TbNamenEingabe
            // 
            TbNamenEingabe.Location = new Point(23, 54);
            TbNamenEingabe.Name = "TbNamenEingabe";
            TbNamenEingabe.PlaceholderText = "Bitte Namen eingeben";
            TbNamenEingabe.Size = new Size(142, 23);
            TbNamenEingabe.TabIndex = 0;
            // 
            // lblNamenKunde
            // 
            lblNamenKunde.AutoSize = true;
            lblNamenKunde.Location = new Point(23, 36);
            lblNamenKunde.Name = "lblNamenKunde";
            lblNamenKunde.Size = new Size(163, 15);
            lblNamenKunde.TabIndex = 1;
            lblNamenKunde.Text = "Namen des Kunden eingeben";
            // 
            // tbAdresseKunden
            // 
            tbAdresseKunden.Location = new Point(23, 126);
            tbAdresseKunden.Name = "tbAdresseKunden";
            tbAdresseKunden.PlaceholderText = "Bitte Adresse des Kunden eingeben ";
            tbAdresseKunden.Size = new Size(142, 23);
            tbAdresseKunden.TabIndex = 2;
            // 
            // lblAdresseKunde
            // 
            lblAdresseKunde.AutoSize = true;
            lblAdresseKunde.Location = new Point(23, 108);
            lblAdresseKunde.Name = "lblAdresseKunde";
            lblAdresseKunde.Size = new Size(168, 15);
            lblAdresseKunde.TabIndex = 3;
            lblAdresseKunde.Text = " Adresse des Kunden eingeben";
            // 
            // btnSpeichern
            // 
            btnSpeichern.Location = new Point(12, 205);
            btnSpeichern.Name = "btnSpeichern";
            btnSpeichern.Size = new Size(75, 23);
            btnSpeichern.TabIndex = 4;
            btnSpeichern.Text = "Speichern";
            btnSpeichern.UseVisualStyleBackColor = true;
            btnSpeichern.Click += btnSpeichern_Click;
            // 
            // btnZurück
            // 
            btnZurück.Location = new Point(111, 205);
            btnZurück.Name = "btnZurück";
            btnZurück.Size = new Size(75, 23);
            btnZurück.TabIndex = 5;
            btnZurück.Text = "Zurück";
            btnZurück.UseVisualStyleBackColor = true;
            btnZurück.Click += btnZurück_Click;
            // 
            // KundenErstellenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(198, 260);
            Controls.Add(btnZurück);
            Controls.Add(btnSpeichern);
            Controls.Add(lblAdresseKunde);
            Controls.Add(tbAdresseKunden);
            Controls.Add(lblNamenKunde);
            Controls.Add(TbNamenEingabe);
            Name = "KundenErstellenForm";
            Text = "Kunden anlegen";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TbNamenEingabe;
        private Label lblNamenKunde;
        private TextBox tbAdresseKunden;
        private Label lblAdresseKunde;
        private Button btnSpeichern;
        private Button btnZurück;
    }
}
