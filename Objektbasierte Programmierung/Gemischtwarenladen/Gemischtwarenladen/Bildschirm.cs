using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemischtwarenladen
{
    public class Bildschirm
    {
        private string[] produktListe;
        private double gesammtpreis;
        private int besetzt;
        
        public Bildschirm(string[] ProduktListe, double Gesammtpreis, int Besetzt) 
        {
            this.produktListe = ProduktListe;
            this.gesammtpreis = Gesammtpreis;
            this.besetzt = Besetzt;
        }
        public void BelegAktualisieren()
        {
            for (int i = 0; i <= besetzt; i++)
            {
                Console.WriteLine(produktListe[i]);
            }
            Console.WriteLine("---------------------------------------------------------------");
            string cgesammtpreis = string.Format("{0:C2}", gesammtpreis);
            Console.WriteLine($"\t\t\t\tGesammtpreis: \t {cgesammtpreis}");
        }
        
    }
}
