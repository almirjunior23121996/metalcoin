using MetalCoin.Api.Models;

namespace MetalCoin.Api.Repositorios.Interfaces
{
    public interface IProdutoRepositorio
    {
        Task<ProdutoModel> BuscarTodosProdutos();
        Task<ProdutoModel> BuscarPorId(int id);
        Task<ProdutoModel> Adicionar(ProdutoModel produto  );
        Task<ProdutoModel> Atualizar(ProdutoModel produto,int id);
        Task<bool> Apagar(int id);
    }
}
