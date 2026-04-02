import builder.AddressBuilder
import enums.*
import model.*
import kotlin.test.Test
import kotlin.test.assertEquals
import kotlin.test.assertFailsWith
import kotlin.test.assertNull


class AddressBuilderTest {

    @Test
    fun `should build address with ONLY mandatory region`() {
        // Arrange (Подготовка)
        val builder = AddressBuilder()
        val expectedRegion = Region("Московская", RegionType.OBLAST)


        val address = builder.setRegion(expectedRegion).build()

        assertEquals(expectedRegion, address.region, "Регион должен совпадать с переданным")


        assertNull(address.locality, "Населенный пункт должен быть null")
        assertNull(address.planningElement, "Элемент планировочной структуры должен быть null")
        assertNull(address.street, "Улица должна быть null")
        assertNull(address.building, "Здание должно быть null")
        assertNull(address.room, "Помещение должно быть null")
    }


    @Test
    fun `should build FULL address with all components`() {

        val builder = AddressBuilder()
        val region = Region("Тульская", RegionType.OBLAST)
        val locality = Locality("Тула", LocalityType.CITY)
        val planning = PlanningElement("Центральный", PlanningElementType.MICRODISTRICT)
        val street = Street("Ленина", StreetType.AVENUE)
        val building = Building("1", BuildingType.HOUSE)
        val room = Room("42", RoomType.APARTMENT)


        val address = builder
            .setRegion(region)
            .setLocality(locality)
            .setPlanning(planning)
            .setStreet(street)
            .setBuilding(building)
            .setRoom(room)
            .build()


        assertEquals(region, address.region)
        assertEquals(locality, address.locality)
        assertEquals(planning, address.planningElement)
        assertEquals(street, address.street)
        assertEquals(building, address.building)
        assertEquals(room, address.room)
    }


    @Test
    fun `should throw IllegalArgumentException when region is MISSING`() {
        // Arrange
        val builder = AddressBuilder()
        val locality = Locality("Москва", LocalityType.FEDERAL_CITY)

        val exception = assertFailsWith<IllegalArgumentException> {
            builder
                .setLocality(locality)

                .build()
        }

        assertEquals("Регион является обязательным параметром", exception.message)
    }


    @Test
    fun `builder should rewrite properties if called multiple times`() {
        val builder = AddressBuilder()
        val firstRegion = Region("Московская", RegionType.OBLAST)
        val secondRegion = Region("Тульская", RegionType.OBLAST)

        val address = builder
            .setRegion(firstRegion)
            .setRegion(secondRegion) // Перезаписываем
            .build()

        assertEquals(secondRegion, address.region, "Строитель должен сохранить последнее переданное значение")
    }
}