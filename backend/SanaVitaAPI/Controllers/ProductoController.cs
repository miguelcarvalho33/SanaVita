using Microsoft.AspNetCore.Mvc;
using SanaVitaAPI.Repositories;

namespace SanaVitaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository _repository;

        public ProdutoController(IProdutoRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Produto
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var produtos = await _repository.GetAllAsync();
            return Ok(produtos);
        }

        // GET: api/Produto/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var produto = await _repository.GetByIdAsync(id);
            if (produto == null)
                return NotFound();

            return Ok(produto);
        }
    }
}
