using System;
using Xunit;

namespace Finance.Tests.Stocks
{
    public class PreferredStock
    {
        [Theory]
        [InlineData(500, 6, 83.33333)]
        [InlineData(1000, 6, 166.66667)]
        [InlineData(1000, 5, 200)]
        [InlineData(5000, 5, 1000)]
        [InlineData(1000000, 3325, 300.75188)]
        public void PreferredStock_Test(double dividends, double discountRate, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.Stocks.PreferredStock(dividends, discountRate);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(0, 0)]
        [InlineData(500, 0)]
        public void PreferredStock_DivideByZero_Test(double dividends, double discountRate)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.Stocks.PreferredStock(dividends, discountRate);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
