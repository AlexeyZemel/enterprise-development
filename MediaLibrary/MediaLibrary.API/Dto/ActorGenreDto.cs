namespace MediaLibrary.API.Dto;

public class ActorGenreDto
{
    /// <summary>
    /// Идентификатор Актёра
    /// </summary>
    public required int ActorId { get; set; }

    /// <summary>
    /// Идентификатор жанра
    /// </summary>
    public required int GenreId { get; set; }
    
}
