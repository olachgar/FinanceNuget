using System;
using Xunit;

namespace Finance.Tests.General
{
    public class PresentValueFactor
    {
        [Theory]
        [InlineData(0, 0, 0, 0)]
        public void PresentValueFactor_1_Test(double futureValue, double rateOfReturn, double numberOfPeriods, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.General.PresentValueFactor(futureValue, rateOfReturn, numberOfPeriods);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }
    }
}
