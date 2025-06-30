using AutoMapper;
using Distribuidora.Application.DTOs;
using Distribuidora.Core.Interfaces;

namespace Distribuidora.Application.UseCases.Cliente
{
    public class ObterTodosClientesUseCase
    {
        private readonly IRepositorioGenerico<Distribuidora.Core.Entities.Cliente> _clienteRepositorio;
        private readonly IMapper _mapper;

        public ObterTodosClientesUseCase(IRepositorioGenerico<Distribuidora.Core.Entities.Cliente> clienteRepositorio, IMapper mapper)
        {
            _clienteRepositorio = clienteRepositorio;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ClienteDTO>> ExecutarAsync()
        {
            var clientes = await _clienteRepositorio.ObterTodosAsync();
            return _mapper.Map<IEnumerable<ClienteDTO>>(clientes);
        }
    }
}
