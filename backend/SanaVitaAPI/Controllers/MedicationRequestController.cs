using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SanaVitaAPI.Interfaces;
using SanaVitaAPI.Models;
using SanaVitaAPI.Repositories;

namespace SanaVitaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin,Caregiver,Patient")]
    public class MedicationRequestController : ControllerBase
    {
        private readonly IMedicationRequestRepository _repository;

        public MedicationRequestController(IMedicationRequestRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Caregiver")]
        public async Task<IActionResult> GetAll() =>
            Ok(await _repository.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var item = await _repository.GetByIdAsync(id);
            return item == null ? NotFound() : Ok(item);
        }

        [HttpPost]
        [Authorize(Roles = "Patient,Caregiver")]
        public async Task<IActionResult> Create([FromBody] MedicationRequest request)
        {
            // Validação específica do campo RecipientName
            if (!request.IsForSelf && string.IsNullOrWhiteSpace(request.RecipientName))
            {
                return BadRequest("RecipientName é obrigatório se o pedido não for para o próprio.");
            }

            await _repository.AddAsync(request);
            return Ok(request);
        }

        [HttpPut("{id}/approve")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Approve(int id)
        {
            await _repository.ApproveAsync(id);
            return Ok($"Request {id} approved.");
        }

        [HttpPut("{id}/reject")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Reject(int id, [FromBody] string reason)
        {
            await _repository.RejectAsync(id, reason);
            return Ok($"Request {id} rejected.");
        }
    }
}
