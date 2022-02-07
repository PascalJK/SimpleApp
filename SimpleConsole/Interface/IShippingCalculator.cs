namespace SimpleApp.Console;

public interface IShippingCalculator
{
    float CalculateShipping(Order order);
}