using System;
using Xunit;

namespace Finance.Tests.Corporate
{
    public class AssetToSalesRatio
    {
        [Fact]
        public void AssetToSalesRatio_100_50_Test()
        {
            // Arrange
            double totalAssets = 100;
            double salesRevenues = 50;

            // Act
            var actualResult = Finance.Corporate.AssetToSalesRatio(totalAssets, salesRevenues);
            var expectedResult = 2;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void AssetToSalesRatio_100_0_Test()
        {
            // Arrange
            double totalAssets = 100;
            double salesRevenues = 0;

            // Act
            Action actualResult = () => Finance.Corporate.AssetToSalesRatio(totalAssets, salesRevenues);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }


        [Fact]
        public void AssetToSalesRatio_100_200_Test()
        {
            // Arrange
            double totalAssets = 100;
            double salesRevenues = 200;

            // Act
            var actualResult = Finance.Corporate.AssetToSalesRatio(totalAssets, salesRevenues);
            var expectedResult = 0.50;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
