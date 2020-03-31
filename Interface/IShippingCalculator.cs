namespace POSInterface
{
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }
}