using System;
using System.ComponentModel.DataAnnotations;
using TalentInsights.Shared.Constants;

namespace TalentInsights.Application.Models.Requests.User;

public class CreateUserRequest
{
    [Required(ErrorMessage = ValidationConstants.REQUIRED)]
    [MaxLength(50, ErrorMessage = ValidationConstants.MAX_LENGTH)]
    [MinLength(3, ErrorMessage = ValidationConstants.MIN_LENGTH)]
    public string Username { get; set; } = null!;

    [Required(ErrorMessage = ValidationConstants.REQUIRED)]
    [EmailAddress(ErrorMessage = "Email inválido")] // Validación extra para correos
    [MaxLength(150, ErrorMessage = ValidationConstants.MAX_LENGTH)]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = ValidationConstants.REQUIRED)]
    [MinLength(8, ErrorMessage = ValidationConstants.MIN_LENGTH)]
    [MaxLength(100, ErrorMessage = ValidationConstants.MAX_LENGTH)]
    public string Password { get; set; } = null!;

    [Required(ErrorMessage = ValidationConstants.REQUIRED)]
    [MaxLength(150, ErrorMessage = ValidationConstants.MAX_LENGTH)]
    [MinLength(10, ErrorMessage = ValidationConstants.MIN_LENGTH)]
    public string FullName { get; set; } = null!;

    [MaxLength(500, ErrorMessage = ValidationConstants.MAX_LENGTH)]
    public string? ProfilePictureUrl { get; set; }

    [Required(ErrorMessage = ValidationConstants.REQUIRED)]
    public DateTime BirthDate { get; set; }
}
