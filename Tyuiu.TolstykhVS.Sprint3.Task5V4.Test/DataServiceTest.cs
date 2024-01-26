using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolstykhVS.Sprint3.Task5V4.Lib;

namespace Tyuiu.TolstykhVS.Sprint3.Task5V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.GetSumSumSeries(5, 1, 3, 1, 13);
            Assert.AreEqual(1112.156, res);
        }
    }
}