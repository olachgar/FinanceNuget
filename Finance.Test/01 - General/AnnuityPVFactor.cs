using System;
using Xunit;

namespace Finance.Tests.General
{
    public class AnnuityPVFactor
    {
        [Theory]
        [InlineData(10.0, 60.0, 0)]
        //[InlineData(100, 60, 100000)]
        //[InlineData(10000, 180, 100)]
        //[InlineData(1000, 30, 10)]
        //[InlineData(5, 5, 0.23097)]
        public void AnnuityPVFactor_Test(double ratePerPeriod, double numberOfPeriods, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.General.AnnuityPVFactor(ratePerPeriod, numberOfPeriods);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(0, 1000)]
        public void AnnuityPVFactor_DivideByZero_Test(double ratePerPeriod, double numberOfPeriods)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.General.AnnuityPVFactor(ratePerPeriod, numberOfPeriods);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
