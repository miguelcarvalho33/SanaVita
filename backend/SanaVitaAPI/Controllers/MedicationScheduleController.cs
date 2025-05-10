using Microsoft.AspNetCore.Mvc;
using SanaVitaAPI.Interfaces;
using SanaVitaAPI.Models;
using SanaVitaAPI.Repositories;

namespace SanaVitaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicationScheduleController : ControllerBase
    {
        private readonly IMedicationScheduleRepository _repository;

        public MedicationScheduleController(IMedicationScheduleRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() =>
            Ok(await _repository.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var schedule = await _repository.GetByIdAsync(id);
            return schedule == null ? NotFound() : Ok(schedule);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] MedicationSchedule schedule)
        {
            await _repository.AddAsync(schedule);
            return Ok(schedule);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] MedicationSchedule schedule)
        {
            if (id != schedule.Id) return BadRequest("ID mismatch");
            await _repository.UpdateAsync(schedule);
            return Ok(schedule);
        }
    }
}
