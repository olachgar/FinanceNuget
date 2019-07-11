using System;
using Xunit;

namespace Finance.Tests.General
{
    public class DoublingTimeSimpleInterest
    {
        [Theory]
        [InlineData(5, 20)]
        [InlineData(10, 10)]
        [InlineData(15, 6.666666666666667)]
        [InlineData(20, 5)]
        [InlineData(25, 4)]
        public void DoublingTimeSimpleInterest_Test(double rate, double expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Finance.General.DoublingTimeSimpleInterest(rate);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 5), Math.Round(actualResult, 5));
        }


        [Theory]
        [InlineData(0)]
        public void DoublingTimeSimpleInterest_DivideByZero_Test(double rate)
        {
            // Arrange

            // Act
            Action actualResult = () => Finance.General.DoublingTimeSimpleInterest(rate);

            // Assert
            Assert.Throws<DivideByZeroException>(actualResult);
        }
    }
}
