using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pract12;

namespace Pract12Test
{
    [TestClass]
    public class InvestorTest
    {
        [TestMethod]
        public void TestInvestor()
        {
            // arrange
            Investor i = new Investor("Эля", "25.06.2017", 1000, 15);
            bool expected = true;
            //act 
            string data = "25.06.2017";
            bool actual = i.partnershipData(data);
            //assert 
            Assert.AreEqual(expected, actual);
        }
    }
}
