using AddresDotNet.Enum;

namespace AddresDotNet;

public record Locality
{
    public string Name { get; init; }
    public LocalityType Type { get; init; }
    
}