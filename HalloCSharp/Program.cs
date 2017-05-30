using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo C# Kurs!");

            string text;
            text = "Mein Text";
            Console.WriteLine(text);

            string eingabe = Console.ReadLine();
            int zahl = 8;

            text = zahl.ToString();

            //zahl = Convert.ToInt32("16");
            zahl = int.Parse("100");
            Console.WriteLine(zahl + 4);

            byte einByte = 255;
            short kleinereZahl;
            int meinezahl;
            long größereZahl;

            float f = 7.4f;
            double d = 18.32;
            decimal dec = 5.74m;

            bool predicate = true;      // false

            char textZeichen = 'x';

            // Mathematische Operatoren
            zahl = 5 + 9;
            zahl = 5 - 8;
            zahl = 5 * 8;
            zahl = 5 / 8;
            zahl = 5 % 8;

            // Vergleichsoperatoren
            predicate = 5 < 9;
            predicate = 5 <= 9;
            predicate = 5 > 9;
            predicate = 5 <= 9;
            predicate = 5 == 9;
            predicate = 5 != 9;
            predicate = !(6 < 9);

            // Verknüpfungsoperatoren
            predicate = 5 < 9 & 7 > 6;
            predicate = 5 < 9 | 7 > 6;
            predicate = 5 < 9 ^ 7 > 6;

            predicate = 5 < 9 && 7 > 6;
            predicate = 5 < 9 || 7 > 6;

            Console.ReadKey();
        }
    }
}
