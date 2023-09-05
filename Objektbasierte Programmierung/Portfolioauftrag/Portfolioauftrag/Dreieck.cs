using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolioauftrag
{
    internal class Dreieck
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
        public double BerechneUmfang()
        {
            double umfang = linie1.Laenge + linie2.Laenge + linie3.Laenge;
            return umfang;
        }
        public double BerechneFlaeche()
        {
            double halbumfang = BerechneUmfang() / 2;
            double flaeche = Math.Sqrt(halbumfang * (halbumfang - linie1.Laenge) * (halbumfang - linie2.Laenge) * (halbumfang - linie3.Laenge));
            return flaeche;
        }
    }
}
