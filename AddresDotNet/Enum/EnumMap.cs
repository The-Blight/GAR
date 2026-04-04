using System.Collections.Generic;

namespace AddresDotNet.Enum;

public static class EnumsMap
{
    public static Dictionary<RegionType, string> RegionTypeMap = new()
    {
        { RegionType.REPUBLIC, "Республика" },
        { RegionType.KRAY, "Край" },
        { RegionType.OBLAST, "Область" },
        { RegionType.FEDERAL_CITY, "Город федерального значения" },
        { RegionType.AUTONOMOUS_OBLAST, "Автономная область" },
        { RegionType.AUTONOMOUS_OKRUG, "Автономный округ" }
    };

    public static Dictionary<LocalityType, string> LocalityTypeMap = new()
    {
        { LocalityType.CITY, "г." },
        { LocalityType.VILLAGE, "с." },
        { LocalityType.SETTLEMENT_TYPE_URBAN, "пгт" },
        { LocalityType.DEREVNYA, "деревня" },
        { LocalityType.KHUTOR, "хутор" }
    };

    public static Dictionary<PlanningElementType, string> PlanningElementTypeMap = new()
    {
        { PlanningElementType.MICRODISTRICT, "мкр." },
        { PlanningElementType.SNT, "СНТ" },
        { PlanningElementType.KVARTAL, "кв." },
        { PlanningElementType.INDUSTRIAL_ZONE, "промзона" },
        { PlanningElementType.GSC, "ГСК" }
    };

    public static Dictionary<StreetType, string> StreetTypeMap = new()
    {
        { StreetType.STREET, "ул." },
        { StreetType.AVENUE, "пр." },
        { StreetType.LANE, "пер." },
        { StreetType.EMBANKMENT, "наб." },
        { StreetType.SQUARE, "пл." },
        { StreetType.BOULEVARD, "б-р" }
    };

    public static Dictionary<BuildingType, string> BuildingTypeMap = new()
    {
        { BuildingType.HOUSE, "д." },
        { BuildingType.BUILDING, "здание" },
        { BuildingType.STRUCTURE, "соор." },
        { BuildingType.LITERA, "лит." }
    };

    public static Dictionary<RoomType, string> RoomTypeMap = new()
    {
        { RoomType.APARTMENT, "кв." },
        { RoomType.OFFICE, "оф." },
        { RoomType.ROOM, "ком." },
        { RoomType.WORK_SPACE, "раб. место" }
    };

    /// <summary>
    /// Возвращает представление enum значения.
    /// </summary>
    /// <typeparam name="TType">Тип enum.</typeparam>
    /// <param name="type">Значение enum.</param>
    /// <param name="map">Словарь сопоставления.</param>
    /// <returns>название.</returns>
    /// <exception cref="KeyNotFoundException">Если значение не найдено в словаре.</exception>
    public static string ToDisplay<TType>(TType type, Dictionary<TType, string> map)
        where TType : struct, System.Enum
        => map[type];
}