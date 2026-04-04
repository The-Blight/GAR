namespace AddresDotNet;

public interface IValueObject
{
    
}

public abstract class ValueObject<TValueType> where TValueType : System.Enum
{
    public abstract required TValueType Type { get; init; }
    public abstract required string Value { get; init; }
}