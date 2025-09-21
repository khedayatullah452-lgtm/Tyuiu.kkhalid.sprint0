using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.kkhalid.sprint0.task4.v0.lib;
namespace Tyuiu.kkhalid.sprint0.task4.v0.test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void checkedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [TestMethod]

        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        [TestMethod]

        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }

        [TestMethod]

        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }

}

