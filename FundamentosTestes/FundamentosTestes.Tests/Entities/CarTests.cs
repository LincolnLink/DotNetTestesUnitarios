
using Bogus;
using FluentAssertions;
using FundamentosTestes.Entities;
using Xunit.Abstractions;

namespace FundamentosTestes.Tests.Entities
{
    [Trait("Category", "Car")]
    public sealed class CarTests
    {
        private readonly Faker _faker = new("pt_BR");
        private readonly ITestOutputHelper _testOutputHelper;

        public CarTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Theory] //- Theory posibilita passar mais que um parametro.
        [InlineData("Ferrari")]
        [InlineData("Fusca")]
        public void TheoryConstructor_GivenAllParameters_ThenShouldSetThePropertiesCorrectly(string expectedCarName)
        {
            // Given All Parameters
            // Arrange - Arruma valores pro teste            
            var expectedId = Guid.NewGuid();

            // Act - Executa o teste
            var carro = new Car(expectedId, expectedCarName);

            // Then should set the properties correctly
            // Assert - Definindo a regra do Teste.
            Assert.Equal(expectedId, carro.Id);
            Assert.Equal(expectedCarName, carro.Name);
        }

        [Fact] //- fato tem apenas uma condição.
        public void NoFakerConstructor_GivenAllParameters_ThenShouldSetThePropertiesCorrectly()
        {
            // Given All Parameters
            // Arrange - Arruma valores pro teste
            var expectedCarName = "Carro";
            var expectedId = Guid.NewGuid();

            // Act - Executa o teste
            var carro = new Car(expectedId, expectedCarName);

            // Then should set the properties correctly
            // Assert - Definindo a regra do Teste.
            Assert.Equal(expectedId, carro.Id);
            Assert.Equal(expectedCarName, carro.Name);
        }

        [Fact]
        public void FakerConstructor_GivenAllParameters_ThenShouldSetThePropertiesCorrectly()
        {
            // Given All Parameters
            // Arrange - Arruma valores pro teste            
            var expectedCarName = _faker.Person.FirstName;
            var expectedId = Guid.NewGuid();
            _testOutputHelper.WriteLine(expectedCarName);

            // Act - Executa o teste
            var carro = new Car(expectedId, expectedCarName);

            // Then should set the properties correctly
            // Assert - Definindo a regra do Teste.
            Assert.Equal(expectedId, carro.Id);
            Assert.Equal(expectedCarName, carro.Name);
        }

        [Fact]
        public void FluentAssertionsConstructor_GivenAllParameters_ThenShouldSetThePropertiesCorrectly()
        {
            // Given All Parameters
            // Arrange
            var expectedCarName = _faker.Person.FirstName;
            var expectedId = Guid.NewGuid();
            _testOutputHelper.WriteLine(expectedCarName);

            // Act
            var carro = new Car(expectedId, expectedCarName);

            // Then should set the properties correctly
            // Assert
            // Assert.Equal(expectedId, carro.Id);
            // Assert.Equal(expectedCarName, carro.Name);
            carro.Id.Should().Be(expectedId, "Should be equal");
            carro.Name.Should().Be(expectedCarName);
        }
    }
}
