using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemischtwarenladen
{
    public class Beleg
    {
        private string produkt;
        private double preis;
        private double gesammtpreis;
        private string produktList;

        public Beleg(string Produkt, double Preis, double Gesammtpreis)
        {
            this.produkt = Produkt;
            this.preis = Preis;
            this.gesammtpreis = Gesammtpreis;
        }
        /// <summary>
        /// Produkt wird dem Beleg hinzugefügt
        /// </summary>
        /// <returns>string mit Produktname und Preis</returns>
        public string AddList()
        {
            string cpreis = string.Format("{0:C2}", preis);
            produktList = $"Produkt: {produkt} \t\tkostet:\t\t {cpreis}";
            
            return produktList;
        }
        /// <summary>
        /// gesammtpreis wird aktualisiert
        /// </summary>
        /// <returns>double gesammtpreis</returns>
        public double SubTotal()
        {
            gesammtpreis = gesammtpreis + preis;
            return gesammtpreis;
        }
    }
}
