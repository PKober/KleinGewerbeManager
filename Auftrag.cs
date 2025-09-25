using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassenbibliothek
{
    public class Auftrag
    {
        public int Id { get; set; }
        public decimal Betrag { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Kunde Kunde { get; set; }
    }
}
