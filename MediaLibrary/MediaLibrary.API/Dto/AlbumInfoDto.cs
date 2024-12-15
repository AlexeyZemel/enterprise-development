namespace MediaLibrary.API.Dto;

/// <summary>
/// Dto для альбома с количеством треков
/// </summary>
public class AlbumInfoDto
{
    /// <summary>
    /// Идентификатор исполнителя
    /// </summary>
    public required int ActorId { get; set; }

    /// <summary>
    /// Название Альбома
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Дата релиза
    /// </summary>
    public required DateOnly Date { get; set; }

    /// <summary>
    /// Количество треков в альбоме
    /// </summary>
    public required int TrackCount { get; set; }
}
