using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using w2homework.Service.IServices;

namespace w2homework.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BootcampController : ControllerBase
    {
        private readonly IBootcampService _bootcampService;

        public BootcampController(IBootcampService bootcampService)
        {
            _bootcampService = bootcampService;
        }

        //Tüm bootcamp'leri listelemek için
        [HttpGet]
        public async Task<IActionResult> GetBootcamps()
        {
            return Ok(await _bootcampService.GetBootcamps());
        }

        //Aktif bootcamp'leri listelemek için
        [HttpGet]
        public async Task<IActionResult> GetActiveBootcamps()
        {            
            return Ok(await _bootcampService.GetBootcampsByActiveFilter(true));
        }

        //Pasif bootcamp'leri listelemek için
        [HttpGet]
        public async Task<IActionResult> GetPassiveBootcamps()
        {
            return Ok(await _bootcampService.GetBootcampsByActiveFilter(false));
        }

        //Id'ye göre bootcamp getirmek için
        [HttpGet]
        public async Task<IActionResult> GetBootcampById(int id)
        {
            return Ok(await _bootcampService.GetBootcampById(id));
        }

        //Id'si verilen kullanıcıyı Id'si verilen bootcamp'in katılımcı listesine eklemek için
        [HttpGet]
        public async Task<IActionResult> JoinBootcamp(int bootcampId, int userId)
        {
            await _bootcampService.JoinBootcamp(bootcampId, userId);
            return Ok();
        }
    }
}
