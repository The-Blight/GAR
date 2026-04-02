package model

import enums.LocalityType

/**
 * Населенный пункт в составе региона.
 *
 * @property name Наименование населенного пункта (например, "Москва", "Тула").
 * @property type Тип населенного пункта, определяемый перечислением [LocalityType].
 */
data class Locality(val name: String, val type: LocalityType)
