using System;
using Xunit;

namespace Finance.Tests.General
{
    public class AvgCollectionPeriod
    {
        [Theory]
        [InlineData(10, 36.50)]
        [InlineData(100, 3.650)]
        [InlineData(1000, 0.365)]
        [InlineData(1, 365)]
        public void AvgCollectionPeriod_ByReceivablesTurnover_Test(double receivablesTurnover, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.General.AvgCollectionPeriod(receivablesTurnover);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }

        [Theory]
        [InlineData(0)]
        public void AvgCollectionPeriod_ByReceivablesTurnover_DivideByZero_Test(double receivablesTurnover)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.General.AvgCollectionPeriod(receivablesTurnover);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }


        [Theory]
        [InlineData(4, 1, 1460.00)]
        [InlineData(4, 4, 365)]
        [InlineData(10, 4, 912.50)]
        [InlineData(10, 1, 3650.00)]
        public void AvgCollectionPeriod_ByAvgAccountsReceivables_Test(double avgAccountsReceivables, double salesRevenue, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.General.AvgCollectionPeriod(avgAccountsReceivables, salesRevenue);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(0, 0)]
        [InlineData(10, 0)]
        [InlineData(-10, 0)]
        public void AvgCollectionPeriod_ByAvgAccountsReceivables_DivideByZero_Test(double avgAccountsReceivables, double salesRevenue)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.General.AvgCollectionPeriod(avgAccountsReceivables, salesRevenue);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
