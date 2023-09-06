using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolioauftrag
{
    internal class Formenbehaelter
    {
        private Linie linie1;
        private Linie linie2;
        private Linie linie3;
        private string[] formBehälter;
        private int besetzt;

        public Formenbehaelter(int Besetzt, string[] FormBehälter, Linie Linie1, Linie Linie2, Linie Linie3) 
        {
            this.besetzt = Besetzt;
            this.formBehälter = FormBehälter;
            this.linie1 = Linie1;
            this.linie2 = Linie2;
            this.linie3 = Linie3;
        }
        
        public string[] DreiecksBehaelter()
        {
            formBehälter[besetzt] = $"Dreieck {besetzt + 1}: {linie1.Laenge}, {linie2.Laenge}, {linie3.Laenge}";
            Console.WriteLine($"Das ist der array {formBehälter[0]}, {formBehälter[1]}");
            return formBehälter;
        }
        public string[] RechtecksBehaelter()
        {
            formBehälter[besetzt] = $"Rechteck {besetzt + 1}: {linie1.Laenge}, {linie2.Laenge}";
            Console.WriteLine($"Das ist der array {formBehälter[0]}, {formBehälter[1]}");
            return formBehälter;
        }
        public string[] KreisBehaelter()
        {
            formBehälter[besetzt] = $"Kreis {besetzt + 1}: {linie1.Laenge}";
            Console.WriteLine($"Das ist der array {formBehälter[0]}, {formBehälter[1]}");
            return formBehälter;
        }
    }
}