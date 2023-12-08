using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabanovMS.Sprint6.Task1.V4.Lib;
namespace Tyuiu.ShabanovMS.Sprint6.Task1.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] waitArray = new double[11] { 7.83, 6.22, 6.36, 6.96, -0.52, 0, -3.3, -5.53, -6.25, -6.63, -8.24 };
            int len = stopValue - startValue + 1;
            double[] resArray;
            resArray = new double[len];
            resArray = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(resArray, waitArray);
        }
    }
}
