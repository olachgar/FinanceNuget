using System;
using Xunit;

namespace Finance.Tests.Stocks
{
    public class CapitalAssetPricingModel
    {
        [Theory]
        [InlineData(1000, 5, 10, -3950)]
        [InlineData(1000, 10, 10, -8900)]
        [InlineData(100000, 5, 100, -399500)]
        [InlineData(100000, 15, 10, -1399850)]
        [InlineData(100000, 1, 10, 10)]
        public void CapitalAssetPricingModel_Test(double riskFreeRate, double beta, double marketReturn, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.Stocks.CapitalAssetPricingModel(riskFreeRate, beta, marketReturn);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }
    }
}
