using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.kkhalid.sprint0.task6.v0.lib;
namespace Tyuiu.kkhalid.sprint0.task6.v0.test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {
            var numbers = new int [] { 1, 2, 3, 4,5 };
            var res = DataServiseTest.AdditionArray(numbers);
            Assert.AreEqual(15, res);
        }

        private static int AdditionArray(int[] numbers)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void CheckSubtractionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubtractionArray(numbers);
            Assert.AreEqual(-15, res);
        }

        [TestMethod]
        public void CheckMultArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
        
            var res = DataServiseTest.Multiplicationarray(numbers); 
            
            Assert.AreEqual(120, res);
        }

        
        }
    }
}
