using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabanovMS.Sprint6.Task4.V10.Lib;
namespace Tyuiu.ShabanovMS.Sprint6.Task4.V10.Test
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
            int len = stopValue - startValue + 1;
            double[] waitArray = { -15.4, -13.31, -11.36, -8, -2.62, 0, 4.49, 6.78, 10.58, 17.38, 23.76 };
            double[] resArray;
            resArray = new double[len];
            resArray = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(resArray, waitArray);
        }
    }
}
