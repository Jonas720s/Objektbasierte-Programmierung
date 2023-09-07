using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolioauftrag
{
    internal class Formenbehaelter
    {
        private Kreis kreis;
        private Dreieck dreieck;
        private Rechteck rechteck;
        private string[] formBehälter;
        private int besetzt;

        public Formenbehaelter(int Besetzt, string[] FormBehälter, Kreis Kreis, Dreieck Dreieck, Rechteck Rechteck) 
        {
            this.besetzt = Besetzt;
            this.formBehälter = FormBehälter;
            this.kreis = Kreis;
            this.dreieck = Dreieck;
            this.rechteck = Rechteck;
        }
        
        public string[] DreiecksBehaelter()
        {
            formBehälter[besetzt] = $"Dreieck {besetzt + 1}: Umfang: {dreieck.BerechneUmfang()}, Fläche: {dreieck.BerechneFlaeche()}";
            return formBehälter;
        }
        public string[] RechtecksBehaelter()
        {
            formBehälter[besetzt] = $"Rechteck {besetzt + 1}: Umfang: {rechteck.BerechneUmfang()}, Fläche: {rechteck.BerechneFlaeche()}";
            return formBehälter;
        }
        public string[] KreisBehaelter()
        {
            formBehälter[besetzt] = $"Kreis {besetzt + 1}: Umfang: {kreis.BerechneUmfang()}, Fläche: {kreis.BerechneFlaeche()}";
            return formBehälter;
        }
    }
}