using System;
using Xunit;

namespace Finance.Tests.General
{
    public class AnnuityPaymentFV
    {
        [Theory]
        [InlineData(0, 0, 0, 0)]
        public void AnnuityPaymentFV_Test(double futureValue, double ratePerPeriod, double numberOfPeriods, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.General.AnnuityPaymentFV(futureValue, ratePerPeriod, numberOfPeriods);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }
    }
}
