using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediaLibrary.Domain.Entities;

/// <summary>
/// Сущность для связи Актёры-Жанры
/// </summary>
[Table("actor_genre")] 
public class ActorGenre
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    [Key]
    [Column("id")]
    public required int Id { get; set; }

    /// <summary>
    /// Идентификатор Актёра
    /// </summary>
    [Column("actor_id")]
    [Required]
    public required int ActorId { get; set; }

    /// <summary>
    /// Идентификатор жанра
    /// </summary>
    [Column("genre_id")]
    [Required]
    public required int GenreId { get; set; }
}
