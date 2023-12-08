using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
namespace Tyuiu.ShabanovMS.Sprint6.Task5.V25.Lib
{

    public class DataService : ISprint6Task5V25
    {
        public int len; 
        public double[] LoadFromDataFile(string path)
        {
            double[] resArray;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }

            resArray = new double[len];
            int index = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    resArray[index] = Convert.ToDouble(line);
                    index++;
                }
            }

            resArray = resArray.Where(val => val != 0).ToArray();

            return resArray;
        }
    }
    
}
