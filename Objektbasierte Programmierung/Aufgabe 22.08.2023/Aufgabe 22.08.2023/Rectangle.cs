using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_22._08._2023
{
    internal class Rectangle
    {
        // Aufgabe 1: Ein Feld mit einem für Felder typischen Zugriffsmodifizierer
        private int hight;

        // Aufgabe 2: Ein Feld, dessen Wert während der Lebensdauer eines Objekts nicht verändert werden kann
        private readonly int width;

        // Aufgabe 3: Ein Feld, für welches ein Standardwert zugewiesen wird
        private colar fillcolar = colar.blue;

        // Aufgabe 4: Eine selber implementierte, read-only Eigenschaft
        private readonly int Area = 42;
        public int Area2
        {
            get { return Area2; }
        }

        // Aufgabe 5: Eine selber implementierte, read-write Eigenschaft
        private int hight1;
        public int higth1
        {
            get { return hight1; }
            set { hight1 = value; }
        }

        // Aufgabe 6: Eine selber implementierte, write-only Eigenschaft
        private string colar4;
        public string colar3
        {
            set { colar3 = value; }
        }

        // Aufgabe 7: Eine automatisch implementierte, read-only Eigenschaft
        public int Hight2 { get; } = 123;

        // Aufgabe 8: Eine automatisch implementierte, read-write Eigenschaft
        public int Width2 { get; set; }

        // Aufgabe 9: Eine automatisch implementierte, write-only Eigenschaft
        // not possible

        // Expression body Schreibweise für Eigenschaften
        public int area4 => width * hight;
    }
}

