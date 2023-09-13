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
        /// <summary>
        /// mit der gescannten Nummer wird das Produkt gesucht
        /// </summary>
        /// <returns>string Produktname</returns>
        public string ProduktName()
        {
            if (produkt == "0014872221")
            {
                typ = "Apfel\t";
                return typ;
            }
            else if (produkt == "0014891598")
            {
                typ = "Brot\t";
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
                typ = "Käse\t";
                return typ;
            }
            else if (produkt.ToUpper() == "Z")
            {
                typ = "Z";
                return typ;
            }
            else
            {

                return "\t\t";
            }

        }
        /// <summary>
        /// Mit der gescannten Nummer wird der Preis gesucht
        /// </summary>
        /// <returns>double Produktpreis</returns>
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
