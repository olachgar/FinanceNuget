using System;
using Xunit;

namespace Finance.Tests.Stocks
{
    public class NetAssetValue
    {
        [Theory]
        [InlineData(500, 50, 10, 45)]
        [InlineData(5000, 50, 10, 495)]
        [InlineData(5000, 5, 10, 499.50)]
        [InlineData(5000, 10, 20, 249.50)]
        [InlineData(1000000, 10, 50, 19999.80)]
        public void NetAssetValue_Test(double fundAssets, double fundLiabilities, double outstandingShares, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.Stocks.NetAssetValue(fundAssets, fundLiabilities, outstandingShares);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(500, 0, 0)]
        [InlineData(500, 50, 0)]
        public void NetAssetValue_DivideByZero_Test(double fundAssets, double fundLiabilities, double outstandingShares)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.Stocks.NetAssetValue(fundAssets, fundLiabilities, outstandingShares);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
