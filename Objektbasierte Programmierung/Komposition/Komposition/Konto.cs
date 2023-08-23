using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komposition
{
    internal class Konto
    {
        public int KontoId { get; set; }
        public string Name { get; set; }

        //Aggregation zu Kunde
        public Kunde Kunde { get; set; }
    }
}
