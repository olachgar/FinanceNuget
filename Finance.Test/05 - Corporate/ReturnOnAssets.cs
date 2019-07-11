using System;
using Xunit;

namespace Finance.Tests.Corporate
{
    public class ReturnOnAssets
    {   
        [Fact]
        public void debtRatio_5_2_Test()
        {
            // Arrange 
            double netIncome = 5;
            double avgTotalAssets = 2;

            // Act
            var actualResult = Finance.Corporate.DebtRatio(netIncome, avgTotalAssets);
            var expectedResult = 2.5;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void debtRatio_100_0_Test()
        {
            // Arrange 
            double netIncome = 100;
            double avgTotalAssets = 0;

            // Act
            Action actualResult = () => Finance.Corporate.DebtRatio(netIncome, avgTotalAssets);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }


        [Fact]
        public void debtRatio_25_30_Test()
        {
            // Arrange 
            double netIncome = 25;
            double avgTotalAssets = 30;

            // Act
            var actualResult = Finance.Corporate.DebtRatio(netIncome, avgTotalAssets);
            var expectedResult = 0.83333333333333337;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
