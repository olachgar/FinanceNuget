using System;
using Xunit;

namespace Finance.Tests.Corporate
{
    public class EquivalentAnnualAnnuity
    {   
        [Fact]
        public void EquivalentAnnualAnnuity_5_2_Test()
        {
            // Arrange 
            double netPresentValue = 100000;
            double ratePerPeriod = 0.08;
            double numberOfPeriods = 15;

            // Act
            var actualResult = Finance.Corporate.EquivalentAnnualAnnuity(netPresentValue, ratePerPeriod, numberOfPeriods);
            var expectedResult = 11682.954493602;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void EquivalentAnnualAnnuity_100_0_Test()
        {
            //TODO

            // Arrange 
            double netPresentValue = 0;
            double ratePerPeriod = 0;
            double numberOfPeriods = 0;
            // Act
            Action actualResult = () => Finance.Corporate.EquivalentAnnualAnnuity(netPresentValue, ratePerPeriod, numberOfPeriods);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }


        [Fact]
        public void EquivalentAnnualAnnuity_2500000_3000000_Test()
        {
            // Arrange 
            double netPresentValue = 150000;
            double ratePerPeriod = 0.08;
            double numberOfPeriods = 15;

            // Act
            var actualResult = Finance.Corporate.EquivalentAnnualAnnuity(netPresentValue, ratePerPeriod, numberOfPeriods);
            var expectedResult = 17524.431740402997;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
