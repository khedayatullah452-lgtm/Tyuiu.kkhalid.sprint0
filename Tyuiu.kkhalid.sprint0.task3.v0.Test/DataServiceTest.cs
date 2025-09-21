using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.kkhalid.sprint0.task2.v0.lib;
using Tyuiu.kkhalid.sprint0.task3.v0.Lib;

namespace Tyuiu.kkhalid.sprint0.task3.v0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(10, Dataservice.sum(5, 5));
        }
    }
}
