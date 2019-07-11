using System;
using Xunit;

namespace Finance.Tests.Stocks
{
    public class BondEquivalentYield
    {
        [Theory]
        [InlineData(500, 50, 60, 5475)]
        [InlineData(1000, 50, 60, 11558.33333)]
        [InlineData(1000, 100, 180, 1825)]
        [InlineData(100000, 5, 180, 4055352.77778)]
        [InlineData(100000, 15, 60, 4054947.22222)]
        public void BondEquivalentYield_Test(double faceValue, double bondPrice, double daysToMaturity, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.Stocks.BondEquivalentYield(faceValue, bondPrice, daysToMaturity);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(500, 0, 60)]
        [InlineData(500, 60, 0)]
        [InlineData(500, 0, 0)]
        public void BondEquivalentYield_DivideByZero_Test(double faceValue, double bondPrice, double daysToMaturity)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.Stocks.BondEquivalentYield(faceValue, bondPrice, daysToMaturity);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
