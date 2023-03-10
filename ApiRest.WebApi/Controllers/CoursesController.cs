using ApiRest.Domain.Entities;
using ApiRest.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ApiRest.WebApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICoursesRepository _coursesRepository;

        public CoursesController(ICoursesRepository coursesRepository)
        {
            _coursesRepository = coursesRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Register(Courses course)
        {
            if (course == null)
            {
                return BadRequest($"{course} can't be null!!");
            }

            await _coursesRepository.Insert(course);

            return Ok("Course registered as successful.");
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _coursesRepository.GetAll();
            return Ok(result.ToList());   
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if (id == 0)
            {
                return BadRequest($"{id} can't be null");
            }

            var result = await _coursesRepository.GetById(id);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Modify(int id, [FromBody] Courses course)
        {
            if (course == null || id == 0 )
            {
                return BadRequest($"{course} or {id} can't be null!!");
            }
            course.Id = id; // no need to send id by request

            await _coursesRepository.Update(id, course);
            return Ok("Course updated as successful.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest($"{id} can't be null!!");
            }

            await _coursesRepository.Delete(id);
            return Ok("Course deleted as successful.");
        }
    }
}
