using System;
using Xunit;

namespace Finance.Tests.Corporate
{
    public class NetWorkingCapital
    {   
        [Fact]
        public void NetWorkingCapital_10_30_Test()
        {
            // Arrange 
            double currentAssets = 10;
            double currentLiabilites = 30;

            // Act
            var actualResult = Finance.Corporate.NetWorkingCapital(currentAssets, currentLiabilites);
            var expectedResult = -20;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void NetWorkingCapital_100_30_Test()
        {
            // Arrange 
            double currentAssets = 100;
            double currentLiabilites = 30;

            // Act
            var actualResult = Finance.Corporate.NetWorkingCapital(currentAssets, currentLiabilites);
            var expectedResult = 70;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
