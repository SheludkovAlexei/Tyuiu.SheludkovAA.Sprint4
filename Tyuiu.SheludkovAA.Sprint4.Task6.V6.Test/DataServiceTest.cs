using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint4.Task6.V6.Lib;

namespace Tyuiu.SheludkovAA.Sprint4.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] mmm = { "Борис", "Анна", "Михаил", "Ирина", "Сергей", "Татьяна", "Олег" };
            string[] wait = { "Борис", "Ирина" };
            string[] res = ds.Calculate(mmm);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
