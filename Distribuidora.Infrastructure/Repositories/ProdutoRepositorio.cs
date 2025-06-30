using Distribuidora.Core.Entities;
using Distribuidora.Core.Interfaces;
using Distribuidora.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Distribuidora.Infrastructure.Repositories
{
    public class ProdutoRepositorio : RepositorioGenerico<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Produto>> ObterComCategoriaAsync()
        {
            return await _context.Produtos.Include(p => p.Categoria).ToListAsync();
        }
    }
}
