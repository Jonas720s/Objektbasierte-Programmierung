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
        public Rechteck(Linie Linie1, Linie Linie2)
        {
            this.linie1 = Linie1;
            this.linie2 = Linie2;
        }
        public double BerechneUmfang()
        {
            double umfang = (linie1.Laenge + linie2.Laenge) * 2;
            return umfang;
        }
        public double BerechneFlaeche()
        {
            double flaeche = linie1.Laenge * linie2.Laenge;
            return flaeche;
        }
    }
}
