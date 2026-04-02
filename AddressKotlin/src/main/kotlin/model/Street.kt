package model

import enums.StreetType
/**
 * Элемент улично-дорожной сети (улица, проспект, переулок).
 *
 * @property name Наименование улицы.
 * @property type Тип улицы, определяемый перечислением [StreetType].
 */
data class Street(val name: String, val type: StreetType)
