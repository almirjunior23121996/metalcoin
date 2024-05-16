using Metalcoin.Core.Domain;
using Metalcoin.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;

namespace MetalCoin.Infra.Data.Repositories
{
    public class CategoriaRepository : Repository<Cupon>, ICategoriaRepository
    {
        public CategoriaRepository(AppDbContext appDbContext) : base (appDbContext) { }

        public async Task<Cupon> BuscarPorNome(string nome)
        {
            var resultado = await DbSet.Where(c => c.Nome == nome).FirstOrDefaultAsync();
            return resultado;                
        }
    }
}
