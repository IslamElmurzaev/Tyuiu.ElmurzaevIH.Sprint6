using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;
using Tyuiu.ElmurzaevIH.Sprint6.Task0.V3.Lib;
namespace Tyuiu.ElmurzaevIH.Sprint6.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(3);
            double wait = 4.154;

            Assert.AreEqual(wait, res);
        }
    }
}
