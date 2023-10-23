using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FaizullinDR.Sprint3.Task6.V23.Lib;

namespace Tyuiu.FaizullinDR.Sprint3.Task6.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 18;
            int stopValue = 28;

            int count = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 34;

            Assert.AreEqual(wait, count);

        }
    }
}
