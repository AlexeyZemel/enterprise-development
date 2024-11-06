using MediaLibrary.API.Dto;
using MediaLibrary.API.Services;
using MediaLibrary.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MediaLibrary.API.Controllers;


/// <summary>
/// Контроллер для запросов к данным
/// </summary>
/// <param name="queryService">Сервис для запросов</param>
[Route("api/[controller]")]
[ApiController]
public class QueryController(QueryService queryService) : Controller
{
    /// <summary>
    /// Возвращает список всех исполнителей
    /// </summary>
    /// <returns>Список исполнителей</returns>
    [HttpGet]
    [Route("all-actors")]
    public ActionResult<List<Actor>> GetAllActors()
    {
        return Ok(queryService.GetAllActors());
    }

    /// <summary>
    /// Возвращает список треков в альбоме
    /// </summary>
    /// <param name="id">Идентификатор альбома</param>
    /// <returns>Список треков в альбоме</returns>
    [HttpGet]
    [Route("tracks-in-album")]
    public ActionResult<List<Track>> GetTracksInAlbum([FromQuery] int id)
    {
        return Ok(queryService.GetTracksInAlbum(id));
    }

    /// <summary>
    /// Возвращает альбомы и количество треков в каждом
    /// </summary>
    /// <param name="year">Год альбома</param>
    /// <returns>Альбомы и количество треков в каждом</returns>
    [HttpGet]
    [Route("albums-info")]
    public ActionResult<List<AlbumInfoDto>> GetAlbumsInfo([FromQuery, 
        Range(1900, 2024, ErrorMessage = "Год должен быть в диапазоне от 1900 до 2024")] int year)
    {
        return Ok(queryService.GetAlbumsInfo(year));
    }

    /// <summary>
    /// Выводит список топ 5 альбомов по продолжительности треков
    /// </summary>
    /// <returns>Топ 5 альбомов по продолжительности треков</returns>
    [HttpGet]
    [Route("top-albums")]
    public ActionResult<List<TopAlbumsDto>> GetTopAlbums()
    {
        return Ok(queryService.GetTopAlbums());
    }

    /// <summary>
    /// Возвращает авторов с макисмальным количеством альбомов
    /// </summary>
    /// <returns>Авторы с макисмальным количеством альбомов</returns>
    [HttpGet]
    [Route("max-albums-actors")]
    public ActionResult<List<AlbumsActorsDto>> GetMaxAlbumsActors()
    {
        return Ok(queryService.GetMaxAlbumsActors());
    }

    /// <summary>
    /// Выводит информацио о минимальной, максимальной и средней продолжительности альбомов 
    /// </summary>
    /// <returns>Минимальная, максимальная и средняя продолжительность альбомов</returns>
    [HttpGet]
    [Route("time-albums-info")]
    public ActionResult<List<TimeAlbumDto>> GetTimeAlbumsInfo()
    {
        return Ok(queryService.GetTimeAlbumsInfo());
    }
}
