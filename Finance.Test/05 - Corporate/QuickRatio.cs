using System;
using Xunit;

namespace Finance.Tests.Corporate
{
    public class QuickRatio
    {   
        [Fact]
        public void QuickRatio_5_2_Test()
        {
            // Arrange 
            double currentAssets = 7;
            double inventory = 2;
            double currentLiabilites = 2;

            // Act
            var actualResult = Finance.Corporate.QuickRatio(currentAssets, inventory, currentLiabilites);
            var expectedResult = 2.5;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void QuickRatio_100_0_Test()
        {
            // Arrange 
            double currentAssets = 100;
            double inventory = 0;
            double currentLiabilites = 0;

            // Act
            Action actualResult = () => Finance.Corporate.QuickRatio(currentAssets, inventory, currentLiabilites);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }


        [Fact]
        public void QuickRatio_2500000_3000000_Test()
        {
            // Arrange 
            double currentAssets = 55;
            double inventory = 30;
            double currentLiabilites = 30;

            // Act
            var actualResult = Finance.Corporate.QuickRatio(currentAssets, inventory, currentLiabilites);
            var expectedResult = 0.83333333333333337;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void QuickRatio_bis_5_2_Test()
        {
            // Arrange 
            double quickAssets = 5;
            double currentLiabilites = 2;

            // Act
            var actualResult = Finance.Corporate.QuickRatio(quickAssets, currentLiabilites);
            var expectedResult = 2.5;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void QuickRatio_bis_100_0_Test()
        {
            // Arrange 
            double quickAssets = 100;
            double currentLiabilites = 0;

            // Act
            Action actualResult = () => Finance.Corporate.QuickRatio(quickAssets, currentLiabilites);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }


        [Fact]
        public void QuickRatio_bis_2500000_3000000_Test()
        {
            // Arrange 
            double quickAssets = 2500000;
            double currentLiabilites = 3000000;

            // Act
            var actualResult = Finance.Corporate.QuickRatio(quickAssets, currentLiabilites);
            var expectedResult = 0.83333333333333337;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
