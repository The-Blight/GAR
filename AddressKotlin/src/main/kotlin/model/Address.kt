package model

import interfaces.IBuilder

class Address(
    val region: Region,
    val locality: Locality,
    val planningElement: PlanningElement,
    val street: Street,
    val building: Building,
    val room: Room
) {

    fun address(builder: IBuilder) {

    }


}