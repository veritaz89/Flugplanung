using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flugplanung
{
    class Personengruppe
    {
        private string nachname;
        private string vorname;
        /// <summary>
        /// Konstruktor der Klasse
        /// </summary>
        /// <param name="vname"></param>
        /// <param name="nname"></param>
        public Personengruppe(string vname, string nname)
        {
            this.vorname = vname;
            this.nachname = nname;
        }
        /// <summary>
        /// Ausgabe der Namen der Personen
        /// </summary>
       public void Ausgabe()
        {
            Console.WriteLine("Name: {0} {1}", this.vorname, this.nachname);
        }
    }
}
