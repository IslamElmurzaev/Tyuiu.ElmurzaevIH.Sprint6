using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ElmurzaevIH.Sprint6.Task6.V26.Lib
{
    public class DataService : ISprint6Task6V26
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var temp = line.Split(' ');
                    resStr += temp[temp.Length - 1] + ' ';
                }
            }
            return resStr;
        }
    }
}
