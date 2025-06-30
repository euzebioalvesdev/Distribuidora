using AutoMapper;
using Distribuidora.Application.DTOs;
using Distribuidora.Core.Interfaces;

namespace Distribuidora.Application.UseCases.Produto
{
    public class ObterProdutoPorIdUseCase
    {
        private readonly IRepositorioGenerico<Distribuidora.Core.Entities.Produto> _produtoRepositorio;
        private readonly IMapper _mapper;

        public ObterProdutoPorIdUseCase(IRepositorioGenerico<Distribuidora.Core.Entities.Produto> produtoRepositorio, IMapper mapper)
        {
            _produtoRepositorio = produtoRepositorio;
            _mapper = mapper;
        }

        public async Task<ProdutoDTO?> ExecutarAsync(int id)
        {
            var produto = await _produtoRepositorio.ObterPorIdAsync(id);
            return produto is null ? null : _mapper.Map<ProdutoDTO>(produto);
        }
    }
}
