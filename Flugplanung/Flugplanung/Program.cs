using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flugplanung
{
    class Program
    {
        internal Verwaltung Verwaltung
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
        /// <summary>
        /// Initialisierung der Klasse Verwaltung
        /// Aufrufen der Methode Run von der Klasse Verwaltung
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {            
            Verwaltung verwaltung = new Verwaltung();
            verwaltung.Run();
        }
    }
}
