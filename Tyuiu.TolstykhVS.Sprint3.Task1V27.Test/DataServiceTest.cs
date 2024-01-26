using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolstykhVS.Sprint3.Task1V27.Lib;

namespace Tyuiu.TolstykhVS.Sprint3.Task1V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void validGetMultiplySeries()
        {
            DataService ds = new DataService();
            double n = 0.75;
            int startValue = 1, stopValue = 5;
            var proiz = ds.GetMultiplySeries(n, startValue, stopValue);
            double wait = 419028.1;

            Assert.AreEqual(wait, proiz);
        }
    }
}
