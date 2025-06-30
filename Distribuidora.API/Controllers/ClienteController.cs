using Distribuidora.Application.DTOs;
using Distribuidora.Application.UseCases.Cliente;
using Microsoft.AspNetCore.Mvc;

namespace Distribuidora.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly CriarClienteUseCase _criar;
        private readonly AtualizarClienteUseCase _atualizar;
        private readonly ObterTodosClientesUseCase _listar;
        private readonly ObterClientePorIdUseCase _obter;
        private readonly RemoverClienteUseCase _remover;

        public ClienteController(
            CriarClienteUseCase criar,
            AtualizarClienteUseCase atualizar,
            ObterTodosClientesUseCase listar,
            ObterClientePorIdUseCase obter,
            RemoverClienteUseCase remover)
        {
            _criar = criar;
            _atualizar = atualizar;
            _listar = listar;
            _obter = obter;
            _remover = remover;
        }

        [HttpGet]
        public async Task<IActionResult> Get() =>
            Ok(await _listar.ExecutarAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var cliente = await _obter.ExecutarAsync(id);
            return cliente is null ? NotFound() : Ok(cliente);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateClienteDTO dto)
        {
            var cliente = await _criar.ExecutarAsync(dto);
            return CreatedAtAction(nameof(Get), new { id = cliente.Id }, cliente);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateClienteDTO dto)
        {
            await _atualizar.ExecutarAsync(dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _remover.ExecutarAsync(id);
            return NoContent();
        }
    }
}
