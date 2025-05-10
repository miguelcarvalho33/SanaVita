using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SanaVitaAPI.Interfaces;
using SanaVitaAPI.Models;
using SanaVitaAPI.Repositories;

namespace SanaVitaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;

        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }

        // GET: api/User
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAll()
        {
            var users = await _repository.GetAllAsync();
            return Ok(users);
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _repository.GetByIdAsync(id);
            if (user == null) return NotFound();

            var currentUsername = User.Identity?.Name;
            if (User.IsInRole("Patient") && user.Username != currentUsername)
                return Forbid();

            return Ok(user);
        }

        // DELETE: api/User/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> RightToBeForgotten(int id)
        {
            var user = await _repository.GetByIdAsync(id);
            if (user == null) return NotFound();

            var currentUsername = User.Identity?.Name;
            if (User.IsInRole("Patient") && user.Username != currentUsername)
                return Forbid();

            await _repository.AnonymizeAsync(id);
            return Ok("Utilizador anonimizado com sucesso.");
        }
    }
}
