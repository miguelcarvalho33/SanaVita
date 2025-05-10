using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SanaVitaAPI.Interfaces;
using SanaVitaAPI.Models;

namespace SanaVitaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Caregiver,Patient")]
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
        [Authorize(Roles = "Caregiver")]
        public async Task<IActionResult> Create([FromBody] MedicationSchedule schedule)
        {
            await _repository.AddAsync(schedule);
            return Ok(schedule);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Caregiver")]
        public async Task<IActionResult> Update(int id, [FromBody] MedicationSchedule schedule)
        {
            if (id != schedule.Id) return BadRequest("ID mismatch");
            await _repository.UpdateAsync(schedule);
            return Ok(schedule);
        }
    }
}
