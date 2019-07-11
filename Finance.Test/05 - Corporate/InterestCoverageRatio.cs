using System;
using Xunit;

namespace Finance.Tests.Corporate
{
    public class InterestCoverageRatio
    {   
        [Fact]
        public void interestCoverageRatio_5_2_Test()
        {
            // Arrange 
            double EBIT = 5;
            double interestExpense = 2;

            // Act
            var actualResult = Finance.Corporate.InterestCoverageRatio(EBIT, interestExpense);
            var expectedResult = 2.5;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void interestCoverageRatio_100_0_Test()
        {
            // Arrange 
            double EBIT = 100;
            double interestExpense = 0;

            // Act
            Action actualResult = () => Finance.Corporate.InterestCoverageRatio(EBIT, interestExpense);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }


        [Fact]
        public void interestCoverageRatio_2500000_3000000_Test()
        {
            // Arrange 
            double EBIT = 2500000;
            double interestExpense = 3000000;

            // Act
            var actualResult = Finance.Corporate.InterestCoverageRatio(EBIT, interestExpense);
            var expectedResult = 0.83333333333333337;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
