using AutoMapper;
using Distribuidora.Application.DTOs;
using Distribuidora.Core.Interfaces;

namespace Distribuidora.Application.UseCases.Cliente
{
    public class ObterClientePorIdUseCase
    {
        private readonly IRepositorioGenerico<Distribuidora.Core.Entities.Cliente> _clienteRepositorio;
        private readonly IMapper _mapper;

        public ObterClientePorIdUseCase(IRepositorioGenerico<Distribuidora.Core.Entities.Cliente> clienteRepositorio, IMapper mapper)
        {
            _clienteRepositorio = clienteRepositorio;
            _mapper = mapper;
        }

        public async Task<ClienteDTO?> ExecutarAsync(int id)
        {
            var cliente = await _clienteRepositorio.ObterPorIdAsync(id);
            return cliente is null ? null : _mapper.Map<ClienteDTO>(cliente);
        }
    }
}
