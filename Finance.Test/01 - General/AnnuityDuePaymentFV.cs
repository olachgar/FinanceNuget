using System;
using Xunit;

namespace Finance.Tests.General
{
    public class AnnuityDuePaymentFV
    {
        [Theory]
        [InlineData(5000.0, 3, 5, 914.34258)]
        [InlineData(1000.0, 10, 3, 274.64982)]
        [InlineData(10000.0, 10, 4, 1958.82549)]
        [InlineData(1000000.00, 10, 25, 9243.70199)]
        public void AnnuityDuePaymentFV_Test(double futureValue, double ratePerPeriod, double numberOfPeriods, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.General.AnnuityDuePaymentFV(futureValue, ratePerPeriod, numberOfPeriods);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }
       
    }
}
