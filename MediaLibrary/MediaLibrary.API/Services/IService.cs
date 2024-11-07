namespace MediaLibrary.API.Services;

/// <summary>
/// Интерфейс для сервисов сущностей
/// </summary>
/// <typeparam name="Dto">Тип сущности Dto</typeparam>
/// <typeparam name="T">Тип сущности</typeparam>
public interface IService<Dto, T> 
{
    /// <summary>
    /// Получение всех сущностей
    /// </summary>
    /// <returns>Список сущностей</returns>
    public IEnumerable<T> GetAll();

    /// <summary>
    /// Получение сущности по идентификатору 
    /// </summary>
    /// <param name="id">Идентификатор сущности</param>
    /// <returns>Сущность с выбранным идентификатором</returns>
    public T? GetById(int id);

    /// <summary>
    /// Добавление сущности
    /// </summary>
    /// <param name="entity">Новая сущность</param>
    /// <returns>Добавленная сущность</returns>
    public T? Post(Dto entity);

    /// <summary>
    /// Обновляет сущность по идентификатору 
    /// </summary>
    /// <param name="id">Идентификатор сущности</param>
    /// <param name="entity">Новая сущность</param>
    /// <returns>Результат операции</returns>
    public bool Put(int id, Dto entity);

    /// <summary>
    /// Удаляет сущность по идентификатору 
    /// </summary>
    /// <param name="id">Идентификатор сущности</param>
    /// <returns>Результат операции</returns>
    public bool Delete(int id);
}
