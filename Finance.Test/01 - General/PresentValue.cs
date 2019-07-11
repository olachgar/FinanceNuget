using System;
using Xunit;

namespace Finance.Tests.General
{
    public class PresentValue
    {
        [Fact]
        public void PresentValue_1_Test()
        {
            // Arrange
            double cashFlowAtPeriod1 = 150;
            double rateOfReturn = 5;
            int numberOfPeriods = 60;

            // Act
            var actualResult = Finance.General.PresentValue(cashFlowAtPeriod1, rateOfReturn, numberOfPeriods);
            var expectedResult = 8.03033;

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult,5));
        }


        [Fact]
        public void PresentValue_2_Test()
        {
            // Arrange
            double cashFlowAtPeriod1 = 0;
            double rateOfReturn = -100;
            int numberOfPeriods = 1;

            // Act
            Action act = () => Finance.General.PresentValue(cashFlowAtPeriod1, rateOfReturn, numberOfPeriods);

            // Assert
            Assert.Throws<DivideByZeroException>(act);
        }


        [Fact]
        public void PresentValue_4_Test()
        {
            // Arrange
            double cashFlowAtPeriod1 = 800.01;
            double rateOfReturn = 0.59;
            int numberOfPeriods = 52;

            // Act 
            var actualResult = Finance.General.PresentValue(cashFlowAtPeriod1, rateOfReturn, numberOfPeriods);
            var expectedResult = 589.17647;

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }
    }
}
