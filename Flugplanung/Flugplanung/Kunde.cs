using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flugplanung
{
    class Kunde : Personengruppe
    {
        private static int anzahlKunden = 0;
        private int kunden_ID;
        private string paket;
        private bool bonitaet;
        /// <summary>
        /// Konstruktor der Klasse
        /// </summary>
        /// <param name="vorname"></param>
        /// <param name="nachname"></param>
        /// <param name="paketname"></param>
        /// <param name="bonitaet"></param>
        public Kunde (string vorname, string nachname,string paketname,bool bonitaet) :base(vorname,nachname)
        {
            this.paket = paketname;
            this.bonitaet = bonitaet;
            anzahlKunden++;
            this.kunden_ID = anzahlKunden;
        }
        /// <summary>
        /// Ausgabe der Werte vom Kunden und aufrufen der Ausgabemethode der Klasse Personengruppe
        /// </summary>
        public void kAusgabe()
        {
            this.Ausgabe();
            Console.WriteLine("Kundennummer: " + this.kunden_ID);
            Console.WriteLine("Im Paket ist: " + this.paket);
            if (this.bonitaet)
            {
                Console.WriteLine("Bonität: Ja");
            }
            else
            {
                Console.WriteLine("Bonität: Nein");
            }
            
        }
    }
}
