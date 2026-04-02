package builder

import interfaces.IBuilder
import model.Address
import model.Building
import model.Locality
import model.PlanningElement
import model.Region
import model.Room
import model.Street

/**
 * Строитель для пошагового создания объекта [Address].
 * Реализует текучий интерфейс для объединения вызовов в цепочку.
 */

class AddressBuilder : IBuilder {

    private var _region: Region? = null
    private var _locality: Locality? = null
    private var _planningElement: PlanningElement? = null
    private var _street: Street? = null
    private var _building: Building? = null
    private var _room: Room? = null;


    /**
     * Устанавливает регион адреса.
     *
     * @param region Объект [Region].
     * @return Текущий экземпляр [AddressBuilder].
     */
    fun setRegion(region: Region): AddressBuilder = apply {
        _region = region
    }

    /**
     * Устанавливает населенный пункт.
     *
     * @param locality Объект [Locality].
     * @return Текущий экземпляр [AddressBuilder].
     */
    fun setLocality(locality: Locality): AddressBuilder = apply {
        _locality = locality
    }

    /**
     * Устанавливает элемент планировочной структуры (например, микрорайон).
     *
     * @param planningElement Объект [PlanningElement].
     * @return Текущий экземпляр [AddressBuilder].
     */
    fun setPlanning(planningElement: PlanningElement): AddressBuilder = apply {
        _planningElement = planningElement
    }

    /**
     * Устанавливает улицу.
     *
     * @param street Объект [Street].
     * @return Текущий экземпляр [AddressBuilder].
     */
    fun setStreet(street: Street): AddressBuilder = apply {
        _street = street
    }

    /**
     * Устанавливает здание или строение.
     *
     * @param building Объект [Building].
     * @return Текущий экземпляр [AddressBuilder].
     */
    fun setBuilding(building: Building): AddressBuilder = apply {
        _building = building;
    }

    /**
     * Устанавливает помещение (квартиру, офис).
     *
     * @param room Объект [Room].
     * @return Текущий экземпляр [AddressBuilder].
     */
    fun setRoom(room: Room): AddressBuilder = apply {
        _room = room
    }


    /**
     * Собирает и возвращает итоговый объект [Address].
     *
     * @return Сконструированный адрес.
     * @throws IllegalArgumentException Если не был установлен обязательный параметр [Region].
     */
    override fun build(): Address {
        val checkedRegion = requireNotNull(_region) { "Регион является обязательным параметром" }
        return Address(
            region = checkedRegion,
            locality = _locality,
            planningElement = _planningElement,
            street = _street,
            building = _building,
            room = _room
        )
    }
}