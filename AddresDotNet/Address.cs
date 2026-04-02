using System;

namespace AddresDotNet;

public record Address
{
    public Region Region { get; init; }
    public Locality Locality { get; init; }
    public PlanningElement PlanningElement { get; init; }
    public Street Street { get; init; }
    public Building Building { get; init; }
    public Room Room { get; init; }

    public Address(AddressBuilder builder)
    {
        Region = builder._region ?? throw new ArgumentNullException(nameof(builder._region));
        Locality = builder._locality ?? throw new ArgumentNullException(nameof(builder._locality));
        PlanningElement = builder._planningElement ?? throw new ArgumentNullException(nameof(builder._planningElement));
        Street = builder._street ?? throw new ArgumentNullException(nameof(builder._street));
        Building = builder._building ?? throw new ArgumentNullException(nameof(builder._building));
        Room = builder._room ?? throw new ArgumentNullException(nameof(builder._room));
    }
}