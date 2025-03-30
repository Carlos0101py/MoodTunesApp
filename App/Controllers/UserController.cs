using Microsoft.AspNetCore.Mvc;
using MoodTunesApp.App.DTOs;
using MoodTunesApp.App.Services;

namespace MoodTunesApp.App.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class UserController : Controller
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public async Task<ActionResult> CreateAccount([FromBody] UserDTO userDTO)
        {
            try
            {
                var response = await _userService.CreateUser(userDTO);
                return response.Success ? Ok(response) : BadRequest(response);
            }   
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}