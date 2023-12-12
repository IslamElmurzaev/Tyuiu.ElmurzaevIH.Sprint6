using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ElmurzaevIH.Sprint6Review.V29.Lib;
namespace Tyuiu.ElmurzaevIH.Sprint6Review.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatix()
        {
            DataService ds = new DataService();

            int R = 2;
            int K = 0;
            int L = 2;

            int[,] array = new int[3, 3] { { 1, 2, 3 }, { 2, 3, 5 }, { 4, 5, 6 } };
            int wait = 15;
            int res = ds.GetMatrix(array, R, K, L);
            Assert.AreEqual(wait, res);

        }
    }
}
