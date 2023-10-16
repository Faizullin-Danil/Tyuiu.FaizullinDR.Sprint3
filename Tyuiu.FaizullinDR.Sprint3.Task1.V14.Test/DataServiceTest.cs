using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FaizullinDR.Sprint3.Task1.V14.Lib;

namespace Tyuiu.FaizullinDR.Sprint3.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double t = 0.7;
            double res = ds.GetMultiplySeries(t);
            double wait = 3.546;
            Assert.AreEqual(wait, res);
        }
    }
}
