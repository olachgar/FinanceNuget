using System;
using Xunit;

namespace Finance.Tests.Corporate
{
    public class ReturnOnInvestment
    {   
        [Fact]
        public void ReturnOnInvestment_5_2_Test()
        {
            // Arrange 
            double earnings = 5;
            double initialInvestment = 2;

            // Act
            var actualResult = Finance.Corporate.ReturnOnInvestment(earnings, initialInvestment);
            var expectedResult = 1.5;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void ReturnOnInvestment_100_0_Test()
        {
            // Arrange 
            double earnings = 100;
            double initialInvestment = 0;

            // Act
            Action actualResult = () => Finance.Corporate.ReturnOnInvestment(earnings, initialInvestment);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }


        [Fact]
        public void ReturnOnInvestment_25_40_Test()
        {
            // Arrange 
            double earnings = 25;
            double initialInvestment = 40;

            // Act
            var actualResult = Finance.Corporate.ReturnOnInvestment(earnings, initialInvestment);
            var expectedResult = -0.375;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
