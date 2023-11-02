using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint4.Task0.V25.Lib;

namespace Tyuiu.SheludkovAA.Sprint4.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] arr = { 1, 4, 2, 6, 4, 8, 6, 7, 8, 4 };
            int wait = 42;
            int res = ds.GetSumEvenArrEl(arr);
            Assert.AreEqual(wait, res);
        }
    }
}
