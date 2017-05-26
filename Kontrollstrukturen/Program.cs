using System;

namespace Kontrollstrukturen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie eine ganze Zahl ein: ");
            int eingabe = int.Parse(Console.ReadLine());

            #region If Else
            //if(eingabe > 10)
            //{
            //    Console.WriteLine("Die Zahl war größer als 10.");
            //}
            //else if(eingabe == 10)
            //{
            //    Console.WriteLine("Die Zahl war genau 10.");
            //}
            //else
            //{
            //    Console.WriteLine("Die Zahl war kleiner 10.");
            //}

            #endregion
            #region Switch
            //switch(eingabe)
            //{
            //    case 3:
            //        Console.WriteLine("Die Eingabe war 3");
            //        break;

            //    case 8:
            //    case 9:
            //    case 5:
            //        Console.WriteLine("Die Eingabe war 5, 8 oder 9");
            //        break;

            //    default:
            //        Console.WriteLine("Was anderes.");
            //        break;
            //}
            #endregion

            #region While

            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine(++i);

            //    //i = i + 1;
            //    //i += 1;
            //    //i++;
            //}

            #endregion

            #region Do While

            //int i = 0;

            //do
            //{
            //    Console.WriteLine(i++);
            //} while (i < 10);

            #endregion

            #region For

            for(int i = 0; i < 10; i++)
            {
                if( i == 5)
                {
                    continue;
                }
                if(i == 8)
                {
                    break;
                }

                Console.WriteLine(i);
            }

            #endregion

            Console.ReadKey();
        }
    }
}
