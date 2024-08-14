using System;

namespace CleanCodeSamples.AvoidRedundancies;

public interface IHasItems
{
    List<Item> Items { get; }
    Customer Customer { get; }

}
