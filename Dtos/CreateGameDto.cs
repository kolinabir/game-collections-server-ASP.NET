using System.ComponentModel.DataAnnotations;

namespace firstProject.Dtos;

public record class CreateGameDto(
    [Required][StringLength(30)] string Name,
    [Required][StringLength(20)] string Genre,
    [Range(1, 100)] decimal Price,
    [Required] DateOnly ReleaseDate);
