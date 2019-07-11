using System;
using Xunit;

namespace Finance.Tests.Banking
{
    public class EfficiencyRatio
    {
        [Theory]
        [InlineData(0, 2, 0)]
        [InlineData(500, 500, 100)]
        [InlineData(10, 100, 10)]
        [InlineData(6, 10, 60)]
        [InlineData(5000000, 10000000, 50)]
        public void EfficiencyRatio_Test(double expenses, double revenue, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.Banking.EfficiencyRatio(expenses, revenue);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(500, 0)]
        [InlineData(0, 0)]
        public void EfficiencyRatio_DivideByZero_Test(double expenses, double revenue)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.Banking.EfficiencyRatio(expenses, revenue);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
