using System;
using TalentInsights.Application.Models.DTOs;
using TalentInsights.Application.Models.Requests.User;
using TalentInsights.Application.Models.Responses;

namespace TalentInsights.Application.Interfaces.Services;

public interface IUserService
{
    public GenericResponse<UserDto> Create(CreateUserRequest model);
}
