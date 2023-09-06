namespace Portfolioauftrag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wilkommen beim Formenkonstruktor!");
            bool formkonstruktor = true;
            int dreieckBesetzt = 0;
            string[] dreiecksbehaelter = new string[4];
            int kreisBesetzt = 0;
            string[] kreisbehaelter = new string[3];
            int rechteckBesetzt = 0;
            string[] rechteckbehaelter = new string[2];

            while (formkonstruktor == true)
            {
                Console.WriteLine("\nWelche Funktion möchten Sie aufrufen? \nF = Formenbehälter \nK = Kreis hinzufügen \nD = Dreieck hinzufügen \nR = Rechteck hinzufügen");
                string antwort = Console.ReadLine().ToUpper();
                

                switch (antwort)
                {
                    case "F":
                        Console.WriteLine("\nKreise:");
                        foreach (string gespeicherteKreise in kreisbehaelter)
                        {
                            Console.WriteLine(gespeicherteKreise);
                        }
                        Console.WriteLine("\nDreiecke:");
                        foreach (string gespeicherteDreiecke in dreiecksbehaelter)
                        {
                            Console.WriteLine(gespeicherteDreiecke);
                        }
                        Console.WriteLine("\nRechtecke:");
                        foreach (string gespeicherteRechtecke in rechteckbehaelter)
                        { 
                            Console.WriteLine(gespeicherteRechtecke);
                        }
                        break;

                    case "K":
                        if (kreisBesetzt > 2)
                        {
                            Console.WriteLine("Es sind bereits 3 Kreise vorhanden!");
                            break;
                        }
                        Console.Write("Geben Sie die Länger der Linie für den Kreis ein: ");
                        Linie kreislinie = new Linie(Convert.ToDouble(Console.ReadLine()));
                        Kreis kreis = new Kreis(kreislinie);
                        Formenbehaelter tempKreisBehaelter = new Formenbehaelter(kreisBesetzt, kreisbehaelter, kreislinie, null, null);
                        kreisBesetzt++;
                        tempKreisBehaelter.KreisBehaelter();
                        Console.WriteLine($"Der Kreisumfang ist: {kreis.BerechneUmfang()}");
                        Console.WriteLine($"Die Kreisfläche ist: {kreis.BerechneFlaeche()}");
                        break;

                    case "D":
                        if (dreieckBesetzt > 3)
                        {
                            Console.WriteLine("Es sind bereits 4 Dreiecke vorhanden!");
                            break;
                        }
                        Console.Write("Geben Sie die Länge der Linien für das Dreieck ein: ");
                        Linie dreieckslinie1 = new Linie(Convert.ToDouble(Console.ReadLine()));
                        Console.Write("Geben Sie die Länge der Linien für das Dreieck ein: ");
                        Linie dreieckslinie2 = new Linie(Convert.ToDouble(Console.ReadLine()));
                        Console.Write("Geben Sie die Länge der Linien für das Dreieck ein: ");
                        Linie dreieckslinie3 = new Linie(Convert.ToDouble(Console.ReadLine()));
                        Dreieck dreieck = new Dreieck(dreieckslinie1, dreieckslinie2, dreieckslinie3);
                        Formenbehaelter tempDreieckBehaelter = new Formenbehaelter(dreieckBesetzt, dreiecksbehaelter, dreieckslinie1, dreieckslinie2, dreieckslinie3);
                        dreieckBesetzt++;
                        tempDreieckBehaelter.DreiecksBehaelter();
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
                        if (rechteckBesetzt > 1)
                        {
                            Console.WriteLine("Es sind bereits 2 Rechtecke vorhanden!");
                            break;
                        }
                        Console.Write("Geben Sie die Höhe des Rechtecks ein: ");
                        Linie rechteckshöhe = new Linie(Convert.ToDouble(Console.ReadLine()));
                        Console.Write("Geben Sie die Breite des Rechtecks ein: ");
                        Linie rechtecksbreite = new Linie(Convert.ToDouble(Console.ReadLine()));
                        Rechteck rechteck = new Rechteck(rechteckshöhe, rechtecksbreite);
                        Formenbehaelter tempRechteckBehaelter = new Formenbehaelter(rechteckBesetzt, rechteckbehaelter, rechteckshöhe, rechtecksbreite, null);
                        rechteckBesetzt++;
                        tempRechteckBehaelter.RechtecksBehaelter();
                        Console.WriteLine($" Der Umfang des Rechtecks beträgt: {rechteck.BerechneUmfang()}");
                        Console.WriteLine($" Die Fläche des Rechtecks beträgt: {rechteck.BerechneFlaeche()}");
                        break;

                    case "Q":
                        if (rechteckBesetzt == 2 && kreisBesetzt > 0)
                        {
                            Console.WriteLine("Aufwiedersehen");
                            formkonstruktor = false;
                        }
                        else
                        {
                            Console.WriteLine($"Sie haben {rechteckBesetzt} von 2 Rechtecken \nund {kreisBesetzt} von min 1 Kreis!");
                        }
                        break;

                    default:
                        Console.WriteLine("Diesen Befehl gibt es nicht!");

                        break;
                }
                

            }
            
        }
    }
}