using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediaLibrary.Domain.Entities;

/// <summary>
/// Жанр композиции
/// </summary>
[Table("genre")]
public class Genre
{
    /// <summary>
    /// Идентификатор жанра
    /// </summary>
    [Key]
    [Column("id")]
    public required int Id { get; set; }

    /// <summary>
    /// Название жанра
    /// </summary>
    [Column("name")]
    [Required]
    public required string Name { get; set; }
}
