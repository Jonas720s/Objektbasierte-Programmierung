using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolioauftrag
{
    internal class Kreis
    {
        private Linie linie;
         
        public Kreis(Linie Linie) {
            this.linie = Linie;
            
        
        }
        public double BerechneUmfang()
        {
            return linie.Laenge;
        }
        public double BerechneFlaeche()
        {
            double flaeche = 0;
            double radius = linie.Laenge / (2 * Math.PI);
            flaeche = Math.Pow(radius, 2) * Math.PI;
            return flaeche;
        }
    }
}
