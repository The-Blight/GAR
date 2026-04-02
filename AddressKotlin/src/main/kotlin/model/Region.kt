package model

import enums.RegionType


/**
 * Субъект РФ (регион).
 * Является обязательным элементом адреса.
 *
 * @property name Наименование региона (например, "Московская", "Татарстан").
 * @property type Тип региона, определяемый перечислением [RegionType].
 */
data class Region(val name: String, val type: RegionType)
