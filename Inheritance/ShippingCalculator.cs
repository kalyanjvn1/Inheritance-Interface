using System;

namespace Inheritance
{
    public interface IShippingCalculator
    {
        double CalculateShipping(Order order);
    }

    public class ShippingCalculator : IShippingCalculator
    {
        public double CalculateShipping(Order order)
        {
            double cost = 0;
            if (order.TotalPrice < 30f)
            {
               cost = order.TotalPrice * 0.1;
            }
            return cost;
        }
    }
}