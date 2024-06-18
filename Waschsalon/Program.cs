using System;

namespace Waschsalon
{
    public class Waschsalon
    {
        static List<Kunden> kundenListe = new List<Kunden>();

        static int KundenNummer = 1;

        public static void Main(string[] args)
        {
            kundenMenue();
        }

        public static void kundenMenue()
        {
            int eingabe;
            do
            {
                Console.WriteLine("Kunden Menü:");
                Console.WriteLine("1. Kunde hinzufügen");
                Console.WriteLine("2. Kunden anzeigen");
                Console.WriteLine("3. Kunde löschen");
                Console.WriteLine("4. Kunde suchen");
                Console.WriteLine("5. Programm beenden");
                Console.WriteLine("");
                Console.WriteLine("Deine Auswahl:");

                eingabe = Convert.ToInt32(Console.ReadLine());

                switch (eingabe)
                {
                    case 1:
                        kundenHinzufuegen();
                    break;

                    case 2:
                        kundenAnzeigen();
                    break;

                    case 3:
                        kundeLoeschen();
                    break;

                    case 4:
                        kundeSuchen();
                    break;

                    default:
                        if (eingabe != 5)
                        {
                            Console.WriteLine("Ungültige Eingabe!");
                        }
                    break;
                }
            }while(eingabe != 5);
        }

        static void kundenHinzufuegen()
        {
            string vorname;
            string nachname;
            bool kundenKarte;

            Console.WriteLine("Vorname");
            vorname = Console.ReadLine();
            Console.WriteLine("Nachname");
            nachname = Console.ReadLine();
            Console.WriteLine("Möchte der Kunden eine Kundenkarte? Y/N");
            if (Console.ReadLine() == "y")
            {
                kundenKarte = true;
                Console.WriteLine("Dem Kunden wurde eine Kundenkarte hinzugefügt");
            }
            else
            {
                kundenKarte = false;
            }

            Kunden neuerKunde = new Kunden( KundenNummer, vorname, nachname, kundenKarte);
            kundenListe.Add(neuerKunde);
            KundenNummer++;
            Console.WriteLine("Der Kunde wurde hinzugefügt");
        }
        
        static void kundenAnzeigen()
        {
            foreach (var kunde in kundenListe)
            {
                Console.WriteLine($"{kundenListe.kundenNummer}, {kundenListe.vorname}, {kundenListe.nachname}, {kundenListe.kundenKarte}");
            }
        }

        static void kundeLoeschen()
        {
            int id;
            foreach (var kunde in kundenListe)
            {
                Console.WriteLine($"{kundenListe.kundenNummer}, {kundenListe.vorname}, {kundenListe.nachname}, {kundenListe.kundenKarte}");
            }

            Console.WriteLine("Gebe die Id des Kunden an");
            id = Convert.ToInt32(Console.ReadLine());

            foreach(var kunde in kundenListe)
            {
                if(id = kundenListe.kundenNummer)
                {
                    kundenListe.Remove(kunde);
                    Console.WriteLine("Der Kunde wurde gelöscht");
                    break;
                }
                Console.WriteLine("Es wurde keine ID gefunden");
            }

        }

        static void kundeSuchen()
        {
            string eingabe;
            Console.WriteLine("Gebe den Kunden ein");
            eingabe = Console.ReadLine();
            foreach (var kunde in kundenListe)
            {
                if(eingabe == kundenListe.kundenNummer || eingabe == kundenListe.vorname || eingabe == kundenListe.nachname)
                {
                    Console.WriteLine($"{kundenListe.kundenNummer}, {kundenListe.vorname}, {kundenListe.nachname}, {kundenListe.kundenKarte}");
                }
            }

        }

        
    }
}