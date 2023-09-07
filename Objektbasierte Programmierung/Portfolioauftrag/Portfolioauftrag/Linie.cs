using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolioauftrag
{
    public class Linie
    {
        private double laenge;
        public double Laenge { get { return laenge; } }
        public Linie(double laenge)
        {
            if (laenge > 0)
            {
                this.laenge = laenge;
            }
            else
            {
                Console.Write("Bitte eine Zahl grösser 0 eingeben: ");
                this.laenge = Convert.ToDouble(Console.ReadLine());
            }
        }

    }
}
