using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung_Auto
{
    internal class Motor
    {
        private Benzinpumpe benzinpumpe = new Benzinpumpe();
        private Anlasser anlasser = new Anlasser();

        public void Starten()
        {
            Console.WriteLine("Motor starten");
            benzinpumpe.Pumpen();
            anlasser.Starten();
            Regeln();
        }

        private void Regeln()
        {
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Motor regeln");
            }
            anlasser.Stoppen();
        }
    }
}
