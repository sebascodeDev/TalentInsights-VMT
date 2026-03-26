using System;

namespace TalentInsights.Application.Models.Requests.User;

public class GetAllUserRequest
{
    public int? Limit { get; set; }
    public int? Offset { get; set; }
}
