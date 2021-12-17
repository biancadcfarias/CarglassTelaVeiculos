using Carglass.TI.Data.EF;
using Carglass.TI.Domain.Contracts.Repositories;
using Carglass.TI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carglass.TI.Data.EF.Repositories
{
    public class UsuarioEFRepository : EFRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioEFRepository(StoreDataContext ctx) : base(ctx)
        {
        }
    }
}
