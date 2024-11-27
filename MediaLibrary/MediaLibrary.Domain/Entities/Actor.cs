using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediaLibrary.Domain.Entities;

/// <summary>
/// Музыкальный исполнитель
/// </summary>
[Table("actor")]
public class Actor
{
    /// <summary>
    /// Идентификатор исполнителя
    /// </summary>
    [Key]
    [Column("id")]
    public required int Id { get; set; }

    /// <summary>
    /// Имя исполнителя
    /// </summary>
    [Column("name")]
    [Required]
    public required string Name { get; set; }

    /// <summary>
    /// Описание исполнителя 
    /// </summary>
    [Column("description")]
    [Required]
    public required string Description { get; set; }
}
