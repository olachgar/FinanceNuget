using System;
using Xunit;

namespace Finance.Tests.Corporate
{
    public class InventoryTurnoverRatio
    {   
        [Fact]
        public void InventoryTurnoverRatio_5_2_Test()
        {
            // Arrange 
            double sales = 5;
            double inventory = 2;

            // Act
            var actualResult = Finance.Corporate.InventoryTurnoverRatio(sales, inventory);
            var expectedResult = 2.5;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void InventoryTurnoverRatio_100_0_Test()
        {
            // Arrange 
            double sales = 100;
            double inventory = 0;

            // Act
            Action actualResult = () => Finance.Corporate.InventoryTurnoverRatio(sales, inventory);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }


        [Fact]
        public void InventoryTurnoverRatio_2500000_3000000_Test()
        {
            // Arrange 
            double sales = 2500000;
            double inventory = 3000000;

            // Act
            var actualResult = Finance.Corporate.InventoryTurnoverRatio(sales, inventory);
            var expectedResult = 0.83333333333333337;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
