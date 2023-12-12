using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ElmurzaevIH.Sprint6Review.V29.Lib
{
    public class DataService
    {
        public int GetMatrix(int[,] array, int c, int k, int l)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
        
            int sum = 0;
            for (int j = k; j <= l; j++)
            {
                sum += array[c, j];
            }
            return sum;
        }
    }
}
