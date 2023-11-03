using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint4.Task2.V25.Lib;

namespace Tyuiu.SheludkovAA.Sprint4.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] arr = { 1, 2, 2, 3, 4, 7, 9, 9, 3, 9,7 };
            int wait = 16;
            int res = ds.Calculate(arr);
            Assert.AreEqual(wait, res);
        }
    }
}
