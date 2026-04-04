using AddresDotNet.Enum;
namespace AddresDotNet;

public class Region : ValueObject<RegionType>, IValueObject
{
    public override required RegionType Type { get; init; }
    public override required string Value { get; init; }

    public override string ToString() => 
        $"{Value} {EnumsMap.ToDisplay(Type, EnumsMap.RegionTypeMap)}";
}