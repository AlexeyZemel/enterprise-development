using MediaLibrary.Domain.Entities;
using MediaLibrary.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MediaLibrary.API.Controllers;

/// <summary>
/// Контроллер для управления треками  
/// </summary>
/// <param name="trackRepository">Сервис для работы с треками</param>
[Route("api/[controller]")]
[ApiController]
public class TrackController(IRepository<Track> trackRepository) : ControllerBase
{
    /// <summary>
    /// Возвращает список всех треков
    /// </summary>
    /// <returns>Список треков</returns>
    [HttpGet]
    public ActionResult<IEnumerable<Track>> Get()
    {
        return Ok(trackRepository.GetAll());
    }

    /// <summary>
    /// Возвращает трек по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор трека</param>
    /// <returns>Трек или "Не найдено"</returns>
    [HttpGet("{id}")]
    public ActionResult<Track> Get(int id)
    {
        var result = trackRepository.GetById(id);
        if (result == null) 
            return NotFound();

        return Ok(result);
    }

    /// <summary>
    /// Добавляет новый трек 
    /// </summary>
    /// <param name="value">Информация о новом треке</param>
    /// <returns>Добавленный трек или "Плохой запрос"</returns>
    [HttpPost]
    public ActionResult<Track> Post([FromBody] Track value)
    {
        var result = trackRepository.Post(value);
        if (result == null)
            return BadRequest();

        return Ok(result);
    }

    /// <summary>
    /// Изменяет трек по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор трека</param>
    /// <param name="value">Обновлённая информация о треке</param>
    /// <returns>Результат операции</returns>
    [HttpPut("{id}")]
    public ActionResult Put(int id, [FromBody] Track value)
    {
        var result = trackRepository.Put(id, value);
        if (!result)
            return BadRequest();

        return Ok();
    }

    /// <summary>
    /// Удаляет трек по идентификатору 
    /// </summary>
    /// <param name="id">Идентификатор трека</param>
    /// <returns>Результат операции</returns>
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var result = trackRepository.Delete(id);
        if (!result)
            return NotFound();

        return Ok();
    }
}
