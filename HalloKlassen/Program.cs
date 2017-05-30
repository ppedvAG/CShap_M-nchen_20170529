using System;

namespace HalloKlassen
{
    class Program
    {
        static void Main(string[] args)
        {
            Fahrzeug pkw = new Fahrzeug("Rot");
            pkw.Geschwindigkeit = 500;
            //pkw.Farbe = "Rot";
            pkw.Beschleunigen(geschwindigkeitsÄnderung: 10);
            pkw.Beschleunigen();
            pkw.Beschleunigen(1.5);
            pkw.Beschleunigen();

            Console.WriteLine($"PKW: {pkw.Geschwindigkeit}");
            Console.WriteLine($"PKW: {pkw.Farbe}");

            Fahrzeug lkw = new Fahrzeug("Lila");
            lkw.Geschwindigkeit = 80;
            lkw.Farbe = "Azure";
            Console.WriteLine($"LKW: {lkw.Geschwindigkeit}");
            Console.WriteLine($"LKW: {lkw.Farbe}");

            #region Wert- & Referenztypen

            //Console.WriteLine("------- Werttypen --------");
            //int i = 5;
            //int j = i;
            //Console.WriteLine("I: {0}", i);
            //Console.WriteLine("J: {0}", j);

            //j = 100;
            //Console.WriteLine("J bearbeiten.");
            //Console.WriteLine("I: {0}", i);
            //Console.WriteLine("J: {0}", j);

            //Console.WriteLine("\n\n\n--------- Referenztypen -------");
            //Fahrzeug schiff = new Fahrzeug();
            //schiff.Geschwindigkeit = 30;
            //Fahrzeug bus = schiff;

            //Console.WriteLine("Schiff: {0} km/h", schiff.Geschwindigkeit);
            //Console.WriteLine("Bus: {0} km/h", bus.Geschwindigkeit);

            //bus.Geschwindigkeit = 80;
            //Console.WriteLine("Bus beschleunigt.");
            //Console.WriteLine("Schiff: {0} km/h", schiff.Geschwindigkeit);
            //Console.WriteLine("Bus: {0} km/h", bus.Geschwindigkeit);
            #endregion

            Console.ReadKey();
        }
    }
}
