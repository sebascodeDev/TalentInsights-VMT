using System;
using TalentInsights.Application.Models.DTOs;
using TalentInsights.Application.Models.Requests.User;
using TalentInsights.Application.Models.Responses;
using TalentInsights.Shared.Helpers;
using TalentInsights.Shared;
using TalentInsights.Application.Interfaces.Services;
using TalentInsights.Application.Helpers;


namespace TalentInsights.Application.Services;

public class UserService(Cache<UserDto> cache) : IUserService
{
    public GenericResponse<UserDto> Create(CreateUserRequest model)
    {
        var user = new UserDto
        {
            UserId = Guid.NewGuid(),
            Username = model.Username,
            FullName = model.FullName,
            ProfilePictureUrl = model.ProfilePictureUrl,
            IsPremium = false, // Por defecto al crear
            JoinedAt = DateTimeHelper.UtcNow(),
        };

        cache.Add(user.UserId.ToString(), user);

        return ResponseHelper.Create(user);
    }
}
