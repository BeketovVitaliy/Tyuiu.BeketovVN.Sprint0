using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;
using Tyuiu.BeketovVN.Sprint0.Task2.V0.Lib;


namespace Tyuiu.BeketovVN.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassegeValid()
        {
            var name = "Виталий";
            var res = DataService.GetMassage(name);

            Assert.AreEqual("привет, Виталий", res);
        }
    }
}
