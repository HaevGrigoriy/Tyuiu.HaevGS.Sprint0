using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.HaevGS.Sprint0.Task4.V0.Lib;

namespace Tyuiu.HaevGS.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckerAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [TestMethod]
        public void CheckerSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }


        [TestMethod]
        public void CheckerMultiplicationValid()
        {
            Assert.AreEqual(25, DataService.Multiplication(5, 5));
        }


        [TestMethod]
        public void CheckerDivisionnValid()
        {
            Assert.AreEqual(2, DataService.Division(10, 5));
        }
    }
}
