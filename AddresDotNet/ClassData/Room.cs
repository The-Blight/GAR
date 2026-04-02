using AddresDotNet.Enum;

namespace AddresDotNet;

public record Room
{
    public string Number { get; init; }
    public RoomType Type { get; init; }
    
}