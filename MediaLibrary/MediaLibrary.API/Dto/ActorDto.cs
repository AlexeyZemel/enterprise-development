namespace MediaLibrary.API.Dto;

public class ActorDto
{
    /// <summary>
    /// Имя исполнителя
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Описание исполнителя 
    /// </summary>
    public required string Description { get; set; }
}
