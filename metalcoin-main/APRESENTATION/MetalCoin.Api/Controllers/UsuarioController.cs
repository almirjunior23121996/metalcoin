using MetalCoin.Api.Models;
using MetalCoin.Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MetalCoin.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        public UsuarioController(IProdutoRepositorio produtoRepositorio) 
        {
            _produtoRepositorio = produtoRepositorio;
        }
        //[HttpGet]
        //public async Task<ActionResult<List<ProdutoModel>>> BuscarTodosOsProdutos()
        //{
        //    List<ProdutoModel> produtos = await _produtoRepositorio.BuscarTodosProdutos();
        //    return Ok(produtos);
        //}
        [HttpGet("{id}")]
        public async Task<ActionResult<ProdutoModel>> BuscarPorId(int id)
        {
            ProdutoModel produtos = await _produtoRepositorio.BuscarPorId(id);
            return Ok(produtos);
        }
        [HttpPost]
        public async Task<ActionResult<ProdutoModel>> Cadastrar([FromBody]ProdutoModel produtoModel)
        {
           ProdutoModel produto = await _produtoRepositorio.Adicionar(produtoModel);
            return Ok(produto);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<ProdutoModel>> Atualizar([FromBody] ProdutoModel produtoModel, int id)
        {
            produtoModel.Id = id;
            ProdutoModel produto = await _produtoRepositorio.Atualizar(produtoModel, id);
            return Ok(produto);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<ProdutoModel>> Apagar( int id)
        {
           
            bool apagado = await _produtoRepositorio.Apagar(id);
            return Ok(apagado);
        }
    }
}
