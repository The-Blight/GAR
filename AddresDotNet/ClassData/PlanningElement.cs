using AddresDotNet.Enum;

namespace AddresDotNet;

public class PlanningElement : ValueObject<PlanningElementType>, IValueObject
{
    public override required PlanningElementType Type { get; init; }
    public override required string Value { get; init; }
    public PlanningElement Clone() => new() { Type = this.Type, Value = this.Value };

    public override string ToString() => 
        $"{EnumsMap.ToDisplay(Type, EnumsMap.PlanningElementTypeMap)} {Value}";
}
