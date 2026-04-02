package model



/**
 * Комплексная модель адреса, объединяющая все его иерархические компоненты.
 *
 * @property region Субъект РФ (единственный обязательный компонент адреса).
 * @property locality Населенный пункт (опционально).
 * @property planningElement Элемент планировочной структуры (опционально).
 * @property street Улица (опционально).
 * @property building Здание или строение (опционально).
 * @property room Помещение (опционально).
 */
data class Address(
    val region: Region,
    val locality: Locality? = null,
    val planningElement: PlanningElement? = null,
    val street: Street? = null,
    val building: Building? = null,
    val room: Room? = null
)