namespace Gemischtwarenladen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen im Gemischtwarenlade");
            bool programmEin = true;
            int besetzt = 0;
            string[] produktListe = new string[100];
            double gesammtpreis = 0;
            bool produkteScannen = true;

            while (programmEin == true)
            {
                

                while (produkteScannen == true)
                {
                    Console.WriteLine("Bitte Scannen Sie ein Produkt");
                    Produkt produkt = new Produkt(Console.ReadLine());
                    if (produkt.ProduktName() == "Q")
                    {
                        produkteScannen = false;
                        break;
                    }
                    Beleg beleg = new Beleg(produkt.ProduktName(), produkt.ProduktPreis(), gesammtpreis);
                    produktListe[besetzt] = beleg.AddList();
                    gesammtpreis = beleg.SubTotal();
                    Bildschirm anzeige = new Bildschirm(produktListe, gesammtpreis, besetzt);
                    anzeige.BelegAktualisieren();
                    besetzt++;

                }
                
                Bezahlen bezahlen = new Bezahlen(gesammtpreis);
            }
            
        }
    }
}