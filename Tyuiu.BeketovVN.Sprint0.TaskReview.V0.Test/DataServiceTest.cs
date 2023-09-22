using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BeketovVN.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.BeketovVN.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            Assert.AreEqual(DataService.Calc(1, 2, 3), 30);
        }
    }
}
