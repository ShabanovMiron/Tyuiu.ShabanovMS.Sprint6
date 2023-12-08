using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShabanovMS.Sprint6.Task4.V10.Lib
{
    public class DataService : ISprint6Task4V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] resArray;
            resArray = new double[len];
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (Math.Sin(i) + 3 != 3) 
                { 
                resArray[count] = Math.Round((((5 * i) + 2.5) / (Math.Sin(i) + 3)) + (2 * i) + Math.Cos(i), 2);
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
