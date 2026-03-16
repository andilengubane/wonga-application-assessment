using MediatR;
using Microsoft.AspNetCore.Mvc;
using WongaApplication.Domain.Entities;
using WongaApplication.Application.Command.UserCommand;
using WongaApplication.Application.Quiries.UserQuiries;

namespace WongaApplication.Api.Controllers
{
    [ApiController]
    public class UserController(ISender sender, ILogger<UserController> _logger) : ControllerBase
    {
       [HttpGet("api/getallusersasync")]
        public async Task<IActionResult> GetAllUserAsync()
        {
            var result = await sender.Send(new GetAllUsersQuery());
            return Ok(result);
        }

        [HttpGet("api/getuserbyidasync")]
        public async Task<IActionResult> GetUserByIdAsync(string username, string password)
        {
            var result = await sender.Send(new GetUserByIdQuery(password, username));
            if (result is not null)
            {
                _logger.LogInformation($"User details: {result}");
                return Ok(result);
            }
            return StatusCode(500, new { message = "user not found." });
        }

        [HttpPost("api/adduserasync")]
        public async Task<IActionResult> AddUserAsync([FromBody] UserEntitiy userEntitiy)
        {
            var result = await sender.Send(new AddUserCommand(userEntitiy));
            _logger.LogInformation($"Add user details {DateTime.Today}: {result}");
            return Ok(result);
        }
    }
}
