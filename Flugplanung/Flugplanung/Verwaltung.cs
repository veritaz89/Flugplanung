using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flugplanung
{
    class Verwaltung
    {
        /// <summary>
        /// Liste für alle Flugmodelle
        /// </summary>
        List<object> Flugmodelle = new List<object>();

        internal Flugmodel Flugmodel
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
        /// Initialisierung der Klassen
        /// Aufrufen der Methode Ausgabe
        /// </summary>
        public void Run ()
        {
            Kunde K_1 = new Kunde("Alex", "Lexi", "Holzeisenbahn", true);
            Kunde K_2 = new Kunde("Timi", "Struppi", "Puppenhaus", true);
            Kunde K_3 = new Kunde("Viki", "Lachs", "Comics", true);
            Kunde K_4 = new Kunde("Konni", "Dreyer", "Computer", true);

            Techniker T_1 = new Techniker("Wolfgang", "Peters", true);
            Techniker T_2 = new Techniker("Marco", "Meyer", true);

            Flugmodel A360 = new Flugmodel("A360",5000, 10000, 20000,K_1,K_3,K_4);
            Flugmodel A40 = new Flugmodel("A40",500, 100, 2000,K_2, K_4);
            A360.AddTechniker(T_1, T_2);
            A40.AddTechniker(T_1, T_2);
            Flugmodelle.Add(A360);
            Flugmodelle.Add(A40);
            Ausgabe();
            Console.ReadLine();
        }
        /// <summary>
        /// Ausgabe aller Flugmodelle
        /// </summary>
        public void Ausgabe()
        {
            foreach (Flugmodel item in Flugmodelle)
            {
                Console.WriteLine("-------Flugmodel-------");
                item.Ausgabe();
                Console.WriteLine();
            }

        }
       
    }
}
