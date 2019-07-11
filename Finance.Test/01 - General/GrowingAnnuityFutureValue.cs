using System;
using Xunit;

namespace Finance.Tests.General
{
    public class GrowingAnnuityFutureValue
    {
        [Theory]
        [InlineData(2000, 3, 5, 5, 11700.74882)]
        public void GrowingAnnuityFutureValue_Test(double firstPayment, double ratePerPeriod, double growthRate, double numberOfPeriods, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.General.GrowingAnnuityFutureValue(firstPayment, ratePerPeriod, growthRate, numberOfPeriods);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(0, 0, 0, 0)]
        public void AnnuityFutureValue_DivideByZero_Test(double firstPayment, double ratePerPeriod, double growthRate, double numberOfPeriods)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.General.GrowingAnnuityFutureValue(firstPayment, ratePerPeriod, growthRate, numberOfPeriods);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
