﻿namespace MediaLibrary.API.Dto;

/// <summary>
/// Dto для исполнителя
/// </summary>
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
