using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolioauftrag
{
    public class Rechteck
    {
        private Linie linie1;
        private Linie linie2;
        private Linie linie3;
        private Linie linie4;
        public Rechteck(Linie Linie1, Linie Linie2, Linie Linie3, Linie Linie4)
        {
            this.linie1 = Linie1;
            this.linie2 = Linie2;
            this.linie3 = Linie3;
            this.linie4 = Linie3;

        }
        /// <summary>
        /// Berechnet Umfang des Rechtecks anhand zwei double
        /// </summary>
        /// <returns>Umfang des Rechtecks</returns>
        public double BerechneUmfang()
        {
            double umfang = linie1.Laenge + linie2.Laenge + linie3.Laenge + linie4.Laenge;
            return umfang;
        }
        /// <summary>
        /// Berechne Fläche des Rechtecks anhand zwei double
        /// </summary>
        /// <returns>Fläche des Rechtecks</returns>
        public double BerechneFlaeche()
        {
            double flaeche = linie1.Laenge * linie2.Laenge;
            return flaeche;
        }
    }
}
