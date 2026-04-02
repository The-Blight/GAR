package model

import enums.PlanningElementType

/**
 * Элемент планировочной структуры (микрорайон, квартал, СНТ и т.д.).
 *
 * @property name Наименование элемента планировочной структуры.
 * @property type Тип элемента, определяемый перечислением [PlanningElementType].
 */
data class PlanningElement(val name: String, val type: PlanningElementType)
