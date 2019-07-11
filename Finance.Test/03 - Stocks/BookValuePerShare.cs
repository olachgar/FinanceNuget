using System;
using Xunit;

namespace Finance.Tests.Stocks
{
    public class BookValuePerShare
    {
        [Theory]
        [InlineData(100, 10, 10)]
        [InlineData(1000, 10, 100)]
        [InlineData(1000, 60, 16.66667)]
        [InlineData(1000, 180, 5.55556)]
        [InlineData(1000, 5, 200)]
        [InlineData(200, 5, 40)]
        public void BookValuePerShare_Test(double totalStockholderEquity, double numberOfShares, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.Stocks.BookValuePerShare(totalStockholderEquity, numberOfShares);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(500, 0)]
        [InlineData(0, 0)]
        public void BookValuePerShare_DivideByZero_Test(double totalStockholderEquity, double numberOfShares)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.Stocks.BookValuePerShare(totalStockholderEquity, numberOfShares);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
