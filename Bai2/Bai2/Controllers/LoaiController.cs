using Bai2.Data;
using Bai2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bai2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiController : ControllerBase
    {
        private readonly MyDBContext _myDBContext;

        public LoaiController(MyDBContext myDBContext)
        {
            _myDBContext = myDBContext;
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            var listLoai = _myDBContext.Loais.ToList();
            return Ok(listLoai);
        }

        [HttpGet("{id}")]
        public IActionResult GetByid(int id)
        {
            var Loai = _myDBContext.Loais.SingleOrDefault(x => x.MaLoai == id);
            if (Loai != null)
            {
                return Ok(Loai);
            }
            return NotFound();
        }

        [HttpPut]
        public IActionResult UpdateById(Loai loai, int id)
        {
            var Loai = _myDBContext.Loais.SingleOrDefault(x => x.MaLoai == id);
            if (Loai != null)
            {
                Loai.TenLoai = loai.TenLoai;
                _myDBContext.SaveChanges();
                return Ok(Loai);
            }
            return NotFound();
        }

        [HttpPost("{id}")]
       
        public IActionResult Create(Loai loai)
        {
            try
            {
                var loaiCreate = new Loai
                {
                    TenLoai = loai.TenLoai
                };

                _myDBContext.Add(loaiCreate);
                _myDBContext.SaveChanges();
                return Ok(loaiCreate);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
