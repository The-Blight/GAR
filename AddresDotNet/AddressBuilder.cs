using AddresDotNet.Enum;

namespace AddresDotNet;

public class AddressBuilder : IBuilder
{
    public Region? _region { get; private set; }
    public Locality? _locality{ get; private set; }
    public PlanningElement? _planningElement{ get; private set; }
    public Street? _street{ get; private set; }
    public Building? _building{ get; private set; }
    public Room? _room{ get; private set; }

    public AddressBuilder SetRegion(string name, RegionType type)
    {
        _region = new Region { Name = name, Type = type };
        return this;
    }

    public AddressBuilder SetLocality(string name, LocalityType type)
    {
        _locality = new Locality { Name = name, Type = type };
        return this;
    }

    public AddressBuilder SetPlanningElement(string name, PlanningElementType type)
    {
        _planningElement = new PlanningElement { Name = name, Type = type };
        return this;
    }

    public AddressBuilder SetStreet(string name, StreetType type)
    {
        _street = new Street { Name = name, Type = type };
        return this;
    }

    public AddressBuilder SetBuilding(string number, BuildingType type)
    {
        _building = new Building { Number = number, Type = type };
        return this;
    }

    public AddressBuilder SetRoom(string number, RoomType type)
    {
        _room = new Room { Number = number, Type = type };
        return this;
    }

    public Address Build()
    {
        return new Address(this);
    }
}