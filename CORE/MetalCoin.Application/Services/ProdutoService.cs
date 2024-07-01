using Metalcoin.Core.Domain;
using Metalcoin.Core.Dtos;
using Metalcoin.Core.Dtos.Request;
using Metalcoin.Core.Dtos.Response;
using Metalcoin.Core.Interfaces.Repositories;
using Metalcoin.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalCoin.Application.Services
{
    public class ProdutoService : IprodutoService
    {

        private readonly IProdutoRepository _produtoRepository;
        public ProdutoService(IProdutoRepository repository)
        {
            _produtoRepository = repository;
        }
        public async Task<ProdutoResponse> AtualizarProduto(ProdutoAtualizarRequest Produto)
        {
            var produtoExiste = await _produtoRepository.ObterPorId(Produto.Id);

            produtoExiste.preco = Produto.preco;
            produtoExiste.Descricao = Produto.Descricao;
            produtoExiste.Nome = Produto.Nome;

            await _produtoRepository.Atualizar(produtoExiste);

            var response = new ProdutoResponse
            {
                Id = produtoExiste.Id,
                Nome = produtoExiste.Nome,
                Descricao = produtoExiste.Descricao,
                preco = produtoExiste.preco,
            };

            return response;

        }

        public async Task<ProdutoResponse> CadastrarProduto(ProdutoCadastrarRequest Produto)
        {
            var produtoExist = await _produtoRepository.BuscarPornome(Produto.Nome);

            if (produtoExist != null) return null;

            var produtoEntidade = new Produto
            {
                Nome = Produto.Nome,
                Descricao = Produto.Descrticao,
                preco = Produto.preco,
            };
            await _produtoRepository.Adicionar(produtoEntidade);

            var response = new ProdutoResponse
            {
                Id = produtoEntidade.Id,
                Nome = produtoEntidade.Nome,
                Descricao = produtoEntidade.Descricao,
                preco = produtoEntidade.preco,

            };

            return response;
           
        }
            public async Task<bool> DeletarProduto(Guid id)
        {
            var categoria = await _produtoRepository.ObterPorId(id);
            if (categoria == null) return false;


            await _produtoRepository.Remover(id);
            return true;
        }
    }
}
