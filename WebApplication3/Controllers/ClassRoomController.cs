using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassRoomController : ControllerBase
    {
        private readonly PctoDbContext _ctx;
        public ClassRoomController(PctoDbContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_ctx.ClassRooms.ToList());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetStudentsByClassRoom(int id)
        {
            var result = _ctx.Students.Where(s => s.ClassRoomId == id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create(ClassRoom entity)
        {
            _ctx.ClassRooms.Add(entity);
            _ctx.SaveChanges();
            return Ok();
        }
    }
}
