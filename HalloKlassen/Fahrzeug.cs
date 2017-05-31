namespace HalloKlassen
{
    /// <summary>
    /// Ein Fahrzeug
    /// </summary>
    public class Fahrzeug
    {
        //public Fahrzeug()
        //{ }
        public Fahrzeug(string farbe)
        {
            Farbe = farbe;
        }
        public Fahrzeug(string farbe, int geschwindigkeit) : this(farbe)
        {
            Geschwindigkeit = geschwindigkeit;
        }
        public Fahrzeug(string farbe, int geschwindigkeit, int baujahr) : this(farbe, geschwindigkeit)
        {
            Baujahr = baujahr;
        }

        private int _geschwindigkeit;           // Feld
        public int Geschwindigkeit              // Property -> regulierter Zugriff auf das Feld
        {
            get
            {
                return _geschwindigkeit;
            }
            set
            {
                if (value > 200)
                    value = 200;
                if (value < 0)
                    value = 0;

                this._geschwindigkeit = value;
            }
        }

        private string _farbe;
        public string Farbe
        {
            get { return _farbe; }
            set
            {
                switch (value)
                {
                    case "Rot":
                    case "Blau":
                    case "Grün":
                    case "Gelb":
                        _farbe = value;
                        break;
                    default:
                        _farbe = "Schwarz";
                        break;
                }
            }
        }

        private int _baujahr;
        public int Baujahr
        {
            get { return _baujahr; }
            set { _baujahr = value; }
        }


        // Methoden überladen
        /// <summary>
        /// Beschleunigt das Fahrzeug um 1.
        /// </summary>
        public void Beschleunigen()
        {
            Beschleunigen(1);
        }
        /// <summary>
        /// Beschleunigt das Fahrzeug um einen übergebenen Wert.
        /// </summary>
        /// <param name="geschwindigkeitsÄnderung"></param>
        public void Beschleunigen(int geschwindigkeitsÄnderung)
        {
            Geschwindigkeit += geschwindigkeitsÄnderung;
        }
        public void Beschleunigen(double faktor)
        {
            Geschwindigkeit = (int)(Geschwindigkeit * faktor);
        }
        public void Beschleunigen(int geschwindigkeitsÄnderung, int p1)
        { }
        public void Beschleunigen(int geschwindigkeitsÄnderung, string p1)
        { }
        public void Beschleunigen(int geschwindigkeitsÄnderung, bool meilenOderKmH)
        { }

        public void Bremsen(int geschwindigkeitsÄnderung)
        {
            Geschwindigkeit -= geschwindigkeitsÄnderung;
        }
    }
}
