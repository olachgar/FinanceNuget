using System;
using Xunit;

namespace Finance.Tests.General
{
    public class PVContinuousCompounding
    {
        [Theory]
        [InlineData(0, 0, 0, 0)]
        public void PVContinuousCompounding_Test(double cashFlow, double rate, double time, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.General.PVContinuousCompounding(cashFlow, rate, time);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }
    }
}
