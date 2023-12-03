﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomanichRM.Sprint6.Task2.V7.Lib;

namespace Tyuiu.KomanichRM.Sprint6.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = -9.1;
            valueWaitArray[1] = 1.55;
            valueWaitArray[2] = 292.78;
            valueWaitArray[3] = -0.57;
            valueWaitArray[4] = -0.35;
            valueWaitArray[5] = 2;
            valueWaitArray[6] = 4.35;
            valueWaitArray[7] = 4.57;
            valueWaitArray[8] = -288.78;
            valueWaitArray[9] = 2.45;
            valueWaitArray[10] = 13.1;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
