using System;
using Xunit;

namespace Finance.Tests.General
{
    public class AnnuityPresentValue
    {
        [Theory]
        [InlineData(2000, 5, 60, 37858.57905)]
        [InlineData(2000, 15, 60, 13330.29197)]
        [InlineData(2000, 5, 180, 39993.86258)]
        [InlineData(1000000, 5, 180, 19996931.28778)]
        [InlineData(1000000, 20, 60, 4999911.26494)]
        public void AnnuityPresentValue_Test(double periodicPayment, double ratePerPeriod, double numberOfPeriods, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.General.AnnuityPresentValue(periodicPayment, ratePerPeriod, numberOfPeriods);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(999999, 0, 999999)]
        public void AnnuityPresentValue_DivideByZero_Test(double periodicPayment, double ratePerPeriod, double numberOfPeriods)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.General.AnnuityPresentValue(periodicPayment, ratePerPeriod, numberOfPeriods);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }

    }
}
