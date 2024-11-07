namespace MediaLibrary.Domain.Entities;

/// <summary>
/// Сущность для связи Актёры-Жанры
/// </summary>
public class ActorGenre
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public required int Id { get; set; }
    /// <summary>
    /// Идентификатор Актёра
    /// </summary>
    public required int ActorId { get; set; }

    /// <summary>
    /// Идентификатор жанра
    /// </summary>
    public required int GenreId { get; set; }
}
