namespace Vererbung
{
    public class Lkw : Fahrzeug
    {
        public Lkw(int baujahr) : base(baujahr)
        { }

        public int MaxLadung { get; set; }
    }
}
