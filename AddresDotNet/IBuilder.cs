namespace AddresDotNet;
/// <summary>
/// Интерфейс для объекта Строитель.
/// </summary>
public interface IBuilder
{
    /// <summary>
    /// Собирает и возвращает объект.
    /// </summary>
    /// <returns>Готовый объект.</returns>
    Address Build();
}