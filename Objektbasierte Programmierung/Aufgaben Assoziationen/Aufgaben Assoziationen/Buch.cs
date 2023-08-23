using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben_Assoziationen
{
    internal class Buch
    {
        {
        public int BuchId { get; set; }
        public string Name { get; set; }

        public Kunde Kunde { get; set; }
        }
    }
}
