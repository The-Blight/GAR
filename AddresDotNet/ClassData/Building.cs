using AddresDotNet.Enum;

namespace AddresDotNet;

public record Building
{
    public string Number { get;init; }
    public BuildingType Type { get; init; }
    
}