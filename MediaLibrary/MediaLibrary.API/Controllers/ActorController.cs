using MediaLibrary.API.Dto;
using MediaLibrary.API.Services;
using MediaLibrary.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MediaLibrary.API.Controllers;

/// <summary>
/// Контроллер для управления исполнителями 
/// </summary>
/// <param name="actorService">Репозиторий для работы с исполнителями</param>
[Route("api/[controller]")]
[ApiController]
public class ActorController(IService<ActorDto, Actor> actorService) : ControllerBase
{
    /// <summary>
    /// Возвращает список всех исполниетелей
    /// </summary>
    /// <returns>Список исполнителей</returns>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Actor>>> Get()
    {
        return Ok(await actorService.GetAll());
    }

    /// <summary>
    /// Возвращает исполнителя по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор исполнителя</param>
    /// <returns>Исполнитель или "Не найдено"</returns>
    [HttpGet("{id}")]
    public async Task<ActionResult<Actor>> Get(int id)
    {
        var result = await actorService.GetById(id);
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
    public async Task<ActionResult<Actor>> Post([FromBody] ActorDto value)
    {
        var result = await actorService.Post(value);
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
    public async Task<ActionResult> Put(int id, [FromBody] ActorDto value)
    {
        var result = await actorService.Put(id, value);
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
    public async Task<ActionResult> Delete(int id)
    {
        var result = await actorService.Delete(id);
        if (!result)
            return NotFound();

        return Ok();
    }
}
