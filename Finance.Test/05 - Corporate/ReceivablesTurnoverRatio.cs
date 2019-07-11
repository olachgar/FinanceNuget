using System;
using Xunit;

namespace Finance.Tests.Corporate
{
    public class ReceivablesTurnoverRatio
    {   
        [Fact]
        public void ReceivablesTurnoverRatio_5_2_Test()
        {
            // Arrange 
            double salesRevenue = 1000000;
            double avgAccountsReceivable = 85000;

            // Act
            var actualResult = Finance.Corporate.ReceivablesTurnoverRatio(salesRevenue, avgAccountsReceivable);
            var expectedResult = 11.764705882352942;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void ReceivablesTurnoverRatio_100_0_Test()
        {
            // Arrange 
            double salesRevenue = 100;
            double avgAccountsReceivable = 0;

            // Act
            Action actualResult = () => Finance.Corporate.ReceivablesTurnoverRatio(salesRevenue, avgAccountsReceivable);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }


        [Fact]
        public void ReceivablesTurnoverRatio_2500000_3000000_Test()
        {
            // Arrange 
            double salesRevenue = 2500000;
            double avgAccountsReceivable = 3000000;

            // Act
            var actualResult = Finance.Corporate.ReceivablesTurnoverRatio(salesRevenue, avgAccountsReceivable);
            var expectedResult = 0.83333333333333337;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
