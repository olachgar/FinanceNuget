using System;
using Xunit;

namespace Finance.Tests.General
{
    public class DoublingTime
    {
        [Theory]
        [InlineData(5, 14.2067)]
        [InlineData(10, 7.27254)]
        [InlineData(15, 4.95948)]
        [InlineData(20, 3.80178)]
        [InlineData(25, 3.10628)]
        public void DoublingTime_Test(double rateOfReturn, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.General.DoublingTime(rateOfReturn);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(0)]
        public void DoublingTime_DivideByZero_Test(double rateOfReturn)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.General.DoublingTime(rateOfReturn);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
