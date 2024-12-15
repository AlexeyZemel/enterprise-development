namespace MediaLibrary.API.Dto;

/// <summary>
/// Dto для альбома
/// </summary>
public class AlbumDto
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
}
