using AddresDotNet.Enum;

namespace AddresDotNet;

public class Room : ValueObject<RoomType>, IValueObject
{
    public override required RoomType Type { get; init; }
    public override required string Value { get; init; }
    public Room Clone() => new() { Type = this.Type, Value = this.Value };

    public override string ToString() => 
        $"{EnumsMap.ToDisplay(Type, EnumsMap.RoomTypeMap)} {Value}";
}