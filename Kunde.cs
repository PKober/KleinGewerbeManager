namespace Klassenbibliothek
{
    public class Kunde
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Adresse { get; set; }
        public List<Auftrag>? AuftragsListe { get; set; }

        public Kunde(string name, string adresse)
        {
            this.Name = name;
            this.Adresse = adresse;
        }

        public Kunde()
        {
                
        }
    }
}
