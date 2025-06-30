using AutoMapper;
using Distribuidora.Application.DTOs;
using Distribuidora.Core.Interfaces;

namespace Distribuidora.Application.UseCases.Cliente
{
    public class AtualizarClienteUseCase
    {
        private readonly IRepositorioGenerico<Distribuidora.Core.Entities.Cliente> _clienteRepositorio;
        private readonly IMapper _mapper;

        public AtualizarClienteUseCase(IRepositorioGenerico<Distribuidora.Core.Entities.Cliente> clienteRepositorio, IMapper mapper)
        {
            _clienteRepositorio = clienteRepositorio;
            _mapper = mapper;
        }

        public async Task ExecutarAsync(UpdateClienteDTO dto)
        {
            var cliente = _mapper.Map<Distribuidora.Core.Entities.Cliente>(dto);
            await _clienteRepositorio.AtualizarAsync(cliente);
        }
    }
}
