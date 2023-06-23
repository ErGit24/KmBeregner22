using Microsoft.VisualStudio.TestTools.UnitTesting;
using KmBeregner2;
using System;

namespace KørselsfradagsTests
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    //Arrange
        //    var obj1 = new KmBeregner.KilometerBeregner();

        //    //Act
        //    var pris = obj1.BeregnPris();


        //    //Assert
        //    Assert.AreEqual(0, pris);
        //}

        [DataTestMethod]
        [DataRow(-50, 0, 0)]
        [DataRow(20, 0, 0)]
        [DataRow(25, 0, 0)]
        [DataRow(100, 0, 0)]
        [DataRow(120, 0, 0)]
        [DataRow(200, 0, 0)]
        [DataRow(120, 0, 2)]
        [DataRow(50, 0, 1)]
        [DataRow(80, 0, 1)]
        [DataRow(25, 0, 2)]
        public void CalcFradrag_True(bool Biltog, float Km, float expectedPenge, int Bropenge)
        {
            //Arrange
            Beregner nyBregner = new Beregner();

            // Act
            float actualPenge = nyBregner.Start(Km, Bropenge);


            //Assert
            
            Assert.AreNotEqual(-1, actualPenge, "CalcFradrag returned an error value.");
            Console.WriteLine($"Actual result: {actualPenge}"); // Output the actual result
        }
    }
}
