namespace CleanCodeSamples.ConsistentFormatting;

public class OrderService
{
    public void ProcessOrder(Order order)
    {
        if (order == null || order.Items == null || order.Items.Count == 0)
        {
            Console.WriteLine("Invalid order");
            return;
        }

        decimal totalAmount = 0;
        foreach (var item in order.Items)
        {
            totalAmount += item.Price * item.Quantity;
        }

        if (order.Customer.IsPremium)
        {
            totalAmount *= 0.9m;
        }

        var invoice = new Invoice
        {
            CustomerName = order.Customer.Name,
            Items = order.Items,
            TotalAmount = totalAmount,
            Date = DateTime.Now
        };

        SendEmail(order.Customer.Email, "Order Processed", $"Your total is {totalAmount}");
    }
    private void SendEmail(string email, string subject, string message)
    {
        // Send a e-mail;
    }
}