using System.Threading;
using System.Windows.Forms;

namespace Autofahren
{
    public class Auto : Button
    {
        public const int MinGeschwindigkeit = 0;
        public const int MaxGeschwindigkeit = 100;

        public Auto(int geschwindigkeit)
        {
            Geschwindigkeit = geschwindigkeit;
        }

        private int _geschwindigkeit;
        public int Geschwindigkeit
        {
            get { return _geschwindigkeit; }
            set
            {
                if (value < MinGeschwindigkeit)
                    value = MinGeschwindigkeit;
                if (value > MaxGeschwindigkeit)
                    value = MaxGeschwindigkeit;

                _geschwindigkeit = value;
            }
        }

        public void Fahren(int ziel)
        {
            while (Left < ziel && Geschwindigkeit > MinGeschwindigkeit)
            {
                Left++;
                Thread.Sleep(100 - Geschwindigkeit);
                Application.DoEvents();
            }
        }
    }
}
