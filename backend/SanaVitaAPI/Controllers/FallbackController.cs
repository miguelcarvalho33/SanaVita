using Microsoft.AspNetCore.Mvc;
using SanaVitaAPI.Services;

namespace SanaVitaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FallbackController : ControllerBase
    {
        private readonly FallbackState _fallback;

        public FallbackController(FallbackState fallback)
        {
            _fallback = fallback;
        }

        [HttpGet("status")]
        public IActionResult Status() => Ok(new
        {
            status = _fallback.IsFallbackEnabled ? "Degraded" : "Normal",
            message = _fallback.Status()
        });

        [HttpPost("enable")]
        public IActionResult Enable()
        {
            _fallback.Activate();
            return Ok("Modo degradado ativado.");
        }

        [HttpPost("disable")]
        public IActionResult Disable()
        {
            _fallback.Deactivate();
            return Ok("Modo degradado desativado.");
        }
    }
}
