﻿using Metalcoin.Core.Domain;

namespace Metalcoin.Core.Interfaces.Repositories
{
    public interface ICategoriaRepository : IRepository<Categoria>
    {
        Task<Cupon>BuscarPorNome(string nome);
    }
}
