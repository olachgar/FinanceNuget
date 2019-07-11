using System;
using Xunit;

namespace Finance.Tests.Corporate
{
    public class AssetTurnoverRatio
    {
        [Fact]
        public void AssetTurnoverRatio_100_50_Test()
        {
            // Arrange
            double totalAssets = 100;
            double salesRevenues = 50;

            // Act
            var actualResult = Finance.Corporate.AssetTurnoverRatio(totalAssets, salesRevenues);
            var expectedResult = 0.50;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void AssetTurnoverRatio_0_100_Test()
        {
            // Arrange
            double totalAssets = 0;
            double salesRevenues = 100;

            // Act
            Action actualResult = () => Finance.Corporate.AssetTurnoverRatio(totalAssets, salesRevenues);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }


        [Fact]
        public void AssetTurnoverRatio_100_200_Test()
        {
            // Arrange
            double totalAssets = 100;
            double salesRevenues = 200;

            // Act
            var actualResult = Finance.Corporate.AssetTurnoverRatio(totalAssets, salesRevenues);
            var expectedResult = 2;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
