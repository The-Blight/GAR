package interfaces

import model.Address

/**
 * Контракт для строителей объектов адреса.
 */
interface IBuilder {

    /**
     * Собирает и возвращает итоговый объект адреса.
     *
     * @return Сконструированный объект [Address].
     */
    fun build(): Address
}