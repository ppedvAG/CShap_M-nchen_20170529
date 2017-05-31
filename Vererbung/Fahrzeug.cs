namespace Vererbung
{
    public class Fahrzeug
    {
        public Fahrzeug(int baujahr)
        {
            Baujahr = baujahr;
        }


        private string _farbe;
        public string Farbe
        {
            get { return _farbe; }
            set { _farbe = value; }
        }

        public int Geschwindigkeit { get; set; }
        public int Baujahr { get; set; }

        public void Beschleunigen(int geschwindigkeitsÄnderung)
        {
            Geschwindigkeit += geschwindigkeitsÄnderung;
        }
    }
}
