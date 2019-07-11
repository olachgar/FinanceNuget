using System;
using Xunit;

namespace Finance.Tests.General
{
    public class AnnuityPVSolve
    {
        [Theory]
        [InlineData(100, 2, 10, 11.26838)]
        [InlineData(100, 12, 20, 8.08525)]
        [InlineData(100, 6, 20, 6.12119)]
        [InlineData(100, 6, 15, 8.76669)]
        public void AnnuityPVSolve_Test(double presentValueOfAnnuity, double ratePerPeriod, double periodicPayment, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.General.AnnuityPVSolve(presentValueOfAnnuity, ratePerPeriod, periodicPayment);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(1000, 100, 0)]
        [InlineData(100, 0, 10)]
        [InlineData(100, 0, 0)]
        [InlineData(0, 0, 0)]
        public void AnnuityPVSolve_DivideByZero_Test(double presentValueOfAnnuity, double ratePerPeriod, double periodicPayment)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.General.AnnuityPVSolve(presentValueOfAnnuity, ratePerPeriod, periodicPayment);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
