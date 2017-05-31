using System;
using System.Text;

namespace Kontofuehrung
{
    class Program
    {
        static void Main(string[] args)
        {
            // Damit das € Zeichen in der Console angezeigt werden kann.
            Console.OutputEncoding = Encoding.Default;

            Konto giroKonto = new Konto(5000);

            while (true)
            {
                Console.WriteLine($"\nAktueller Kontostand: {giroKonto.Kontostand:C}");
                Console.WriteLine("(1) Einzahlen, (2) Auszahlen, (0) Beenden");
                string eingabe = Console.ReadLine();

                switch (eingabe)
                {
                    case "0":
                        return;

                    case "1":
                        Console.Write("Betrag einzahlen: ");
                        eingabe = Console.ReadLine();
                        giroKonto.Einzahlen(decimal.Parse(eingabe));
                        break;

                    case "2":
                        Console.Write("Betrag auszahlen: ");
                        eingabe = Console.ReadLine();
                        giroKonto.Auszahlen(decimal.Parse(eingabe));
                        break;

                    default:
                        Console.WriteLine("Ungültige Eingabe.");
                        break;
                }
            }
        }
    }
}
