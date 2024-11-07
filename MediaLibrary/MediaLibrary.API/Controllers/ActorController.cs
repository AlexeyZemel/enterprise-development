using MediaLibrary.Domain.Entities;
using MediaLibrary.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MediaLibrary.API.Controllers;

/// <summary>
/// Контроллер для управления исполнителями 
/// </summary>
/// <param name="actorRepository">Репозиторий для работы с исполнителями</param>
[Route("api/[controller]")]
[ApiController]
public class ActorController(IRepository<Actor> actorRepository) : ControllerBase
{
    /// <summary>
    /// Возвращает список всех исполниетелей
    /// </summary>
    /// <returns>Список исполнителей</returns>
    [HttpGet]
    public ActionResult<IEnumerable<Actor>> Get()
    {
        return Ok(actorRepository.GetAll());
    }

    /// <summary>
    /// Возвращает исполнителя по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор исполнителя</param>
    /// <returns>Исполнитель или "Не найдено"</returns>
    [HttpGet("{id}")]
    public ActionResult<Actor> Get(int id)
    {
        var result = actorRepository.GetById(id);
        if (result == null) 
            return NotFound();

        return Ok(result);
    }

    /// <summary>
    /// Добавляет нового исполнителя 
    /// </summary>
    /// <param name="value">Информация о новом исполнителе</param>
    /// <returns>Добавленный исполнитель или "Плохой запрос"</returns>
    [HttpPost]
    public ActionResult<Actor> Post([FromBody] Actor value)
    {
        var result = actorRepository.Post(value);
        if (result == null)
            return BadRequest();

        return Ok(result);
    }

    /// <summary>
    /// Изменяет исполнителя по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор исполниетеля</param>
    /// <param name="value">Обновлённая информация о исполнителе</param>
    /// <returns>Результат операции</returns>
    [HttpPut("{id}")]
    public ActionResult Put(int id, [FromBody] Actor value)
    {
        var result = actorRepository.Put(id, value);
        if (!result)
            return BadRequest();

        return Ok();
    }

    /// <summary>
    /// Удаляет исполнителя по идентификатору 
    /// </summary>
    /// <param name="id">Идентификатор исполнителя</param>
    /// <returns>Результат операции</returns>
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var result = actorRepository.Delete(id);
        if (!result)
            return NotFound();

        return Ok();
    }
}
