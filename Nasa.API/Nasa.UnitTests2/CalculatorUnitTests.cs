using FluentAssertions;
using Nasa.Helpers;
using Xunit;

namespace Nasa.UnitTests2;

public class CalculatorUnitTests
{
    private Calculator calculator;

    public CalculatorUnitTests()
    {
        calculator = new Calculator();
    }
    
    [Fact]
    public void SumShouldReturnGoodResultForTwoNumbers()
    {
        // Arrange
        var firstNumber = 10;
        var secondNumber = 10;
        
        // Act
        var result = calculator.Sum(firstNumber, secondNumber);

        // Assert
        result.Should().Be(20);
    }

    [Theory]
    [InlineData(10, 10, 20)]
    [InlineData(5, 5, 10)]
    public void SumShouldReturnGoodResultForTwoNumbers2(int firstNumber, int secondNumber, int result)
    {
        // Act
        var resultOfSum = calculator.Sum(firstNumber, secondNumber);

        // Assert
        resultOfSum.Should().Be(result);
    }
}