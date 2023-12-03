using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ElmurzaevIH.Sprint6.Task3.V3.Lib
{
    public class DataService : ISprint6Task3V3
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[] second = new int[5];
            second[0] = matrix[0,1];
            second[1] = matrix[1, 1];
            second[2] = matrix[2, 1];
            second[3] = matrix[3, 1];
            second[4] = matrix[4, 1];
            Array.Sort(second);

            matrix[0,1] = second[0];
            matrix[1, 1] = second[1];
            matrix[2, 1] = second[2];
            matrix[3, 1] = second[3];
            matrix[4, 1] = second[4];

            return matrix;

        }
    }
}
