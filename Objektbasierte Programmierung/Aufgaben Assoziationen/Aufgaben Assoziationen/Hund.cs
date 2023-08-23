using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben_Assoziationen
{
    internal class Hund
    {
        public int HundId { get; set; }
        public string Name { get; set; }

        // Liste der Läuse, die der Hund hat
        public List<Laus> Laeuse { get; set; } = new List<Laus>();
    }
}
