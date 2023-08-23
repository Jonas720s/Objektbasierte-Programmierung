using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    internal class NotebookFestplatte
    {
        {
        public int FestplatteId { get; set; }
        public string Name { get; set; }

        //Aggregation zu Notebook
        public Notebook Notebook { get; set; }
        }
    }
}
