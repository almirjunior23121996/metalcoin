using Metalcoin.Core.Domain;
using Metalcoin.Core.Dtos.Request;                                              
using Metalcoin.Core.Interfaces.Repositories;
using Metalcoin.Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MetalCoin.Api.Controllers
{
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository _ProdutoRepository;
        private readonly IprodutoService _ProdutoService;

        public ProdutoController(IProdutoRepository ProdutoRepository, IprodutoService ProdutoService)
        {
            _ProdutoRepository = ProdutoRepository;
            _ProdutoService = ProdutoService;
        }
        [HttpGet]
        [Route("todosProdutos")]
        public async Task<ActionResult> ObterTodosProdutos()
        {
            var listacupons = await _ProdutoRepository.ObterTodos();

            if (listacupons.Count == 0) return NoContent();

            return Ok(listacupons);
        }
        [HttpGet]
        [Route("p/{id:guid}")]
        public async Task<ActionResult> ObterUmaCupon(Guid id)
        {
            var cupon = await _ProdutoRepository.ObterPorId(id);
            if (cupon == null) return BadRequest("Produto não encontrado");
            return Ok(cupon);
        }


        [HttpPost]
        [Route("cadastrarProduto")]
        public async Task<ActionResult> CadastrarProduto([FromBody] ProdutoCadastrarRequest produto)
        {
            if (produto == null) return BadRequest("Informe a descrição");

            var response = await _ProdutoService.CadastrarProduto(produto);

            if (response == null) return BadRequest("Produto já existe");

            return Created("cadastrar", response);
        }


        [HttpPut]
        [Route("atualizarProdutos")]
        public async Task<ActionResult> AtualizarProduto([FromBody] ProdutoAtualizarRequest produto)
        {
            if (produto == null) return BadRequest("Nenhum valor chegou na API");

            var response = await _ProdutoService.AtualizarProduto(produto);

            return Ok(response);
        }

        [HttpDelete]
        [Route("deletarr-p/{id:guid}")]
        public async Task<ActionResult> RemoverCupon(Guid id)
        {
            if (id == Guid.Empty) return BadRequest("Id não informado");

            var resultado = await _ProdutoService.DeletarCupon(id);

            if (!resultado) return BadRequest("");

            return Ok("Produto deletada com sucesso");



        }
    }
}
