using System;
using Xunit;

namespace Finance.Tests.Corporate
{
    public class CurrentRatio
    {   
        [Fact]
        public void CurrentRatio_5_2_Test()
        {
            // Arrange 
            double currentAssets = 5;
            double currentLiabilities = 2;

            // Act
            var actualResult = Finance.Corporate.CurrentRatio(currentAssets, currentLiabilities);
            var expectedResult = 2.5;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void CurrentRatio_100_0_Test()
        {
            // Arrange 
            double currentAssets = 100;
            double currentLiabilities = 0;

            // Act
            Action actualResult = () => Finance.Corporate.CurrentRatio(currentAssets, currentLiabilities);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }


        [Fact]
        public void CurrentRatio_10_2_Test()
        {
            // Arrange 
            double currentAssets = 10;
            double currentLiabilities = 2;

            // Act
            var actualResult = Finance.Corporate.CurrentRatio(currentAssets, currentLiabilities);
            var expectedResult = 5;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
