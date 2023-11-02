using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint4.Task1.V4.Lib;

namespace Tyuiu.SheludkovAA.Sprint4.Task1.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] arr = { 1, 2, 5, 3, 4, 7, 8, 8, 3, 9 };
            int wait = 2835;
            int res = ds.Calculate(arr);
            Assert.AreEqual(wait, res);
        }
    }
}
