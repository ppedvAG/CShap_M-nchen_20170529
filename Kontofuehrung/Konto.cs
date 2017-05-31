namespace Kontofuehrung
{
    public class Konto
    {
        private decimal _kontostand;
        public decimal Kontostand
        {
            get { return _kontostand; }
            private set { _kontostand = value; }
        }

        public Konto(decimal startkapital)
        {
            Kontostand = startkapital;
        }

        public void Einzahlen(decimal betrag)
        {
            Kontostand += betrag;
        }
        public void Auszahlen(decimal betrag)
        {
            Kontostand -= betrag;
        }
    }
}
