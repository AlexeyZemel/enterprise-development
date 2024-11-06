﻿using MediaLibrary.API.Dto;
using MediaLibrary.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace MediaLibrary.API.Controllers;

/// <summary>
/// Контроллер для управления треками  
/// </summary>
/// <param name="trackService">Сервис для работы с треками</param>
[Route("api/[controller]")]
[ApiController]
public class TrackController(TrackService trackService) : ControllerBase
{
    /// <summary>
    /// Возвращает список всех треков
    /// </summary>
    /// <returns>Список треков</returns>
    [HttpGet]
    public ActionResult<IEnumerable<TrackDto>> Get()
    {
        return Ok(trackService.GetAll());
    }

    /// <summary>
    /// Возвращает трек по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор трека</param>
    /// <returns>Трек или "Не найдено"</returns>
    [HttpGet("{id}")]
    public ActionResult<TrackDto> Get(int id)
    {
        var result = trackService.GetById(id);
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
    public ActionResult<TrackDto> Post([FromBody] TrackDto value)
    {
        var result = trackService.Post(value);
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
    public ActionResult Put(int id, [FromBody] TrackDto value)
    {
        var result = trackService.Put(id, value);
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
        var result = trackService.Delete(id);
        if (!result)
            return NotFound();

        return Ok();
    }
}
