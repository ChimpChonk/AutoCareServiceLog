using AutoCareBackend.Repo.Model;
using AutoCareBackend.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AutoCareBackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<ActionResult<User>> Create([FromBody] User user)
        {
            try
            {
                if(await _userService.CreateUser(user) != null)
                {
                    return Ok(user);
                }
                else
                {
                    return StatusCode(422, "Not found");
                }
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
    
}