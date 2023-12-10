using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomanichRM.Sprint6.Task6.V19.Lib;

namespace Tyuiu.KomanichRM.Sprint6.Task6.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            string path = @"C:\DataSprint6\InPutFileTask6V19.txt";
            DataService ds = new DataService();
            string res = ds.CollectTextFromFile(path);
            string wait = "HqrXl PAlR TwlB AWkgYPxilmC";
            Assert.AreEqual(wait, res);
        }
    }
}
