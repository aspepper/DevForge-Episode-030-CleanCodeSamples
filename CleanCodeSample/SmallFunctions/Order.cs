namespace CleanCodeSamples.SmallFunctions;

public class Order
{
    public Customer Customer { get; set; } = new();

    public List<Item> Items { get; set; } = [];
}