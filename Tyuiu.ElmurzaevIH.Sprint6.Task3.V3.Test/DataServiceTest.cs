using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ElmurzaevIH.Sprint6.Task3.V3.Lib;

namespace Tyuiu.ElmurzaevIH.Sprint6.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            var ds = new DataService();
            int[,] matr = new int[5, 5] { { -18, 21, 10, -2, 12 }, { -18, -10, 33, -20, 32 }, { 14, -15, -14, 12, -18 }, { -19, 5, -3, 28, -17 }, { -14, -9, 23, -13, 11 } };
            int[,] res = ds.Calculate(matr);

            int[,] wait = new int[5, 5] { { -18, -15, 10, -2, 12 }, { -18, -10, 33, -20, 32 }, { 14, -9, -14, 12, -18 }, { -19, 5, -3, 28, -17 }, { -14, 21, 23, -13, 11 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
