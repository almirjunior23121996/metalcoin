using MetalCoin.Api.Data;
using MetalCoin.Api.Models;
using MetalCoin.Api.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MetalCoin.Api.Repositorios
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly SistemaProdutoDBContex _dBContex;
        public ProdutoRepositorio(SistemaProdutoDBContex sistemaProdutoDBContex) 
        {
            _dBContex = sistemaProdutoDBContex;
        }
        public async Task<ProdutoModel> BuscarPorId(int id)
        {
            return await _dBContex.Produtos.FirstOrDefaultAsync(x => x.Id ==id);
        }

        public async Task<List<ProdutoModel>> BuscarTodosProdutos()
        {
            return await _dBContex.Produtos.ToListAsync();
        }
        public async Task<ProdutoModel> Adicionar(ProdutoModel produto)
        {
             await _dBContex.Produtos.AddAsync(produto);
             await _dBContex.SaveChangesAsync();
            return produto;
           
        }
        public async Task<ProdutoModel> Atualizar(ProdutoModel produto, int id)
        {
            ProdutoModel produtoPorId = await BuscarPorId(id);
            if(produtoPorId == null)
            {
                throw new Exception($"Produto para o ID:{id} não foi encontrado");
            }
            produtoPorId.Descricao = produto.Descricao;
            produtoPorId.Valor = produto.Valor;
            _dBContex.Produtos.Update(produtoPorId);
            await _dBContex.SaveChangesAsync();
            return produtoPorId;
        }
        public async Task<bool> Apagar(int id)
        {

            ProdutoModel produtoPorId = await BuscarPorId(id);
            if (produtoPorId == null)
            {
                throw new Exception($"Produto para o ID:{id} não foi encontrado");
            }
            _dBContex.Produtos.Remove(produtoPorId);
            await _dBContex.SaveChangesAsync();
            return true;
        }

        Task<ProdutoModel> IProdutoRepositorio.BuscarTodosProdutos()
        {
            throw new NotImplementedException();
        }
    }
}
