using CleanCodeSamples.AutomatedTesting;
using NUnit.Framework;

namespace CleanCodeSampleTest;

[TestFixture]
public class CalculatorTests
{
    private Calculator calculator = new();

    [SetUp]
    public void Setup()
    {
        calculator = new Calculator();
    }

    [Test]
    public void Add_WhenCalled_ReturnsSum()
    {
        int result = calculator.Add(2, 3);
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Subtract_WhenCalled_ReturnsDifference()
    {
        int result = calculator.Subtract(5, 3);
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void Multiply_WhenCalled_ReturnsProduct()
    {
        int result = calculator.Multiply(2, 3);
        Assert.That(result, Is.EqualTo(6));
    }

    [Test]
    public void Divide_WhenDivisorIsNonZero_ReturnsQuotient()
    {
        int result = calculator.Divide(6, 3);
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void Divide_WhenDivisorIsZero_ThrowsDivideByZeroException()
    {
        Assert.Throws<DivideByZeroException>(() => calculator.Divide(6, 0));
    }
}