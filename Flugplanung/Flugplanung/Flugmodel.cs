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

        public Flugmodel(string bezeichner,float ladungsvolumen, float hoechstgeschwindigkeit, float Flugreichweite)
        {
            this.bezeichner = bezeichner;
            this.ladungsvolumen = ladungsvolumen;
            this.hoechstgeschwindigkeit = hoechstgeschwindigkeit;
            this.flugreichtweite = Flugreichweite;
        }

        public void Ausgabe()
        {
            Console.WriteLine("Flugzeugmodel: "+this.bezeichner);
            Console.WriteLine("Ladungsvolumen: " + this.ladungsvolumen);
            Console.WriteLine("Höchstgeschwindigkeit: " + this.hoechstgeschwindigkeit);
            Console.WriteLine("Flugreichweite: " + this.flugreichtweite);
        }
    }
}
