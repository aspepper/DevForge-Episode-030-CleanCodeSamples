namespace CleanCodeSamples.AvoidRedundancies;

public class OrderServiceBad
{
    public decimal CalculateOrderTotal(Order order)
    {
        decimal total = 0;
        foreach (var item in order.Items)
        {
            total += item.Price * item.Quantity;
        }

        if (order.Customer.IsPremium)
        {
            total *= 0.9m;
        }

        return total;
    }

    public decimal CalculateInvoiceTotal(Invoice invoice)
    {
        decimal total = 0;
        foreach (var item in invoice.Items)
        {
            total += item.Price * item.Quantity;
        }

        if (invoice.Customer.IsPremium)
        {
            total *= 0.9m;
        }

        return total;
    }
}

