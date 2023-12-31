﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
namespace Tyuiu.ShabanovMS.Sprint6.Task7.V7.Lib
{
    public class DataService : ISprint6Task7V7
    {
        public int[,] GetMatrix(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] resArray = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    resArray[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }

            int rows_1 = resArray.GetUpperBound(0) + 1;
            int columns_1 = resArray.Length / rows_1; 
            for (int r = 0; r < rows_1; r++)
            {
                for (int c = 0; c < columns_1; c++ )
                {
                     if(resArray[5,c] % 2 != 0)
                    {
                        resArray[5, c] = 66;
                    }
                }
            }
            return resArray;
        }
    }
}
