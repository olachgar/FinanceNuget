using System;
using Xunit;

namespace Finance.Tests.Corporate
{
    public class NetPresentValue
    {   
        [Fact]
        public void debtRatio_5_2_Test()
        {
            // Arrange 
            double totalLiabilities = 5;
            double totalAssets = 2;

            // Act
            var actualResult = Finance.Corporate.DebtRatio(totalLiabilities, totalAssets);
            var expectedResult = 2.5;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void debtRatio_100_0_Test()
        {
            // Arrange 
            double totalLiabilities = 100;
            double totalAssets = 0;

            // Act
            Action actualResult = () => Finance.Corporate.DebtRatio(totalLiabilities, totalAssets);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }


        [Fact]
        public void debtRatio_2500000_3000000_Test()
        {
            // Arrange 
            double totalLiabilities = 2500000;
            double totalAssets = 3000000;

            // Act
            var actualResult = Finance.Corporate.DebtRatio(totalLiabilities, totalAssets);
            var expectedResult = 0.83333333333333337;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
