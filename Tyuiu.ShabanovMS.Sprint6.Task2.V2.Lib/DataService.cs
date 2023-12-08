using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShabanovMS.Sprint6.Task2.V2.Lib
{
    public class DataService : ISprint6Task2V2
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] resultArray;
            int len = stopValue - startValue + 1;
            resultArray = new double[len];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (3*x + 0.5 != 0.5)
                {
                    resultArray[count] = Math.Round(Math.Sin(x) + (2 / ((3 * x) + 0.5)) - (2 * Math.Cos(x)) * (2 * x), 2);
                    count++;
                }
                else
                {
                    resultArray[count] = 0;
                    count++;
                }
            }
            return resultArray; 
        }
    }
}
