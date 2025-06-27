using Bai3.Models;
using Bai3.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Bai3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiController : ControllerBase
    {
        private readonly ILoaiServices _loaiServices;
        public LoaiController(ILoaiServices loaiServices)
        {
            _loaiServices = loaiServices;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var list = _loaiServices.GetALl();
                return Ok(new
                {
                    status = 200,
                    data = list
                });
            }
            catch(Exception ex)
            {
                return Ok(new
                {
                    status = 400,
                    data = "Server Err "+ex
                });
            }
            
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var loai = _loaiServices.GetById(id);
                if (loai != null)
                {
                    return Ok(new
                    {
                        status = 200,
                        data = loai
                    });
                }
                return NotFound(new
                {
                    status = 404
                });
            }
            catch(Exception ex)
            {
                return Ok(new
                {
                    status = 500,
                    data = "Server Err " + ex
                });
            }
            
        }


        [HttpPost]
        public IActionResult Create(Loai loai)
        {
            try
            {
                var loaiCreate = _loaiServices.Create(loai);
                if (loaiCreate != null)
                {
                    return Ok(new
                    {
                        status = 200,
                        data = loaiCreate
                    });
                }
                return BadRequest(new
                {
                    status = 400,
                    data = "Error"
                });
            }
            catch(Exception ex)
            {
                return BadRequest(new
                {
                    status = 400,
                    data = "Error"
                });
            }         
        }

        [HttpPut]
        public IActionResult Update(Loai loai)
        {
            try
            {
                _loaiServices.Update(loai);
                return Ok(new
                {
                    status = 200
                });
            }catch(Exception ex)
            {
                return BadRequest(new
                {
                    status = 400,
                    data = "Error"
                });
            }
        }
    }
}
