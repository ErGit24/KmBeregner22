using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KørselsfradagsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var obj1 = new KmBeregner.KilometerBeregner();

            //Act
            var pris = obj1.BeregnPris();


            //Assert
            Assert.AreEqual(200, pris);
        }
    }
}
