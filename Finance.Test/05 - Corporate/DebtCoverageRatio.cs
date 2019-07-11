using System;
using Xunit;

namespace Finance.Tests.Corporate
{
    public class DebtCoverageRatio
    {   
        [Fact]
        public void DebtCoverageRatio_200000_35000_Test()
        {
            // Arrange
            double netOperatingIncome = 200000;
            double debtService = 35000;

            // Act
            var actualResult = Finance.Corporate.DebtCoverageRatio(netOperatingIncome, debtService);
            var expectedResult = 5.7142857142857144;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void DebtCoverageRatio_100_0_Test()
        {
            // Arrange 
            double netOperatingIncome = 100;
            double debtService = 0;

            // Act
            Action actualResult = () => Finance.Corporate.DebtCoverageRatio(netOperatingIncome, debtService);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }


        [Fact]
        public void DebtCoverageRatio_10_2_Test()
        {
            // Arrange 
            double netOperatingIncome = 10;
            double debtService = 2;

            // Act
            var actualResult = Finance.Corporate.DebtCoverageRatio(netOperatingIncome, debtService);
            var expectedResult = 5;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
