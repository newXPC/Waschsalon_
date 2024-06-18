using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Waschsalon
{
    public class Kunden
    {
        public int kundenNummer {get; set;}
        public string vorname { get; set;}
        public string nachname { get; set;}
        public bool kundenKarte { get; set;}

        public Kunden (int Kundennummer, string Vorname, string Nachname, bool Kundenkarte){
            kundenNummer = Kundennummer;
            vorname = Vorname;
            nachname = Nachname;
            kundenKarte = Kundenkarte;
        }
    }
}