using Aufgabe_1_9;

namespace Aufgabe_Funktionen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 12, b = 16;
            Console.WriteLine(MyMath.Calc_ggT(a, b));
            Console.WriteLine(MyMath.Calc_kgV(a, b));
            Console.WriteLine($"Eingegebene Zahl: {ReadInt()}");
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
        static void ShowResult(string[] args)
        {
            Console.WriteLine($"ggT von: {a} und {b} ist: {z}");
        }
    }
}