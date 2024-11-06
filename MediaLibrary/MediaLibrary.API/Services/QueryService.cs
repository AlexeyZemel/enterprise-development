using MediaLibrary.API.Dto;
using MediaLibrary.Domain.Entities;
using MediaLibrary.Domain.Repositories;

namespace MediaLibrary.API.Services;

/// <summary>
/// Сервис для запросов к данным
/// </summary>
/// <param name="actorRepository">Репозиторий исполнителей</param>
/// <param name="trackRepository">Репозиторий треков</param>
/// <param name="albumRepository">Репозиторий альбомов</param>
public class QueryService(ActorRepository actorRepository, 
    TrackRepository trackRepository, AlbumRepository albumRepository)
{
    /// <summary>
    /// Возвращает список всех исполнителей
    /// </summary>
    /// <returns>Список исполнителей</returns>
    public List<Actor> GetAllActors()
    {
        var actorInfo =
            (from actor in actorRepository.GetAll()
            orderby actor
            select actor)
            .ToList();

        return actorInfo;
    }

    /// <summary>
    /// Возвращает список треков в альбоме
    /// </summary>
    /// <param name="id">Идентификатор альбома</param>
    /// <returns>Список треков в альбоме</returns>
    public List<Track> GetTracksInAlbum(int id)
    {
        var tracksInfo =
            (from album in albumRepository.GetAll()
             join track in trackRepository.GetAll() on album.Id equals track.AlbumId
             where album.Id == id
             orderby track.Number
             select track)
             .ToList();

        return tracksInfo;
    }

    /// <summary>
    /// Возвращает альбомы и количество треков в каждом
    /// </summary>
    /// <param name="year">Год альбома</param>
    /// <returns>Альбомы и количество треков в каждом</returns>
    public List<AlbumInfoDto> GetAlbumsInfo(int year)
    {
        var albumsInfo =
            (from album in albumRepository.GetAll()
             where album.Date.Year == year
             join track in trackRepository.GetAll()
             on album.Id equals track.AlbumId into albumTracks
             select new AlbumInfoDto
             {
                 ActorId = album.ActorId,
                 Name = album.Name,
                 Date = album.Date,
                 TrackCount = albumTracks.Count(),
             })
             .ToList();

        return albumsInfo;
    }

    /// <summary>
    /// Выводит список топ 5 альбомов по продолжительности треков
    /// </summary>
    /// <returns>Топ 5 альбомов по продолжительности треков</returns>
    public List<TopAlbumsDto> GetTopAlbums()
    {
        var topAlbums =
            (from album in albumRepository.GetAll()
             join track in trackRepository.GetAll()
             on album.Id equals track.AlbumId into albumTracks
             group albumTracks by album into groupAlbums
             select new TopAlbumsDto
             {
                 ActorId = groupAlbums.Key.ActorId,
                 Name = groupAlbums.Key.Name,
                 Date = groupAlbums.Key.Date,
                 TotalTime = groupAlbums.Sum(g => g.Sum(t => t.Time.TotalSeconds))
             })
             .OrderByDescending(t => t.TotalTime)
             .Take(5)
             .ToList();

        return topAlbums;
    }

    /// <summary>
    /// Возвращает авторов с макисмальным количеством альбомов
    /// </summary>
    /// <returns>Авторы с макисмальным количеством альбомов</returns>
    public List<AlbumsActorsDto> GetMaxAlbumsActors()
    {
        var topActors =
           (from album in albumRepository.GetAll()
            group album by album.ActorId into albumGroup
            let albumCount = albumGroup.Count()
            let maxAlbumCount =
                       (from al in albumRepository.GetAll()
                        group al by al.ActorId into alGroup
                        select alGroup.Count()).Max()
            where albumCount == maxAlbumCount
            join actor in actorRepository.GetAll()
            on albumGroup.Key equals actor.Id
            select new AlbumsActorsDto
            {
                Name = actor.Name,
                Description = actor.Description,
                AlbumsCount = albumCount
            })
           .ToList();

        return topActors;
    }

    /// <summary>
    /// Выводит информацио о минимальной, максимальной и средней продолжительности альбомов 
    /// </summary>
    /// <returns>Минимальная, максимальная и средняя продолжительность альбомов</returns>
    public TimeAlbumDto GetTimeAlbumsInfo()
    {
        var albumsDurations =
           (from track in trackRepository.GetAll()
            group track by track.AlbumId into trackGroup
            select trackGroup.Sum(t => t.Time.TotalSeconds))
           .ToList();

        return new TimeAlbumDto
        {
            MinTime = albumsDurations.Min(),
            MaxTime = albumsDurations.Max(),
            AvgTime = albumsDurations.Average()
        };
    }
}
