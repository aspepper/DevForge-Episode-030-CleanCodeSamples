namespace CleanCodeSamples.AvoidUnnecessaryComments;

public class AvoidUnnecessaryComments
{
    public decimal CalculateTotalPrice(Order order)
    {
        decimal totalPrice = 0;

        foreach (var item in order.Items)
        {
            totalPrice += item.Price * item.Quantity;
        }

        if (order.Customer.IsPremium)
        {
            totalPrice = ApplyPremiumDiscount(totalPrice);
        }

        return totalPrice;
    }

    private decimal ApplyPremiumDiscount(decimal totalPrice)
    {
        return totalPrice * 0.9m;
    }

}