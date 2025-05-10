using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SanaVitaAPI.Interfaces;
using SanaVitaAPI.Models;

namespace SanaVitaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Patient,Caregiver")]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationRepository _repository;

        public NotificationController(INotificationRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() =>
            Ok(await _repository.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var notif = await _repository.GetByIdAsync(id);
            return notif == null ? NotFound() : Ok(notif);
        }

        [HttpPost]
        [Authorize(Roles = "Caregiver")]
        public async Task<IActionResult> Create([FromBody] Notification notification)
        {
            await _repository.AddAsync(notification);
            return Ok(notification);
        }

        [HttpPost("mark-as-read/{id}")]
        public async Task<IActionResult> MarkAsRead(int id)
        {
            await _repository.MarkAsReadAsync(id);
            return Ok($"Notification {id} marked as read.");
        }
    }
}
