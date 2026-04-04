using AddresDotNet.Enum;

namespace AddresDotNet;

public class PlanningElement : ValueObject<PlanningElementType>, IValueObject
{
    public override required PlanningElementType Type { get; init; }
    public override required string Value { get; init; }

    public override string ToString() => 
        $"{EnumsMap.ToDisplay(Type, EnumsMap.PlanningElementTypeMap)} {Value}";
}
