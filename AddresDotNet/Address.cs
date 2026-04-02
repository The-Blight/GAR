using System;

namespace AddresDotNet;
/// <summary>
/// Неизменяемый объект адреса, собранный из отдельных компонентов.
/// </summary>
public class Address
{
    /// <summary>
    /// Регион адреса.
    /// </summary>
    public Region Region { get; }
    /// <summary>
    /// Населённый пункт (город, деревня и т.п.).
    /// </summary>
    public Locality Locality { get;}
    /// <summary>
    /// Планировочный элемент.
    /// </summary>
    public PlanningElement PlanningElement { get;}
    /// <summary>
    /// Улица или проезд.
    /// </summary>
    public Street Street { get;}
    /// <summary>
    /// Здание.
    /// </summary>
    public Building Building { get;}
    /// <summary>
    /// Помещение внутри здания.
    /// </summary>
    public Room Room { get;}
    /// <summary>
    /// Создаёт объект адреса на основе готового билдера.
    /// </summary>
    /// <param name="builder">Билдер, содержащий все компоненты адреса.</param>
    /// <exception cref="ArgumentNullException">Если любой из компонентов в билдере равен <see langword="null"/>.</exception>
    public Address(AddressBuilder builder)
    {
        Region = builder._region ?? throw new ArgumentNullException(nameof(builder._region));
        Locality = builder._locality ?? throw new ArgumentNullException(nameof(builder._locality));
        PlanningElement = builder._planningElement ?? throw new ArgumentNullException(nameof(builder._planningElement));
        Street = builder._street ?? throw new ArgumentNullException(nameof(builder._street));
        Building = builder._building ?? throw new ArgumentNullException(nameof(builder._building));
        Room = builder._room ?? throw new ArgumentNullException(nameof(builder._room));
    }
    /// <summary>
    /// Возвращает строковое представление полного адреса в читаемом формате.
    /// </summary>
    /// <returns>Возвращает строку</returns>
    public string GetFullAddress()
    {
        return $"{Region.Name}, {Locality.Name}, {Street.Name} {Street.Type}, д. {Building.Number}, {Room.Type} {Room.Number}";
    }
}