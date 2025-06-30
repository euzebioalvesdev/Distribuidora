using AutoMapper;
using Distribuidora.Application.DTOs;
using Distribuidora.Core.Interfaces;

namespace Distribuidora.Application.UseCases.Produto
{
    public class AtualizarProdutoUseCase
    {
        private readonly IRepositorioGenerico<Distribuidora.Core.Entities.Produto> _produtoRepositorio;
        private readonly IMapper _mapper;

        public AtualizarProdutoUseCase(IRepositorioGenerico<Distribuidora.Core.Entities.Produto> produtoRepositorio, IMapper mapper)
        {
            _produtoRepositorio = produtoRepositorio;
            _mapper = mapper;
        }

        public async Task ExecutarAsync(UpdateProdutoDTO dto)
        {
            var cliente = _mapper.Map<Distribuidora.Core.Entities.Produto>(dto);
            await _produtoRepositorio.AtualizarAsync(cliente);
        }
    }
}
