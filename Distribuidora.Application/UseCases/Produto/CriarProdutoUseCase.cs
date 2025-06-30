using AutoMapper;
using Distribuidora.Application.DTOs;
using Distribuidora.Core.Interfaces;

namespace Distribuidora.Application.UseCases.Produto
{
    public class CriarProdutoUseCase
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        private readonly IMapper _mapper;

        public CriarProdutoUseCase(IProdutoRepositorio produtoRepositorio, IMapper mapper)
        {
            _produtoRepositorio = produtoRepositorio;
            _mapper = mapper;
        }

        public async Task<ProdutoDTO> ExecutarAsync(CreateProdutoDTO dto)
        {
            var entidade = _mapper.Map<Distribuidora.Core.Entities.Produto>(dto);
            var criado = await _produtoRepositorio.CriarAsync(entidade);
            return _mapper.Map<ProdutoDTO>(criado);
        }
    }
}
