using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TalentInsights.Domain.Database;

namespace TalentInsights.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly TalentDbContext _dbContext;

        public TestController(TalentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("usuarios")]
        public async Task<IActionResult> GetUsuarios()
        {
            var lista = await _dbContext.Collaborators.ToListAsync();
            return Ok(lista);
        }


        
    }
}
