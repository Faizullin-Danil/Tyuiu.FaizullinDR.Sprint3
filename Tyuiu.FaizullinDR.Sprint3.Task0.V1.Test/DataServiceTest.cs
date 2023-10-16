using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FaizullinDR.Sprint3.Task0.V1.Lib;

namespace Tyuiu.FaizullinDR.Sprint3.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 4;
            double res = ds.GetSumSeries(x);
            double wait = 1921;
            Assert.AreEqual(wait, res);
        }
    }
}
