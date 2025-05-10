using Microsoft.AspNetCore.Mvc;
using SanaVitaAPI.Interfaces;
using SanaVitaAPI.Models;
using SanaVitaAPI.Repositories;

namespace SanaVitaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicationRequestController : ControllerBase
    {
        private readonly IMedicationRequestRepository _repository;

        public MedicationRequestController(IMedicationRequestRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() =>
            Ok(await _repository.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var item = await _repository.GetByIdAsync(id);
            return item == null ? NotFound() : Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] MedicationRequest request)
        {
            await _repository.AddAsync(request);
            return Ok(request);
        }

        [HttpPut("{id}/approve")]
        public async Task<IActionResult> Approve(int id)
        {
            await _repository.ApproveAsync(id);
            return Ok($"Request {id} approved.");
        }

        [HttpPut("{id}/reject")]
        public async Task<IActionResult> Reject(int id, [FromBody] string reason)
        {
            await _repository.RejectAsync(id, reason);
            return Ok($"Request {id} rejected.");
        }
    }
}
