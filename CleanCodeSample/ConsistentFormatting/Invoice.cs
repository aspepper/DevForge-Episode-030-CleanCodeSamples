namespace CleanCodeSamples.ConsistentFormatting;

public class Invoice
{
    public string CustomerName { get; set; } = string.Empty;

    public List<Item> Items { get; set; } = [];

    public decimal TotalAmount { get; set; }

    public DateTime Date { get; set; }
}