namespace CleanCodeSamples.SmallFunctions;

public class SmallFunctions
{
    public void ProcessOrder(Order order)
    {
        if (!IsValidOrder(order))
        {
            Console.WriteLine("Order is invalid");
            return;
        }

        decimal totalAmount = CalculateTotalAmount(order);
        totalAmount = ApplyDiscountIfNeened(order, totalAmount);

        var invoice = GenerateInvoice(order, totalAmount);
        SendOrderConfirmation(order.Customer.Email, invoice);
    }

    private bool IsValidOrder(Order order)
    {
        return order != null && order.Items != null && order.Items.Count > 0;
    }

    private decimal CalculateTotalAmount(Order order)
    {
        decimal totalAmount = 0;
        foreach (var item in order.Items)
        {
            totalAmount += item.Price * item.Quantity;
        }
        return totalAmount;
    }

    private decimal ApplyDiscountIfNeened(Order order, decimal totalAmount)
    {
        if (order.Customer.IsPremium)
        {
            totalAmount *= 0.9m;
        }
        return totalAmount;
    }

    private Invoice GenerateInvoice(Order order, decimal totalAmount)
    {
        return new Invoice
        {
            CustomerName = order.Customer.Name,
            Items = order.Items,
            TotalAmount = totalAmount,
            Date = DateTime.Now
        };
    }

    private void SendOrderConfirmation(string email, Invoice invoice)
    {
        SendEmail(email, "Your order has been processed", 
                "Thank you for your purchase. Your total is " 
                + invoice.TotalAmount);
    }

    private void SendEmail(string email, string subject, string message)
    {
        // Send a e-mail;
    }
}