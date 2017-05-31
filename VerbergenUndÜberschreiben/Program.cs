using System;

namespace VerbergenUndÜberschreiben
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Grafik g = new Grafik();
            g.Farbe = "Blau";
            g.Zeichnen();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Kreis k = new Kreis();
            k.Farbe = "Grün";
            k.Radius = 1.2;
            k.Zeichnen();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Linie l = new Linie();
            l.Farbe = "Rot";
            l.Länge = 7;
            l.Zeichnen();

            Console.WriteLine();

            VerwendeGrafik(g);
            VerwendeGrafik(k);
            VerwendeGrafik(l);

            Console.ReadKey();
        }

        private static void VerwendeGrafik(Grafik g)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            g.Farbe = "Schwarz";
            g.Zeichnen();
        }
    }
}
