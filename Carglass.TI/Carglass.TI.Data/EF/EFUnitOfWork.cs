using Carglass.TI.Data.EF;
using Carglass.TI.Domain.Contracts.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carglass.TI.Data.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly StoreDataContext _ctx;

        public EFUnitOfWork(StoreDataContext ctx)
        {
            _ctx = ctx;
        }

        public void Commit()
        {
            _ctx.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _ctx.SaveChangesAsync();
        }

        public void Rollback()
        { 
        // NO EF não precisamos, pois basta não dar um SaveChanges()
        // Wm outras tecnologias, como ADO, precisamos
            throw new NotImplementedException();
        }

        public Task RollbackAsync()
        {
            throw new NotImplementedException();
        }
    }
}
