using Microsoft.AspNetCore.Mvc;
using SanaVitaAPI.Interfaces;
using SanaVitaAPI.Models;
using SanaVitaAPI.Repositories;

namespace SanaVitaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdministrationController : ControllerBase
    {
        private readonly IAdministrationRepository _repository;

        public AdministrationController(IAdministrationRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() =>
            Ok(await _repository.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _repository.GetByIdAsync(id);
            return result == null ? NotFound() : Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Record([FromBody] AdministrationEvent admin)
        {
            await _repository.RecordAsync(admin);
            return Ok(admin);
        }
    }
}
