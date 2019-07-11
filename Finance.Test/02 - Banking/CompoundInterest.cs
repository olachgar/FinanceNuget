using System;
using Xunit;

namespace Finance.Tests.Banking
{
    public class CompoundInterest
    {
        [Fact]
        public void CompoundInterest_1000_1_12_Test()
        {
            // Arrange
            double originalBalance = 1000;
            double ratePerPeriod = 1;
            double numberOfPeriods = 12;

            // Act
            var actualResult = Finance.Banking.CompoundInterest(originalBalance, ratePerPeriod, numberOfPeriods);
            var expectedResult = 126.82503;

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Fact]
        public void CompoundInterest_1000_05_24_Test()
        {
            // Arrange
            double originalBalance = 1000;
            double ratePerPeriod = 0.5;
            double numberOfPeriods = 24;

            // Act
            var actualResult = Finance.Banking.CompoundInterest(originalBalance, ratePerPeriod, numberOfPeriods);
            var expectedResult = 127.15978;

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }
    }
}
