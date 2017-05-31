using System;

namespace AbstrakteKlassen
{
    class Program
    {
        static void Main(string[] args)
        {
            Kreis k = new Kreis();
            k.Radius = 2.12;
            
            Linie l = new Linie();
            l.Länge = 10;

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
