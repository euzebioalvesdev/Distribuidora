using Distribuidora.Core.Entities;

namespace Distribuidora.Core.Interfaces
{
    public interface IProdutoRepositorio : IRepositorioGenerico<Produto>
    {
        Task<IEnumerable<Produto>> ObterComCategoriaAsync();
    }

    public interface IVendaRepositorio : IRepositorioGenerico<Venda>
    {
        Task<Venda?> ObterDetalhesAsync(int id);
    }
}
