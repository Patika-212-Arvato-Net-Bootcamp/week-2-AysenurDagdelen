using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using w2homework.Core.Models;
using w2homework.Service.IServices;

namespace w2homework.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        //Yeni üye kaydı için
        [HttpPost]
        public async Task<IActionResult> SignUp (User user)
        {
            await _userService.AddUser(user);
            return Ok(user.FirstName);
        }
    }
}
