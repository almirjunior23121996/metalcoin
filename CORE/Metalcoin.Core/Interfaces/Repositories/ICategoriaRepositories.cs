using Metalcoin.Core.Domain;

namespace Metalcoin.Core.Interfaces.Repositories
{
    public interface ICategoriaRepository : IRepository<Cupon>
    {
        Task<Cupon>BuscarPorNome(string nome);
    }
}
