using AddresDotNet.Enum;

namespace AddresDotNet;

/// <summary>
/// Строитель (Builder) для создания объекта адреса.
/// Позволяет пошагово задать компоненты адреса и затем собрать неизменяемый <see cref="Address"/>.
/// </summary>
public class AddressBuilder : IBuilder
{
    /// <summary>
    /// Регион адреса.
    /// </summary>
    public Region _region { get; private set; }
    /// <summary>
    /// Населённый пункт.
    /// </summary>
    public Locality _locality{ get; private set; }
    /// <summary>
    /// Планировочный элемент.
    /// </summary>
    public PlanningElement _planningElement{ get; private set; }
    /// <summary>
    /// Улица или проезд.
    /// </summary>
    public Street _street{ get; private set; }
    /// <summary>
    /// Здание.
    /// </summary>
    public Building _building{ get; private set; }
    /// <summary>
    /// Помещение внутри здания.
    /// </summary>
    public Room _room{ get; private set; }
    /// <summary>
    /// Устанавливает регион адреса.
    /// </summary>
    /// <param name="name">Название региона.</param>
    /// <param name="type">Тип региона.</param>
    /// <returns>Текущий экземпляр <see cref="AddressBuilder"/> для цепочки вызовов.</returns>
    public AddressBuilder SetRegion(string name, RegionType type)
    {
        _region = new Region { Name = name, Type = type };
        return this;
    }
    /// <summary>
    /// Устанавливает населённый пункт.
    /// </summary>
    /// <param name="name">Название населённого пункта.</param>
    /// <param name="type">Тип населённого пункта.</param>
    /// <returns>Текущий экземпляр <see cref="AddressBuilder"/> для цепочки вызовов.</returns>
    public AddressBuilder SetLocality(string name, LocalityType type)
    {
        _locality = new Locality { Name = name, Type = type };
        return this;
    }
    /// <summary>
    /// Устанавливает планировочный элемент.
    /// </summary>
    /// <param name="name">Название планировочного элемента.</param>
    /// <param name="type">Тип планировочного элемента.</param>
    /// <returns>Текущий экземпляр <see cref="AddressBuilder"/> для цепочки вызовов.</returns>

    public AddressBuilder SetPlanningElement(string name, PlanningElementType type)
    {
        _planningElement = new PlanningElement { Name = name, Type = type };
        return this;
    }
    /// <summary>
    /// Устанавливает улицы.
    /// </summary>
    /// <param name="name">Название улицы.</param>
    /// <param name="type">Тип улицы.</param>
    /// <returns>Текущий экземпляр <see cref="AddressBuilder"/> для цепочки вызовов.</returns>
    public AddressBuilder SetStreet(string name, StreetType type)
    {
        _street = new Street { Name = name, Type = type };
        return this;
    }
    /// <summary>
    /// Устанавливает здание.
    /// </summary>
    /// <param name="number">Номер здания.</param>
    /// <param name="type">Тип здания.</param>
    /// <returns>Текущий экземпляр <see cref="AddressBuilder"/> для цепочки вызовов.</returns>
    public AddressBuilder SetBuilding(string number, BuildingType type)
    {
        _building = new Building { Number = number, Type = type };
        return this;
    }
    /// <summary>
    /// Устанавливает комнату/помещение в здании.
    /// </summary>
    /// <param name="number">Номер помещения.</param>
    /// <param name="type">Тип помещения.</param>
    /// <returns>Текущий экземпляр <see cref="AddressBuilder"/> для цепочки вызовов.</returns>
    public AddressBuilder SetRoom(string number, RoomType type)
    {
        _room = new Room { Number = number, Type = type };
        return this;
    }
    /// <summary>
    /// Собирает и возвращает объект адреса на основе заданных компонентов.
    /// </summary>
    /// <returns>Новый неизменяемый объект <see cref="Address"/>.</returns>
    /// <exception cref="ArgumentNullException">Если какой‑либо обязательный компонент не задан.</exception>
    public Address Build()
    {
        return new Address(this);
    }
}