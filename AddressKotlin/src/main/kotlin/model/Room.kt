package model

import enums.RoomType


/**
 * Помещение внутри здания (квартира, офис, комната).
 *
 * @property number Номер помещения (например, "42", "101").
 * @property type Тип помещения, определяемый перечислением [RoomType].
 */
data class Room(val number: String, val type: RoomType)
