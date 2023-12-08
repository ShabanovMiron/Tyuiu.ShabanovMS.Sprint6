using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShabanovMS.Sprint6.Task1.V4.Lib
{
    public class DataService : ISprint6Task1V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = 0;
            double[] resArray = new double[stopValue - startValue + 1];
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 1.2 != 0)
                {
                    resArray[count] = Math.Round((Math.Sin(x) / (x + 1.2) - Math.Sin(x) * 2 - (2 * x)), 2);
                    count++;
                }
                else
                {
                    resArray[count] = 0;
                    count++;
                }
            }
            return resArray;
        }
    }
}
