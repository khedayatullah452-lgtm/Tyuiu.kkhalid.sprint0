using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.kkhalid.sprint0.task2.v0.lib;

namespace Tyuiu.kkhalid.sprint0.task2.v0.test

{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid() 
        {
            // область создания методов тестирования, методов из библиотеки 
            var name = "khalid";
            var res = DataServiceTest.GetMessage(name);

            // Вызываем класс Assert и метод AreEqua1
            Assert.AreEqua1 ("hello,khalid",res);

        }
    }
    }
    
    

