using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabanovMS.Sprint6.Task2.V2.Lib;
namespace Tyuiu.ShabanovMS.Sprint6.Task2.V2.Test
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
            double[] waitArray = { 6.49, -9.88, -12.26, -4.6, 0.52, 0, -0.75, 4.55, 12.23, 9.86, -6.5 };
            double[] resArray;
            resArray = new double[len];
            resArray = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(resArray, waitArray);
            
        }
    }
}
