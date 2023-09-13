namespace Gemischtwarenladen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Das Programm Gemischtwarenladen wurde gestartet\n\n");
            bool programmEin = true;
            int besetzt = 0;
            string[] produktListe = new string[100];
            double gesammtpreis = 0;
            bool produkteScannen = true;

            while (programmEin == true)
            {

                Console.WriteLine("Willkommen im Gemischtwarenladen");
                while (produkteScannen == true)
                {
                    Console.Write("\nBitte Scannen Sie ein Produkt\t");
                    Produkt produkt = new Produkt(Console.ReadLine());
                    if (produkt.ProduktName() == "Z")
                    {
                        produkteScannen = false;
                        break;
                    }
                    Beleg beleg = new Beleg(produkt.ProduktName(), produkt.ProduktPreis(), gesammtpreis);
                    if (beleg.AddList() != null)
                    {
                        produktListe[besetzt] = beleg.AddList();
                        gesammtpreis = beleg.SubTotal();
                        Bildschirm anzeige = new Bildschirm(produktListe, gesammtpreis, besetzt);
                        anzeige.BelegAktualisieren();
                        besetzt++;
                    }
                    else
                    {
                        Console.WriteLine("Dieser Artikel wurde nicht gefunden!");
                    }
                }
                while (gesammtpreis > 0)
                {
                    Bezahlen bezahlen = new Bezahlen(gesammtpreis);
                    string zahlungsart = bezahlen.Zahlungsart();
                    if (zahlungsart == "K")
                    {
                        gesammtpreis = bezahlen.KartenZahlung();
                    }
                    else if (zahlungsart == "T")
                    {
                        gesammtpreis = bezahlen.TwintZahlung();
                    }
                    else if (zahlungsart == "B")
                    {
                        gesammtpreis = bezahlen.BarZahlung();
                    }
                }
                Console.WriteLine("\n\n\nVielen Dank für Ihren EInkauf\nFür neuen Kunden N\nProgramm beenden Q");
                string antwort = Console.ReadLine();
                if (antwort.ToUpper() == "N")
                {
                    Console.WriteLine("Sie können jetzt eine Neuen Kunden erfassen\n\n\n");
                    besetzt = 0;
                    produktListe = new string[100];
                    gesammtpreis = 0;
                    produkteScannen = true;
                }
                else if (antwort.ToUpper() == "Q")
                {
                    programmEin = false;
                }

            }
            
        }
    }
}