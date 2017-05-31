using System;
using System.Collections.Generic;
using System.IO;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Fahrzeug f = new Fahrzeug();
            Bauteil b = new Bauteil();
            b.BauteilNummer = 5;

            Lackieren(f);
            Lackieren(b);


            List<string> namen = new List<string>();
            namen.Add("Sepp");
            namen.Add("Lisa");
            namen.Add("Stanislaus");
            namen.Add("Peter");
            namen.Add("Andrea");

            foreach (string name in namen)
            {
                Console.WriteLine(name);
            }


            using (FileStream fs =  new FileStream(@"C:\Kurse\CSharp\CShap_München_20170529\Test.txt", FileMode.OpenOrCreate))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("Mein wichtiger Text aus dem C# Program!");
                }
            }
            
            Console.ReadKey();
        }

        private static void Lackieren(ILackierbar objekt)
        {
            objekt.Farbe = "Blau";
        }
    }
}
