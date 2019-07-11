using System;
using Xunit;

namespace Finance.Tests.General
{
    public class AnnuityFVSolve
    {
        [Theory]
        [InlineData(1000, 5, 100, 8.31039)]
        [InlineData(1000, 5, 10, 36.72378)]
        [InlineData(10000, 10, 500, 11.5267)]
        [InlineData(1000000, 15, 1000, 35.89876)]
        public void AnnuityFVSolve_Test(double futureValueOfAnnuity, double ratePerPeriod, double periodicPayment, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.General.AnnuityFVSolve(futureValueOfAnnuity, ratePerPeriod, periodicPayment);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(1000, 5, 0)]
        public void AnnuityFVSolve_DivideByZero_Test(double futureValueOfAnnuity, double ratePerPeriod, double periodicPayment)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.General.AnnuityFVSolve(futureValueOfAnnuity, ratePerPeriod, periodicPayment);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
