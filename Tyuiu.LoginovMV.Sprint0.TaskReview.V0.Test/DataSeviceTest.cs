using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LoginovMV.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.LoginovMV.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataSeviceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 1;
            int z = 1;
            var res = ds.Calc(x, y, z);
            Assert.AreEqual(15, res);
        }
    }
}
