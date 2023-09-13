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
            switch (produkt.ToUpper())
            {
                case "0014872221":
                    typ = "Apfel\t";
                    break;

                case "0014891598":
                    typ = "Brot\t";
                    break;

                case "0014877158":
                    typ = "Mineral";
                    break;

                case "0014870584":
                    typ = "Fleisch";
                    break;

                case "0014884074":
                    typ = "Käse\t";
                    break;

                case "Z":
                    typ = "Z";
                    break;

                default:
                    typ = "Nicht gefunden";
                    break;
            }
            return typ;
        }
        /// <summary>
        /// Mit der gescannten Nummer wird der Preis gesucht
        /// </summary>
        /// <returns>double Produktpreis</returns>
        public double ProduktPreis()
        {
            switch (produkt)
            {
                case "0014872221":
                    preis = 2;
                    break;

                case "0014891598":
                    preis = 3;
                    break;

                case "0014877158":
                    preis = 1;
                    break;

                case "0014870584":
                    preis = 12;
                    break;

                case "0014884074":
                    preis = 5;
                    break;

                default:
                    preis = 0;
                    break;
            }
            return preis;
        }
    }
}
