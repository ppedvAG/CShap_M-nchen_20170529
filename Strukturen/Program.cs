namespace Strukturen
{
    class Program
    {
        static void Main(string[] args)
        {
            Fahrzeug pkw = new Fahrzeug();
            pkw.Baujahr = 1996;
            pkw.Beschleunigen(100);


            // Ojekte von Strukturen sind Werttypen
            // Keine Vererbung
            // Keine Interfaces
            Fahrzeug lkw = pkw;
        }
    }
}
