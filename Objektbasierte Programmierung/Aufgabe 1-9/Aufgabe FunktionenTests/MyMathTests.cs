using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aufgabe_1_9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_1_9.Tests
{
    [TestClass()]
    public class MyMathTests
    {
        [TestMethod()]
        public void Calc_ggTTest()
        {
            int ggT1 = MyMath.Calc_ggT(14, 43);
            int ggT2 = MyMath.Calc_ggT(25, 50);
            int ggt3 = MyMath.Calc_ggT(12, 4);

            Assert.AreEqual(1, ggT1);
            Assert.AreEqual(25, ggT2);
            Assert.AreEqual(4, ggt3);
        }
        [TestMethod()]
        public void Calc_kgVTest() 
        { 
            int kgV1 = MyMath.Calc_kgV(14, 43);
            int kgV2 = MyMath.Calc_kgV(12, 55);
            int kgV3 = MyMath.Calc_kgV(342, 543);

            Assert.AreEqual(602, kgV1);
            Assert.AreEqual(660, kgV2);
            Assert.AreEqual(61902, kgV3);
        }
    }
}