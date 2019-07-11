using System;
using Xunit;

namespace Finance.Tests.Stocks
{
    public class TotalStockReturn
    {
        [Theory]
        [InlineData(5, 10, 100, 2100)]
        [InlineData(15, 10, 100, 633.33333)]
        [InlineData(5, 7, 100, 2040)]
        [InlineData(5, 10, 10, 300)]
        [InlineData(5, 10, 3, 160)]
        public void TotalStockReturn_price_Test(double initialSharePrice, double endingSharePrice, double dividends, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.Stocks.TotalStockReturn(initialSharePrice, endingSharePrice, dividends);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 0, 10)]
        [InlineData(0, 6, 0)]
        [InlineData(0, 6, 10)]
        public void TotalStockReturn_price_DivideByZero_Test(double initialSharePrice, double endingSharePrice, double dividends)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.Stocks.TotalStockReturn(initialSharePrice, endingSharePrice, dividends);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }



        [Theory]
        [InlineData(500, 1, 499)]
        [InlineData(500, 500, 0)]
        [InlineData(500, 600, -100)]
        [InlineData(500, 200, 300)]
        [InlineData(1, 60, -59)]
        public void TotalStockReturn_dividendYield_capitalGainsYield_Test(double dividendYield, double capitalGainsYield, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.Stocks.TotalStockReturn(dividendYield, capitalGainsYield);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }
    }
}
