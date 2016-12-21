using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flugplanung
{
    class Techniker : Personengruppe
    {
        private static int anzahlTechniker = 0;
        private int technikernummer;
        private bool wartungslizenz;
        /// <summary>
        /// Konstruktor der Klasse
        /// </summary>
        /// <param name="vname"></param>
        /// <param name="nname"></param>
        /// <param name="lizenz"></param>
        public Techniker (string vname,string nname,bool lizenz):base(vname,nname)
        {
            anzahlTechniker++;
            this.technikernummer = anzahlTechniker;
            this.wartungslizenz = lizenz;
        }
        /// <summary>
        /// Ausgabe der Werte vom Techniker und aufrufen der Ausgabemethode der Klasse Personengruppe
        /// </summary>
        public void tAusgabe ()
        {
            this.Ausgabe();
            Console.WriteLine("Techikernummer: " + this.technikernummer);
            if(this.wartungslizenz)
            {
                Console.WriteLine("Wartungslizenz vorhanden: Ja");
            }
            else
            {
                Console.WriteLine("Wartungslizenz vorhanden: Nein");
            }
        }
    }
}
