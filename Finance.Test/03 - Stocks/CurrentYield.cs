using System;
using Xunit;

namespace Finance.Tests.Stocks
{
    public class CurrentYield
    {
        [Theory]
        [InlineData(100, 900, 11.11111)]
        [InlineData(100, 5, 2000)]
        [InlineData(100, 10, 1000)]
        [InlineData(1000000, 10, 10000000)]
        [InlineData(1000000, 9852, 10150.2233)]
        public void CurrentYield_Test(double annualCoupon, double currentBondPrice, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.Stocks.CurrentYield(annualCoupon, currentBondPrice);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(500, 0)]
        [InlineData(0, 0)]
        public void CurrentYield_DivideByZero_Test(double annualCoupon, double currentBondPrice)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.Stocks.CurrentYield(annualCoupon, currentBondPrice);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
