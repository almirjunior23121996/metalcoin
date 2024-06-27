using Metalcoin.Core.Dtos.Categorias;
using Metalcoin.Core.Dtos.Request;
using Metalcoin.Core.Interfaces.Repositories;
using Metalcoin.Core.Interfaces.Services;
using MetalCoin.Application.Services;
using MetalCoin.Infra.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MetalCoin.Api.Controllers
{
    [ApiController]
    public class CuponsController : ControllerBase
    {
        private readonly ICouponRepository _cuponRepository;
        private readonly IcuponService _cuponService;

        public CuponsController(ICouponRepository cuponRepository, IcuponService cuponService)
        {
            _cuponRepository = cuponRepository;
            _cuponService = cuponService;
        }
        [HttpGet]
        [Route("todosCupons")]
        public async Task<ActionResult> ObterTodosCupons()
        {
            var listacupons = await _cuponRepository.ObterTodos();

            if (listacupons.Count == 0) return NoContent();

            return Ok(listacupons);
        }
        [HttpGet]
        [Route("{id:guid}")]
        public async Task<ActionResult> ObterUmaCupon(Guid id)
        {
            var cupon = await _cuponRepository.ObterPorId(id);
            if (cupon == null) return BadRequest("cupon não encontrado");
            return Ok(cupon);
        }


        [HttpPost]
        [Route("cadastrarCuposn")]
        public async Task<ActionResult> CadastrarCupon([FromBody] CuponCadastrarRequest cupon)
        {
            if (cupon == null) return BadRequest("Informe a descrição");

            var response = await _cuponService.CadastrarCupon(cupon);

            if (response == null) return BadRequest("cupon já existe");

            return Created("cadastrar", response);
        }


        [HttpPut]
        [Route("atualizarCuposn")]
        public async Task<ActionResult> AtualizarCupon([FromBody] CoponAtualizarRequest cupon)
        {
            if (cupon == null) return BadRequest("Nenhum valor chegou na API");

            var response = await _cuponService.AtualizarCupon(cupon);

            return Ok(response);
        }

        [HttpDelete]
        [Route("deletarr/{id:guid}")]
        public async Task<ActionResult> RemoverCupon(Guid id)
        {
            if (id == Guid.Empty) return BadRequest("Id não informado");

            var resultado = await _cuponService.DeletarCupon(id);

            if (!resultado) return BadRequest("");

            return Ok("Produto deletada com sucesso");



        }
    }
}
