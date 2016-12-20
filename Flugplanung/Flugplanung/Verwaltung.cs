using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flugplanung
{
    class Verwaltung
    {
        List<object> Flugmodelle = new List<object>();
        public void Run ()
        {
            Flugmodel A360 = new Flugmodel("A360",5000, 10000, 20000);
            Flugmodel A40 = new Flugmodel("A40",500, 100, 2000);
            Flugmodelle.Add(A360);
            Flugmodelle.Add(A40);            
            A360.Ausgabe();
            A40.Ausgabe();
            Console.ReadLine();
        }
       
    }
}
