using FluentAssertions;
using Note.Helpers;

namespace Note.Test;

public class CalculatorTests
{
    [Theory]
    [InlineData("",0)]
    [InlineData("1",1)]
    [InlineData("1,2",3)]
    public void Add_AddUpToTwoNumbers_WhenStringISValid(string calculation,int expected)

    {
        var calculator = new Calculator();
        var result = calculator.Add(calculation);
        result.Should().Be(expected);
    }
    [Theory]
    [InlineData("1,2,3,4",10)]
    [InlineData("1,2,10",13)]
    public void Add_AnyNumbers_WhenStringISValid(string calculation,int expected)

    {
        var calculator = new Calculator();
        var result = calculator.Add(calculation);
        result.Should().Be(expected);
    }
}