using System;
using Xunit;
using ТDD._1;

namespace ТDD._1Tests
{
    public class ProductTests
    {
        [Fact]
        public void Product_ShouldBeCreatedWithCorrectProperties()
        {
            // Arrange
            string expectedName = "Test Product";
            decimal expectedPrice = 10.5m;
            int expectedQuantity = 3;

            // Act
            var product = new Product(expectedName, expectedPrice, expectedQuantity);
           
            // Assert
            Assert.Equal(expectedName, product.Name);
            Assert.Equal(expectedPrice, product.Price);
            Assert.Equal(expectedQuantity, product.Quantity);
        }


        
        [Fact]
        public void Name_ShouldNotBeEmpty()
        {
            // Arrange
            string name = "";
            decimal price = 10.5m;
            int quantity = 3;

            // Act & Assert
            ArgumentException ex = Assert.Throws<ArgumentException>(() => new Product(name, price, quantity));
            Assert.Equal("Name cannot be empty.", ex.Message);
        }


        [Fact]
        public void Price_ShouldBeChangedOnlyToPositiveValue()
        {

            // Arrange
            string name = "Test Product";
            decimal price = -10.5m;
            int quantity = 3;

            // Act & Assert

            ArgumentException ex = Assert.Throws<ArgumentException>(() => new Product(name, price, quantity)); // Invalid update
            Assert.Equal("Price must be a positive value.", ex.Message);
        }

        [Fact]
        public void Quantity_ShouldBeChangedOnlyToPositiveValue()
        {
            // Arrange
            string name = "Test Product";
            decimal price = 10.5m;
            int quantity = -3;

            // Act & Assert
            ArgumentException ex =Assert.Throws<ArgumentException>(() => new Product(name, price, quantity)); // Invalid update
            Assert.Equal("Quantity cannot be negative.",ex.Message);
        }
    }
}
