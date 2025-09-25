using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassenbibliothek
{
    public class Ausgabe
    {
        public string? Name { get; set; }
        public decimal Betrag { get; set; }
        public string? Beschreibung { get; set; }
        public bool Privat { get; set; }
        
        public DateTime Datum { get; set; }
    }
}
