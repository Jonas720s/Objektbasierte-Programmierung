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
    public class KreisTests
    {
        [TestMethod()]
        public void KreisTest()
        {
            //KreisTesta
            Linie liniea = new Linie(23);

            Kreis kreisa = new Kreis(liniea);

            double ergebnisa = kreisa.BerechneFlaeche();

            Assert.AreEqual(42.096482447806316, ergebnisa);

            //KreisTestb
            Linie linieb = new Linie(14643);

            Kreis kreisb = new Kreis(linieb);

            double ergebnisb = kreisb.BerechneFlaeche();

            Assert.AreEqual(17062798.446752183, ergebnisb);

            //KreisTestc
            Linie liniec = new Linie(9874);

            Kreis kreisc = new Kreis(liniec);

            double ergebnisc = kreisc.BerechneFlaeche();

            Assert.AreEqual(7758475.298237243, ergebnisc);
        }
    }
}