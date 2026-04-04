using AddresDotNet.Enum;

namespace AddresDotNet;

public class Locality : ValueObject<LocalityType>, IValueObject
{
    public override required LocalityType Type { get; init; }
    public override required string Value { get; init; }

    public override string ToString() => 
        $"{EnumsMap.ToDisplay(Type, EnumsMap.LocalityTypeMap)} {Value}";
}