using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flugplanung
{
    class Flugmodel
    {
        private string bezeichner;
        private float ladungsvolumen;
        private float hoechstgeschwindigkeit;
        private float flugreichtweite;
        private Kunde[] Kunde;
        private Techniker[] Techniker;
        /// <summary>
        /// Konstruktor für die Klasse,
        /// Kunden wird übergeben und in einen Array gespeichert
        /// </summary>
        /// <param name="bezeichner"></param>
        /// <param name="ladungsvolumen"></param>
        /// <param name="hoechstgeschwindigkeit"></param>
        /// <param name="Flugreichweite"></param>
        /// <param name="K"></param>
        public Flugmodel(string bezeichner,float ladungsvolumen, float hoechstgeschwindigkeit, float Flugreichweite,params Kunde[] K)
        {
            this.bezeichner = bezeichner;
            this.ladungsvolumen = ladungsvolumen;
            this.hoechstgeschwindigkeit = hoechstgeschwindigkeit;
            this.flugreichtweite = Flugreichweite;
            this.Kunde = K;
        }

        internal Techniker Techniker1
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal Kunde Kunde1
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
        /// Techniker in ein Array speichern
        /// </summary>
        /// <param name="T"></param>
        public void AddTechniker(params Techniker[] T)
        {
            this.Techniker = T;
        }
        /// <summary>
        /// Ausgabe des Flugmodells und aufrufen der Ausgabe vom Kunden und Techniker
        /// </summary>
        public void Ausgabe()
        {
            Console.WriteLine("Flugzeugmodel: "+this.bezeichner);
            Console.WriteLine("Ladungsvolumen: " + this.ladungsvolumen);
            Console.WriteLine("Höchstgeschwindigkeit: " + this.hoechstgeschwindigkeit);
            Console.WriteLine("Flugreichweite: " + this.flugreichtweite);
            Console.WriteLine("\n+++++++++Kunde+++++++++");
            for (int i = 0; i < this.Kunde.Length; i++)
            {
                Kunde[i].kAusgabe();
            }
            Console.WriteLine("\n+++++++++Techniker+++++++++");
            for (int i = 0; i < this.Techniker.Length; i++)
            {
                Techniker[i].tAusgabe();
            }
        }
    }
}
