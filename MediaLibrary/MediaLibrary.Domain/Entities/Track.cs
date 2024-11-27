using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediaLibrary.Domain.Entities;

/// <summary>
/// Трек в альбоме
/// </summary>
[Table("track")]
public class Track
{
    /// <summary>
    ///  Идентификатор трека
    /// </summary>
    [Key]
    [Column("id")]
    public required int Id { get; set; }

    /// <summary>
    /// Номер трека в альбоме
    /// </summary>
    [Column("number")]
    [Required]
    public required int Number { get; set; }

    /// <summary>
    /// Название трека
    /// </summary>
    [Column("name")]
    [Required]
    public required string Name { get; set; }

    /// <summary>
    /// Идентификатор альбома трека
    /// </summary>
    [Column("album_id")]
    [Required]
    public required int AlbumId { get; set; }

    /// <summary>
    /// Продолжительность трека
    /// </summary>
    [Column("time")]
    [Required]
    public required TimeSpan Time { get; set; }
}
