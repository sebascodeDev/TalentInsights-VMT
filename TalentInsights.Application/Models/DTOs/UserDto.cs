using System;

namespace TalentInsights.Application.Models.DTOs;

public class UserDto
{
    public Guid UserId { get; set; }
    public string Username { get; set; } = null!;
    public string FullName { get; set; } = null!;
    public string? ProfilePictureUrl { get; set; }
    public bool IsPremium { get; set; }
    public DateTime JoinedAt { get; set; }

}
