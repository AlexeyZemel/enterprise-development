using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediaLibrary.Domain.Entities;

/// <summary>
/// Альбом исполнителя
/// </summary>
[Table("album")]
public class Album
{
    /// <summary>
    /// Идентификатор альбома
    /// </summary>
    [Key]
    [Column("id")]
    public required int Id { get; set; }

    /// <summary>
    /// Идентификатор исполнителя
    /// </summary>
    [Column("actor_id")]
    [Required]
    public required int ActorId { get; set; }

    /// <summary>
    /// Название Альбома
    /// </summary>
    [Column("name")]
    [Required]
    public required string Name { get; set; }

    /// <summary>
    /// Дата релиза
    /// </summary>
    [Column("date")]
    [Required]
    public required DateTime Date { get; set; }
}
