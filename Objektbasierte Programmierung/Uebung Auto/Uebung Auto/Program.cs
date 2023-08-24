namespace Uebung_Auto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
      
            string eingabe = "";
 
            while (eingabe != "STARTEN")
            {
                Console.WriteLine($"Guten Tag! \n Geben Sie STARTEN ein um den Motor zu starten: ");
                eingabe = Console.ReadLine();
                eingabe = eingabe.ToUpper();
            }

            auto.Anlassen();

        }
    }
}