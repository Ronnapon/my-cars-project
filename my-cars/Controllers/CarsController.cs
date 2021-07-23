using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_cars.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_cars.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        [HttpPost]
        public IActionResult AddDoctor([FromBody] Car car)
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAllDoctors(string search, string specialization, int page)
        {
            return Ok();
        }

        [HttpGet("{Id}")]
        public IActionResult GetDoctor(int Id)
        { 
            return Ok();
        }

        [HttpPut("{Id}")]
        public IActionResult UpdateDoctor([FromBody] Car car, int Id)
        {      
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteDoctor(int Id)
        {
            return Ok();
        }
    }
}
