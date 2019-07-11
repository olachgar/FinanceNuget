using System;
using Xunit;

namespace Finance.Tests.Stocks
{
    public class CapitalGainsYield
    {
        [Theory]
        [InlineData(500, 5, -99)]
        [InlineData(1000, 5, -99.500)]
        [InlineData(100000, 20, -99.980)]
        [InlineData(100000, 60, -99.940)]
        [InlineData(100000, 180, -99.820)]
        public void CapitalGainsYield_Test(double initialStockPrice, double endingStockPrice, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.Stocks.CapitalGainsYield(initialStockPrice, endingStockPrice);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(0, 10)]
        [InlineData(0, 0)]
        public void CapitalGainsYield_DivideByZero_Test(double initialStockPrice, double endingStockPrice)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.Stocks.CapitalGainsYield(initialStockPrice, endingStockPrice);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
