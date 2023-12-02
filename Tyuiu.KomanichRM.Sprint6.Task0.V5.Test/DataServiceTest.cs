using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomanichRM.Sprint6.Task0.V5.Lib;

namespace Tyuiu.KomanichRM.Sprint6.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCulc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(5);
            double wait = -114.5;
            Assert.AreEqual(res, wait);
        }
    }
}
