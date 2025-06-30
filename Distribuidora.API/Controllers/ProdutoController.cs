using Distribuidora.Application.DTOs;
using Distribuidora.Application.UseCases.Produto;
using Microsoft.AspNetCore.Mvc;

namespace Distribuidora.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly CriarProdutoUseCase _criar;
        private readonly AtualizarProdutoUseCase _atualizar;
        private readonly ObterTodosProdutosUseCase _listar;
        private readonly ObterProdutoPorIdUseCase _obter;
        private readonly RemoverProdutoUseCase _remover;

        public ProdutoController(
            CriarProdutoUseCase criar,
            AtualizarProdutoUseCase atualizar,
            ObterTodosProdutosUseCase listar,
            ObterProdutoPorIdUseCase obter,
            RemoverProdutoUseCase remover)
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
            var produto = await _obter.ExecutarAsync(id);
            return produto is null ? NotFound() : Ok(produto);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateProdutoDTO dto)
        {
            var produto = await _criar.ExecutarAsync(dto);
            return CreatedAtAction(nameof(Get), new { id = produto.Id }, produto);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateProdutoDTO dto)
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
