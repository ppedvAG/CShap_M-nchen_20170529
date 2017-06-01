using System;

namespace Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            Fahrzeug f = new Fahrzeug(2013);
            //f.Baujahr = 2013;
            f.Farbe = "Lila";
            f.Geschwindigkeit = 20;

            Pkw pkw = new Pkw(1996);
            //pkw.Baujahr = 1996;
            pkw.Farbe = "Rot";
            pkw.Geschwindigkeit = 80;
            pkw.Sitzplätze = 5;

            Lkw lkw = new Lkw(2004);
            lkw.Farbe = "Weiß";
            lkw.Geschwindigkeit = 70;
            lkw.MaxLadung = 18000;

            Cabrio cabrio = new Cabrio(2006);
            cabrio.Farbe = "Gelb";
            cabrio.Geschwindigkeit = 130;
            cabrio.Sitzplätze = 2;
            cabrio.Dachart = "Softtop";

            Console.WriteLine(f.ToString());
            Console.WriteLine(pkw.ToString());
            Console.WriteLine(lkw.ToString());
            Console.WriteLine(cabrio.ToString());


            Lackieren(f);
            Lackieren(pkw);
            Lackieren(lkw);
            Lackieren(cabrio);

            Fahrzeug cf = new Lkw(2017);

            //Cabrio cab = (Cabrio)cf;      // Wenn nicht Cabrio: Schmeist eine Exception
            Cabrio cab = cf as Cabrio;      // Wenn nicht Cabrio: cab = null
            if(cab != null)
                Console.WriteLine($"Cast funktioniert?: {cab.Sitzplätze}");

            Console.WriteLine(f.Farbe);
            Console.WriteLine(pkw.Farbe);
            Console.WriteLine(lkw.Farbe);
            Console.WriteLine(cabrio.Farbe);

            Console.ReadKey();
        }

        private static void Lackieren(Fahrzeug fahrzeug)
        {
            fahrzeug.Farbe = "Scharz";

            if (fahrzeug is Pkw)
            {
                // Muss PKW oder eine von PKW erbende Klasse sein.
                fahrzeug.Farbe = "Blau";
            }
            if(fahrzeug.GetType() == typeof(Pkw))
            {
                // Muss genau PKW sein!!
            }
        }
    }
}
