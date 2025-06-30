using AutoMapper;
using Distribuidora.Application.DTOs;
using Distribuidora.Core.Interfaces;

namespace Distribuidora.Application.UseCases.Produto
{
    public class ObterTodosProdutosUseCase
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        private readonly IMapper _mapper;

        public ObterTodosProdutosUseCase(IProdutoRepositorio produtoRepositorio, IMapper mapper)
        {
            _produtoRepositorio = produtoRepositorio;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProdutoDTO>> ExecutarAsync()
        {
            var produtos = await _produtoRepositorio.ObterComCategoriaAsync();
            return _mapper.Map<IEnumerable<ProdutoDTO>>(produtos);
        }
    }
}
