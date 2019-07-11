using System;
using Xunit;

namespace Finance.Tests.Banking
{
    public class AnnualPercentageYield
    {
        [Fact]
        public void AnnualPercentageYield_6persent_12_Test()
        {
            // Arrange
            double statedAnnualInterestRate = 6;
            double numberOfTimesCompounded = 12;

            // Act
            var actualResult = Finance.Banking.AnnualPercentageYield(statedAnnualInterestRate, numberOfTimesCompounded);
            var expectedResult = 6.16778;

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Fact]
        public void AnnualPercentageYield_0_12_Test()
        {
            // Arrange
            double statedAnnualInterestRate = 0;
            double numberOfTimesCompounded = 0;

            // Act
            Action actualResult = () => Finance.Banking.AnnualPercentageYield(statedAnnualInterestRate, numberOfTimesCompounded);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }


        [Fact]
        public void AnnualPercentageYield_2_6_Test()
        {
            // Arrange
            double statedAnnualInterestRate = 2;
            double numberOfTimesCompounded = 6;

            // Act
            var actualResult = Finance.Banking.AnnualPercentageYield(statedAnnualInterestRate, numberOfTimesCompounded);
            var expectedResult = 2.01674;

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }
    }
}
