using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostageCalculator.Classes;

namespace Exercises.Tests
{
    [TestClass]
    public class PostageTest
    {
        [TestMethod]
        public void FexEdTest()
        {
            FexEd fexEdTest = new FexEd();
            Assert.AreEqual(20, fexEdTest.CalculateRate(100, 10));
        }
        [TestMethod]
        public void PostalService1Test()
        {
            PostalService1st postalService1Test = new PostalService1st();
            Assert.AreEqual(4.7, postalService1Test.CalculateRate(100, 10));
        }
        [TestMethod]
        public void PostalService2Test()
        {
            PostalService2nd postalService2Test = new PostalService2nd();
            Assert.AreEqual(4.5, postalService2Test.CalculateRate(100, 128));
        }
        [TestMethod]
        public void PostalService3Test()
        {
            PostalService3rd postalService3Test = new PostalService3rd();
            Assert.AreEqual(.24, postalService3Test.CalculateRate(100, 10));
        }
        [TestMethod]
        public void SPU4Test()
        {
            SPU4Day sPU4Test = new SPU4Day();
            Assert.AreEqual(5, sPU4Test.CalculateRate(100, 10));
        }
        [TestMethod]
        public void SPU2Test()
        {
            SPU2Day sPU2Test = new SPU2Day();
            Assert.AreEqual(50, sPU2Test.CalculateRate(100, 10));
        }
        [TestMethod]
        public void SPUNextTest()
        {
            SPUNextDay sPUNextTest = new SPUNextDay();
            Assert.AreEqual(75, sPUNextTest.CalculateRate(100, 10));
        }
    }
}
