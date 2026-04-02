using AddresDotNet.Enum;

namespace AddresDotNet;

public record Street
{
    public string Name { get; init; }
    public StreetType Type { get; init; }

}