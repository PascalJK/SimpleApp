using SimpleConsole;

namespace SimpleApp.UnitTests;

public class FakeShippingCalculator : IShippingCalculator
{
    public float CalculateShipping(Order order) => 1;
}