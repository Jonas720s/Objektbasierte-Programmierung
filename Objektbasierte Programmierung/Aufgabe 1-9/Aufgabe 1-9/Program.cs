using Aufgabe_1_9;
using System.Diagnostics;

namespace Aufgabe_Funktionen
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            int stop = 0;
            int stopesc = 1;

            while (stop == 0)
            {
                int a = ReadIntA();
                int b = ReadIntB();
                Console.WriteLine($"ggT von a und b: {MyMath.Calc_ggT_r(a, b)}");
                Console.WriteLine($"kgV von a und b: {MyMath.Calc_kgV(a, b)}");
                //Console.WriteLine($"Eingegebene Zahl: {ReadInt()}");
                MyMath.Swap(ref a, ref b);
                Console.WriteLine($"a: {a} b: {b}");
                Console.WriteLine("If you want to continue, write y: ");
                string stopCalc = Console.ReadLine();
                if (stopCalc != "y")
                {
                    stop = stop + stopesc;
                }
            }
        }

        static int ReadInt()
        {
            int i;
            do
            {
                Console.WriteLine("Bitte Zahl eingeben");
                string s = Console.ReadLine();
                int.TryParse(s, out i);

            } while (i <= 0);
            Console.WriteLine("danke");
            return i;

        }
        public static int ReadIntA()
        {
            int a;
            do
            {
                Console.Write("geben sie eine Zahl ein: ");
                string one = Console.ReadLine();
                int.TryParse(one, out a);
            } while (a <= 0);
            Console.WriteLine("danke");
            return a;
        }
        public static int ReadIntB()
        {
            int b;
            do
            {
                Console.Write("geben sie eine Zahl ein: ");
                string two = Console.ReadLine();
                int.TryParse(two, out b);
            } while (b <= 0);
            Console.WriteLine("danke");
            return b;
        }

    }
}