using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ElmurzaevIH.Sprint6.Task2.V21.Lib
{
    public class DataService : ISprint6Task2V21
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray = new double[stopValue - startValue + 1];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x != -2)
                {
                    y = Math.Cos(x) + (Math.Cos(x) / (x + 2)) - 3 * x;
                    valueArray[count] = Math.Round(y, 2);
                    count++;
                }
                else
                {
                    valueArray[count] = 0;
                    count++;
                }
                
            }
            return valueArray;

        }
    }
}
