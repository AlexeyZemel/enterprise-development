namespace MediaLibrary.Domain.Repositories;

/// <summary>
/// Репозиторий для работы с сущностями
/// </summary>
/// <typeparam name="T">Тип сущности</typeparam>
public interface IRepository<T>
{
    /// <summary>
    /// Получить все сущности
    /// </summary>
    /// <returns>Список сущностей</returns>
    public Task<IEnumerable<T>> GetAll();

    /// <summary>
    /// Получить сущность по идентификатору 
    /// </summary>
    /// <param name="id">Идентификатор сущности</param>
    /// <returns>Сущность с заданным идентификатором</returns>
    public Task<T?> GetById(int id);

    /// <summary>
    /// Добавить новую сущность
    /// </summary>
    /// <param name="entity">Новая сущность</param>
    /// <returns>Добавленная сущность</returns>
    public Task<T?> Post(T entity);

    /// <summary>
    /// Обновить сущность по идентификатору 
    /// </summary>
    /// <param name="id">Идентификатор сущности</param>
    /// <param name="entity">Новая сущность</param>
    /// <returns>Результат операции</returns>
    public Task<bool> Put(int id, T entity);

    /// <summary>
    /// Удалить сущность по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор сущности</param>
    /// <returns>Результат операции</returns>
    public Task<bool> Delete(int id);
}
