﻿using Microsoft.AspNetCore.Mvc;
using MediaLibrary.Domain.Entities;
using MediaLibrary.API.Services;
using MediaLibrary.API.Dto;

namespace MediaLibrary.API.Controllers;

/// <summary>
/// Контроллер для управления инофрмацией о жанрах и исполнителях  
/// </summary>
/// <param name="actorGenreService">Сервис для работы со связями "исполнитель - жанр"</param>
[Route("api/[controller]")]
[ApiController]
public class ActorGenreController(IService<ActorGenreDto, ActorGenre> actorGenreService) : ControllerBase
{
    /// <summary>
    /// Возвращает список всех связей "исполнитель - жанр"
    /// </summary>
    /// <returns>Список всех связей</returns>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ActorGenre>>> Get()
    {
        return Ok(await actorGenreService.GetAll());
    }

    /// <summary>
    /// Возвращает жанр исполнителя по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор исполнителя</param>
    /// <returns>Жанр или "Не найдено"</returns>
    [HttpGet("{id}")]
    public async Task<ActionResult<ActorGenre>> Get(int id)
    {
        var result = await actorGenreService.GetById(id);
        if (result == null) 
            return NotFound();

        return Ok(result);
    }

    /// <summary>
    /// Добавляет новую связь "исполнитель - жанр" 
    /// </summary>
    /// <param name="value">Информация о новой связи</param>
    /// <returns>Добавленная связь или "Плохой запрос"</returns>
    [HttpPost]
    public async Task<ActionResult<ActorGenre>> Post([FromBody] ActorGenreDto value)
    {
        var result = await actorGenreService.Post(value);
        if (result == null)
            return BadRequest();

        return Ok(result);
    }

    /// <summary>
    /// Изменяет связь "исполнитель - жанр" по идентификатору исполнителя
    /// </summary>
    /// <param name="id">Идентификатор исполниетеля</param>
    /// <param name="value">Обновлённая информация о связи</param>
    /// <returns>Результат операции</returns>
    [HttpPut("{id}")]
    public async Task<ActionResult> Put(int id, [FromBody] ActorGenreDto value)
    {
        var result = await actorGenreService.Put(id, value);
        if (!result)
            return BadRequest();

        return Ok();
    }

    /// <summary>
    /// Удаляет связь "исполнитель - жанр" по идентификатору исполнителя
    /// </summary>
    /// <param name="id">Идентификатор исполнителя</param>
    /// <returns>Результат операции</returns>
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var result = await actorGenreService.Delete(id);
        if (!result)
            return NotFound();

        return Ok();
    }
}
