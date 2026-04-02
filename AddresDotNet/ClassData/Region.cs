using AddresDotNet.Enum;
namespace AddresDotNet;

public record Region
{
    public string Name { get; init; }
    public RegionType Type { get; init; }

}