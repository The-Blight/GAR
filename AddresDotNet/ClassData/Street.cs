using AddresDotNet.Enum;

namespace AddresDotNet;

public class Street : ValueObject<StreetType>, IValueObject
{
    public override required StreetType Type { get; init; }
    public override required string Value { get; init; }
    public Street Clone() => new() { Type = this.Type, Value = this.Value };

    public override string ToString() => 
        $"{Value} {EnumsMap.ToDisplay(Type, EnumsMap.StreetTypeMap)}";
}