namespace Vererbung
{
    public class Cabrio : Pkw
    {
        public Cabrio(int baujahr) : base(baujahr)
        {
        }

        public string Dachart { get; set; }
    }
}