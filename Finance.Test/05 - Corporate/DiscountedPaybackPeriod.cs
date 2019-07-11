using System;
using Xunit;

namespace Finance.Tests.Corporate
{
    public class DiscountedPaybackPeriod
    {   
        [Fact]
        public void DiscountedPaybackPeriod_5_2_Test()
        {
            // Arrange 
            double initialInvestment = 5000;
            double periodicCashFlow = 1000;
            double rate = 0.10;

            // Act
            var actualResult = Finance.Corporate.DiscountedPaybackPeriod(initialInvestment, periodicCashFlow, rate);
            var expectedResult = 7.2725408973417132;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }



        [Fact]
        public void DiscountedPaybackPeriod_5000_1000_Test()
        {
            // Arrange 
            double initialInvestment = 5000;
            double periodicCashFlow = 1000;
            double rate = 0;

            // Act
            Action actualResult = () => Finance.Corporate.DiscountedPaybackPeriod(initialInvestment, periodicCashFlow, rate);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
