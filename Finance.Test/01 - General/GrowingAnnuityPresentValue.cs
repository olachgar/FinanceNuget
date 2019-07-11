using System;
using Xunit;

namespace Finance.Tests.General
{
    public class GrowingAnnuityPresentValue
    {
        [Theory]
        [InlineData(100, 5, 4, 60, 4368.26237)]
        public void GrowingAnnuityPresentValue_Test(double firstPayment, double ratePerPeriod, double growthRate, double numberOfPeriods, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.General.GrowingAnnuityPresentValue(firstPayment, ratePerPeriod, growthRate, numberOfPeriods);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(0, -100, 2, 0)]
        [InlineData(0, 2, 2, 0)]
        public void GrowingAnnuityPresentValue_DivideByZero_Test(double firstPayment, double ratePerPeriod, double growthRate, double numberOfPeriods)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.General.GrowingAnnuityPresentValue(firstPayment, ratePerPeriod, growthRate, numberOfPeriods);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
