using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung_Auto
{
    internal class Auto
    {
        private Motor motor = new Motor();

        public void Anlassen()
        {
            Console.WriteLine("Auto anlassen");
            motor.Starten();
        }
    }
}
