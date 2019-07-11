using System;
using Xunit;

namespace Finance.Tests.Stocks
{
    public class HoldingPeriodReturn
    {
        [Theory]
        [InlineData(500)]
        public void HoldingPeriodReturn_Test(double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.Stocks.HoldingPeriodReturn();

            // Assert
            //Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }
    }
}
