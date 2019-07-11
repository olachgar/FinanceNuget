using System;
using Xunit;

namespace Finance.Tests.Stocks
{
    public class BidAskSpread
    {
        [Theory]
        [InlineData(500, 1, 499)]
        [InlineData(500, 500, 0)]
        [InlineData(500, 600, -100)]
        [InlineData(500, 200, 300)]
        [InlineData(1, 60, -59)]
        public void BidAskSpread_Test(double askPrice, double bidPrice, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.Stocks.BidAskSpread(askPrice, bidPrice);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }
    }
}
