using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carglass.TI.Domain.Contracts.Infra
{
    public interface IUnitOfWork
    {
        void Commit();
        Task CommitAsync();

        void Rollback();
        Task RollbackAsync();


    }
}
