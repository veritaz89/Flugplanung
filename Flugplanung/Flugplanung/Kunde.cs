using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flugplanung
{
    class Kunde : Personengruppe
    {
        public Kunde (string vorname, string nachname)
        {
            this.vorname = vorname;
            this.nachname = nachname;
        }
    }
}
