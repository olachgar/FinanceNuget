using System;
using Xunit;

namespace Finance.Tests.General
{
    public class GrowingAnnuityPaymentFV
    {
        [Theory]
        [InlineData(1000, 5, 2, 60, 1.94829)]
        [InlineData(1200, 5, 2, 60, 2.33794)]
        [InlineData(10000.00, 12, 2, 60, 1.11817)]
        [InlineData(1000000, 2, 5, 180, 4.62815)]
        public void GrowingAnnuityPaymentFV_Test(double presentValue, double ratePerPeriod, double growthRate, double numberOfPeriods, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.General.GrowingAnnuityPaymentFV(presentValue, ratePerPeriod, growthRate, numberOfPeriods);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(0, 2, 2, 0)]
        public void GrowingAnnuityPaymentPV_DivideByZero_Test(double presentValue, double ratePerPeriod, double growthRate, double numberOfPeriods)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.General.GrowingAnnuityPaymentFV(presentValue, ratePerPeriod, growthRate, numberOfPeriods);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
