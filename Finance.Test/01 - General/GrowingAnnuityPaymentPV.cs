using System;
using Xunit;

namespace Finance.Tests.General
{
    public class GrowingAnnuityPaymentPV
    {
        [Theory]
        [InlineData(1000, 2, 5, 10, 89.21643)]
        [InlineData(2000, 4, 5, 10, 199.15787)]
        [InlineData(1000000, 4, 5, 10, 99578.9358)]
        [InlineData(500000, 5, 1, 60, 22154.71948)]
        public void GrowingAnnuityPaymentFV_Test(double presentValue, double ratePerPeriod, double growthRate, double numberOfPeriods, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.General.GrowingAnnuityPaymentPV(presentValue, ratePerPeriod, growthRate, numberOfPeriods);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(0, 2, 2, 0)]
        public void GrowingAnnuityPaymentPV_DivideByZero_Test(double presentValue, double ratePerPeriod, double growthRate, double numberOfPeriods)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.General.GrowingAnnuityPaymentPV(presentValue, ratePerPeriod, growthRate, numberOfPeriods);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
