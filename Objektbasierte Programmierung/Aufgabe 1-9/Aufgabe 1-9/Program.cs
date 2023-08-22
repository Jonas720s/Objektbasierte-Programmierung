using Aufgabe_1_9;

namespace Aufgabe_Funktionen
{
    internal class Program
    {
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
        static void Main(string[] args)
        {
            int a = ReadIntA();
            int b = ReadIntB();
            Console.WriteLine($"ggT von a und b: {MyMath.Calc_ggT_r(a, b)}");
            Console.WriteLine($"kgV von a und b: {MyMath.Calc_kgV(a, b)}");
            //Console.WriteLine($"Eingegebene Zahl: {ReadInt()}");
            MyMath.Swap(ref a, ref b);
            Console.WriteLine($"a: {a} b: {b}");
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

    }
}