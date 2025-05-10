using Microsoft.AspNetCore.Mvc;
using SanaVitaAPI.Interfaces;
using SanaVitaAPI.Models;
using SanaVitaAPI.Repositories;

namespace SanaVitaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
