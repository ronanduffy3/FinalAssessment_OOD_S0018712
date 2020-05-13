using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalAssessment_OOD_Ronan_Finnegan_Duffy_S00187127;

namespace FinalAssessment.Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IncreasePriceTest()
        {
            // ARRANGE
            Phone phone = new Phone();
            phone.Price = 100;
            decimal newPrice = 150;

            // ACT
            phone.IncreasePrice(50);

            // ASSERT
            Assert.AreEqual(newPrice, phone.Price);

        }
    }
}
