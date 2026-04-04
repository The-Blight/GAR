using System;
using AddresDotNet.Enum;

namespace AddresDotNet;

/// <summary>
/// Строитель (Builder) для создания объекта адреса.
/// Позволяет пошагово задать компоненты адреса и затем собрать неизменяемый <see cref="Address"/>.
/// </summary>
public class AddressBuilder
{
    /// <summary>
    /// Регион адреса.
    /// </summary>
    private Region _region { get; set; }
    /// <summary>
    /// Населённый пункт.
    /// </summary>
    private Locality? _locality{ get; set; }
    /// <summary>
    /// Планировочный элемент.
    /// </summary>
    private PlanningElement? _planningElement{ get; set; }
    /// <summary>
    /// Улица или проезд.
    /// </summary>
    private Street? _street{ get; set; }
    /// <summary>
    /// Здание.
    /// </summary>
    private Building? _building{ get; set; }
    /// <summary>
    /// Помещение внутри здания.
    /// </summary>
    private Room? _room{ get; set; }
    /// <summary>
    /// Устанавливает регион адреса.
    /// </summary>
    /// <param name="name">Название региона.</param>
    /// <param name="type">Тип региона.</param>
    /// <returns>Текущий экземпляр <see cref="AddressBuilder"/> для цепочки вызовов.</returns>
    public AddressBuilder SetRegion(string name, RegionType type)
    {
        _region = new Region { Value = name, Type = type };
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
        _locality = new Locality { Value = name, Type = type };
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
        _planningElement = new PlanningElement { Value = name, Type = type };
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
        _street = new Street { Value = name, Type = type };
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
        _building = new Building { Value = number, Type = type };
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
        _room = new Room { Value = number, Type = type };
        return this;
    }
    /// <summary>
    /// Собирает и возвращает объект адреса на основе заданных компонентов.
    /// </summary>
    /// <returns>Новый неизменяемый объект <see cref="Address"/>.</returns>
    /// <exception cref="InvalidOperationException">Если обязательный компонент (регион) не задан.</exception>
    public Address Build()
    {
        if (_region == null)
            throw new InvalidOperationException("Регион является обязательным компонентом адреса.");
        return new Address(_region,_locality,_planningElement, _street,_building,_room)
        {
            Region = _region,
            Locality = _locality,
            PlanningElement = _planningElement,
            Street = _street,
            Building = _building,
            Room =_room,
        };
    }
}