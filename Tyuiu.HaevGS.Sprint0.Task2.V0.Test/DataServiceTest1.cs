using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.HaevGS.Sprint0.Task2.V0.Lib;

namespace Tyuiu.HaevGS.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest1
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Григорий";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Григорий", res);
        }
    }
}
