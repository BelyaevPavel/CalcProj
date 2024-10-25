using ClalcProj;
using JetBrains.Annotations;
using Xunit;

namespace ClalcProj.Tests;

[TestSubject(typeof(Calculator))]
public class CalculatorTest
{

    [Fact]
    public void Add_2_plus_3_equals_5()
    {
        var calculator = new Calculator();
        var result = calculator.Add(2, 3);
        
        Assert.Equal(5, result);
    }
    
    [Fact]
    public void Add_2_plus_3_equals_6()
    {
        var calculator = new Calculator();
        var result = calculator.Add(2, 3);
        
        Assert.Equal(6, result);
    }
}