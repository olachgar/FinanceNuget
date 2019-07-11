using System;
using Xunit;

namespace Finance.Tests.Stocks
{
    public class DividendsPerShare
    {
        [Theory]
        [InlineData(1, 2, 50)]
        [InlineData(10, 2, 500)]
        [InlineData(2000, 5, 40000)]
        [InlineData(9000, 5, 180000)]
        [InlineData(8000, 2, 400000)]
        public void DividendYield_Test(double dividends, double numberOfShares, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.Stocks.DividendYield(dividends, numberOfShares);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(500, 0)]
        [InlineData(0, 0)]
        public void DividendYield_DivideByZero_Test(double dividends, double numberOfShares)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.Stocks.DividendYield(dividends, numberOfShares);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
