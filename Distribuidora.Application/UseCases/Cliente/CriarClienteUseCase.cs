using AutoMapper;
using Distribuidora.Application.DTOs;
using Distribuidora.Core.Interfaces;

namespace Distribuidora.Application.UseCases.Cliente
{
    public class CriarClienteUseCase
    {
        private readonly IRepositorioGenerico<Distribuidora.Core.Entities.Cliente> _clienteRepositorio;
        private readonly IMapper _mapper;

        public CriarClienteUseCase(IRepositorioGenerico<Distribuidora.Core.Entities.Cliente> clienteRepositorio, IMapper mapper)
        {
            _clienteRepositorio = clienteRepositorio;
            _mapper = mapper;
        }

        public async Task<ClienteDTO> ExecutarAsync(CreateClienteDTO dto)
        {
            var cliente = _mapper.Map<Distribuidora.Core.Entities.Cliente>(dto);
            var criado = await _clienteRepositorio.CriarAsync(cliente);
            return _mapper.Map<ClienteDTO>(criado);
        }
    }
}
