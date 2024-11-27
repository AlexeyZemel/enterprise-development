using MediaLibrary.API.Dto;
using MediaLibrary.API.Services;
using MediaLibrary.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MediaLibrary.API.Controllers;

/// <summary>
/// Контроллер для управления жанрами  
/// </summary>
/// <param name="genreService">Сервис для работы с жанрами</param>
[Route("api/[controller]")]
[ApiController]
public class GenreController(IService<GenreDto, Genre> genreService) : ControllerBase
{
    /// <summary>
    /// Возвращает список всех жанров
    /// </summary>
    /// <returns>Список жанров</returns>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Genre>>> Get()
    {
        return Ok(await genreService.GetAll());
    }

    /// <summary>
    /// Возвращает жанр по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор жанра</param>
    /// <returns>Жанр или "Не найдено"</returns>
    [HttpGet("{id}")]
    public async Task<ActionResult<Genre>> Get(int id)
    {
        var result = await genreService.GetById(id);
        if (result == null) 
            return NotFound();

        return Ok(result);
    }

    /// <summary>
    /// Добавляет новый жанр 
    /// </summary>
    /// <param name="value">Информация о новом жанре</param>
    /// <returns>Добавленный жанр или "Плохой запрос"</returns>
    [HttpPost]
    public async Task<ActionResult<Genre>> Post([FromBody] GenreDto value)
    {
        var result = await genreService.Post(value);
        if (result == null)
            return BadRequest();

        return Ok(result);
    }

    /// <summary>
    /// Изменяет жанр по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор жанра</param>
    /// <param name="value">Обновлённая информация о жанре</param>
    /// <returns>Результат операции</returns>
    [HttpPut("{id}")]
    public async Task<ActionResult> Put(int id, [FromBody] GenreDto value)
    {
        var result = await genreService.Put(id, value);
        if (!result) 
            return BadRequest();

        return Ok();
    }

    /// <summary>
    /// Удаляет жанр по идентификатору 
    /// </summary>
    /// <param name="id">Идентификатор жанра</param>
    /// <returns>Результат операции</returns>
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var result = await genreService.Delete(id);
        if (!result)
            return NotFound();

        return Ok();
    }
}
