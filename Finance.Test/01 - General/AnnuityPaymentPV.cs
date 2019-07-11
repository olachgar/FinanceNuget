using System;
using Xunit;

namespace Finance.Tests.General
{
    public class AnnuityPaymentPV
    {
        [Theory]
        [InlineData(0, 0, 0, 0)]
        public void AnnuityPaymentPV_Test(double presentValue, double ratePerPeriods, double numberOfPeriods, double  expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.General.AnnuityPaymentPV(presentValue, ratePerPeriods, numberOfPeriods);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }
    }
}
