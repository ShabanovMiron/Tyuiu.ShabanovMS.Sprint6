using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabanovMS.Sprint6.Task0.V15.Lib;
namespace Tyuiu.ShabanovMS.Sprint6.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int x = 1;
            double res = ds.Calculate(x);
            int wait = 12;
            Assert.AreEqual(res, wait);
        }
    }
}
