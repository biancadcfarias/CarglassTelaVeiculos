using Carglass.TI.Domain.Contracts.Repositories;
using Carglass.TI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carglass.TI.Data.EF.Repositories
{
    public class VeiculoEFRepository : EFRepository<Veiculo>, IVeiculoRepository
    {
        public VeiculoEFRepository(StoreDataContext ctx) : base(ctx)
        {
        }

        public IEnumerable<Veiculo> GetByName(string nome)
        {
            return _ctx.Set<Veiculo>().Where(x => x.Name.Contains(nome));
        }

        public IEnumerable<Veiculo> GetWithMarca()
        {
            return _ctx.Set<Veiculo>().Include(x => x.Marca).ToList();
        }

        public async Task<IEnumerable<Veiculo>> GetWithMarcaAsync()
        {
            return await _ctx.Set<Veiculo>().Include(x => x.Marca).ToListAsync();
        }
    }
}
