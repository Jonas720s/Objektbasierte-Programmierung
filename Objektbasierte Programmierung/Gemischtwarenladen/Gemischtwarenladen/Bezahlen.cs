using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemischtwarenladen
{
    public class Bezahlen
    {
        private double gesammtpreis;
        public Bezahlen(double Gesammtpreis) 
        { 
            this.gesammtpreis = Gesammtpreis;
        }
        public string Zahlungsart()
        {
            Console.WriteLine($"Mit Welchem Zahlungsmittel möchten sie Bezahlen?\nKarte\nTWINT\nBar");
            while
        }
    }
}
