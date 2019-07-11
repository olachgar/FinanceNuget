using System;
using Xunit;

namespace Finance.Tests.Stocks
{
    public class EquityMultiplier
    {
        [Theory]
        [InlineData(500, 6, 83.33333)]
        [InlineData(1000, 6, 166.66667)]
        [InlineData(1000, 5, 200)]
        [InlineData(5000, 5, 1000)]
        [InlineData(1000000, 3325, 300.75188)]
        public void EquityMultiplier_Test(double totalAssets, double stockholderEquity, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.Stocks.EquityMultiplier(totalAssets, stockholderEquity);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(0, 0)]
        [InlineData(500, 0)]
        public void EquityMultiplier_DivideByZero_Test(double totalAssets, double stockholderEquity)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.Stocks.EquityMultiplier(totalAssets, stockholderEquity);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
