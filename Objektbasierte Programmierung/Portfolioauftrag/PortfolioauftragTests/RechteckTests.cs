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
    public class RechteckTests
    {
        [TestMethod()]
        public void RechteckTest()
        {
            //RechteckTesta
            Linie liniea1 = new Linie(13);
            Linie liniea2 = new Linie(55);

            Rechteck rechtecka = new Rechteck(liniea1, liniea2);

            double ergebnisa = rechtecka.BerechneFlaeche();

            Assert.AreEqual(715, ergebnisa);

            //RechteckTestb
            Linie linieb1 = new Linie(2344);
            Linie linieb2 = new Linie(4643);

            Rechteck rechteckb = new Rechteck(linieb1, linieb2);

            double ergebnisb = rechteckb.BerechneFlaeche();

            Assert.AreEqual(10883192, ergebnisb);

            //RechteckTestc
            Linie liniec1 = new Linie(98327);
            Linie liniec2 = new Linie(345);

            Rechteck rechteckc = new Rechteck(liniec1, liniec2);

            double ergebnisc = rechteckc.BerechneFlaeche();

            Assert.AreEqual(33922815, ergebnisc);
        }
    }
}