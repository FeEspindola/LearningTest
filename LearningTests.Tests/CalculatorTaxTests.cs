using System.Threading.Tasks;
using FakeItEasy;
using FluentAssertions;
using LearningTests.Tax;
using NUnit.Framework;

namespace LearningTests.Tests
{
    public class CalculatorTaxTests
    {
        [Test]
        public async Task CalculateSalaryLiquidMustDiscountAliquotDoSalaryPast()
        {
            // Arrange
            var fakeServicoIR = A.Fake<IServiceTaxIncome>();
            A.CallTo(() => fakeServicoIR.GetAliquot(3000)).Returns(10);
            var calculatorTax = new CalculatorTax(fakeServicoIR);

            // Act
            var resultado = await calculatorTax.CalculateSalaryLiquid(3000);

            // Assert
            resultado.Should().Be(2700);
        }
    }

}