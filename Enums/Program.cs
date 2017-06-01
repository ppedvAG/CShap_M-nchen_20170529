using System;
using System.Windows.Forms;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    DialogResult result = MessageBox.Show(
            //        text: "Bitte wenden Sie sich an ihren Systemadministrator!",
            //        caption: "Es ist ein unbekannter Fehler aufgetreten!",
            //        buttons: MessageBoxButtons.RetryCancel,
            //        icon: MessageBoxIcon.Stop);

            //    switch (result)
            //    {
            //        case DialogResult.Cancel:
            //            return;

            //        case DialogResult.Retry:
            //            Console.WriteLine("Nochmal! Nochmal!");
            //            break;
            //    }
            //}


            Wochentage tage = Wochentage.Mittwoch | Wochentage.Freitag;
            //Console.WriteLine(tage);

            tage = (Wochentage)17;
            //Console.WriteLine(tage);

            int zahl = (int)tage;


            for (int i = 0; i < 128; i++)
            {
                Console.WriteLine((Wochentage)i);
            }

            Console.ReadKey();
        }

        private static Wochentage BerechneTag()
        {
            return Wochentage.Mittwoch;
        }
    }
}
