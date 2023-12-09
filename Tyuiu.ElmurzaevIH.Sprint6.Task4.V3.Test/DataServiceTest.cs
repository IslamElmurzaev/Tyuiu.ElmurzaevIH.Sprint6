using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ElmurzaevIH.Sprint6.Task4.V3.Lib;

namespace Tyuiu.ElmurzaevIH.Sprint6.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int start = -5;
            int end = 5;

            int len = end - start + 1;

            double[] wait;
            wait = new double[len];

            wait[0] = 4.34;
            wait[1] = 4.16;
            wait[2] = 3.71;
            wait[3] = 3.27;
            wait[4] = 2.93;
            wait[5] = 2.50;
            wait[6] = 0.71;
            wait[7] = -47.61;
            wait[8] = 55.15;
            wait[9] = 45.17;
            wait[10] = 14.97;

            double[] res = new double[len];
            res = ds.GetMassFunction(start, end);
            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\adami\source\repos\Tyuiu.ElmurzaevIH.Sprint6\Tyuiu.ElmurzaevIH.Sprint6.Task4.V3\bin\Debug\OutPutFileTask4V3.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
