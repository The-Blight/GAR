using AddresDotNet.Enum;
namespace AddresDotNet;

public class Region : ValueObject<RegionType>, IValueObject
{
    public override required RegionType Type { get; init; }
    public override required string Value { get; init; }
    public Region Clone() => new() { Type = this.Type, Value = this.Value };
    public override string ToString() => 
        $"{Value} {EnumsMap.ToDisplay(Type, EnumsMap.RegionTypeMap)}";
}