using Distribuidora.Core.Interfaces;

namespace Distribuidora.Application.UseCases.Produto
{
    public class RemoverProdutoUseCase
    {
        private readonly IRepositorioGenerico<Distribuidora.Core.Entities.Produto> _produtoRepositorio;

        public RemoverProdutoUseCase(IRepositorioGenerico<Distribuidora.Core.Entities.Produto> produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public async Task ExecutarAsync(int id)
        {
            await _produtoRepositorio.RemoverAsync(id);
        }
    }
}
