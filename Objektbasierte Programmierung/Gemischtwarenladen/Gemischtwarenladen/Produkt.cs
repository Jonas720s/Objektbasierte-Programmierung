using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemischtwarenladen
{
    public class Produkt
    {
        private string produkt;
        public string typ;
        public double preis;


        public Produkt(string produkt)
        {
            this.produkt = produkt;
        }
        public string ProduktName()
        {
            if (produkt == "0014872221")
            {
                typ = "Apfel";
                return typ;
            }
            else if (produkt == "0014891598")
            {
                typ = "Brot";
                return typ;
            }
            else if (produkt == "0014877158")
            {
                typ = "Mineral";
                return typ;
            }
            else if (produkt == "0014870584")
            {
                typ = "Fleisch";
                return typ;
            }
            else if (produkt == "0014884074")
            {
                typ = "Käse";
                return typ;
            }
            else if (produkt.ToUpper() == "Z")
            {
                typ = "Z";
                return typ;
            }
            else
            {

                return "";
            }

        }
        public double ProduktPreis()
        {
            if (produkt == "0014872221")
            {
                preis = 2;
                return preis;
            }
            else if (produkt == "0014891598")
            {
                preis = 3;
                return preis;
            }
            else if (produkt == "0014877158")
            {
                preis = 1;
                return preis;
            }
            else if (produkt == "0014870584")
            {
                preis = 12;
                return preis;
            }
            else if (produkt == "0014884074")
            {
                preis = 5;
                return preis;
            }
            else
            {
                return 0;
            }
        }
    }
}
