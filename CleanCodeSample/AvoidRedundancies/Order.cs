using System;

namespace CleanCodeSamples.AvoidRedundancies;

public class Order : IHasItems
{
    public Customer Customer { get; set; } = new();

    public List<Item> Items { get; set; } = [];
}