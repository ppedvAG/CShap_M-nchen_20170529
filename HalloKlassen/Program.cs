using System;

namespace HalloKlassen
{
    class Program
    {
        static void Main(string[] args)
        {
            Fahrzeug pkw = new Fahrzeug();
            pkw.geschwindigkeit = 50;
            pkw.farbe = "Blau";
            Fahrzeug lkw = new Fahrzeug();
            lkw.geschwindigkeit = 80;
            lkw.farbe = "Rot";



            Console.WriteLine("------- Werttypen --------");
            int i = 5;
            int j = i;
            Console.WriteLine("I: {0}", i);
            Console.WriteLine("J: {0}", j);

            j = 100;
            Console.WriteLine("J bearbeiten.");
            Console.WriteLine("I: {0}", i);
            Console.WriteLine("J: {0}", j);

            Console.WriteLine("\n\n\n--------- Referenztypen -------");
            Fahrzeug schiff = new Fahrzeug();
            schiff.geschwindigkeit = 30;
            Fahrzeug bus = schiff;

            Console.WriteLine("Schiff: {0} km/h", schiff.geschwindigkeit);
            Console.WriteLine("Bus: {0} km/h", bus.geschwindigkeit);

            bus.geschwindigkeit = 80;
            Console.WriteLine("Bus beschleunigt.");
            Console.WriteLine("Schiff: {0} km/h", schiff.geschwindigkeit);
            Console.WriteLine("Bus: {0} km/h", bus.geschwindigkeit);


            Console.ReadKey();
        }
    }
}
