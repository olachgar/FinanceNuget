using System;
using Xunit;

namespace Finance.Tests.Banking
{
    public class ContinuousCompounding
    {
        [Fact]
        public void ContinuousCompounding_1000_10_2_Test()
        {
            // Arrange
            double originalBalance = 1000;
            double ratePerPeriod = 10;
            double numberOfPeriods = 2;

            // Act
            var actualResult = Finance.Banking.ContinuousCompounding(originalBalance, ratePerPeriod, numberOfPeriods);
            var expectedResult = 1221.4027582;

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Fact]
        public void ContinuousCompounding_1000_05_24_Test()
        {
            // Arrange
            double originalBalance = 1000;
            double ratePerPeriod = 0.5;
            double numberOfPeriods = 24;

            // Act
            var actualResult = Finance.Banking.ContinuousCompounding(originalBalance, ratePerPeriod, numberOfPeriods);
            var expectedResult = 1127.49685;

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }
    }
}
