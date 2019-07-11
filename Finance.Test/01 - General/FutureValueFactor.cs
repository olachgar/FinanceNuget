using System;
using Xunit;

namespace Finance.Tests.General
{
    public class FutureValueFactor
    {
        [Theory]
        [InlineData(10, 15, 4.17725)]
        [InlineData(10, 10, 2.59374)]
        [InlineData(100, 25, 33554432)]
        public void FutureValueFactor_Test(double rateOfPeriod, double numberOfPeriods, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.General.FutureValueFactor(rateOfPeriod, numberOfPeriods);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }
    }
}
