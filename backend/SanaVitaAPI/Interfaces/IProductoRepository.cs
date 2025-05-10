using SanaVitaAPI.Models;

namespace SanaVitaAPI.Repositories
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> GetAllAsync();
        Task<Produto?> GetByIdAsync(int id);
    }
}
