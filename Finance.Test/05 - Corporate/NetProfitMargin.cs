using System;
using Xunit;

namespace Finance.Tests.Corporate
{
    public class NetProfitMargin
    {   
        [Fact]
        public void NetProfitMargin_5_2_Test()
        {
            // Arrange 
            double netIncome = 5;
            double salesRevenue = 2;

            // Act
            var actualResult = Finance.Corporate.NetProfitMargin(netIncome, salesRevenue);
            var expectedResult = 2.5;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void NetProfitMargin_100_0_Test()
        {
            // Arrange 
            double netIncome = 100;
            double salesRevenue = 0;

            // Act
            Action actualResult = () => Finance.Corporate.NetProfitMargin(netIncome, salesRevenue);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }


        [Fact]
        public void NetProfitMargin_1000000_25000000_Test()
        {
            // Arrange 
            double netIncome = 1000000;
            double salesRevenue = 25000000;

            // Act
            var actualResult = Finance.Corporate.NetProfitMargin(netIncome, salesRevenue);
            var expectedResult = 0.04;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
