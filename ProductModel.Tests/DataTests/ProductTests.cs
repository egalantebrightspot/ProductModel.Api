using ProductModel.Domain.Products;
using Xunit;

namespace ProductModel.Tests.DataTests
{
    public class ProductTests
    {
        [Fact]
        public void Product_Properties_CanBeSetAndRetrieved()
        {
            // Arrange
            var product = new Product
            {
                // Act
                Id = 1,
                Name = "Test Product",
                Description = "A sample product",
                Price = 9.99m,
                CategoryId = 2
            };

            // Assert
            Assert.Equal(1, product.Id);
            Assert.Equal("Test Product", product.Name);
            Assert.Equal("A sample product", product.Description);
            Assert.Equal(9.99m, product.Price);
            Assert.Equal(2, product.CategoryId);
        }

        [Fact]
        public void Product_DefaultValues_AreCorrect()
        {
            // Arrange & Act
            var product = new Product();

            // Assert
            Assert.Equal(0, product.Id);
            Assert.Equal(string.Empty, product.Name);
            Assert.Equal(string.Empty, product.Description);
            Assert.Equal(0m, product.Price);
            Assert.Equal(0, product.CategoryId);
        }
    }
}
