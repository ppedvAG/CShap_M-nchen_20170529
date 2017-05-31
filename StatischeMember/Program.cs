using System;

namespace StatischeMember
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rechner r = new Rechner();

            int ergebnis = Rechner.Addieren(7, 90);
            ergebnis = Rechner.Subtrahieren(7, 90);
            Console.WriteLine(ergebnis);

            Console.ReadKey();
        }
    }
}
