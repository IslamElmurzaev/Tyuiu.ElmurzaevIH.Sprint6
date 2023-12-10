using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ElmurzaevIH.Sprint6.Task7.V28.Lib
{
    public class DataService : ISprint6Task7V28
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path); // читаем данные из файла

            // Разделяем на строки
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Определение кол-ва строк и столбцов
            int rows = lines.Length;
            int colums = lines[0].Split(';').Length;

            // Создание массива необходимой длинны
            int[,] arrayValues = new int[rows, colums];

            // Заполнение массива
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }

            for (int c = 0; c < colums; c++)
            {
                if (arrayValues[6, c] != 13)
                {
                    arrayValues[6, c] = 0;
                }
            }

            return arrayValues;
        }
    }
}
