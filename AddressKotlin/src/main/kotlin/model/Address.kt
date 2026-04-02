package model

import interfaces.IBuilder

data class Address(
    val region: Region,
    val locality: Locality? = null,
    val planningElement: PlanningElement? = null,
    val street: Street? = null,
    val building: Building? = null,
    val room: Room? = null
)