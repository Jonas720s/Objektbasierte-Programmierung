using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolioauftrag
{
    public class Dreieck
    {
        private Linie linie1;
        private Linie linie2;
        private Linie linie3;


        public Dreieck(Linie Linie1, Linie Linie2, Linie Linie3)
        {
        
            this.linie1 = Linie1;
            this.linie2 = Linie2;
            this.linie3 = Linie3;


        }
        /// <summary>
        /// Ermittelt ob mit den eingegebenen Werten ein Dreieck erstellt werden kann
        /// </summary>
        /// <returns>boolean</returns>
        public bool IstDreieckMoeglich()
        {
            return (linie1.Laenge + linie2.Laenge > linie3.Laenge) && (linie1.Laenge + linie3.Laenge > linie2.Laenge) && (linie2.Laenge + linie3.Laenge > linie1.Laenge);
        }
        /// <summary>
        /// Berechnet Umfang des Dreiecks anhand drei double
        /// </summary>
        /// <returns>Umfang des Dreiecks: double</returns>
        public double BerechneUmfang()
        {
            double umfang = linie1.Laenge + linie2.Laenge + linie3.Laenge;
            return umfang;
        }
        /// <summary>
        /// Berechne Fläche des Dreiecks
        /// </summary>
        /// <returns>Fläche des Dreiecks: double</returns>
        public double BerechneFlaeche()
        {
            double halbumfang = BerechneUmfang() / 2;
            double v = Math.Sqrt(halbumfang * (halbumfang - linie1.Laenge) * (halbumfang - linie2.Laenge) * (halbumfang - linie3.Laenge));
            double flaeche = v;
            return flaeche;
        }
    }
}
