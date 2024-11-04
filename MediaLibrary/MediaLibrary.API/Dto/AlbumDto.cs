namespace MediaLibrary.API.Dto;

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
    public required DateTime Date { get; set; }
}
