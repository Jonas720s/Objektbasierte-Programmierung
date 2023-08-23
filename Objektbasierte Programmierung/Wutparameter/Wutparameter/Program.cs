﻿namespace Wutparameter
{
    internal class Program
    {

        static void Main(string[] args, bool)
        {
            Console.WriteLine("Wilkommen beim Wutparameter: ");

            int p = ReadIntP();
            string eg = ReadIntEG();
            //int ev = ReadIntEV();
            int a = ReadIntA();
            Person person = new Person();
            person.Provozieren(p);
            person.EssenGeben(eg);
            //person.EssenVerweigern();
            person.ArbeitsauftragGeben(a);
        }
        public static int ReadIntP()
        {
            int p;
            do
            {
                Console.Write("werden Sie provoziert? von 1-10: ");
                string one = Console.ReadLine();
                int.TryParse(one, out p);
            } while (p <= 0);
            Console.WriteLine("danke");
            return p;
        }
        public static string ReadIntEG()
        {
            string eg;
            do
            {
                Console.Write("Sind Sie satt?");
                string two = Console.ReadLine();
                two = two.ToLower();
                
            }
            while (two == "yes", "no");
        }
        /*public static int ReadIntEV()
        {
            int ev;
            do
            {
                Console.Write("Wann hast du das letzte mal kein essen bekommen? ");
                string three = Console.ReadLine();
                int.TryParse(three, out ev);
            } while (ev <= 0);
            Console.WriteLine("danke");
            return ev;
        }*/
        public static int ReadIntA()
        {
            int a;
            do
            {
                Console.Write("Wie viel arbeiten sie in letzter zeit von 1-10? ");
                string four = Console.ReadLine();
                int.TryParse(four, out a);
            } while (a <= 0);
            Console.WriteLine("danke");
            return a;
        }
    }
}