using Carglass.TI.Data.EF;
using Carglass.TI.Data.EF.Repositories;
using Carglass.TI.Domain.Contracts.Repositories;
using Carglass.TI.Domain.Entities;

namespace Carglass.TI.Data.EF.Repositories
{
    public class MarcaEFRepository : EFRepository<Marca>, IMarcaRepository
    {
        public MarcaEFRepository(StoreDataContext ctx) : base(ctx)
        {
        }
    }
}
