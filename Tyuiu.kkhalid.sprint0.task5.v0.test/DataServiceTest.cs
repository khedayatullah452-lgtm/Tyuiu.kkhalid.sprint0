using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

//Подключение библиотеки
using Tyuiu.kkhalid.sprint0.task5.v0.lib;

namespace Tyuiu.kkhalid.sprint0.task5.v0.test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataServiceTest.Addition(5, 5));
        }

        private static int Addition(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }
        [TestMethod]
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50,DataService.Multiplication(10, 5));
        }
        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }



    }
}

