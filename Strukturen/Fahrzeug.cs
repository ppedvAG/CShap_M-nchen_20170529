namespace Strukturen
{
    public struct Fahrzeug
    {
        private int _baujahr;
        public int Baujahr
        {
            get { return _baujahr; }
            set { _baujahr = value; }
        }

        public int Geschwindigkeit { get; set; }

        public void Beschleunigen(int änderung)
        {
            Geschwindigkeit += änderung;
        }
    }
}
