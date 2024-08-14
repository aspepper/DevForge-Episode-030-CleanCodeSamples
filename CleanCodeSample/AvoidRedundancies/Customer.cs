using System;

namespace CleanCodeSamples.AvoidRedundancies;

public class Customer
{
    public string Name { get; set; } = string.Empty;
    public bool IsPremium { get; set; }

    public string Email { get; set; } = string.Empty;
}
