using System;
using Xunit;

namespace Finance.Tests.General
{
    public class AnnuityDuePaymentPV
    {
        [Theory]
        [InlineData(5000, 2, 60, 141.01944)]
        [InlineData(10000, 2, 60, 282.03888)]
        [InlineData(100000.00, 5, 180, 4762.63552)]
        [InlineData(1000000.00, 5, 180, 47626.3552)]
        public void AnnuityDuePaymentPV_Test(double presentValue, double ratePerPeriod, double numberOfPeriods, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.General.AnnuityDuePaymentPV(presentValue, ratePerPeriod, numberOfPeriods);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(1000000.00, -100, 180)]
        public void AnnuityDuePaymentPV_DivideByZero_Test(double presentValue, double ratePerPeriod, double numberOfPeriods)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.General.AnnuityDuePaymentPV(presentValue, ratePerPeriod, numberOfPeriods);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
