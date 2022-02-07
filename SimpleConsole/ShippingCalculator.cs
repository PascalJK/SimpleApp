namespace SimpleConsole;

public class ShippingCalculator : IShippingCalculator
{
    public float CalculateShipping(Order order)
        => order.TotalPrice < 30f ? order.TotalPrice * 0.1f : 0;
}