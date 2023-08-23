using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben_Assoziationen
{
    internal class Vater
    {
        {
        public int VaterId { get; set; }
        public string Name { get; set; }

        // 0-1 Assoziation zum Kind
        public Kind Kind { get; set; }
        }

    }
}
