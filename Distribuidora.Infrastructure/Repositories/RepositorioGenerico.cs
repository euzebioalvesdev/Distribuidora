using Distribuidora.Core.Interfaces;
using Distribuidora.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Distribuidora.Infrastructure.Repositories
{
    public class RepositorioGenerico<T> : IRepositorioGenerico<T> where T : class
    {
        protected readonly AppDbContext _context;

        public RepositorioGenerico(AppDbContext context)
        {
            _context = context;
        }

        public async Task<T> CriarAsync(T entidade)
        {
            _context.Set<T>().Add(entidade);
            await _context.SaveChangesAsync();
            return entidade;
        }

        public async Task AtualizarAsync(T entidade)
        {
            _context.Set<T>().Update(entidade);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> ObterTodosAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T?> ObterPorIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task RemoverAsync(int id)
        {
            var entidade = await ObterPorIdAsync(id);
            if (entidade is not null)
            {
                _context.Set<T>().Remove(entidade);
                await _context.SaveChangesAsync();
            }
        }
    }
}
