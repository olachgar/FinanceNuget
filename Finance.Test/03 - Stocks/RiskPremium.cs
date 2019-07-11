using System;
using Xunit;

namespace Finance.Tests.Stocks
{
    public class RiskPremium
    {
        [Theory]
        [InlineData(500, 1, 499)]
        [InlineData(500, 500, 0)]
        [InlineData(500, 600, -100)]
        [InlineData(500, 200, 300)]
        [InlineData(1, 60, -59)]
        public void RiskPremium_assetReturn_riskFreeReturn_Test(double assetReturn, double riskFreeReturn, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.Stocks.RiskPremium(assetReturn, riskFreeReturn);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(5, 10, 7, -15)]
        [InlineData(15, 10, 7, -45)]
        [InlineData(15, 3, 7, 60)]
        [InlineData(7, 3, 7, 28)]
        [InlineData(7, 3, 17, 98)]
        public void RiskPremium_beta_riskFreeReturn_marketReturn_Test(double beta, double riskFreeReturn, double marketReturn, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.Stocks.RiskPremium(beta, riskFreeReturn, marketReturn);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }
    }
}
