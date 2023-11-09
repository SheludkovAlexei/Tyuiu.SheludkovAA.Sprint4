using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint4.Task5.V30.Lib;

namespace Tyuiu.SheludkovAA.Sprint4.Task5.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mtr = new int[2, 2] { { -3, 5},
                                         { 1, -8} };
            
            int res = ds.Calculate(mtr);
            int wait = 6;
            Assert.AreEqual(wait, res);
        }
    }
}
