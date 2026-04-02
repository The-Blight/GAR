using AddresDotNet.Enum;

namespace AddresDotNet;

public record PlanningElement
{
    public string Name { get; init; }
    public PlanningElementType Type { get; init; }
    
}