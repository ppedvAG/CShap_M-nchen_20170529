using System;

namespace VerbergenUndÜberschreiben
{
    public class Kreis : Grafik
    {
        public double Radius { get; set; }

        //public new int Farbe { get; set; }

        // Verbergen
        public new void Zeichnen()
        {
            Console.WriteLine($"Zeichne Kreis in der Farbe {Farbe} mit einem Radius von {Radius}.");
        }
    }
}
