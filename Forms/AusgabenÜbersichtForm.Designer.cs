namespace Komponenten.Forms
{
    partial class MeineForm
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
            listView1 = new ListView();
            cbPrivatAnzeigen = new CheckBox();
            btn_zurück = new Button();
            lblSumme = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            listView1.Location = new Point(170, 39);
            listView1.Name = "listView1";
            listView1.Size = new Size(275, 322);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.Resize += listView1_Resize;
            // 
            // cbPrivatAnzeigen
            // 
            cbPrivatAnzeigen.AutoSize = true;
            cbPrivatAnzeigen.Location = new Point(12, 39);
            cbPrivatAnzeigen.Name = "cbPrivatAnzeigen";
            cbPrivatAnzeigen.Size = new Size(111, 19);
            cbPrivatAnzeigen.TabIndex = 1;
            cbPrivatAnzeigen.Text = "Privat anzeigen?";
            cbPrivatAnzeigen.UseVisualStyleBackColor = true;
            cbPrivatAnzeigen.CheckedChanged += checkBox_Privat_checked;
            // 
            // btn_zurück
            // 
            btn_zurück.Location = new Point(37, 376);
            btn_zurück.Name = "btn_zurück";
            btn_zurück.Size = new Size(75, 23);
            btn_zurück.TabIndex = 4;
            btn_zurück.Text = "Zurück";
            btn_zurück.UseVisualStyleBackColor = true;
            btn_zurück.Click += Btn_zurück_click;
            // 
            // lblSumme
            // 
            lblSumme.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblSumme.AutoSize = true;
            lblSumme.Location = new Point(170, 364);
            lblSumme.Name = "lblSumme";
            lblSumme.Size = new Size(0, 15);
            lblSumme.TabIndex = 5;
            // 
            // MeineForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 413);
            Controls.Add(lblSumme);
            Controls.Add(btn_zurück);
            Controls.Add(cbPrivatAnzeigen);
            Controls.Add(listView1);
            Name = "MeineForm";
            Text = "Ausgaben Übersicht";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private CheckBox cbPrivatAnzeigen;
        private Button btn_zurück;
        private Label lblSumme;
    }
}