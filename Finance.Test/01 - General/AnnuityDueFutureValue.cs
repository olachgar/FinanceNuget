using System;
using Xunit;

namespace Finance.Tests.General
{
    public class AnnuityDueFutureValue
    {
        [Theory]
        [InlineData(1000, 3, 5, 5468.40988)]
        [InlineData(1000, 1, 1, 1010.00)]
        [InlineData(1000, 3, 1, 1030.00)]
        public void AnnuityDueFutureValue_Test(double periodicPayment, double ratePerPeriod, double numberOfPeriods, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.General.AnnuityDueFutureValue(periodicPayment, ratePerPeriod, numberOfPeriods);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(1000, 0, 1)]
        public void AnnuityDueFutureValue_DivideByZero_Test(double periodicPayment, double ratePerPeriod, double numberOfPeriods)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.General.AnnuityDueFutureValue(periodicPayment, ratePerPeriod, numberOfPeriods);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
