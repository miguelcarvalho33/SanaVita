﻿using Microsoft.EntityFrameworkCore;
using SanaVitaAPI.Data;
using SanaVitaAPI.Models;

namespace SanaVitaAPI.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;

        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Produto>> GetAllAsync()
            => await _context.Produtos
                .Include(p => p.Embalagems)
                .Include(p => p.LnkProdAtcs)
                    .ThenInclude(link => link.AtcCodNavigation)
                .ToListAsync();

        public async Task<Produto?> GetByIdAsync(int id)
            => await _context.Produtos
                .Include(p => p.Embalagems)
                .Include(p => p.LnkProdAtcs)
                    .ThenInclude(link => link.AtcCodNavigation)
                .FirstOrDefaultAsync(p => p.ProdId == id);
    }
}
