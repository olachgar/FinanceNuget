using System;
using Xunit;

namespace Finance.Tests.Stocks
{
    public class DividendPayoutRatio
    {
        [Theory]
        [InlineData(10, 10, 100)]
        [InlineData(500, 10, 5000)]
        [InlineData(1000, 20, 5000)]
        [InlineData(1000, 500, 200)]
        [InlineData(5000, 50, 10000)]
        public void DividendPayoutRatio_Test(double dividends, double netIncome, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.Stocks.DividendPayoutRatio(dividends, netIncome);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(500, 0)]
        [InlineData(0, 0)]
        public void DividendPayoutRatio_DivideByZero_Test(double dividends, double netIncome)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.Stocks.DividendPayoutRatio(dividends, netIncome);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
