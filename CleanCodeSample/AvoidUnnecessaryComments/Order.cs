namespace CleanCodeSamples.AvoidUnnecessaryComments;

public class Order
{
    public Customer Customer { get; set; } = new();

    public List<Item> Items { get; set; } = [];
}