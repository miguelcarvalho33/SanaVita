using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SanaVitaAPI.Repositories;

namespace SanaVitaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin,Pharmacist,Caregiver,Patient")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository _repository;

        public ProdutoController(IProdutoRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Produto
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll()
        {
            var produtos = await _repository.GetAllAsync();

            var result = produtos.Select(p => new
            {
                Id = p.ProdId,
                Nome = p.Nome,
                Dosagem = p.Dosagem,
                Marca = p.Marca,
                Modelo = p.Modelo,
                ReferenceUrl = p.ReferenceUrl,
                AtcCodes = p.LnkProdAtcs
                    .Where(l => l.AtcCodNavigation != null)
                    .Select(l => l.AtcCodNavigation!.AtcCod)
                    .Distinct()
                    .ToList()
            });

            return Ok(result);
        }

        // GET: api/Produto/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var produto = await _repository.GetByIdAsync(id);
            if (produto == null) return NotFound();

            var result = new
            {
                Id = produto.ProdId,
                Nome = produto.Nome,
                Dosagem = produto.Dosagem,
                Marca = produto.Marca,
                Modelo = produto.Modelo,
                ReferenceUrl = produto.ReferenceUrl,
                AtcCodes = produto.LnkProdAtcs
                    .Where(l => l.AtcCodNavigation != null)
                    .Select(l => l.AtcCodNavigation!.AtcCod)
                    .Distinct()
                    .ToList()
            };

            return Ok(result);
        }
    }
}
