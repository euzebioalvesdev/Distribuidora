using Distribuidora.Core.Interfaces;

namespace Distribuidora.Application.UseCases.Cliente
{
    public class RemoverClienteUseCase
    {
        private readonly IRepositorioGenerico<Distribuidora.Core.Entities.Cliente> _clienteRepositorio;

        public RemoverClienteUseCase(IRepositorioGenerico<Distribuidora.Core.Entities.Cliente> clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public async Task ExecutarAsync(int id)
        {
            await _clienteRepositorio.RemoverAsync(id);
        }
    }
}
