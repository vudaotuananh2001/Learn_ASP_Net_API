using Bai3.Models;
using Bai3.Repository;
using Bai3.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bai3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HangHoaController : ControllerBase
    {
        private readonly IHangHoaService _IHangHoaService;
        public HangHoaController(IHangHoaService hangHoaService)
        {
            _IHangHoaService = hangHoaService;
        }

        [HttpGet]
        public IActionResult GetAll(string? search)
        {
            try
            {
                var list = _IHangHoaService.GetAll(search).ToList();
                return Ok(new {
                    status = 200,
                    data = list
                });
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
            
        }

        [HttpPost]
        public IActionResult Create(HangHoa hangHoa)
        {
            try
            {
                var x = _IHangHoaService.Create(hangHoa);
                if(hangHoa != null)
                {
                    return Ok(new
                    {
                        status = 200,
                        data = x
                    });
                }
                return BadRequest();

            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
