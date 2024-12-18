﻿using MediaLibrary.Domain.Entities;

namespace MediaLibrary.Tests;

/// <summary>
/// Класс для тестовых данных
/// </summary>
public class MediaLibraryFixture
{
    /// <summary>
    /// Список исполнителей 
    /// </summary>
    public List<Actor> Actors { get; }

    /// <summary>
    /// Список сущностей Исполнитель-Жанр
    /// </summary>
    public List<ActorGenre> ActorGenres { get; }

    /// <summary>
    /// Список жанров
    /// </summary>
    public List<Genre> Genres { get; }

    /// <summary>
    /// Список треков
    /// </summary>
    public List<Track> Tracks { get; }

    /// <summary>
    /// Список альбомов
    /// </summary>
    public List<Album> Albums { get; }

    /// <summary>
    /// Инициализация тестовых данных 
    /// </summary>
    public MediaLibraryFixture()
    {
        Actors = 
        [ 
            new()
            {
                Id = 1,
                Name = "Beyoncé",
                Description = "American singer, songwriter, and actress, one of the best-selling music artists of all time"
            },
            new()
            {
                Id = 2,
                Name = "Ed Sheeran",
                Description = "English singer-songwriter known for his hits 'Shape of You' and 'Perfect'"
            },
            new()
            {
                Id = 3,
                Name = "Taylor Swift",
                Description = "American singer-songwriter, known for blending country, pop, and alternative music"
            },
            new()
            {
                Id = 4,
                Name = "The Weeknd",
                Description = "Canadian singer and record producer, recognized for his dark, moody R&B style"
            },
            new()
            {
                Id = 5,
                Name = "Billie Eilish",
                Description = "American singer-songwriter known for her unique, whispery vocal style and hits like 'Bad Guy'"
            },
            new()
            {
                Id = 6,
                Name = "Drake",
                Description = "Canadian rapper, singer, and actor, one of the most influential figures in modern rap"
            },
            new()
            {
                Id = 7,
                Name = "Adele",
                Description = "British singer-songwriter, famous for powerful ballads like 'Hello' and 'Someone Like You'"
            },
            new()
            {
                Id = 8,
                Name = "Coldplay",
                Description = "British rock band formed in 1996, known for their anthemic sound and hit albums like 'A Rush of Blood to the Head'"
            },
            new()
            {
                Id = 9,
                Name = "Dua Lipa",
                Description = "British-Albanian singer-songwriter, known for her pop hits 'Don't Start Now' and 'Levitating'"
            }
        ];

        Genres =
        [
            new()
            {
                Id = 1,
                Name = "Pop"
            },
            new()
            {
                Id = 2,
                Name = "R&B"
            },
            new()
            {
                Id = 3,
                Name = "Alternative Pop"
            },
            new()
            {
                Id = 4,
                Name = "Hip-Hop"
            },
            new()
            {
                Id = 5,
                Name = "Rock"
            }
        ];

        ActorGenres = 
        [
            new()
            {
                Id = 1,
                ActorId = 1,
                GenreId = 1
            },
            new()
            {
                Id = 2,
                ActorId = 2,
                GenreId = 1
            },
            new()
            {
                Id = 3,
                ActorId = 3,
                GenreId = 1
            },
            new()
            {
                Id = 4,
                ActorId = 4,
                GenreId = 2
            },
            new()
            {
                Id = 5,
                ActorId = 5,
                GenreId = 3
            },
            new()
            {
                Id = 6,
                ActorId = 6,
                GenreId = 4
            },
            new()
            {
                Id = 7,
                ActorId = 7,
                GenreId = 1
            },
            new()
            {
                Id = 8,
                ActorId = 8,
                GenreId = 5
            },
            new()
            {
                Id = 9,
                ActorId = 9,
                GenreId = 1
            }
        ];

        Albums =
        [
            new()
            {
                Id = 1,
                Name= "Lemonade",
                Date= new DateOnly(2016, 4, 23),
                ActorId = 1
            },
            new()
            {
                Id = 2,
                Name= "Divide (÷)",
                Date= new DateOnly(2017, 3, 3),
                ActorId = 2
            },
            new()
            {
                Id = 3,
                Name= "Multiply (×)",
                Date= new DateOnly(2014, 6, 20),
                ActorId = 2
            },
            new()
            {
                Id = 4,
                Name= "Equals (=)",
                Date= new DateOnly(2021, 10, 29),
                ActorId = 2
            },
            new()
            {
                Id = 5,
                Name= "Midnights",
                Date= new DateOnly(2022, 10, 21),
                ActorId = 3
            },
            new()
            {
                Id = 6,
                Name= "After Hours",
                Date= new DateOnly(2020, 3, 20),
                ActorId = 4
            },
            new()
            {
                Id = 7,
                Name= "Starboy",
                Date= new DateOnly(2016, 11, 25),
                ActorId = 4
            },
            new()
            {
                Id = 8,
                Name= "Dawn FM",
                Date= new DateOnly(2022, 1, 7),
                ActorId = 4
            },
            new()
            {
                Id = 9,
                Name= "Happier Than Ever",
                Date= new DateOnly(2021, 7, 30),
                ActorId = 5
            },
            new()
            {
                Id = 10,
                Name= "Scorpion",
                Date= new DateOnly(2018, 6, 29),
                ActorId = 6
            },
            new()
            {
                Id = 11,
                Name= "Views",
                Date= new DateOnly(2016, 4, 29),
                ActorId = 6
            },
            new()
            {
                Id = 12,
                Name= "Nothing Was the Same",
                Date= new DateOnly(2013, 9, 24),
                ActorId = 6
            },
            new()
            {
                Id = 13,
                Name= "25",
                Date= new DateOnly(2015, 11, 20),
                ActorId = 7
            },
            new()
            {
                Id = 14,
                Name= "A Head Full of Dreams",
                Date= new DateOnly(2015, 12, 4),
                ActorId = 8
            },
            new()
            {
                Id = 15,
                Name= "Mylo Xyloto",
                Date= new DateOnly(2011, 10, 24),
                ActorId = 8
            },
            new() 
            { 
                Id = 16, 
                Name= "Ghost Stories",
                Date= new DateOnly(2014, 5, 16), 
                ActorId = 8 
            },
            new() 
            { 
                Id = 17, 
                Name= "Future Nostalgia",
                Date= new DateOnly(2020, 3, 27), 
                ActorId = 9 
            }
        ];

        Tracks = 
        [
            new() 
            { 
                Id = 1, 
                Number = 1, 
                Name = "Pray You Catch Me",
                AlbumId = 1, 
                Time = TimeSpan.FromSeconds(229) 
            },
            new() 
            { 
                Id = 2, 
                Number = 2, 
                Name = "Hold Up",
                AlbumId = 1, 
                Time = TimeSpan.FromSeconds(261) 
            },
            new() 
            { 
                Id = 3, 
                Number = 3, 
                Name = "Sorry",
                AlbumId = 1, 
                Time = TimeSpan.FromSeconds(224) 
            },
            new() 
            { 
                Id = 4, 
                Number = 4, 
                Name = "Freedom",
                AlbumId = 1, 
                Time = TimeSpan.FromSeconds(265) 
            },
            new() 
            { 
                Id = 5, 
                Number = 1, 
                Name = "Eraser",
                AlbumId = 2, 
                Time = TimeSpan.FromSeconds(228) 
            },
            new() 
            { 
                Id = 6, 
                Number = 2, 
                Name = "Castle on the Hill",
                AlbumId = 2, 
                Time = TimeSpan.FromSeconds(261) 
            },
            new() 
            { 
                Id = 7, 
                Number = 3, 
                Name = "Dive",
                AlbumId = 2, 
                Time = TimeSpan.FromSeconds(197) 
            },
            new() 
            { 
                Id = 8, 
                Number = 4, 
                Name = "Happier",
                AlbumId = 2, 
                Time = TimeSpan.FromSeconds(212) 
            },
            new() 
            { 
                Id = 9, 
                Number = 5, 
                Name = "New Man",
                AlbumId = 2, 
                Time = TimeSpan.FromSeconds(243) 
            },
            new() 
            { 
                Id = 10, 
                Number = 6, 
                Name = "Hearts Don't Break Around Here",
                AlbumId = 2, 
                Time = TimeSpan.FromSeconds(263) 
            },
            new() 
            { 
                Id = 11, 
                Number = 1, 
                Name = "Willow",
                AlbumId = 3, 
                Time = TimeSpan.FromSeconds(211) 
            },
            new() 
            { 
                Id = 12, 
                Number = 2, 
                Name = "Champagne Problems",
                AlbumId = 3, 
                Time = TimeSpan.FromSeconds(254) 
            },
            new() 
            { 
                Id = 13, 
                Number = 3, 
                Name = "Gold Rush",
                AlbumId = 3, 
                Time = TimeSpan.FromSeconds(208) 
            },
            new() 
            { 
                Id = 14, 
                Number = 4, 
                Name = "Tis the Damn Season",
                AlbumId = 3, 
                Time = TimeSpan.FromSeconds(241) 
            },
            new() 
            { 
                Id = 15, 
                Number = 1, 
                Name = "Alone Again",
                AlbumId = 4, 
                Time = TimeSpan.FromSeconds(234) 
            },
            new() 
            { 
                Id = 16, 
                Number = 2, 
                Name = "Too Late",
                AlbumId = 4, 
                Time = TimeSpan.FromSeconds(198) 
            },
            new() 
            {
                Id = 17, 
                Number = 3, 
                Name = "Hardest to Love",
                AlbumId = 4, 
                Time = TimeSpan.FromSeconds(237) 
            },
            new() 
            { 
                Id = 18, 
                Number = 4, 
                Name = "Scared to Live",
                AlbumId = 4, 
                Time = TimeSpan.FromSeconds(200) 
            },
            new() 
            { 
                Id = 19, 
                Number = 5, 
                Name = "Snowchild",
                AlbumId = 4, 
                Time = TimeSpan.FromSeconds(232) 
            },
            new() 
            {
                Id = 20, 
                Number = 1, 
                Name = "Getting Older",
                AlbumId = 5, 
                Time = TimeSpan.FromSeconds(242) 
            },
            new() 
            { 
                Id = 21, 
                Number = 2, 
                Name = "I Didn’t Change My Number",
                AlbumId = 5, 
                Time = TimeSpan.FromSeconds(237) 
            },
            new() 
            { 
                Id = 22, 
                Number = 3, 
                Name = "Billie Bossa Nova",
                AlbumId = 5, 
                Time = TimeSpan.FromSeconds(218) 
            },
            new() 
            {
                Id = 23, 
                Number = 4, 
                Name = "Lost Cause",
                AlbumId = 5, 
                Time = TimeSpan.FromSeconds(240) 
            },
            new() 
            { 
                Id = 24, 
                Number = 1, 
                Name = "Survival",
                AlbumId = 6, 
                Time = TimeSpan.FromSeconds(200) 
            },
            new() 
            { 
                Id = 25, 
                Number = 2, 
                Name = "Elevate",
                AlbumId = 6, 
                Time = TimeSpan.FromSeconds(265) 
            },
            new() 
            { 
                Id = 26, 
                Number = 3, 
                Name = "In My Feelings",
                AlbumId = 6, 
                Time = TimeSpan.FromSeconds(244) 
            },
            new() 
            { 
                Id = 27, 
                Number = 1, 
                Name = "Hello",
                AlbumId = 7, 
                Time = TimeSpan.FromSeconds(245) 
            },
            new() 
            {
                Id = 28, 
                Number = 2, 
                Name = "Send My Love",
                AlbumId = 7, 
                Time = TimeSpan.FromSeconds(222) 
            },
            new() 
            { 
                Id = 29, 
                Number = 3, 
                Name = "I Miss You",
                AlbumId = 7, 
                Time = TimeSpan.FromSeconds(248) 
            },
            new() 
            { 
                Id = 30, 
                Number = 4, 
                Name = "Water Under the Bridge",
                AlbumId = 7, 
                Time = TimeSpan.FromSeconds(215) 
            },
            new() 
            { 
                Id = 31, 
                Number = 1, 
                Name = "A Head Full of Dreams",
                AlbumId = 8, 
                Time = TimeSpan.FromSeconds(271) 
            },
            new() 
            { 
                Id = 32, 
                Number = 2, 
                Name = "Hymn for the Weekend",
                AlbumId = 8, 
                Time = TimeSpan.FromSeconds(230)
            },
            new() 
            { 
                Id = 33, 
                Number = 3, 
                Name = "Adventure of a Lifetime",
                AlbumId = 8, 
                Time = TimeSpan.FromSeconds(235) 
            },
            new() 
            { 
                Id = 34, 
                Number = 4, 
                Name = "Everglow",
                AlbumId = 8, 
                Time = TimeSpan.FromSeconds(232) 
            },
            new() 
            { 
                Id = 35, 
                Number = 5, 
                Name = "Up&Up",
                AlbumId = 8, 
                Time = TimeSpan.FromSeconds(254) 
            },
            new() 
            { 
                Id = 36, 
                Number = 1, 
                Name = "Don't Start Now",
                AlbumId = 9, 
                Time = TimeSpan.FromSeconds(183) 
            },
            new() 
            { 
                Id = 37, 
                Number = 2, 
                Name = "Physical",
                AlbumId = 9, 
                Time = TimeSpan.FromSeconds(183) 
            },
            new() 
            { 
                Id = 38, 
                Number = 3, 
                Name = "Levitating",
                AlbumId = 9, 
                Time = TimeSpan.FromSeconds(203) 
            },
            new() 
            { 
                Id = 39, 
                Number = 4, 
                Name = "Pretty Please",
                AlbumId = 9, 
                Time = TimeSpan.FromSeconds(209) 
            },
            new() 
            {
                Id = 40,
                Number = 5, 
                Name = "Love Again",
                AlbumId = 9, 
                Time = TimeSpan.FromSeconds(229) 
            },
        ];
    }
}
