using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ElmurzaevIH.Sprint6.Task6.V26.Lib;
namespace Tyuiu.ElmurzaevIH.Sprint6.Task6.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            var path = @"C:\DataSprint6\InPutFileTask6V26.txt";
            var wait = "HlidZPHKeLLU OoyPFhjSRwp GUilXww iukCfO UaZNpcgYjw";
            var res = ds.CollectTextFromFile(path);
            Assert.AreNotSame(wait, res);
        }
    }
}
