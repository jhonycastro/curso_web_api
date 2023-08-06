using Core.Services.Implementations;
using Core.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var _service2 = new StudentService();
            var dtos = _service.GetAll();
            return Ok();
        }
    }
}
