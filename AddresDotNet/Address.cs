using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AddresDotNet;
/// <summary>
/// Неизменяемый объект адреса, собранный из отдельных компонентов.
/// </summary>
public class Address: IEnumerable<IValueObject>, IClone<Address>
{
    /// <summary>
    /// Регион адреса.
    /// </summary>
    public Region Region { get; init; }

    /// <summary>
    /// Населённый пункт.
    /// </summary>
    public Locality? Locality { get; init; }

    /// <summary>
    /// Планировочный элемент.
    /// </summary>
    public PlanningElement? PlanningElement { get; init; }

    /// <summary>
    /// Улица или проезд.
    /// </summary>
    public Street? Street { get; init; }

    /// <summary>
    /// Здание.
    /// </summary>
    public Building? Building { get; init; }

    /// <summary>
    /// Помещение внутри здания.
    /// </summary>
    public Room? Room { get; init; }

    /// <summary>
    /// Создаёт объект адреса на основе готового билдера.
    /// </summary>
    /// <param name="region">Регион адреса (обязательный).</param>
    /// <param name="locality">Населённый пункт (может быть <see langword="null"/>).</param>
    /// <param name="planningElement">Планировочный элемент (может быть <see langword="null"/>).</param>
    /// <param name="street">Улица (может быть <see langword="null"/>).</param>
    /// <param name="building">Здание (может быть <see langword="null"/>).</param>
    /// <param name="room">Помещение (может быть <see langword="null"/>).</param>
    public Address(Region region, Locality? locality, PlanningElement? planningElement, 
        Street? street, Building? building, Room? room)
    {
        Region = region;
        Locality = locality;
        PlanningElement = planningElement;
        Street = street;
        Building = building;
        Room = room;
    }
    /// <summary>
    /// Возвращает строковое представление полного адреса в читаемом формате.
    /// </summary>
    /// <returns>Возвращает строку</returns>
    public string GetFullAddress()
    {
        var list = this.Select(v => v.ToString()).ToList();
        return string.Join(", ", list);
    }
    /// <summary>
    /// Возвращает перечислитель для перебора всех компонентов адреса, реализующих <see cref="IValueObject"/>.
    /// </summary>
    /// <returns>Перечислитель компонентов адреса (<see cref="Region"/>, <see cref="Locality"/>, 
    /// <see cref="PlanningElement"/>, <see cref="Street"/>, <see cref="Building"/>, <see cref="Room"/>).</returns>
    /// <remarks>
    /// Перечисляет только свойства, значения которых реализуют <see cref="IValueObject"/> и не равны <see langword="null"/>.
    /// </remarks>
    public IEnumerator<IValueObject> GetEnumerator()
    {
        var properties = this.GetType().GetProperties();
        foreach (var property in properties)
        {
            if (property.GetValue(this) is IValueObject value)
            {
                yield return value;
            }
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    
    /// <summary>
    /// Делает копию <see cref="Address"/>.
    /// </summary>
    public Address Clone() => new(
        Region.Clone(),
        Locality?.Clone(),
        PlanningElement?.Clone(),
        Street?.Clone(),
        Building?.Clone(),
        Room?.Clone()
    );
}