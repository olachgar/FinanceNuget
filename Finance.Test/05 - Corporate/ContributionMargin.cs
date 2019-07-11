using Xunit;

namespace Finance.Tests.Corporate
{
    public class ContributionMargin
    {
        [Fact]
        public void ContributionMargin_400000_1000000_Test()
        {
            // Arrange
            double pricePerProduct = 1000000;
            double variableCostPerProduct = 400000;

            // Act
            var actualResult = Finance.Corporate.ContributionMargin(pricePerProduct, variableCostPerProduct);
            var expectedResult = 600000;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void ContributionMargin_10_25_Test()
        {
            // Arrange
            double pricePerProduct = 10;
            double variableCostPerProduct = 25;

            // Act
            var actualResult = Finance.Corporate.ContributionMargin(pricePerProduct, variableCostPerProduct);
            var expectedResult = -15;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void ContributionMargin_10_5_Test()
        {
            // Arrange
            double pricePerProduct = 10;
            double variableCostPerProduct = 5;

            // Act
            var actualResult = Finance.Corporate.ContributionMargin(pricePerProduct, variableCostPerProduct);
            var expectedResult = 5;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
