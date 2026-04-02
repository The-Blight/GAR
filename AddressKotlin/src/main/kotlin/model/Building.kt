package model

import enums.BuildingType

/**
 * Здание, сооружение или строение.
 *
 * @property number Номер или обозначение здания (например, "10", "15А").
 * @property type Тип строения, определяемый перечислением [BuildingType].
 */
data class Building(val number: String, val type: BuildingType)
