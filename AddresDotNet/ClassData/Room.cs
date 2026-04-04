using AddresDotNet.Enum;

namespace AddresDotNet;

public class Room : ValueObject<RoomType>, IValueObject
{
    public override required RoomType Type { get; init; }
    public override required string Value { get; init; }

    public override string ToString() => 
        $"{EnumsMap.ToDisplay(Type, EnumsMap.RoomTypeMap)} {Value}";
}