using AddresDotNet.Enum;

namespace AddresDotNet;

public class Building : ValueObject<BuildingType>, IValueObject
{
    public override required BuildingType Type { get; init; }
    public override required string Value { get; init; }
    public Building Clone() => new() { Type = this.Type, Value = this.Value };
    

    public override string ToString() => 
        $"{EnumsMap.ToDisplay(Type, EnumsMap.BuildingTypeMap)} {Value}";
}