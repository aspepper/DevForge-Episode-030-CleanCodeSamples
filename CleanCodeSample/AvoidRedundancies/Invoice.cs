using System;

namespace CleanCodeSamples.AvoidRedundancies;

public class Invoice: IHasItems
{
    public Customer Customer { get; set; } = new();

    public List<Item> Items { get; set; } = [];

    public decimal TotalAmount { get; set; }

    public DateTime Date { get; set; }
}