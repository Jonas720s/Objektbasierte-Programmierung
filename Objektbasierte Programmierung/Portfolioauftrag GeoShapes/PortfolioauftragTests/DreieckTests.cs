using Microsoft.VisualStudio.TestTools.UnitTesting;
using Portfolioauftrag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolioauftrag.Tests
{
    [TestClass()]
    public class DreieckTests
    {
        [TestMethod()]
        public void DreieckTest()
        {
            //DreieckTesta
            Linie liniea1 = new Linie(13);
            Linie liniea2 = new Linie(55);
            Linie liniea3 = new Linie(46);

            Dreieck dreiecka = new Dreieck(liniea1, liniea2, liniea3);

            double ergebnisa = dreiecka.BerechneFlaeche();

            Assert.AreEqual(234.89572154468885, ergebnisa);

            //DreieckTestb
            Linie linieb1 = new Linie(3567);
            Linie linieb2 = new Linie(4566);
            Linie linieb3 = new Linie(1030);

            Dreieck dreieckb = new Dreieck(linieb1, linieb2, linieb3);

            double ergebnisb = dreieckb.BerechneFlaeche();

            Assert.AreEqual(505826.5601537127, ergebnisb);

            //DreieckTestc
            Linie liniec1 = new Linie(9843);
            Linie liniec2 = new Linie(1000);
            Linie liniec3 = new Linie(10340);

            Dreieck dreieckc = new Dreieck(liniec1, liniec2, liniec3);

            double ergebnisc = dreieckc.BerechneFlaeche();

            Assert.AreEqual(4373074.719487987, ergebnisc);
        }
    }
}