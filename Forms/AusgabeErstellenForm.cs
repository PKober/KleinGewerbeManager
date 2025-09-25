using Klassenbibliothek;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komponenten.Forms
{
    public partial class AusgabeErstellenForm : Form
    {
        public AusgabeErstellenForm()
        {
            InitializeComponent();
            tb_Beschreibung.Visible = false;
        }

        Ausgabe ausgabe = new Ausgabe();
        DialogResult dialogResult;
        private void btnSpeichern_Click(object sender, EventArgs e)
        {

            if (tbBetragEingeben.Text != string.Empty || tbNamenEingeben.Text != string.Empty)
            {
                if (tbNamenEingeben.Text != string.Empty)
                {
                    ausgabe.Name = tbNamenEingeben.Text;
                }
                else
                {
                    MessageBox.Show("Bitte Namen der Ausgabe angeben");
                    return;

                }
                // ausgabe.Betrag = Convert.ToDecimal(tbBetragEingeben.Text);


                if (tbBetragEingeben.Text != string.Empty)
                {
                    ausgabe.Betrag = Convert.ToDecimal(tbBetragEingeben.Text);
                }
                else
                {
                    MessageBox.Show("Bitte Betrag eingeben");
                    return;
                }

            }
            else
            {
                MessageBox.Show("Bitte Betrag und einen Namen eingeben");
                return;
            }


            if (tb_Beschreibung.Visible && tb_Beschreibung.Text != string.Empty)
            {
                ausgabe.Beschreibung = tb_Beschreibung.Text;
            }
            else
            {
                ausgabe.Beschreibung = "Keine Beschreibung vorhanden";
            }

            ausgabe.Privat = cbPrivatAusgabe.Checked;
            ausgabe.Datum = DateTime.UtcNow.Date;
            ListViewItem item = new ListViewItem(ausgabe.Name);
            item.SubItems.Add(ausgabe.Betrag.ToString() + " €");
            listView1.Items.Add(item);

            tb_Beschreibung.Text = string.Empty;
            tbNamenEingeben.Text = string.Empty;
            tbBetragEingeben.Text = string.Empty;

        }

        private void tbKontrolle_Betrag(object sender, KeyPressEventArgs e)
        {
            // Erlaube Ziffern und Steuerelemente
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Erlaube nur EIN Komma
            // Die Bedingung prüft, ob die gedrückte Taste ein Komma ist UND
            // ob in der TextBox bereits ein Komma enthalten ist.
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(','))
            {
                e.Handled = true;
            }
        }

        private void btnZurück_Click(Object sender, EventArgs e)
        {

            if (tbNamenEingeben.Text != string.Empty || tbBetragEingeben.Text != string.Empty)
            {
                dialogResult = MessageBox.Show("Wirklich beenden?", null, MessageBoxButtons.OKCancel);
            }else
            {
                this.Close();
            }

            if (DialogResult.OK == dialogResult)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void Cb_Beschreibung_Checked(object sender, EventArgs e)
        {
            if (cbBeschreibungHinzu.Checked)
            {
                tb_Beschreibung.Visible = true;
                tb_Beschreibung.Focus();

            }
            else
            {
                tb_Beschreibung.Visible = false;
            }
        }

        
    }
}
