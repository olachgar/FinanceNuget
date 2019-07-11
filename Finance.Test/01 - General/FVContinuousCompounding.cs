using System;
using Xunit;

namespace Finance.Tests.General
{
    public class FVContinuousCompounding
    {
        [Theory]
        [InlineData(0, 0, 0, 0)]
        public void FVContinuousCompounding_Test(double presentValue, double rate, double time, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.General.FVContinuousCompounding(presentValue, rate, time);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }
    }
}
