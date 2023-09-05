namespace Portfolioauftrag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wilkommen beim Formenkonstruktor!");
            bool formkonstruktor = true;
            while (formkonstruktor == true)
            {
                Console.WriteLine("\nWelche Funktion möchten Sie aufrufen? \nF = Formenbehälter \nK = Kreis hinzufügen \nD = Dreieck hinzufügen \nR = Rechteck hinzufügen");
                string antwort = Console.ReadLine().ToUpper();

                switch (antwort)
                {
                    case "F":
                        Console.WriteLine("...");
                        break;

                    case "K":
                        Console.Write("Geben Sie die Länger der Linie für den Kreis ein: ");
                        Linie kreislinie = new Linie(Convert.ToDouble(Console.ReadLine()));
                        Kreis kreis = new Kreis(kreislinie);
                        Console.WriteLine($"Der Kreisumfang ist: {kreis.BerechneUmfang()}");
                        Console.WriteLine($"Die Kreisfläche ist: {kreis.BerechneFlaeche()}");
                        break;

                    case "D":
                        Console.Write("Geben Sie die Länge der Linien für das Dreieck ein: ");
                        Linie dreieckslinie1 = new Linie(Convert.ToDouble(Console.ReadLine()));
                        Console.Write("Geben Sie die Länge der Linien für das Dreieck ein: ");
                        Linie dreieckslinie2 = new Linie(Convert.ToDouble(Console.ReadLine()));
                        Console.Write("Geben Sie die Länge der Linien für das Dreieck ein: ");
                        Linie dreieckslinie3 = new Linie(Convert.ToDouble(Console.ReadLine()));
                        Dreieck dreieck = new Dreieck(dreieckslinie1, dreieckslinie2, dreieckslinie3);
                        if (dreieck.IstDreieckMoeglich())
                        {
                            Console.WriteLine($"Der Umfang des Dreiecks beträgt: {dreieck.BerechneUmfang()}");
                            Console.WriteLine($"Die Fläche des Dreiecks beträgt: {dreieck.BerechneFlaeche()}");
                        }                    
                        else
                        {
                            Console.WriteLine("Diese Längen ergeben kein gültiges Dreieck!");
                        }
                        break;

                    case "R":
                        Console.Write("Geben Sie die Höhe des Rechtecks ein: ");
                        Linie rechteckshöhe = new Linie(Convert.ToDouble(Console.ReadLine()));
                        Console.Write("Geben Sie die Breite des Rechtecks ein: ");
                        Linie rechtecksbreite = new Linie(Convert.ToDouble(Console.ReadLine()));
                        Rechteck rechteck = new Rechteck(rechteckshöhe, rechtecksbreite);
                        Console.WriteLine($" Der Umfang des Rechtecks beträgt: {rechteck.BerechneUmfang()}");
                        Console.WriteLine($" Die Fläche des Rechtecks beträgt: {rechteck.BerechneFlaeche()}");
                        break;

                    default:
                        Console.WriteLine("Diesen Befehl gibt es nicht!");
                        formkonstruktor = false;
                        break;
                }
            }
            
        }
    }
}