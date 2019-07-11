using System;
using Xunit;

namespace Finance.Tests.General
{
    public class FutureValue
    {
        [Theory]
        [InlineData(0, 0, 0, 0)]
        public void FutureValue_Test(double cashFlowAtPeriod0, double rateOfReturn, double numberOfPeriods, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.General.FutureValue(cashFlowAtPeriod0, rateOfReturn, numberOfPeriods);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }

    }
}
