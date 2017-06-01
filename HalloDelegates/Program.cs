using System;

namespace HalloDelegates
{
    public delegate string MyDelegate(int zahl, double wert);

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate del = new MyDelegate(MeineMethodeflkghlashg);

            string result = del(9, 2.4);

            Console.WriteLine(result);
            Console.ReadKey();
        }

        private static string MeineMethode(int x, double d)
        {
            return (x + d).ToString();
        }
    }
}
