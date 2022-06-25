using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using w2homework.Core.Models;
using w2homework.Service.IServices;

namespace w2homework.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        //Bootcamp eklemek için
        [HttpPost]
        public async Task<IActionResult> AddBootcamp(Bootcamp bootcamp)
        {
            await _adminService.AddBootcamp(bootcamp);
            return Ok();
        }

        //Bootcamp'i iptal etmek için
        [HttpGet]
        public async Task<IActionResult> DeleteBootcamp(int id)
        {
            await _adminService.CancelBootcamp(id);
            return Ok();
        }

        //Adminin yeni kayıt olmuş kullanıcıyı onaylaması için
        [HttpGet]
        public async Task<IActionResult> ConfirmUser(int id)
        {
            await _adminService.ConfirmUser(id);
            return Ok(await _adminService.GetUserById(id)); //Onaylanmış kullancıyı geri döndürür
        }

        //Adminin yeni kayıt olup onaylanmamış kullanıcıları listelemesi için
        [HttpGet]
        public async Task<IActionResult> GetUnconfirmedUsers()
        {
            var list = await _adminService.GetUnconfirmedUsers();
            return Ok(list);
        }

        //Id'si verilen kullanıcıyı silmek için
        [HttpDelete]
        public async Task<IActionResult> DeleteUser(int id)
        {
            await _adminService.RemoveUser(id);
            return Ok();
        }
    }
}
