using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TollBoothCalculator.Classes;

namespace Exercises.Tests
{
    [TestClass]
    public class VehicleTest
    {
        [TestMethod]
        public void CarTestTrailer()
        {
            Car carTest = new Car(true);
            Assert.AreEqual(3, carTest.CalculateToll(100));
        }
        [TestMethod]
        public void CarTestNoTrailer()
        {
            Car carTest = new Car(false);
            Assert.AreEqual(2, carTest.CalculateToll(100));
        }
        [TestMethod]
        public void TruckTest4Axle()
        {
            Truck truckTest = new Truck(4);
            Assert.AreEqual(4, truckTest.CalculateToll(100));
        }
        [TestMethod]
        public void TruckTest8Axle()
        {
            Truck truckTest = new Truck(8);
            Assert.AreEqual(4.8, truckTest.CalculateToll(100));
        }
        [TestMethod]
        public void TankTest()
        {
            Tank tankTest = new Tank();
            Assert.AreEqual(0, tankTest.CalculateToll(100));
        }

    }
}
