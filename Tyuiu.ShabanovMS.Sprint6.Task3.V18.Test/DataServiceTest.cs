using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabanovMS.Sprint6.Task3.V18.Lib;
namespace Tyuiu.ShabanovMS.Sprint6.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5,5] {{ -19, -19, 1, 18, 7},
                                { 5, 3, -4, -6, -12},
                                { -15, 6, 2, 2, -14},
                                { -9, -10, 15, -5, -6},
                                { -13, -15, -9, 7, 1} };

            int [,] resMatrix = ds.Calculate(matrix);
            int [,] waitMatrix = new int [5,5] {{ -19, -19, 1, 18, 7},
                                { 5, 3, -4, -6, -12},
                                { -15, 6, 2, 2, -14},
                                { -9, -10, 15, -5, -6},
                                { 0, 0, 0, 0, 0} };
            CollectionAssert.AreEqual(resMatrix, waitMatrix);
        }
    }
}
