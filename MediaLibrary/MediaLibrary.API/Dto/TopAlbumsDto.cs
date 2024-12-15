namespace MediaLibrary.API.Dto;

/// <summary>
/// Dto для альбома с продолжительностью треков в нём
/// </summary>
public class TopAlbumsDto
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
    /// Продолжительность треков в альбоме
    /// </summary>
    public required double TotalTime { get; set; }
}
