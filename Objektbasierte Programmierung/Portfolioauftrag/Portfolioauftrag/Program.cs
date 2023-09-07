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

            //Zwie Kreise hinzufügen
            Linie kreislinie1 = new Linie(34);
            Kreis kreis1 = new Kreis(kreislinie1);
            Formenbehaelter tempKreisBehaelter1 = new Formenbehaelter(kreisBesetzt, kreisbehaelter, kreis1, null, null);
            kreisBesetzt++;
            tempKreisBehaelter1.KreisBehaelter();
            Linie kreislinie2 = new Linie(55);
            Kreis kreis2 = new Kreis(kreislinie2);
            Formenbehaelter tempKreisBehaelter2 = new Formenbehaelter(kreisBesetzt, kreisbehaelter, kreis2, null, null);
            kreisBesetzt++;
            tempKreisBehaelter2.KreisBehaelter();

            //Ein Dreieck hinzufügen
            Linie dreiecksliniea1 = new Linie(14);
            Linie dreiecksliniea2 = new Linie(13);
            Linie dreiecksliniea3 = new Linie(12);
            Dreieck dreiecka = new Dreieck(dreiecksliniea1, dreiecksliniea2, dreiecksliniea3);
            Formenbehaelter tempDreieckBehaeltera = new Formenbehaelter(dreieckBesetzt, dreiecksbehaelter, null, dreiecka, null);
            dreieckBesetzt++;
            tempDreieckBehaeltera.DreiecksBehaelter();

            //Zwei Rechtecke hinzufügen
            Linie rechteckshöhea1 = new Linie(45);
            Linie rechteckshöheb1 = new Linie(45);
            Linie rechtecksbreitea1 = new Linie(23);
            Linie rechtecksbreiteb1 = new Linie(23);
            Rechteck rechteck1 = new Rechteck(rechteckshöhea1, rechteckshöheb1, rechtecksbreitea1, rechtecksbreiteb1);
            Formenbehaelter tempRechteckBehaelter1 = new Formenbehaelter(rechteckBesetzt, rechteckbehaelter, null, null, rechteck1);
            rechteckBesetzt++;
            tempRechteckBehaelter1.RechtecksBehaelter();
            Linie rechteckshöhea2 = new Linie(56);
            Linie rechteckshöheb2 = new Linie(56);
            Linie rechtecksbreitea2 = new Linie(67);
            Linie rechtecksbreiteb2 = new Linie(67);
            Rechteck rechteck2 = new Rechteck(rechteckshöhea2, rechteckshöheb2, rechtecksbreitea2, rechtecksbreiteb2);
            Formenbehaelter tempRechteckBehaelter2 = new Formenbehaelter(rechteckBesetzt, rechteckbehaelter, null, null, rechteck2);
            rechteckBesetzt++;
            tempRechteckBehaelter2.RechtecksBehaelter();


            while (formkonstruktor == true)
            {
                Console.WriteLine("\nWelche Funktion möchten Sie aufrufen? \nF = Formenbehälter \nK = Kreis hinzufügen \nD = Dreieck hinzufügen \nR = Rechteck hinzufügen \nQ = um das Programm zu beenden");
                string antwort = Console.ReadLine().ToUpper();
                

                switch (antwort)
                {
                    case "F":
                        if (rechteckBesetzt == 2 && kreisBesetzt > 0)
                        {
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
                        }
                        else
                        {
                            Console.WriteLine($"Sie haben {rechteckBesetzt} von 2 Rechtecken \nund {kreisBesetzt} von min 1 Kreis! \nBitte Kompletieren sie den Formenbehälter!");
                        }
                        break;

                    case "K":
                        if (kreisBesetzt > 2)
                        {
                            Console.WriteLine("Es sind bereits 3 Kreise vorhanden! \nWenn Sie nochmal Kreis aufrufen, wird der erste Kreis überschrieben!");
                            kreisBesetzt = 0;
                            break;
                        }
                        Console.Write("Geben Sie die Länger der Linie für den Kreis ein: ");
                        Linie kreislinie = new Linie(Convert.ToDouble(Console.ReadLine()));
                        Kreis kreis = new Kreis(kreislinie);
                        Formenbehaelter tempKreisBehaelter = new Formenbehaelter(kreisBesetzt, kreisbehaelter, kreis, null, null);
                        kreisBesetzt++;
                        tempKreisBehaelter.KreisBehaelter();
                        Console.WriteLine($"Der Kreisumfang ist: {kreis.BerechneUmfang()}");
                        Console.WriteLine($"Die Kreisfläche ist: {kreis.BerechneFlaeche()}");
                        break;

                    case "D":
                        if (dreieckBesetzt > 3)
                        {
                            Console.WriteLine("Es sind bereits 4 Dreiecke vorhanden! \nWenn Sie nochmal Dreieck aufrufen, wird das erste Dreieck überschrieben!");
                            dreieckBesetzt = 0;
                            break;
                        }
                        Console.Write("Geben Sie die Länge der Linien für das Dreieck ein: ");
                        Linie dreieckslinie1 = new Linie(Convert.ToDouble(Console.ReadLine()));
                        Console.Write("Geben Sie die Länge der Linien für das Dreieck ein: ");
                        Linie dreieckslinie2 = new Linie(Convert.ToDouble(Console.ReadLine()));
                        Console.Write("Geben Sie die Länge der Linien für das Dreieck ein: ");
                        Linie dreieckslinie3 = new Linie(Convert.ToDouble(Console.ReadLine()));
                        Dreieck dreieck = new Dreieck(dreieckslinie1, dreieckslinie2, dreieckslinie3);
                        Formenbehaelter tempDreieckBehaelter = new Formenbehaelter(dreieckBesetzt, dreiecksbehaelter, null, dreieck, null);
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
                            Console.WriteLine("Es sind bereits 2 Rechtecke vorhanden! \nWenn Sie nochmal Rechteck aufrufen, wird das erste Rechteck überschrieben!");
                            rechteckBesetzt = 0;
                            break;
                        }
                        Console.Write("Geben Sie die Höhe des Rechtecks ein: ");
                        Linie rechteckshöhea = new Linie(Convert.ToDouble(Console.ReadLine()));
                        Linie rechteckshöheb = rechteckshöhea;
                        Console.Write("Geben Sie die Breite des Rechtecks ein: ");
                        Linie rechtecksbreitea = new Linie(Convert.ToDouble(Console.ReadLine()));
                        Linie rechtecksbreiteb = rechtecksbreitea;
                        Rechteck rechteck = new Rechteck(rechteckshöhea, rechteckshöheb, rechtecksbreitea, rechtecksbreiteb);
                        Formenbehaelter tempRechteckBehaelter = new Formenbehaelter(rechteckBesetzt, rechteckbehaelter, null, null, rechteck);
                        rechteckBesetzt++;
                        tempRechteckBehaelter.RechtecksBehaelter();
                        Console.WriteLine($" Der Umfang des Rechtecks beträgt: {rechteck.BerechneUmfang()}");
                        Console.WriteLine($" Die Fläche des Rechtecks beträgt: {rechteck.BerechneFlaeche()}");
                        break;

                    case "Q":
                        Console.WriteLine("Aufwiedersehen");
                        formkonstruktor = false;
                        break;

                    default:
                        Console.WriteLine("Diesen Befehl gibt es nicht!");

                        break;
                }
                

            }
            
        }
    }
}