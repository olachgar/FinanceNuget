using System;
using Xunit;

namespace Finance.Tests.Corporate
{
    public class AnnualPercentageYield
    {
        [Fact]
        public void DaysInInventory_432_365orYear_Test()
        {
            // Arrange
            double inventoryTurnover = 4.32;

            // Act
            var actualResult = Finance.Corporate.DaysInInventory(inventoryTurnover);
            var expectedResult = 84.490740740740733;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void DaysInInventory_0_365orYear_Test()
        {
            // Arrange
            double inventoryTurnover = 0;

            // Act
            Action actualResult = () => Finance.Corporate.DaysInInventory(inventoryTurnover);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }


        [Fact]
        public void DaysInInventory_231_180_Test()
        {
            // Arrange
            double inventoryTurnover = 2.31;
            int timePeriod = 180;

            // Act
            var actualResult = Finance.Corporate.DaysInInventory(inventoryTurnover, timePeriod);
            var expectedResult = 77.922077922077918;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
