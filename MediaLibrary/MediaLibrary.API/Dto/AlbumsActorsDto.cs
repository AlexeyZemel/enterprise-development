namespace MediaLibrary.API.Dto;

/// <summary>
/// Dto для исполнителя с количеством альбомов
/// </summary>
public class AlbumsActorsDto
{
    /// <summary>
    /// Имя исполнителя
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Описание исполнителя 
    /// </summary>
    public required string Description { get; set; }

    /// <summary>
    /// Количество альбомов у исполнителя 
    /// </summary>
    public required int AlbumsCount { get; set; }
}
