using System;
using Xunit;

namespace Finance.Tests.Corporate
{
    public class PaybackPeriod
    {   
        [Fact]
        public void PaybackPeriod_5_2_Test()
        {
            // Arrange 
            double initialInvestment = 5;
            double periodicCashFlow = 2;

            // Act
            var actualResult = Finance.Corporate.PaybackPeriod(initialInvestment, periodicCashFlow);
            var expectedResult = 2.5;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void PaybackPeriod_100_0_Test()
        {
            // Arrange 
            double initialInvestment = 100;
            double periodicCashFlow = 0;

            // Act
            Action actualResult = () => Finance.Corporate.PaybackPeriod(initialInvestment, periodicCashFlow);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }


        [Fact]
        public void PaybackPeriod_10000_1000_Test()
        {
            // Arrange 
            double initialInvestment = 10000;
            double periodicCashFlow = 1000;

            // Act
            var actualResult = Finance.Corporate.PaybackPeriod(initialInvestment, periodicCashFlow);
            var expectedResult = 10;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
