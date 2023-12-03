using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ElmurzaevIH.Sprint6.Task1.V14.Lib
{
    public class DataService : ISprint6Task1V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray = new double[stopValue - startValue + 1];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = (2 * x + 6) / (Math.Cos(x) + x) - 3;
                valueArray[count] = Math.Round(y, 2);
                count++;
            }
            return valueArray;
        }
    }
}
