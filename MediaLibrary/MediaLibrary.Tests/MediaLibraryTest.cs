﻿using MediaLibrary.Domain.Entities;

namespace MediaLibrary.Tests;

/// <summary>
/// Класс для тестирования запросов
/// </summary>
/// <param name="fixture">Данные для тестирования</param>
public class MediaLibraryTest(MediaLibraryFixture fixture) : IClassFixture<MediaLibraryFixture>
{
    /// <summary>
    /// Проверка вывода всех исполнителей
    /// </summary>
    [Fact]
    public void AllActors()
    {
        var actorInfo =
            from actor in fixture.Actors
            orderby actor
            select actor;

        Assert.NotNull(actorInfo);
        Assert.Equal(9, actorInfo.Count());
    }

    /// <summary>
    /// Проверка вывода всех треков в альбоме, упорядоченных по номеру
    /// </summary>
    [Fact]
    public void TracksInAlbum()
    {
        var expectedValues = new List<Track>()
        {
            fixture.Tracks[0],
            fixture.Tracks[1],
            fixture.Tracks[2],
            fixture.Tracks[3],
        };
        var albumId = 1;
        
        var tracksInfo =
            (from album in fixture.Albums
            join track in fixture.Tracks on album.Id equals track.AlbumId
            where album.Id == albumId
            orderby track.Number
            select track).ToList();
       
        Assert.NotNull(tracksInfo);
        Assert.Equal(expectedValues, tracksInfo);
    }

    /// <summary>
    /// Проверка вывода всех альбомов в указанный год с количеством треков в альбоме
    /// </summary>
    [Fact]
    public void AlbumsInfo()
    {
        var albumYear = 2022;
        var expectedValues = new[]
        {
            new
            {
                Album = fixture.Albums[4],
                TrackCount = 4
            },
            new
            {
                Album = fixture.Albums[7],
                TrackCount = 5
            }
        };

        var albumsInfo =
            (from album in fixture.Albums
             where album.Date.Year == albumYear
             join track in fixture.Tracks
             on album.Id equals track.AlbumId into albumTracks
             select new
             {
                 Album = album,
                 TrackCount = albumTracks.Count(),
             })
             .ToList();

        Assert.NotNull(albumsInfo);
        Assert.Equal(expectedValues, albumsInfo);
    }

    /// <summary>
    /// Проверка вывода топ 5 альбомов по продолжительности 
    /// </summary>
    [Fact]
    public void TopAlbums()
    {
        var expectedValues = new[]
         {
            new
            {
                Album = fixture.Albums[1],
                TotalTime = 1404.0
            },
            new
            {
                Album = fixture.Albums[7],
                TotalTime = 1222.0
            },
            new
            {
                Album = fixture.Albums[3],
                TotalTime = 1101.0
            },
            new
            {
                Album = fixture.Albums[8],
                TotalTime = 1007.0
            },
            new
            {
                Album = fixture.Albums[0],
                TotalTime = 979.0
            },
        };

        var topAlbums =
            (from album in fixture.Albums
             join track in fixture.Tracks
             on album.Id equals track.AlbumId into albumTracks
             group albumTracks by album into groupAlbums
             select new
             {
                 Album = groupAlbums.Key,
                 TotalTime = groupAlbums.Sum(g => g.Sum(t => t.Time.TotalSeconds))
             })
             .OrderByDescending(t => t.TotalTime)
             .Take(5)
             .ToList();

        Assert.NotNull(topAlbums);
        Assert.Equal(expectedValues, topAlbums);
    }

    /// <summary>
    /// Проверка вывода артистов с максимальным количеством альбомов
    /// </summary>
    [Fact]
    public void MaxAlbumsActors()
    {
        var expectedValues = new[]
         {
            new
            {
               Actor = fixture.Actors[1],
               AlbumsCount = 3
            },
            new
            {
               Actor = fixture.Actors[3],
               AlbumsCount = 3
            },
            new
            {
               Actor = fixture.Actors[5],
               AlbumsCount = 3
            },
            new
            {
               Actor = fixture.Actors[7],
               AlbumsCount = 3
            },
        };

        var topActors =
            (from album in fixture.Albums
             group album by album.ActorId into albumGroup
             let albumCount = albumGroup.Count()
             let maxAlbumCount =
                        (from al in fixture.Albums
                         group al by al.ActorId into alGroup
                         select alGroup.Count()).Max()
             where albumCount == maxAlbumCount
             join actor in fixture.Actors
             on albumGroup.Key equals actor.Id
             select new
             {
                 Actor = actor,
                 AlbumsCount = albumCount,
             })
            .ToList();
        
        Assert.NotNull(topActors);
        Assert.Equal(expectedValues, topActors);
    }

    /// <summary>
    /// Проверка вывода информации о минимальной, средней и максимальной
    /// продолжительности альбомов
    /// </summary>
    [Fact]
    public void TimeAlbumInfo()
    {
        var albumsDurations =
            (from track in fixture.Tracks
             group track by track.AlbumId into trackGroup
             select trackGroup.Sum(t => t.Time.TotalSeconds))
            .ToList();
        
        var minTime = albumsDurations.Min();
        var maxTime = albumsDurations.Max();
        var averageTime = albumsDurations.Average();

        Assert.NotNull(albumsDurations);
        Assert.Equal(1404.0, maxTime);
        Assert.Equal(709.0, minTime);
        Assert.Equal(1022.6, averageTime, 1);
    }
}