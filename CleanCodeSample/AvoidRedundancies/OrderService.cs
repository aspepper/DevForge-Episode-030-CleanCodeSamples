using System;

namespace CleanCodeSamples.AvoidRedundancies;

public class OrderService
{
    public decimal CalculateTotal(IHasItems entity)
    {
        decimal total = 0;
        foreach (var item in entity.Items)
        {
            total += item.Price * item.Quantity;
        }

        if (entity.Customer.IsPremium)
        {
            total *= 0.9m;
        }

        return total;
    }
}