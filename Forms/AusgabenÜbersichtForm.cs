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
using static System.Windows.Forms.ListViewItem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Komponenten.Forms
{
    public partial class MeineForm : Form
    {
        public MeineForm()
        {
            InitializeComponent();
            listView1.View = View.Details;
            DatenInListViewLaden();
            AktualisiereSumme();
        }

        List<Ausgabe> ausgaben = new List<Ausgabe>
             {
            new Ausgabe{Betrag=12,Name = "ColaDose",Privat = true,Datum=DateTime.UtcNow.Date},
            new Ausgabe{Name="Für die Firma",Betrag=12.00M,Privat=false ,Datum=DateTime.UtcNow.Date},
            new Ausgabe{Name="Für die Firma 2", Betrag= 22.32M,Privat = false,Datum=DateTime.UtcNow.Date},
            new Ausgabe{Name ="Für Mich", Betrag= 12.32M,Privat = true,Datum=DateTime.UtcNow.Date }
        };


        private void On_Load(object sender, EventArgs e)
        {
            DatenInListViewLaden();
            AktualisiereSumme();
        }


        private void listView1_Resize(object sender, EventArgs e)
        {
            // Stelle sicher, dass die ListView mindestens eine Spalte hat
            if (listView1.Columns.Count == 0)
                return;

            // Berechne die verfügbare Breite für jede Spalte
            int spaltenBreite = listView1.ClientSize.Width / listView1.Columns.Count;

            // Setze die Breite für jede Spalte
            foreach (ColumnHeader column in listView1.Columns)
            {
                column.Width = spaltenBreite;
            }
        }
        private void DatenInListViewLaden()
        {

            if (cbPrivatAnzeigen.Checked)
            {
                listView1.Columns.Clear();
                listView1.Columns.Add("Bezeichnung", 100);
                listView1.Columns.Add("Betrag", 50);
                listView1.Columns.Add("Privat", 100);
                listView1.Columns.Add("Datum", 50);
                foreach (var item in ausgaben)
                {
                    if (item.Privat)
                    {
                        ListViewItem listViewItem = new ListViewItem(item.Name);
                        listViewItem.SubItems.Add(item.Betrag.ToString() + "€");
                        listViewItem.SubItems.Add(item.Privat ? "Private ausgabe" : "");
                        listViewItem.SubItems.Add(item.Datum.ToShortDateString());
                        listView1.Items.Add(listViewItem);
                    }
                }

            }
            else
            {
                listView1.Columns.Clear();
                listView1.Columns.Add("Bezeichnung", 150);
                listView1.Columns.Add("Betrag", 150);
                listView1.Columns.Add("Datum", 50);
                foreach (var item in ausgaben)
                {
                    if (!item.Privat)
                    {
                        ListViewItem listViewItem = new ListViewItem(item.Name);
                        listViewItem.SubItems.Add(item.Betrag.ToString() + "€");
                        listViewItem.SubItems.Add(item.Datum.ToShortDateString());
                        listView1.Items.Add(listViewItem);

                    }
                }
            }

        }

        private void Btn_zurück_click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void checkBox_Privat_checked(object sender, EventArgs e)
        {
            listView1.Clear();
            DatenInListViewLaden();
            AktualisiereSumme();

        }

        private void AktualisiereSumme()
        {
            decimal summe = 0;
            string Betrag = string.Empty;
            foreach (ListViewItem item in listView1.Items)
            {
                // Hole den Text aus der zweiten Spalte (Index 1)
                string betragText = item.SubItems[1].Text;

                // Konvertiere den Text in eine Zahl.
                // Wichtig: Wir müssen das "€"-Zeichen und Leerzeichen entfernen, 
                // bevor wir es in eine Dezimalzahl umwandeln.
                betragText = betragText.Replace("€", "").Trim();

                // Versuche, den Text in eine Dezimalzahl umzuwandeln
                if (decimal.TryParse(betragText, out decimal betrag))
                {
                    summe += betrag;
                }


            }
            
            lblSumme.Text = summe.ToString() + "€";
            lblSumme.Font = new Font(lblSumme.Font.FontFamily, 13, FontStyle.Bold | FontStyle.Italic);

        }
    }
}
