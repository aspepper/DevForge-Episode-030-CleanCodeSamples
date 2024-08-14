namespace CleanCodeSamples.SmallFunctions;

public class SmallFunctionsBad
{
    public void ProcessOrder(Order order)
    {
        // Validate the order data
        if (order == null || order.Items == null || order.Items.Count == 0)
        {
            Console.WriteLine("Order is invalid");
            return;
        }

        // Calculate the total amount
        decimal totalAmount = 0;
        foreach (var item in order.Items)
        {
            totalAmount += item.Price * item.Quantity;
        }

        // Apply discount if applicable
        if (order.Customer.IsPremium)
        {
            totalAmount *= 0.9m;
        }

        // Generate the invoice
        var invoice = new Invoice
        {
            CustomerName = order.Customer.Name,
            Items = order.Items,
            TotalAmount = totalAmount,
            Date = DateTime.Now
        };

        // Send confirmation email
        SendEmail(order.Customer.Email, "Your order has been processed", "Thank you for your purchase. Your total is " + totalAmount);
    }

    private void SendEmail(string email, string subject, string message)
    {
        // Send a e-mail;
    }

}