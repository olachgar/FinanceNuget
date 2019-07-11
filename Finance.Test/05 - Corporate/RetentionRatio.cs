using System;
using Xunit;

namespace Finance.Tests.Corporate
{
    public class RetentionRatio
    {   
        [Fact]
        public void RetentionRatio_5_2_Test()
        {
            // Arrange 
            double netIncome = 5;
            double dividends = 2;

            // Act
            var actualResult = Finance.Corporate.RetentionRatio(netIncome, dividends);
            var expectedResult = 0.60;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void RetentionRatio_0_100_Test()
        {
            // Arrange 
            double netIncome = 0;
            double dividends = 100;

            // Act
            Action actualResult = () => Finance.Corporate.RetentionRatio(netIncome, dividends);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }


        [Fact]
        public void RetentionRatio_25_30_Test()
        {
            // Arrange 
            double netIncome = 25;
            double dividends = 30;

            // Act
            var actualResult = Finance.Corporate.RetentionRatio(netIncome, dividends);
            var expectedResult = -0.2;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
