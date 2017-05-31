using System;

namespace Interfaces
{
    public class Fahrzeug : ILackierbar, IDisposable
    {
        public int Baujahr { get; set; }
        public int Geschwindigkeit { get; set; }

        public string Farbe { get; set; }

        public void Dispose()
        {
            Console.WriteLine("Das Fahrzeug wird zerstört...");
        }
    }
}
