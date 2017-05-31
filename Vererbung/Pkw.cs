namespace Vererbung
{
    public class Pkw : Fahrzeug
    {
        public Pkw(int baujahr) : base(baujahr)
        { }

        public int Sitzplätze { get; set; }
    }
}
