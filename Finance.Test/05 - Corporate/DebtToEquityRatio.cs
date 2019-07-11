using System;
using Xunit;

namespace Finance.Tests.Corporate
{
    public class DebtToEquityRatio
    {   
        [Fact]
        public void DebtToEquityRatio_5_2_Test()
        {
            // Arrange 
            double totalLiabilities = 5;
            double totalEquity = 2;

            // Act
            var actualResult = Finance.Corporate.DebtToEquityRatio(totalLiabilities, totalEquity);
            var expectedResult = 2.5;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void DebtToEquityRatio_100_0_Test()
        {
            // Arrange 
            double totalLiabilities = 100;
            double totalEquity = 0;

            // Act
            Action actualResult = () => Finance.Corporate.DebtToEquityRatio(totalLiabilities, totalEquity);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }


        [Fact]
        public void DebtToEquityRatio_2500000_3000000_Test()
        {
            // Arrange 
            double totalLiabilities = 2500000;
            double totalEquity = 3000000;

            // Act
            var actualResult = Finance.Corporate.DebtToEquityRatio(totalLiabilities, totalEquity);
            var expectedResult = 0.83333333333333337;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
