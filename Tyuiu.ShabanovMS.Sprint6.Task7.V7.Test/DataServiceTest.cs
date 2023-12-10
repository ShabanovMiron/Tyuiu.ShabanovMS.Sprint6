﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabanovMS.Sprint6.Task7.V7.Lib;
using System.IO;
namespace Tyuiu.ShabanovMS.Sprint6.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask7V7.csv";
            int[,] waitMtrx = {
                {2, 19, 9 , 4, 0, -1, -15, 19, 11, 9},
                {15, 5, -2, 8, 9, -5, -19, -10, 9, -5},
                {19, 7, 1, 1, -7, -1, 16, 13, -5, 1},
                {-11, 20, -13, 17, 15, -3, -10, 16, -5, 9},
                {10,  9, -19, 15, 12, 14, 1, -2, 13, 4},
                {18,  66, 8, -8, -16, 66, 66, -8, 4, 8},
                {5 ,-3 ,-5 , 14,  12, -12, -1, 4, 9, 2},
                {-6, 6, 14, 3, 8, 5, 8, 4, 19, 10},
                { -17, 13,  13 , 0, - 10, 6, -7,  17,  20, -8},
                { -6 , 20, -18, 19, -20, 4, 20, -18, 2 , 12}
            };

            int[,] resMtrx = ds.GetMatrix(path);

            CollectionAssert.AreEqual(resMtrx, waitMtrx);
        }
    }
}
