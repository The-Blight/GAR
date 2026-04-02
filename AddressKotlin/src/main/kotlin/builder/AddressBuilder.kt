package builder

import interfaces.IBuilder
import model.Address
import model.Building
import model.Locality
import model.PlanningElement
import model.Region
import model.Room
import model.Street

class AddressBuilder : IBuilder {

    private var _region: Region? = null
    private var _locality: Locality? = null
    private var _planningElement: PlanningElement? = null
    private var _street: Street? = null
    private var _building: Building? = null
    private var _room: Room? = null;


    fun setRegion(region: Region): AddressBuilder = apply {
        _region = region
    }

    fun setLocality(locality: Locality): AddressBuilder = apply {
        _locality = locality
    }

    fun setPlanning(planningElement: PlanningElement): AddressBuilder = apply {
        _planningElement = planningElement
    }

    fun setStreet(street: Street): AddressBuilder = apply {
        _street = street
    }

    fun setBuilding(building: Building): AddressBuilder = apply {
        _building = building;
    }

    fun setRoom(room: Room): AddressBuilder = apply {
        _room = room
    }

    override fun build(): Address {
        val checkedRegion = requireNotNull(_region)
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