using Microsoft.VisualStudio.TestTools.UnitTesting;
using OODMay2022_S00212883;

namespace OODMay2022UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IncreaseRentTestMethod()
        {
            //Arrange
            RentalProperty r1 = new RentalProperty{Price = 100m};
            decimal expectedPrice = 115m;
            //Act
            r1.IncreaseRent(0.15m);
            //Assert
            Assert.AreEqual(expectedPrice, r1.Price);

        }
    }
}
