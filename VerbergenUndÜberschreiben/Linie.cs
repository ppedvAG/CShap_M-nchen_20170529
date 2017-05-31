using System;

namespace VerbergenUndÜberschreiben
{
    public class Linie : Grafik
    {
        public int Länge { get; set; }

        // Überschreiben
        public override void Zeichnen()
        {
            Console.WriteLine($"Zeichne Linie in der Farbe {Farbe} mit einer Länge von {Länge}.");
        }
    }
}
