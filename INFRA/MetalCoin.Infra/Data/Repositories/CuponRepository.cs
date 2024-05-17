using Metalcoin.Core.Domain;
using Metalcoin.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalCoin.Infra.Data.Repositories
{
    public class CuponRepository : Repository<Cupon>, ICouponRepository
    { 
        public CuponRepository(AppDbContext appDbContext) : base(appDbContext) { }

        public async Task<Cupon> BuscarPorId(Guid Id)
        {
            var resultado = await DbSet.Where(c => c.Id == Id ).FirstOrDefaultAsync();
            return resultado;
        }

        public Task<Cupon> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
