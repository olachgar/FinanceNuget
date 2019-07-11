using System;
using Xunit;

namespace Finance.Tests.General
{
    public class AnnuityDuePresentValue
    {
        [Theory]
        [InlineData(1000, 5, 60, 19875.754)]
        [InlineData(10000.00, 5, 180, 209967.77852)]
        [InlineData(100000.00, 15, 180, 766666.66666)]
        public void AnnuityDuePresentValue_Test(double periodicPayment, double ratePerPeriod, double numberOfPeriods, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.General.AnnuityDuePresentValue(periodicPayment, ratePerPeriod, numberOfPeriods);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(1000, 0, 60)]
        public void AnnuityDuePresentValue_DivideByZero_Test(double periodicPayment, double ratePerPeriod, double numberOfPeriods)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.General.AnnuityDuePresentValue(periodicPayment, ratePerPeriod, numberOfPeriods);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
