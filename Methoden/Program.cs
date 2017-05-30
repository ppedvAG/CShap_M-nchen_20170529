using System;
using System.Linq;

namespace Methoden
{
    class Program
    {
        static void Main(string[] args)
        {
            ParameterBenennen(10, 5.4, "Hallo");
            ParameterBenennen(zahl: 4, wert: 9.8, text: "Welt");
            ParameterBenennen(text: "Mein Text", zahl: 1, wert: 1.0);

            ParameterBenennen(4, wert: 9.8, text: "Welt");


            Console.WriteLine("Fertig");
            Console.ReadKey();
        }

        private static void ParameterBenennen(int zahl, double wert, string text)
        { }

        private static string Addieren(int zahl, double wert)
        {
            double ergebnis = zahl + wert;

            return ergebnis.ToString();
        }
        private static void GeradeWerte(int von, int bis)
        {
            for (int i = von; i <= bis; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }
        private static void Primzahlen(int von, int bis)
        {
            while (von <= bis)
            {
                if (IsPrime(von))
                {
                    Console.WriteLine(von);
                }

                von++;
            }
        }
        private static bool IsPrime(int value)
        {
            if (value < 2)
                return false;

            if (value == 2)
                return true;

            for (int i = 2; i < (value / 2) + 1; i++)
                if (value % i == 0)
                    return false;

            return true;
        }
        private static bool EasyIsPrime(int value)
        {
            return !(value % 2 == 0 ||
                     value % 3 == 0 ||
                     value % 5 == 0 ||
                     value % 7 == 0);
        }
    }
}
