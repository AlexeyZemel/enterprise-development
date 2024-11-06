namespace MediaLibrary.API.Dto;

/// <summary>
/// Dto для продолжительности альбомов
/// </summary>
public class TimeAlbumDto
{
    /// <summary>
    /// Минимальная продолжительность альбомов
    /// </summary>
    public required double MinTime { get; set; }

    /// <summary>
    /// Средняя продолжительность альбомов
    /// </summary>
    public required double AvgTime { get; set; }

    /// <summary>
    /// Максимальная продолжительность альбомов
    /// </summary>
    public required double MaxTime { get; set; }
}
