using System;
using Xunit;

namespace Finance.Tests.General
{
    public class AnnuityFutureContinuousCompounding
    {
        [Theory]
        [InlineData(1000, 5, 60, 372247.48976)]
        [InlineData(10000, 5, 60, 3722474.89759)]
        [InlineData(10000, 1, 60, 818015.05737)]
        [InlineData(10000, 10, 180, 6243167725330.91)]
        public void AnnuityFutureContinuousCompounding_Test(double periodicCashFlow, double ratePerPeriod, double time, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.General.AnnuityFutureValueContinuousCompounding(periodicCashFlow, ratePerPeriod, time);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(1000, 0, 60)]
        public void AnnuityFutureValueContinuousCompounding_DivideByZero_Test(double periodicCashFlow, double ratePerPeriod, double time)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.General.AnnuityFutureValueContinuousCompounding(periodicCashFlow, ratePerPeriod, time);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
