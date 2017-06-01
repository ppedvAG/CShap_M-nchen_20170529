using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Syntax Fehler
            // 2. Laufzeitfehler
            // 3. Logische Fehler

            try
            {
                int zahl1 = int.Parse(Console.ReadLine());
                int zahl2 = int.Parse(Console.ReadLine());

                if (zahl1 == 1 || zahl2 == 1)
                    throw new MustNotBe1Exception("Weil heute der 01.06. ist, darf nicht 1 eingegeben werden!");

                int ergebnis = zahl1 + zahl2;

                Console.WriteLine(ergebnis);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Bitte geben Sie nur Zahlen ein.");
                Console.WriteLine(ex.Message);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Bitte keine so großen Zahlen eingeben.");
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Dieser Code wird immer ausgeführt!");
            }

            Console.ReadKey();
        }
    }
}
