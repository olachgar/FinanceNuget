using System;
using Xunit;

namespace Finance.Tests.General
{
    public class AnnuityFutureValue
    {
        [Theory]
        [InlineData(1000, 5, 60, 353583.71788)]
        [InlineData(10000, 5, 60, 3535837.17882)]
        [InlineData(10000.00, 5, 180, 1303278368.19305)]
        [InlineData(1000, 5, 18, 28132.38467)]
        public void AnnuityFutureValue_Test(double periodicPayement, double ratePerPeriod, double numberOfPeriods, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.General.AnnuityFutureValue(periodicPayement, ratePerPeriod, numberOfPeriods);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(0, 0, 0)]
        public void AnnuityFutureValue_DivideByZero_Test(double periodicPayement, double ratePerPeriod, double numberOfPeriods)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.General.AnnuityFutureValue(periodicPayement, ratePerPeriod, numberOfPeriods);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
