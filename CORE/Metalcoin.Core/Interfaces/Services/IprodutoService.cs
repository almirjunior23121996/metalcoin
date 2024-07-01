using Metalcoin.Core.Domain;
using Metalcoin.Core.Dtos.Categorias;
using Metalcoin.Core.Dtos.Request;
using Metalcoin.Core.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metalcoin.Core.Interfaces.Services
{
    public interface IprodutoService
    {
        Task<ProdutoResponse> CadastrarProduto(ProdutoCadastrarRequest Produto);
        Task<ProdutoResponse> AtualizarProduto(ProdutoAtualizarRequest Produto);
        Task<bool> DeletarProduto(Guid id);

    }
}
