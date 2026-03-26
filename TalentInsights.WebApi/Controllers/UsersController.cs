using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TalentInsights.Application.Helpers;
using TalentInsights.Application.Interfaces.Services;
using TalentInsights.Application.Models.Requests.User;

namespace TalentInsights.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController(IUserService userService) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUserRequest model)
        {
            var rsp = userService.Create(model);
            return Ok(rsp);
        }

        [HttpGet]
        public  async Task<IActionResult> Get([FromBody] GetAllUserRequest model)
        {
            return Ok(ResponseHelper.Create(userService.Get(model.Limit ?? 0, model.Offset ?? 0)));
        }
    }
}
