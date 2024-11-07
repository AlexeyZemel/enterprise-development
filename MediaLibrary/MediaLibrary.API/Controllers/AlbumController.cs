using MediaLibrary.API.Dto;
using MediaLibrary.API.Services;
using MediaLibrary.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MediaLibrary.API.Controllers;

/// <summary>
/// Контроллер для управления альбомами 
/// </summary>
/// <param name="albumService">Репозиторий для работы с альбомами</param>
[Route("api/[controller]")]
[ApiController]
public class AlbumController(IService<AlbumDto, Album> albumService) : ControllerBase
{
    /// <summary>
    /// Возвращает список всех альбомов
    /// </summary>
    /// <returns>Список альбомов</returns>
    [HttpGet]
    public ActionResult<IEnumerable<Album>> Get()
    {
        return Ok(albumService.GetAll());
    }

    /// <summary>
    /// Возвращает альбом по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор альбом</param>
    /// <returns>Альбом или "Не найдено"</returns>
    [HttpGet("{id}")]
    public ActionResult<Album> Get(int id)
    {
        var result = albumService.GetById(id);
        if (result == null) 
            return NotFound();

        return Ok(result);
    }

    /// <summary>
    /// Добавляет новый альбом 
    /// </summary>
    /// <param name="value">Информация о новом альбоме</param>
    /// <returns>Добавленный альбом или "Плохой запрос"</returns>
    [HttpPost]
    public ActionResult<Album> Post([FromBody] AlbumDto value)
    {
        var result = albumService.Post(value);
        if (result == null)
            return BadRequest();

        return Ok(result);
    }

    /// <summary>
    /// Изменяет альбом по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор альбома</param>
    /// <param name="value">Обновлённая информация об альбоме</param>
    /// <returns>Результат операции</returns>
    [HttpPut("{id}")]
    public ActionResult Put(int id, [FromBody] AlbumDto value)
    {
        var result = albumService.Put(id, value);
        if (!result)
            return BadRequest();

        return Ok();
    }

    /// <summary>
    /// Удаляет альбом по идентификатору 
    /// </summary>
    /// <param name="id">Идентификатор альбома</param>
    /// <returns>Результат операции</returns>
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var result = albumService.Delete(id);
        if (!result)
            return BadRequest();

        return Ok();
    }
}
