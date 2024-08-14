namespace CleanCodeSamples.AvoidUnnecessaryComments;

public class AvoidUnnecessaryCommentsBad
{
    public decimal CalculateTotalPrice(Order order)
    {
        // Initialize total price
        decimal totalPrice = 0;

        // Loop through each item in the order
        foreach (var item in order.Items)
        {
            // Multiply item price by quantity
            totalPrice += item.Price * item.Quantity;
        }

        // Apply discount if the customer is premium
        if (order.Customer.IsPremium)
        {
            // Reduce the total price by 10%
            totalPrice *= 0.9m;
        }

        // Return the total price
        return totalPrice;
    }

}
